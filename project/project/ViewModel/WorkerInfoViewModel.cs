using project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.ViewModel
{
    class WorkerInfoViewModel
    {
        public Workers CurrentWorker;
        public WorkerInfoViewModel(Workers worker)
        {
            this.CurrentWorker = worker;

            Firstname = worker.Firstname;
        }

        public string Firstname { get; set; }
    }
}
