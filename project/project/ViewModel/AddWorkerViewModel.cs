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

    }
}
