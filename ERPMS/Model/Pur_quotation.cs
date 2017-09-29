using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 采购报价单
    /// </summary>
    public class Pur_quotation
    {
        private int q_id;
        /// <summary>
        /// 报价单编号
        /// </summary>
        public int Q_id
        {
            get { return q_id; }
            set { q_id = value; }
        }
        private int q_name;
        /// <summary>
        /// 报价单申请人
        /// </summary>
        public int Q_name
        {
            get { return q_name; }
            set { q_name = value; }
        }
        private DateTime q_time;
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime Q_time
        {
            get { return q_time; }
            set { q_time = value; }
        }
        private int q_material;
        /// <summary>
        /// 采购原材料
        /// </summary>
        public int Q_material
        {
            get { return q_material; }
            set { q_material = value; }
        }
        private int q_num;
        /// <summary>
        /// 采购数量
        /// </summary>
        public int Q_num
        {
            get { return q_num; }
            set { q_num = value; }
        }
        private int q_auditor;
        /// <summary>
        /// 审核人
        /// </summary>
        public int Q_auditor
        {
            get { return q_auditor; }
            set { q_auditor = value; }
        }
        private DateTime q_auditdate;
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime Q_auditdate
        {
            get { return q_auditdate; }
            set { q_auditdate = value; }
        }
        private int q_auditstate;
        /// <summary>
        /// 审核日期
        /// </summary>
        public int Q_auditstate
        {
            get { return q_auditstate; }
            set { q_auditstate = value; }
        }
        private string q_note;
        /// <summary>
        /// 备注
        /// </summary>
        public string Q_note
        {
            get { return q_note; }
            set { q_note = value; }
        }
    }
}
