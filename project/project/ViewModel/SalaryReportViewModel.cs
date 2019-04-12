using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                var some = db.Workers.GroupBy(w => w.SpecialtyId).Select(w => new { Name = w.Key });
            }
        }

    }

    class SalaryInfo
    {
        public int SpecialityId { get; set; }
        public string SpecialityName { get; set; }
    }
}
