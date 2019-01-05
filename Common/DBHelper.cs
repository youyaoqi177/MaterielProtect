using System;
using System.Data;
using System.Data.SqlClient;

namespace Common
{

    public static class DBHelper
    {
        private static SqlConnection con;
        /// <summary>
        /// 初始化连接
        /// </summary>
        public static void InitConnection()
        {
            try
            {
                con = new SqlConnection("server=13831526661.tpddns.cn,6002;database=DBText1;uid=sa;pwd=123456");
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接错误" + ex.Message);
            }

        }
        /// <summary>
        /// 增删改方法
        /// </summary>
        /// <param name="sqlstr">sql语句</param>
        /// <returns></returns>
        public static bool Update(string sqlstr)
        {
            InitConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("更新数据错误" + ex.Message);
            }


        }
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sqlstr)
        {
            InitConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(sqlstr, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        /// <summary>
        /// 按照分类查询数据
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="sqlparameter"></param>
        /// <returns></returns>
        public static DataSet FindByPartition(string sqlstr, SqlParameter sqlparameter)
        {
            InitConnection();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = sqlstr;

            cmd.Parameters.Add(sqlparameter);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;

        }
    }
}
