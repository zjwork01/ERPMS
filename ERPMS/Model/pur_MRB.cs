using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 退货单
    /// </summary>
    public class pur_MRB
    {
        private int p_id;
        /// <summary>
        /// 退货单编号
        /// </summary>
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private int p_staff;
        /// <summary>
        /// 负责人
        /// </summary>
        public int P_staff
        {
            get { return p_staff; }
            set { p_staff = value; }
        }
        private DateTime p_date;
        /// <summary>
        /// 退货日期
        /// </summary>
        public DateTime P_date
        {
            get { return p_date; }
            set { p_date = value; }
        }
        private int p_material;
        /// <summary>
        /// 退货物品
        /// </summary>
        public int P_material
        {
            get { return p_material; }
            set { p_material = value; }
        }
        private int p_num;
        /// <summary>
        /// 退货数量
        /// </summary>
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
        private int p_state;
        /// <summary>
        /// 退货状态
        /// </summary>
        public int P_state
        {
            get { return p_state; }
            set { p_state = value; }
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
