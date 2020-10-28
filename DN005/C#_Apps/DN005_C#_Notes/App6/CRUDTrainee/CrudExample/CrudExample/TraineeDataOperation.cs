using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET namespaces
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CrudExample
{
    //This class with contain ADO.Net components through which we can perform CRUD operations
    //with Database
    public class TraineeDataOperation : ITraineeDataOperation
    {
        /*Extract Connection Data from App.Config File*/
        public string Connection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DbConnect"].ConnectionString;
            }
        }

        //create a connection object
        SqlConnection _sqlConnect;
        static readonly string InsertTrainee = "INSERT INTO trainee(TraineeName,BatchCode,DateOfJoining) " +
            "VALUES(@name,@batch,@doj)";

        public bool AddRecord(TraineeDL dl)
        {
            try
            {
                //establish the connection with sql server
                using (_sqlConnect = new SqlConnection(Connection))
                {
                    _sqlConnect.Open();
                    using (SqlCommand _insertCmd = new SqlCommand(InsertTrainee, _sqlConnect))
                    {
                        //Map model proprties with sql variables
                        _insertCmd.Parameters.AddWithValue("@name", dl.TraineeName);
                        _insertCmd.Parameters.AddWithValue("@batch", dl.BatchCode);
                        _insertCmd.Parameters.AddWithValue("@doj", dl.DateOfJoining);

                        int i = _insertCmd.ExecuteNonQuery();
                        if (i > 0) //insert is successful
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        
        }

        static readonly string ExtractRecord = "SELECT * FROM trainee";
        public List<TraineeDL> DisplayAllTraineesInfo()
        {
            try
            {
                List<TraineeDL> li = new List<TraineeDL>();
                using (_sqlConnect = new SqlConnection(Connection))
                {
                    _sqlConnect.Open();
                    using (SqlCommand _selectAllRecords = new SqlCommand(ExtractRecord, _sqlConnect))
                    {
                        //Use Data Reader to read data in read only forward only mode
                        using (SqlDataReader _reader = _selectAllRecords.ExecuteReader())
                        {
                            //Check if data reader has any row to read from table
                            if (_reader.HasRows)
                            {
                                //read one data at a time and continue the reading till last record
                                while (_reader.Read())
                                {
                                    TraineeDL dl = new TraineeDL();
                                    //under the properties of DL object save data info extracted
                                    //by data reader
                                    dl.TraineeId = int.Parse(_reader["TraineeId"].ToString());
                                    dl.TraineeName = _reader["TraineeName"].ToString();
                                    dl.BatchCode = _reader["BatchCode"].ToString();
                                    dl.DateOfJoining = DateTime.Parse(_reader["DateOfJoining"].ToString());

                                    //Add the class object to list
                                    li.Add(dl);
                                }
                            }
                        }
                    }
                }
                return li;
            }
            catch
            {
                return null;
            }
        }

        static readonly string SearchByID = "SELECT * FROM trainee where TraineeId=@id";
        public TraineeDL SearchById(int searchId)
        {
            TraineeDL dl = new TraineeDL();
           try
            {
                using (_sqlConnect = new SqlConnection(Connection))
                {
                    _sqlConnect.Open();
                    using (SqlCommand _selectById = new SqlCommand(SearchByID, _sqlConnect))
                    {
                        _selectById.Parameters.AddWithValue("@id", searchId);
                        //Use Data Reader to read data in read only forward only mode
                        using (SqlDataReader _reader = _selectById.ExecuteReader())
                        {
                            //Check if data reader has any row to read from table
                            if (_reader.HasRows)
                            {
                                //read one data at a time and continue the reading till last record
                                while (_reader.Read())
                                {                                    
                                    //under the properties of DL object save data info extracted
                                    //by data reader
                                    dl.TraineeId = int.Parse(_reader["TraineeId"].ToString());
                                    dl.TraineeName = _reader["TraineeName"].ToString();
                                    dl.BatchCode = _reader["BatchCode"].ToString();
                                    dl.DateOfJoining = DateTime.Parse(_reader["DateOfJoining"].ToString());
                                                                       
                                }
                            }
                        }
                    }
                }
                return dl;
            }
            catch
            {
                return null;
            }
        }

        static readonly string SearchByBatch = "SELECT * from trainee WHERE BatchCode=@batch";
        public List<TraineeDL> DisplayTraineeByDepartment(string searchBatch)
        {
            try
            {
                List<TraineeDL> li = new List<TraineeDL>();
                using (_sqlConnect = new SqlConnection(Connection))
                {
                    _sqlConnect.Open();
                    using (SqlCommand _selectAllRecords = new SqlCommand(SearchByBatch, _sqlConnect))
                    {
                        _selectAllRecords.Parameters.AddWithValue("@batch", searchBatch);
                        //Use Data Reader to read data in read only forward only mode
                        using (SqlDataReader _reader = _selectAllRecords.ExecuteReader())
                        {
                            //Check if data reader has any row to read from table
                            if (_reader.HasRows)
                            {
                                //read one data at a time and continue the reading till last record
                                while (_reader.Read())
                                {
                                    TraineeDL dl = new TraineeDL();
                                    //under the properties of DL object save data info extracted
                                    //by data reader
                                    dl.TraineeId = int.Parse(_reader["TraineeId"].ToString());
                                    dl.TraineeName = _reader["TraineeName"].ToString();
                                    dl.BatchCode = _reader["BatchCode"].ToString();
                                    dl.DateOfJoining = DateTime.Parse(_reader["DateOfJoining"].ToString());

                                    //Add the class object to list
                                    li.Add(dl);
                                }
                            }
                        }
                    }
                }
                return li;
            }
            catch
            {
                return null;
            }
        }
    }
}
