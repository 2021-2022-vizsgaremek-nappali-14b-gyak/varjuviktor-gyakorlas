using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Models
{
    public enum DBSOurce { NONE, LOCALHOST, DEVOPS}
    class DataBaseSource
    {
        DBSOurce dBSOurce;

        public DBSOurce DBSOurce { get => dBSOurce; set => dBSOurce = value; }

        public DataBaseSource(DBSOurce dBSOurce)
        {
            DBSOurce = DBSOurce.NONE;
           
        }
    }
}
