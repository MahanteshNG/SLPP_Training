using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CrudExample
{
    public class DbHandler
    {
        /*Extract Connection Data from App.Config File*/
        static SqlConnection _sqlConnect;
        public static SqlConnection Connection
        {
            get
            {
             _sqlConnect=new SqlConnection
                    (ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString);
                return _sqlConnect;
            }
        }
    }
}
