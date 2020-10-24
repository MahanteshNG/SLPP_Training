using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace to take DataSet or DataTable to Store Data under .NET Framework\
//which are extracted as bulk record vai Data Adapter
using System.Data;

namespace CRUDDisplay
{
    interface IOperation
    {
        DataTable DisplayAllTrainees();
    }
}
