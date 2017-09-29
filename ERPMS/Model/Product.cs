using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 产品
    /// </summary>
    public class Product
    {
        private int p_id;
        /// <summary>
        /// 产品编号
        /// </summary>
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private string p_name;
        /// <summary>
        /// 产品名称
        /// </summary>
        public string P_name
        {
            get { return p_name; }
            set { p_name = value; }
        }
        private string p_unit;
        /// <summary>
        /// 计量单位
        /// </summary>
        public string P_unit
        {
            get { return p_unit; }
            set { p_unit = value; }
        }
        private int p_num;
        /// <summary>
        /// 产品数量
        /// </summary>
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
        private int p_warehouse;
        /// <summary>
        /// 产品所在仓库
        /// </summary>
        public int P_warehouse
        {
            get { return p_warehouse; }
            set { p_warehouse = value; }
        }
        private string p_note;
        /// <summary>
        /// 备注
        /// </summary>
        public string P_note
        {
            get { return p_note; }
            set { p_note = value; }
        }
    }
}
