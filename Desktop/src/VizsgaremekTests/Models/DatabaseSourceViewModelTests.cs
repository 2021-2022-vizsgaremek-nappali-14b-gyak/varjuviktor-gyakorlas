using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;
using Vizsgaremek.ViewModels;

namespace VizsgaremekTests
{
    [TestClass()]
    class DatabaseSourceViewModelTests
    {
        [TestMethod()]
        public void DatabaseSourceViewModelTestLocalhost()
        {
            DatabaseSourceViewModel databaseSourceViewModel = new DatabaseSourceViewModel();
            databaseSourceViewModel.SelectedDatabaseSource = "localhost";
            DBSOurce expectedDbSource = DBSOurce.LOCALHOST;

            DBSOurce actualDbSource = databaseSourceViewModel.DatabaseSource;

            Assert.AreEqual(expectedDbSource, actualDbSource, "A kiválasztott adatbázis a 'localhost', de nem váltott át DbSource.LOCALHOST-ra");

        }
    }
}
