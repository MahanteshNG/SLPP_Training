using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET Operation 
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CRUDDisplay
{
    public class Operation : IOperation
    {
        public string Connection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;
            }
        }

        static readonly string ExtractAllRecords = "SELECT * FROM trainee";
        SqlConnection _sqlConnect;
        public DataTable DisplayAllTrainees()
        {
            DataTable dt = new DataTable();
            try
            {
                using (_sqlConnect = new SqlConnection(Connection))
                {
                    using (SqlCommand _selectCmd = new SqlCommand(ExtractAllRecords, _sqlConnect))
                    {
                        _sqlConnect.Open();
                        //Take SQL Data Adapter to execute the command object to fetch
                        //bulk records from table
                        using (SqlDataAdapter _da = new SqlDataAdapter(_selectCmd))
                        {
                            //store data under data table
                            //Fill() 
                            _da.Fill(dt);
                        }
                    }
                }
            }
            catch
            {
                return null;
            }
            return dt;
        }
    }
}
