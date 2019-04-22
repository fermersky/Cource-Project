using Microsoft.Win32;
using project.Helpers;
using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace project.ViewModel
{
    class AddWorkerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public AddWorkerViewModel()
        {
            using (var db = new StaffEntities())
            {
                CurrentWorker = new Workers();
                CurrentWorker.Gender = true;
                specialties = db.Specialties.ToList();
                //CurrentWorker = db.Workers.Where(w => w.Id == 1).FirstOrDefault();
            }
        }

        private List<Specialties> specialties;

        public List<Specialties> Specialties
        {
            get { return specialties; }
            set
            {
                specialties = value;
                NotifyPropertyChanged();
            }
        }

        private RelayCommand loadImageCommand;

        public RelayCommand LoadImageCommand
        {
            get
            {
                return loadImageCommand ?? (loadImageCommand = new RelayCommand(obj => 
                {
                    var diag = new OpenFileDialog();
                    diag.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                    if (diag.ShowDialog() != false)
                    {
                        var file = new FileInfo(diag.FileName);
                        try
                        {
                            file.CopyTo("../../images/" + diag.SafeFileName, true);
                        }
                        catch (Exception) { }
                        ImgFile = diag.SafeFileName;
                    }
                }));
            }
        }

        private RelayCommand addWorkerCommand;
        public RelayCommand AddWorkerCommand
        {
            get
            {
                return addWorkerCommand ?? (addWorkerCommand = new RelayCommand((obj) => 
                {
                    if (CurrentWorker.ImgFile == null)
                    {
                        if (CurrentWorker.Gender == true) // male
                            CurrentWorker.ImgFile = "man.png";
                        else
                            CurrentWorker.ImgFile = "woman.png";
                    }


                    /*var worker = new Workers()
                    {
                        Surname = this.Surname,
                        Firstname = this.Firstname,
                        Lastname = this.Lastname,
                        Gender = this.Gender,
                        Address = this.Address,
                        Phone = "+380" + this.Phone,
                        BirthDate = this.BirthDate,
                        SpecialtyId = this.SpecId,
                        Salary = int.Parse(this.Salary),
                        ImgFile = this.ImgFile,
                        IsDeleted = false
                    };*/

                    using (var db = new StaffEntities())
                    {

                        CurrentWorker.Specialties = db.Specialties.Where(s => s.Id == SpecId).FirstOrDefault();
                        CurrentWorker.IsDeleted = false;
                        db.Workers.Add(CurrentWorker);
                        db.SaveChanges();
                    }

                    (obj as Window).Close();

                }, (obj) => 
                {
                    //return true;
                    return isAllAreaField();
                }));
            }
        }

        private bool isAllAreaField()
        {
            int s;
            return !(string.IsNullOrEmpty(CurrentWorker.Firstname) ||
                     string.IsNullOrEmpty(CurrentWorker.Lastname) ||
                     string.IsNullOrEmpty(CurrentWorker.Surname) ||
                     string.IsNullOrEmpty(CurrentWorker.Address) ||
                     (CurrentWorker.Salary == null) ||
                     (SpecId == -1) ||
                     (CurrentWorker.BirthDate == null) ||
                     (CurrentWorker.Salary == null));
        }

        //

        private Workers currentWorker;

        public Workers CurrentWorker
        {
            get { return currentWorker; }
            set { currentWorker = value; NotifyPropertyChanged(); }
        }


        //

        private string imgFile = null;
        public string ImgFile
        {
            get => imgFile;
            set
            {
                imgFile = value;
                NotifyPropertyChanged();
            }
        }

        //

        private int specId = -1;

        public int SpecId
        {
            get { return specId; }
            set
            {
                specId = value;
                NotifyPropertyChanged();
            }
        }

    }
}
