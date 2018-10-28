using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace BachelorWishList
{
    public class LogInClass
    {
        public static string _sqltable = "Event";

        public static LogInClass GetIDByEMail(string EMail)
        {
            SqlConnection conn = new SqlConnection(SetUpClass._dbcon);
            SqlCommand comm = new SqlCommand("SELECT * FROM " + _sqltable + " WHERE E_Mail=" + EMail, conn);
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
            }
            conn.Close();
            return new LogInClass(res);
        }

    /*    public static bool LogIn(LogInClass LIS)
        {
            if (Password.Equals(UserPassword) && Email.Equals(UserEMail))
            {
                return true;
            }

            return false;
        }*/



        #region --- Properties ---

        private int _userID = -1; // The ID of the user (Primary Key)
        public int UserID { get { return _userID; } set { _userID = value; } }

        private string _userName = ""; // Name of the user (Not username)
        public string UserName { get { return _userName; } set { _userName = value; } }

        private string _userPassword = ""; // The password for login 
        public string UserPassword { get { return _userPassword; } set { _userPassword = value; } }  //TODO handle encryption

        private string _userEmail = ""; //The E-mail of the user
        public string UserEmail { get { return _userEmail; } set { _userEmail = value; } }

        private string _userSkin = ""; // The skin name, if the user is using a skin
        public string UserSkin { get { return _userSkin; } set { _userSkin = value; } }

        private bool _userPremium = false; // If the user is a paying costumer
        public bool UserPremium { get { return _userPremium; } set { _userPremium = value; } }

        private bool _userActive = false; // User have been active for the last X month
        public bool UserActive { get { return _userActive; } set { _userActive = value; } }

        private bool _userMaster = false; // If the user is someone who can change the program
        public bool UserMaster { get { return _userMaster; } set { _userMaster = value; } }


        #endregion--- Properties ---

        public LogInClass()
        { }

        //Comes as String
        public LogInClass(List<string> res)
        {
            this._userID = System.Convert.ToInt32(res[0]);
            this._userName = res[1];
            this._userPassword = res[2];
            this._userEmail = res[3];
            this._userSkin = res[4];

            if (res[5].Equals(0))
            {
                this._userPremium = false;
            }
            else if (res[5].Equals(1))
            {
                this._userPremium = true;
            }

            if (res[6].Equals(0))
            {
                this._userActive = false;
            }
            else if (res[6].Equals(1))
            {
                this._userActive = true;
            }

            if (res[7].Equals(0))
            {
                this._userMaster = false;
            }
            else if (res[7].Equals(1))
            {
                this._userMaster = true;
            }

            //  this._userPremium = System.Convert.ToBoolean(res[5]);
            //  this._userActive = System.Convert.ToBoolean(res[6]);
            //  this._userMaster = System.Convert.ToBoolean(res[7]);
        }
    }
}