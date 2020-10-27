using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace FlightBookingApp //Do not change the namespace name
{
    public class FlightDAL //Do not change the class name
    {

        public  SqlConnection sqlConnection = null;
        public  SqlCommand sqlCommand = null;
        public  SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public DataTable dataTable;

        //Implement the ConnectionString property here
        //Implement the required methods here
    }
}
