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
        private List<SalaryInfo> salaryReportList;

        public List<SalaryInfo> SalaryReportList
        {
            get { return salaryReportList; }
            set { salaryReportList = value; }
        }

        public SalaryReportViewModel()
        {
            // SalaryReportList

            SalaryReportList = new List<SalaryInfo>();

            using (var db = new StaffContext())
            {
                // TODO
                /* Доделать отчет по начислениям з.п
                 * Сделать добавление сотрудника (с фоткой и т.д)
                 * У Сергея спросить про адекватный вывод в listview
                 * 
                 */

                var report = from Workers in db.Workers
                           join Specialties in db.Specialties on new { SpecialtyId = (int)Workers.SpecialtyId } equals new { SpecialtyId = Specialties.Id }
                           group new { Workers, Specialties } by new
                           {
                               Workers.SpecialtyId,
                               Specialties.SpecName
                           } into g
                           select new
                           {
                               SpecialtyId = (int?)g.Key.SpecialtyId,
                               g.Key.SpecName,
                               TotalSum = (int?)g.Sum(p => p.Workers.Salary) // total sum for each speciality
                           };


                foreach (var elem in report)
                    SalaryReportList.Add(new SalaryInfo(elem.SpecialtyId, elem.SpecName, elem.TotalSum));

                TotalSum = SalaryReportList.Sum(s => s.TotalSum); // total sum for all specialties
            }
        }

        public int? TotalSum { get; set; }
    }

    class SalaryInfo
    {
        public SalaryInfo(int? specialityId, string specialityName, int? totalSum)
        {
            SpecialityId = specialityId;
            SpecialityName = specialityName;
            TotalSum = totalSum;
        }

        public int? SpecialityId { get; set; }
        public string SpecialityName { get; set; }
        public int? TotalSum { get; set; }
    }

}
