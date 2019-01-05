using Common;
using System;
using System.Collections;
using System.Data;

namespace DAL
{
    public class MaterielInfoDAL
    {
        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public DataTable FindMaterielInfo()
        {
            string sqlstr = "select ID,PID,UID,MName,PuPrice,SaPrice,Specifications,Number," +
                "FirstDate,LastDate from Materiel";
            DataSet ds = DBHelper.GetDataSet(sqlstr);
            DataTable table = ds.Tables[0];
            return table;
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="materielInfo"></param>
        /// <returns></returns>
        public bool InsertInfo(MaterielInfo materielInfo)
        {
            string sqlstr = string.Format("INSERT INTO Materiel VALUES('{0}',{1},{2},'{3}',{4},{5},'{6}',{7},'{8}','{9}')",
                materielInfo.ID,
                materielInfo.Partition.PID,
                materielInfo.unit.UID,
                materielInfo.MName,
                materielInfo.PuPrice,
                materielInfo.SaPrice,
                materielInfo.Specifications,
                materielInfo.Number,
                materielInfo.FirstDate,
                materielInfo.LastDate);
            return DBHelper.Update(sqlstr);
        }
        /// <summary>
        /// 获取当前编码最大值
        /// </summary>
        /// <returns></returns>
        public long GetMaxMaterielID()
        {
            string d1 = DateTime.Now.ToString("yyyyMMdd");
            string sqlstr = "select ID from Materiel where ID LIKE '" + d1 + "%'";
            DataTable dt = DBHelper.GetDataSet(sqlstr).Tables[0];

            if (dt.Rows.Count > 0)
            {
                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(long.Parse(row[0].ToString()));
                }

                list.Sort();

                return long.Parse(list[list.Count - 1].ToString());
            }
            return 0;

        }
        /// <summary>
        /// 数据更新
        /// </summary>
        /// <param name="materielInfo"></param>
        /// <param name="MID"></param>
        /// <returns></returns>
        public bool UpdateInfo(MaterielInfo materielInfo, string MID)
        {
            string sqlstr = string.Format("UPDATE Materiel SET PID={0},UID={1},MName='{2}',PuPrice={3},SaPrice={4}," +
                "Specifications='{5}',Number={6},LastDate='{7}'  WHERE ID='{8}'",
                materielInfo.Partition.PID,
                materielInfo.unit.UID,
                materielInfo.MName,
                materielInfo.PuPrice,
                materielInfo.SaPrice,
                materielInfo.Specifications,
                materielInfo.Number,
                materielInfo.LastDate,
                MID

                );
            return (bool)DBHelper.Update(sqlstr);
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="MID"></param>
        /// <returns></returns>
        public bool DeleteInfo(string MID)
        {
            string sqlstr = string.Format("DELETE FROM Materiel WHERE ID='{0}'", MID);
            return (bool)DBHelper.Update(sqlstr);
        }
    }
}
