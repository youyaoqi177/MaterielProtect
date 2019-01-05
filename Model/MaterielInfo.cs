using System;

namespace DAL
{
    public class MaterielInfo
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MName { set; get; }
        /// <summary>
        /// 物料分类
        /// </summary>
        public MaterielPartition Partition { set; get; }
        /// <summary>
        /// 物料采购价
        /// </summary>
        public decimal PuPrice { set; get; }
        /// <summary>
        /// 物料销售价
        /// </summary>
        public decimal SaPrice { set; get; }
        /// <summary>
        /// 物料单位
        /// </summary>
        public Unit unit { set; get; }
        /// <summary>
        /// 物料规格
        /// </summary>
        public string Specifications { set; get; }
        /// <summary>
        /// 增加日期
        /// </summary>
        public DateTime FirstDate { set; get; }
        /// <summary>
        /// 最后修改日期
        /// </summary>
        public DateTime LastDate { set; get; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Number { set; get; }
    }
}
