﻿using project.Helpers;
using project.Model;
using project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                            .ToList(), spec, _autUser);

                        var win = new ConcreteSpec(vm, _autUser);
                        win.Show();
                    }
                }));
            }
        }

        private RelayCommand viewSalaryReportCommand;
        private string _autUser;

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
            _autUser = autUser;
        }
    }
}
