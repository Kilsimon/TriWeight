using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BachelorWishList
{
    public class CompanyClass
    {
        public static string _sqltable = "Company";
        public static List<string> _eventsValues = new List<string>();

        public static List<CompanyClass> GetAllCompany()
        {
            List<CompanyClass> tempList = new List<CompanyClass>();
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
                    tempList.Add(new CompanyClass(res));
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

        public static List<CompanyClass> GetAllCompanyWithName(String S)
        {
            List<CompanyClass> tempList = new List<CompanyClass>();
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            try
            {
                SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " Where CompanyName='" + S + "'", conn);
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
                    tempList.Add(new CompanyClass(res));
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

        public static CompanyClass GetCompanyByCompanyID(int CompanyID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE CompanyID=" + CompanyID.ToString(), conn);
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
            return new CompanyClass(res);
        }

        public static List<String> GetCompanyByCompanyIDAsString(int CompanyID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE CompanyID=" + CompanyID.ToString(), conn);
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

        public static String GetCompanyNameByCompanyIDAsString(int CompanyID)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE CompanyID=" + CompanyID.ToString(), conn);
            conn.Open();
            String res = "";
            SqlDataReader sr = comm.ExecuteReader();

            while (sr.Read())
            {
                string s = "";
                s += (sr.GetValue(1));
                res = s;
            }
            conn.Close();
            return res;
        }


        #region --- Properties  ---

        private int _companyID = 1; // The ID of the Event (Primary Key)
        public int CompanyID { get { return _companyID; } set { _companyID = value; } }

        private string _companyName = ""; // The ID of the Event (Primary Key)
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }

        private int _companyCount = -1; // The ID of the User owning the Event
        public int CompanyCount { get { return _companyCount; } set { _companyCount = value; } }


        #endregion --- Properties ---


        public CompanyClass() {
        }

        //Comes as String
        public CompanyClass(List<string> res)
        {
            this._companyID = System.Convert.ToInt32(res[0]);
            this._companyName = res[1];
            this._companyCount = System.Convert.ToInt32(res[2]);
        }

        public bool SaveMe(string user)
        {
                try
                {
                    {
                        SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
                        try
                        {
                            SqlCommand comm = new SqlCommand("save_Company", conn);
                            comm.CommandType = System.Data.CommandType.StoredProcedure;

                            //comm.Parameters.Add("username", System.Data.SqlDbType.VarChar);
                            //comm.Parameters["username"].Value = this._username;
                            comm.Parameters.Add("CompanyID", System.Data.SqlDbType.Int);
                            comm.Parameters["CompanyID"].Value = this._companyID;
                            comm.Parameters.Add("CompanyName", System.Data.SqlDbType.VarChar);
                            comm.Parameters["CompanyName"].Value = this._companyName;
                            comm.Parameters.Add("CompanyCount", System.Data.SqlDbType.Int);
                            comm.Parameters["CompanyCount"].Value = this._companyCount;

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

    }
}
