using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project.ViewModel
{
    class SalaryReportViewModel
    {
        private List<string> salaryReportList;

        public List<string> SalaryReportList
        {
            get { return salaryReportList; }
            set { salaryReportList = value; }
        }

        public SalaryReportViewModel()
        {
            // SalaryReportList

            using (var db = new StaffEntities())
            {
                
            }
        }

    }

    class SalaryInfo
    {
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }
    }
}
