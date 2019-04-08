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

        private bool filterMaleOn; // is male

        public bool FilterMaleOn
        {
            get { return filterMaleOn; }
            set
            {
                filterMaleOn = value;
                NotifyPropertyChanged();
            }
        }

        private bool filterFemaleOn; // is female

        public bool FilterFemaleOn
        {
            get { return filterFemaleOn; }
            set
            {
                filterFemaleOn = value;
                NotifyPropertyChanged();
            }
        }



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
                        string param = obj as string;
                        string spec = _localWorkers[0].Specialties.SpecName; // get current Speciality of Workers

                        var filteredWorkers = db.Workers
                            .Where(w => w.FirsnName.Contains(param) && w.Specialties.SpecName == spec)
                            .ToList();
                        Workers = CollectionViewSource.GetDefaultView(filteredWorkers);
                        Workers.Filter = CustomerFilter; // predicate
                    }
                }));
            }
        }

        private bool CustomerFilter(object item) // predicate
        {
            var worker = item as Workers;

            bool result = true;


            if (string.IsNullOrEmpty(SearchPattern))
            {
                return true;
            }
            else
            {


                if (FilterBySurnameOn)
                {
                    if (worker.Surname.Contains(SearchPattern))
                        result = true & result;
                    else
                        result = false & result;
                }
                if (FilterByFirstnameOn)
                {
                    if (worker.FirsnName.Contains(SearchPattern))
                        result = true & result;
                    else
                        result = false & result;
                }
                if (FilterByLastnameOn)
                {
                    if (worker.Lastlame.Contains(SearchPattern))
                        result = true & result;
                    else
                        result = false & result;
                }
                if (FilterByAgeOn)
                {
                    /* if (worker.BirthDate == new DateTime(SearchPattern))
                         result = true & result;
                     else
                         result = false & result;*/
                    result = true & result;
                }
                if (FilterMaleOn)
                {
                    if (worker.Gender == FilterMaleOn)
                        result = true & result;
                    else
                        result = false & result;
                    result = true & result;
                }
                if (FilterFemaleOn)
                {
                    if (worker.Gender == FilterFemaleOn)
                        result = true & result;
                    else
                        result = false & result;
                    result = true & result;
                }

                return result;
            }

            
        }

        public string Title { get; set; } = "test";

        public ConcreteSpecViewModel(List<Model.Workers> _workers)
        {
            this._workersView = CollectionViewSource.GetDefaultView(_workers);
            this._localWorkers = _workers;
        }
    }
}
