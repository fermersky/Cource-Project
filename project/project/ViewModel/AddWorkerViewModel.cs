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
                specialties = db.Specialties.ToList();
                
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

                    if (diag.ShowDialog() != null)
                    {
                        var file = new FileInfo(diag.FileName);
                        file.CopyTo("../../images/" + diag.SafeFileName, true);
                        ImgFile = @"../images/" + diag.SafeFileName;
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
                    MessageBox.Show(BirthDate.ToString());
                }));
            }
        }

        
        private string imgFile;
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

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set
            {
                firstname = value;
                NotifyPropertyChanged();
            }
        }

        // 

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;
                NotifyPropertyChanged();
            }
        }

        // 

        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                NotifyPropertyChanged();
            }
        }

        //

        private bool gender = true;

        public bool Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                NotifyPropertyChanged();
            }
        }


        //

        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                NotifyPropertyChanged();
            }
        }

        //

        private DateTime? birthDate;

        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                NotifyPropertyChanged();
            }
        }

        //

        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                NotifyPropertyChanged();
            }
        }

        //

        private int specId;

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
