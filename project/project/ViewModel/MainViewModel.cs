using project.Helpers;
using project.Model;
using project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project.ViewModel
{
    class MainViewModel
    {
        private RelayCommand openConcreteCommand;
        public RelayCommand OpenConcreteCommand
        {
            get
            {
                // if openProgersCommand is not null return it, else right hand

                return openConcreteCommand ?? (openConcreteCommand = new RelayCommand(obj =>
                {
                    using (var db = new StaffEntities())
                    {
                        string spec = obj as string;

                        // generate ViewModel
                        var vm = new ConcreteSpecViewModel(db.Workers
                            .Include("Specialties")
                            .Where(w => w.Specialties.SpecName == spec)
                            .ToList(), spec);

                        var win = new ConcreteSpec(vm);
                        win.Show();
                    }
                }));
            }
        }

        private RelayCommand viewSalaryReportCommand;
        public RelayCommand ViewSalaryReportCommand
        {
            get
            {
                return viewSalaryReportCommand ?? (viewSalaryReportCommand = new RelayCommand(obj =>
                {
                    new SalaryReportWindow().Show();
                }));
            }
        }

        public MainViewModel()
        {

        }

        public MainViewModel(string autUser)
        {

        }
    }
}
