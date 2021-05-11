// File:    UserDAO.cs
// Author:  hp
// Created: 2018年12月10日 2:43:19
// Purpose: Definition of Class UserDAO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserDAO
    {
        SQLHelper sqlhelper = null;

        public UserDAO()
        {
            sqlhelper = new SQLHelper();
        }

        public bool Insert(string sqlStr, SqlParameter[] paras)
        {
            bool flag = false;
            int res = sqlhelper.ExecuteNonQuery(sqlStr, paras);
            if (res > 0) { flag = true; }
            return flag;
        }

        public bool Edit(string sqlStr, SqlParameter[] paras)
        {
            bool flag = false;
            int res = sqlhelper.ExecuteNonQuery(sqlStr, paras);
            if (res > 0) { flag = true; }
            return flag;
        }

        public bool Delete(string tableName, string target, string value)
        {
            bool flag = false;
            string sqlStr = "delete from " + tableName + " where " + target + "=@value";
            SqlParameter[] paras = new SqlParameter[]{ 
            new SqlParameter("@value",value)           
            };
            int res = sqlhelper.ExecuteNonQuery(sqlStr, paras);
            if (res > 0) { flag = true; }
            return flag;
        }

        public DataTable Select(string tableName)
        {
            string sqlstr = "select * From " + tableName;
            DataSet ds = sqlhelper.GetDataSet(sqlstr, tableName);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable Select(string tableName, string target, string value)
        {
            string sqlstr = "select * From " + tableName + " Where " + target + " = '" + value + "'";
            DataSet ds = sqlhelper.GetDataSet(sqlstr, tableName);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public DataTable SelectDate(string sqlStr)
        {
            return sqlhelper.ExecuteQuery(sqlStr);
        }

        public int Login(string userID, string password)
        {
            string sqlStr = "select password from users where userID= '" + userID + "'";
            DataTable dat = sqlhelper.ExecuteQuery(sqlStr);
            if (dat.Rows.Count == 0) { return 0; }
            string pwd = dat.Rows[0][0].ToString();
            if (password.Equals(pwd)) { return 1; }
            return -1;
        }
    }
}
