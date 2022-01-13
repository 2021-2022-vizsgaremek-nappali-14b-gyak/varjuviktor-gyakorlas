using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Vizsgaremek.Repositories;
namespace Vizsgaremek.ViewModels
{
    class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabasesources;
        private string selectedDatabaseSource;
        DataBaseSources repoDatabaseSources;
        public ObservableCollection<string> DisplayedDatabaseSource
        {
            get
            {
                return displayedDatabasesources;
            }
        }

        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }

    }
}
