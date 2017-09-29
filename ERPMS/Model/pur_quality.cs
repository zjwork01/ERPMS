using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 质检单
    /// </summary>
    public class pur_quality
    {
        private int q_id;
        /// <summary>
        /// 质检单编号
        /// </summary>
        public int Q_id
        {
            get { return q_id; }
            set { q_id = value; }
        }
        private int q_provider;
        /// <summary>
        /// 商品供应商
        /// </summary>
        public int Q_provider
        {
            get { return q_provider; }
            set { q_provider = value; }
        }
        private int q_material;
        /// <summary>
        /// 商品
        /// </summary>
        public int Q_material
        {
            get { return q_material; }
            set { q_material = value; }
        }
        private int q_num;
        /// <summary>
        /// 数量
        /// </summary>
        public int Q_num
        {
            get { return q_num; }
            set { q_num = value; }
        }
        private int q_staff;
        /// <summary>
        /// 质检人
        /// </summary>
        public int Q_staff
        {
            get { return q_staff; }
            set { q_staff = value; }
        }
        private string q_information;
        /// <summary>
        /// 检验情况
        /// </summary>
        public string Q_information
        {
            get { return q_information; }
            set { q_information = value; }
        }
        private int q_state;
        /// <summary>
        /// 之间状态
        /// </summary>
        public int Q_state
        {
            get { return q_state; }
            set { q_state = value; }
        }
        private DateTime q_date;
        /// <summary>
        /// 检验日期
        /// </summary>
        public DateTime Q_date
        {
            get { return q_date; }
            set { q_date = value; }
        }
    }
}
