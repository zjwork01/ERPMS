using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 采购订单
    /// </summary>
    public class pur_indent
    {
        private int p_id;
        /// <summary>
        /// 订单号
        /// </summary>
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private int p_staff;
        /// <summary>
        /// 采购人员
        /// </summary>
        public int P_staff
        {
            get { return p_staff; }
            set { p_staff = value; }
        }
        private DateTime p_indentdate;
        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime P_indentdate
        {
            get { return p_indentdate; }
            set { p_indentdate = value; }
        }
        private DateTime p_pickdate;
        /// <summary>
        /// 收货日期
        /// </summary>
        public DateTime P_pickdate
        {
            get { return p_pickdate; }
            set { p_pickdate = value; }
        }
        private int p_material;
        /// <summary>
        /// 采购的原材料
        /// </summary>
        public int P_material
        {
            get { return p_material; }
            set { p_material = value; }
        }
        private int p_num;
        /// <summary>
        /// 采购的数量
        /// </summary>
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
        private int p_indentstate;
        /// <summary>
        /// 订单状态
        /// </summary>
        public int P_indentstate
        {
            get { return p_indentstate; }
            set { p_indentstate = value; }
        }
        private string p_logistics;
        /// <summary>
        /// 物流名称
        /// </summary>
        public string P_logistics
        {
            get { return p_logistics; }
            set { p_logistics = value; }
        }
        private int p_logisticeid;
        /// <summary>
        /// 物流单号
        /// </summary>
        public int P_logisticeid
        {
            get { return p_logisticeid; }
            set { p_logisticeid = value; }
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
