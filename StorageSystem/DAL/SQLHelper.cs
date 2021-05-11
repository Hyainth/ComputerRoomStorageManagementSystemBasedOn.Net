using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class SQLHelper
    {
        private SqlConnection sqlCon = null;
        private SqlCommand sqlCom = null;
        private SqlDataReader sqlDReader = null;
        private SqlDataAdapter sqlDAdapter = null;
        string connStr = @"server=.;uid=sa;pwd=123456;database=CSS";

        public SQLHelper()
        {
            sqlCon = new SqlConnection(connStr);
        }
        #region 该方法用于打开数据库连接
        /// <summary>
        /// 该方法用于打开数据库连接
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetsqlCon()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            return sqlCon;
        }
        #endregion

        #region 该方法执行传入的Sql增删改语句
        /// <summary>
        /// 该方法执行传入的Sql增删改语句
        /// </summary>
        /// <param name="sqlStr">Sql增删改语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sqlStr)
        {
            int res;
            try
            {
                sqlCom = new SqlCommand(sqlStr, GetsqlCon());
                res = sqlCom.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return res;
        }
        #endregion

        #region 执行带参数的sqlStr增删改语句
        /// <summary>
        /// 执行带参数的sqlStr增删改语句
        /// </summary>
        /// <param name="sqlStr">带参数的sqlStr增删改语句</param>
        /// <param name="paras">参数集合</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sqlStr, SqlParameter[] paras)
        {
            int res;
            using (sqlCom = new SqlCommand(sqlStr, GetsqlCon()))
            {
                sqlCom.Parameters.AddRange(paras);
                res = sqlCom.ExecuteNonQuery();
            }
            return res;
        }
        #endregion

        #region 该方法执行传入的Sql查询语句
        /// <summary>
        /// 该方法执行传入的Sql查询语句
        /// </summary>
        /// <param name="sqlStr">Sql查询语句</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sqlStr)
        {
            DataTable My_table = new DataTable();
            sqlCom = new SqlCommand(sqlStr, GetsqlCon());
            using (sqlDReader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection))
            {
                My_table.Load(sqlDReader);
            }
            return My_table;
        }
        #endregion

        #region 该方法执行带参数的Sql查询语句
        /// <summary>
        /// 该方法执行带参数的Sql查询语句
        /// </summary>
        /// <param name="sqlStr">带参数的Sql查询语句</param>
        /// <param name="paras">参数集合</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sqlStr, SqlParameter[] paras)
        {
            DataTable My_table = new DataTable();
            sqlCom = new SqlCommand(sqlStr, GetsqlCon());
            sqlCom.Parameters.AddRange(paras);
            using (sqlDReader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection))
            {
                My_table.Load(sqlDReader);
            }
            return My_table;
        }
        #endregion

        #region 该方法执行传入的Sql查询语句
        /// <summary>
        /// 该方法执行传入的Sql查询语句
        /// </summary>
        /// <param name="sqlStr">sql语句</param>
        /// <param name="TableName">表名</param>
        /// <returns>My_set</returns>
        public DataSet GetDataSet(string sqlStr, string TableName)
        {
            DataSet My_set = new DataSet();
            sqlDAdapter = new SqlDataAdapter(sqlStr, GetsqlCon());
            sqlDAdapter.Fill(My_set, TableName);
            return My_set;
        }
        #endregion

        #region 该方法执行传入的Sql查询语句
        /// <summary>
        /// 该方法执行传入的Sql查询语句
        /// </summary>
        /// <param name="sqlStr">sql语句</param>
        /// <returns>sqlDReader</returns>
        public SqlDataReader GetRead(string sqlStr, SqlParameter[] paras)
        {
            sqlCom = new SqlCommand(sqlStr, GetsqlCon());
            sqlCom.Parameters.AddRange(paras);
            sqlDReader = sqlCom.ExecuteReader();
            return sqlDReader;
        }
        #endregion
    }
}
