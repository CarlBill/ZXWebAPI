using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Dapper;

namespace PublicClass
{
    /// <summary>
    /// Dapper 帮助类
    /// </summary>
    public static class DapperHelper
    {

        static string sqlconnection = ConfigurationManager.ConnectionStrings["sqlServer"].ToString();

        private static SqlConnection OpenConnection()
        {

            SqlConnection connection = new SqlConnection(sqlconnection);  
            connection.Open();
            return connection;
        }

        #region 查询数据
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity">T</param>
        /// <returns></returns>
        public static List<T> Query<T>(string sql, T entity)
        {
            List<T> list = new List<T>();
            using (IDbConnection conn = OpenConnection())
            {

                list = conn.Query<T>(sql, entity).ToList();

            }
            return list;
        }


        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public static List<T> Query<T>(string sql, object obj)
        {
            List<T> list = new List<T>();
            using (IDbConnection conn = OpenConnection())
            {
                list = conn.Query<T>(sql, obj).ToList();
            }
            return list;
        }

        /// <summary>
        /// 查询第一行第一列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public static T QueryScalar<T>(string sql, object obj)
        {

            T result = default(T);

            using (IDbConnection conn = OpenConnection())
            {
                result = conn.ExecuteScalar<T>(sql, obj);
            }
            return result;
        }
        #endregion

        #region 执行增，删，改 
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int NonQuery<T>(string sql, T entity)
        {
            int res = 0;
            using (IDbConnection conn = OpenConnection())
            {
                res = conn.Execute(sql, entity);
            }
            return res;
        }

        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int NonQuery(string sql, object obj)
        {
            int res = 0;
            using (IDbConnection conn = OpenConnection())
            {
                res = conn.Execute(sql, obj);
            }
            return res;
        }
        #endregion

    }
}
