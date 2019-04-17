using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModel
{
    class WorkerInfoViewModel : INotifyPropertyChanged
    {
        
        public WorkerInfoViewModel(Workers worker)
        {
            this.CurrentWorker = worker;
            this.ImgFile = worker.ImgFile;

            using (var db = new StaffEntities())
            {
                Certificates = new List<StaffandCertificates>();
                
                //Certificates = db.StaffandCertificates.Where(w => w.Id == worker.Id).ToList();
                Certificates = db.StaffandCertificates.Include("Certificates").Where(w => w.Id == worker.Id).ToList();

            }
        }

        private Workers currentWorker;

        public Workers CurrentWorker
        {
            get { return currentWorker; }
            set
            {
                currentWorker = value;
                NotifyPropertyChanged();
            }
        }

        private string imgFile;

        public string ImgFile
        {
            get { return imgFile; }
            set { imgFile = value; NotifyPropertyChanged(); }
        }

        private List<StaffandCertificates> certificates;

        public List<StaffandCertificates> Certificates
        {
            get { return certificates; }
            set
            {
                certificates = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
