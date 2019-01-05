using Common;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MaterielPartitionDAL
    {
        /// <summary>
        /// 根据分类查询数据
        /// </summary>
        /// <param name="PartitionID"></param>
        /// <returns></returns>
        public DataTable FindByPartition(int PartitionID)
        {

            string sqlstr = "select a.*,u.UName as uName from (select m.*,p.PName as pName from Materiel m,MaterielPartition p where m.PID=p.ID and PID=@pid) a,Unit u where a.UID=u.ID";

            SqlParameter para1 = new SqlParameter("@pid", PartitionID);
            DataSet ds = DBHelper.FindByPartition(sqlstr, para1);
            DataTable dt = ds.Tables[0];
            return dt;
        }
        /// <summary>
        /// 查询全部分类
        /// </summary>
        /// <returns></returns>
        public DataTable FindPartition()
        {
            string sqlstr = "select ID,PName from MaterielPartition";
            DataTable dt = DBHelper.GetDataSet(sqlstr).Tables[0];
            return dt;
        }
    }
}
