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

        public AddWorkerViewModel() // Worker adding mode of viewmodel
        {
            Operation = "Add new worker";
            using (var db = new StaffContext())
            {
                CurrentWorker = new Workers();
                CurrentWorker.Gender = true;
                specialties = db.Specialties.ToList();
                //CurrentWorker = db.Workers.Where(w => w.Id == 1).FirstOrDefault();
            }
        }

        public AddWorkerViewModel(int workerId) // Worker editing mode of viewmodel
        {
            this.workerId = workerId;
            Operation = "Save changes";

            using (var db = new StaffContext())
            {
                CurrentWorker = db.Workers.Where(w => w.Id == workerId).FirstOrDefault();
                specialties = db.Specialties.ToList();
                SpecId = (int)CurrentWorker.SpecialtyId;
                ImgFile = CurrentWorker.ImgFile;
            }
        }

        private List<Specialties> specialties; // combobox source

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
                        CurrentWorker.ImgFile = ImgFile;
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
                    if (Operation == "Add new worker") // adding mode
                    {
                        if (CurrentWorker.ImgFile == null)
                        {
                            if (CurrentWorker.Gender == true) // gender is male
                                CurrentWorker.ImgFile = "man.png";
                            else
                                CurrentWorker.ImgFile = "woman.png";
                        }


                        using (var db = new StaffContext())
                        {
                            CurrentWorker.Phone = CurrentWorker.Phone;
                            CurrentWorker.Specialties = db.Specialties.Where(s => s.Id == SpecId).FirstOrDefault();
                            CurrentWorker.IsDeleted = false;

                            try
                            {
                                db.Workers.Add(CurrentWorker);
                                db.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Something wrong!", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }
                    else
                    {
                        using (var db = new StaffContext())
                        {
                            CurrentWorker.SpecialtyId = SpecId;
                            var oldWorker = db.Workers.Include("Specialties").Where(w => w.Id == workerId).FirstOrDefault();
                            
                            try
                            {
                                db.Entry(oldWorker).CurrentValues.SetValues(CurrentWorker); // exchnage workers
                                db.SaveChanges();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Something wrong!", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }

                (obj as Window).Close();

                }, (obj) =>
                {
                    return isAllAreaField();
                }));

            }
        }

        private bool isAllAreaField()
        {
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
        private int workerId;

        public int SpecId
        {
            get { return specId; }
            set
            {
                specId = value;
                NotifyPropertyChanged();
            }
        }

        public string Operation { get; private set; } // button caption
    }
}
