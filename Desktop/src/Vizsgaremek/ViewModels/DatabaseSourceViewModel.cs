using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Vizsgaremek.Repositories;
using Vizsgaremek.Models;
namespace Vizsgaremek.ViewModels

{
    public class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabasesources;
        private string selectedDatabaseSource;
        private DBSOurce dBSOurce;
        DataBaseSources repoDatabaseSources;
        public ObservableCollection<string> DisplayedDatabaseSource
        {
            get
            {
                return displayedDatabasesources;
            }
        }

        public DBSOurce DatabaseSource
        {
            get
            {
                return DBSOurce.NONE;
            }
        }




        public string SelectedDatabaseSource
        {
            get => selectedDatabaseSource;
            set => selectedDatabaseSource = value;
        }

    }
}
