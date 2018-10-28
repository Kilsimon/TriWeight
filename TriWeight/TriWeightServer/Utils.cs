using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace BachelorWishList
{
    public class Utils
    {

        public static int GetNextId(string filename)
        {

            {
                //Could be made with Enums to avoid more errors.
                List<string> res = new List<string>();
                string sql = "";
                if (filename == "Data")
                {
                    sql = "SELECT Max(DataID) FROM " + filename;
                }
                else if (filename == "Company")
                {
                    sql = "SELECT Max(CompanyID) FROM " + filename;
                }
                else if (filename == "Trivet")
                {
                    sql = "SELECT Max(TrivetID) FROM " + filename;
                }
                SqlConnection conn = new SqlConnection(SetUpClass._dbcon);

                SqlCommand comm = new SqlCommand(sql, conn);

                    try
                    {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                        SqlDataReader sr = comm.ExecuteReader();
                        while (sr.Read())
                        {

                            for (int i = 0; i < sr.FieldCount; i++)
                            {
                                string s = "";
                                s += (sr.GetValue(i));
                                res.Add(s);
                            }
                        }


                        if (res[0] != string.Empty)
                            return (System.Convert.ToInt32(res[0]) + 1);
                        else
                            return 1;
                    }
                    catch (Exception ex)
                    {
                    Console.WriteLine("{0} Exception caught.", ex.Message);
                    }
                    conn.Close();
                    return 0;
            }
        }

        public static string CreateRandomPassword(int len)
        {
            string res = "";
            string c = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789"; // I,l,1,O,0 have been omitted on purpose
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < len; i++)
            {
                int index = r.Next(0, c.Length);
                res += c[index];
            }
            return res;
        }

        /// <summary>
        /// Taken from http://haacked.com/archive/2007/08/21/i-knew-how-to-validate-an-email-address-until-i.aspx
        /// </summary>
        /// <returns></returns>
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public static bool EmailIsValid(string emailAddress)
        {
            Regex ValidEmailRegex = CreateValidEmailRegex();
            bool isValid = (!string.IsNullOrEmpty(emailAddress)) && ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }

        //Reads a number with format [Number] - text
        public static int ExtractRecord(string s)
        {
            if (s.StartsWith("[") == true)
            {
                int end = s.IndexOf("] -");
                if (end > -1)
                {
                    try
                    {
                        string value = s.Substring(1, end - 1);
                        return System.Convert.ToInt32(value);
                    }
                    catch
                    {
                        return -1;
                    }
                }
                else
                    return -1;
            }
            else
                return -1;
        }

        public static bool IsNumeric(string s) //Virker ikke
        {
            int i = 0; 
            if (Object.ReferenceEquals(s.GetType(), i.GetType()))
            {
                return true;
            }
            return false;
        }
    }
}