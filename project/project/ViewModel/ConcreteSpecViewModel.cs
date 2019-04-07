using project.Helpers;
using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace project.ViewModel
{
    public class ConcreteSpecViewModel : INotifyPropertyChanged
    {
        private ICollectionView _workersView;

        public ICollectionView Workers
        {
            set
            {
                _workersView = value;
                NotifyPropertyChanged();
                _workersView.Refresh();
            }
            get { return _workersView; }
        }

        private RelayCommand filterWorkersCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private List<Workers> _localWorkers;

        public RelayCommand FilterWorkersCommand
        {
            get
            {
                return filterWorkersCommand ?? (filterWorkersCommand = new RelayCommand(obj =>
                {
                    using (var db = new StaffEntities())
                    {
                        /*string param = obj as string;
                        string spec = _localWorkers[0].Specialties.SpecName; // get current Speciality of Workers

                        var filteredWorkers = db.Workers
                            .Where(w => w.FirsnName.Contains(param) && w.Specialties.SpecName == spec)
                            .ToList();
                        Workers = CollectionViewSource.GetDefaultView(filteredWorkers);
                        Workers.Filter = CustomerFilter;*/

                        
                    }
                }));
            }
        }

        private bool CustomerFilter(object item)
        {
            var worker = item as Workers;

           

            return true;
        }

        public string Title { get; set; } = "Programmers";

        public ConcreteSpecViewModel(List<Model.Workers> _workers)
        {
            this._workersView = CollectionViewSource.GetDefaultView(_workers);
            this._localWorkers = _workers;
        }
    }
}
