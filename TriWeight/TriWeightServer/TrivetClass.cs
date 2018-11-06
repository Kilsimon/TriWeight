
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BachelorWishList
{
    public class TrivetClass
    {
        public static string _sqltable = "Trivet";

        public static List<TrivetClass> GetAllTrivet()
        {
            List<TrivetClass> tempList = new List<TrivetClass>();
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
                    tempList.Add(new TrivetClass(res));
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

        public static TrivetClass GetCompanyByCompanyID(int TrivetID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE TrivetID=" + TrivetID.ToString(), conn);
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
            return new TrivetClass(res);
        }

        public static List<String> GetTrivetByIDAsString(int TrivetID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE TrivetID=" + TrivetID.ToString(), conn);
            conn.Open();
            List<String> res = new List<String>();
            SqlDataReader sr = comm.ExecuteReader();


            while (sr.Read())
            {
                string s = "";
                s += (sr.GetValue(2));
                res.Add(s);

            }
            conn.Close();
            return res;
        }

        #region --- Properties ---

        private int _trivetID = -1; // The ID of the Event (Primary Key)
        public int TrivetID { get { return _trivetID; } set { _trivetID = value; } }

        private int _trivetType = -1; // The ID of the Event (Primary Key)
        public int TrivetType { get { return _trivetType; } set { _trivetType = value; } }

        private String _trivetName = ""; // The ID of the Event (Primary Key)
        public String TrivetName { get { return _trivetName; } set { _trivetName = value; } }

        #endregion --- Properties ---

        public TrivetClass()
        { }

        //Comes as String
        public TrivetClass(List<string> res)
        {
            this._trivetID = System.Convert.ToInt32(res[0]);
            this._trivetType = System.Convert.ToInt32(res[1]);
            this._trivetName = res[2];
        }

        public bool SaveMe(string user)
        {
            if (true) //If UserID does exist TODO
            {
                try
                {
                    {
                        SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
                        try
                        {
                            SqlCommand comm = new SqlCommand("save_Trivet", conn);
                            comm.CommandType = System.Data.CommandType.StoredProcedure;

                            //comm.Parameters.Add("username", System.Data.SqlDbType.VarChar);
                            //comm.Parameters["username"].Value = this._username;
                            comm.Parameters.Add("TrivetID", System.Data.SqlDbType.Int);
                            comm.Parameters["TrivetID"].Value = this._trivetID;
                            comm.Parameters.Add("TrivetType", System.Data.SqlDbType.Int);
                            comm.Parameters["TrivetType"].Value = this._trivetType;
                            comm.Parameters.Add("TrivetName", System.Data.SqlDbType.VarChar);
                            comm.Parameters["TrivetName"].Value = this._trivetName;

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
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }
    }
}