using Common;
using System.Data;

namespace DAL
{
    public class UnitDAL
    {
        /// <summary>
        /// 查询全部单位
        /// </summary>
        /// <returns></returns>
        public DataTable FindUnit()
        {
            string sqlstr = "select ID,UName from Unit";
            DataTable dt = DBHelper.GetDataSet(sqlstr).Tables[0];
            return dt;
        }
    }
}
