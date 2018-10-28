using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace BachelorWishList
{
    public class DataClass
    {
        public static string _sqltable = "Data";
        public static List<string> _dataValues = new List<string>();

        public static List<DataClass> GetAllData()
        {
            List<DataClass> tempList = new List<DataClass>();
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            try
            {
                SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable, conn);
                //  SqlCommand comm = new SqlCommand("SELECT * FROM Users", conn);
                conn.Open();
                List<string> res = new List<string>();
                SqlDataReader sr = comm.ExecuteReader();

                while (sr.Read())
                {

                    for (int i = 0; i < sr.FieldCount; i++) //FieldCount - Gets the number of columns in the current row
                    {
                        string s = "";
                        s += (sr.GetValue(i));
                        res.Add(s);
                    }
                    tempList.Add(new DataClass(res));
                    res.Clear();
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tempList;
        }

        public static DataClass GetDataByDataID(int DataID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE DataID=" + DataID.ToString(), conn);
            conn.Open();
            List<string> res = new List<string>();
            SqlDataReader sr = comm.ExecuteReader();

            while (sr.Read())
            {
                res.Clear();
                for (int i = 0; i < sr.FieldCount; i++) //FieldCount - Gets the number of columns in the current row
                {
                    string s = "";
                    s += (sr.GetValue(i));
                    res.Add(s);
                }
            }
            conn.Close();
            return new DataClass(res);
        }

        public static List<String> GetDataByDataIDAsString(int DataID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE DataID=" + DataID.ToString(), conn);
            conn.Open();
            List<string> res = new List<string>();
            SqlDataReader sr = comm.ExecuteReader();

            while (sr.Read())
            {
                res.Clear();
                for (int i = 0; i < sr.FieldCount; i++) //FieldCount - Gets the number of columns in the current row
                {
                    string s = "";
                    s += (sr.GetValue(i));
                    res.Add(s);
                }
            }
            conn.Close();
            return res;
        }

        #region --- Properties ---

        private int _dataID = -1; // The ID of the Event (Primary Key)
        public int DataID { get { return _dataID; } set { _dataID = value; } }

        private int _trivetID = -1; // The ID of the User owning the Event
        public int TrivetID { get { return _trivetID; } set { _trivetID = value; } }

        private int _companyID = -1; // The name of the event 
        public int CompanyID { get { return _companyID; } set { _companyID = value; } }  //TODO handle encryption

        private DateTime _dataTime = new DateTime(1753, 1, 1, 12, 0, 0); //Year, month, day, Hour, Minut, Second
        public DateTime DataTime { get { return _dataTime; } set { _dataTime = value; } }

        private int _dataWeight = -1; // The location of the event
        public int DataWeight { get { return _dataWeight; } set { _dataWeight = value; } }


        #endregion--- Properties ---

        public DataClass()
        { }

        //Comes as String
        public DataClass(List<string> res)
        {
            this._dataID = System.Convert.ToInt32(res[0]);
            this._trivetID = System.Convert.ToInt32(res[1]);
            this._companyID = System.Convert.ToInt32(res[2]);
            this._dataTime = System.Convert.ToDateTime(res[3]);
            this._dataWeight = System.Convert.ToInt32(res[4]);
        }

        public bool SaveMe(string user)
        {
           SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
           try
           {
               SqlCommand comm = new SqlCommand("save_Data", conn);
               comm.CommandType = System.Data.CommandType.StoredProcedure;
               comm.Parameters.Add("DataID", System.Data.SqlDbType.Int);
               comm.Parameters["DataID"].Value = this._dataID;
               comm.Parameters.Add("TrivetID", System.Data.SqlDbType.Int);
               comm.Parameters["TrivetID"].Value = this._trivetID;
               comm.Parameters.Add("CompanyID", System.Data.SqlDbType.Int);
               comm.Parameters["CompanyID"].Value = this._companyID; 
               comm.Parameters.Add("DataTime", System.Data.SqlDbType.DateTime);
               comm.Parameters["DataTime"].Value = this._dataTime;
               comm.Parameters.Add("DataWeight", System.Data.SqlDbType.Int);
               comm.Parameters["DataWeight"].Value = this._dataWeight;


               conn.Open();
               int rowsaffected = comm.ExecuteNonQuery();

               return true;
           }
           catch (Exception ex)
           {
                Console.WriteLine("{0} Exception caught.", ex.Message);
               return false;
           }
           finally
           { conn.Close(); }
        }

    }
}