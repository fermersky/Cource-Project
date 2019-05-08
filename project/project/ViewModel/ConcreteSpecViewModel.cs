using project.Helpers;
using project.Model;
using project.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace project.ViewModel
{
    public class ConcreteSpecViewModel : INotifyPropertyChanged
    {
        private bool tooltipIsActive = false;

        public bool TooltipIsActive
        {
            get { return tooltipIsActive; }
            set { tooltipIsActive = value; }
        }


        private string searchPattern; // textbox value

        public string SearchPattern
        {
            get { return searchPattern; }
            set
            {
                if (searchPattern != value)
                {
                    searchPattern = value;
                    NotifyPropertyChanged(nameof(SearchPattern));
                }
            }
        }

        //

        private Workers selectedWorker;

        public Workers SelectedWorker
        {
            get { return selectedWorker; }
            set
            {
                NotifyPropertyChanged();
                selectedWorker = value;
            }
        }


        // Filter Properties

        private bool filterBySurnameOn = false; // Surname
        public bool FilterBySurnameOn
        {
            set
            {
                filterBySurnameOn = value;
                NotifyPropertyChanged();
            }
            get => filterBySurnameOn;
        }

        //

        private bool filterByFirstnameOn = false; // Firstname
        public bool FilterByFirstnameOn
        {
            set
            {
                filterByFirstnameOn = value;
                NotifyPropertyChanged();
            }
            get => filterByFirstnameOn;
        }

        //

        private bool filterByLastnameOn = false; // Lastname
        public bool FilterByLastnameOn
        {
            set
            {
                filterByLastnameOn = value;
                NotifyPropertyChanged();
            }
            get => filterByLastnameOn;
        }

        //

        private bool filterByAgeOn = false; // Age
        public bool FilterByAgeOn
        {
            set
            {
                filterByAgeOn = value;
                NotifyPropertyChanged();
            }
            get => filterByAgeOn;
        }

        //

        private bool filterMaleOn = true; // is male
        public bool FilterMaleOn
        {
            get { return filterMaleOn; }
            set
            {
                filterMaleOn = value;
                NotifyPropertyChanged();
            }
        }

        //

        private bool filterFemaleOn = false; // is female
        public bool FilterFemaleOn
        {
            get { return filterFemaleOn; }
            set
            {
                filterFemaleOn = value;
                NotifyPropertyChanged();
            }
        }

        //

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

        private List<Workers> _localWorkers;
        public string _currentSpeciality { get; set; } // title of window
        public string _autUser { get; private set; }

        //

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        private RelayCommand filterWorkersCommand;
        public RelayCommand FilterWorkersCommand
        {
            get
            {
                return filterWorkersCommand ?? (filterWorkersCommand = new RelayCommand(obj =>
                {
                    using (var db = new StaffContext())
                    {
                        Workers = CollectionViewSource.GetDefaultView(_localWorkers);
                        Workers.Filter = CustomerFilter; // predicate
                    }
                }));
            }
        }

        private RelayCommand addWorkerCommand;
        public RelayCommand AddWorkerCommand
        {
            get
            {
                return addWorkerCommand ?? (addWorkerCommand = new RelayCommand(obj =>
                {
                    using (var db = new StaffContext())
                    {
                        new AddWorkerWindow().ShowDialog();
                    }
                }, (obj) => 
                {
                    return (this._autUser == "admin") || false;
                }));
            }
        }

        private bool CustomerFilter(object item) // predicate
        {
            var worker = item as Workers;
            bool result = true;


            if (string.IsNullOrEmpty(SearchPattern)) // if search field is empty, get all workers
            {
                return true;
            }
            else // all selected properties must contain search text
            {
                if (FilterBySurnameOn)
                {
                    if (worker.Surname.Contains(SearchPattern))
                        result = result & true;
                    else
                        result = result & false;
                }
                if (FilterByFirstnameOn)
                {
                    if (worker.Firstname.Contains(SearchPattern))
                        result = result & true;
                    else
                        result = result & false;
                }
                if (FilterByLastnameOn)
                {
                    if (worker.Lastname.Contains(SearchPattern))
                        result = result & true;
                    else
                        result = result & false;
                }
                if (FilterByAgeOn)
                {
                    int age;
                    if (int.TryParse(SearchPattern, out age))
                    {
                        if (worker.BirthDate.Value.Year + int.Parse(SearchPattern) == DateTime.Now.Year)
                            result = result & true;
                        else
                            result = result & false;
                    }

                }
                if (FilterMaleOn)
                {
                    if (worker.Gender == FilterMaleOn)
                        result = result & true;
                    else
                        result = result & false;
                }
                else
                {
                    if (worker.Gender != FilterFemaleOn)
                        result = result & true;
                    else
                        result = result & false;
                }

                return result;
            }

        }

        private RelayCommand viewWorkerInfoCommand;

        public RelayCommand ViewWorkerInfoCommand
        {
            get
            {
                return viewWorkerInfoCommand ?? (viewWorkerInfoCommand = new RelayCommand((SelectedWorker) => 
                {
                    using (var db = new StaffContext())
                    {
                        var worker = db.Workers
                            .Include("Specialties")
                            .Where(w => w.Id == (SelectedWorker as Workers).Id);

                        new WorkerInfoWindow(SelectedWorker as Workers).ShowDialog();
                    } 
                }));
            }
        }



        public ConcreteSpecViewModel(List<Model.Workers> _workers, string spec, string _autUser)
        {
            this._workersView = CollectionViewSource.GetDefaultView(_workers);
            this._localWorkers = _workers;
            this._currentSpeciality = spec;
            this._autUser = _autUser;
        }

    }
}
