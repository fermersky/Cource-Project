using project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace project.ViewModel
{
    public class WorkersViewModel
    {
        private ICollectionView _workersView;

        public ICollectionView Workers
        {
            get { return _workersView; }
        }

        public string Title { get; set; } = "test";

        public WorkersViewModel(List<Model.Workers> _workers)
        {
            _workersView = CollectionViewSource.GetDefaultView(_workers);
        }
    }
}
