// File:    Admin.cs
// Author:  hp
// Created: 2018年12月10日 3:59:45
// Purpose: Definition of Class Admin

using System;







namespace Model
{
    public class User
    {
        private string userID;
        private string password;
        private string loginInfo;

        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                this.userID = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        public string LoginInfo
        {
            get
            {
                return loginInfo;
            }
            set
            {
                this.loginInfo = value;
            }
        }

    }
}
