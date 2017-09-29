using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class Provider
    {
        private int p_id;
        /// <summary>
        /// 供应商编号
        /// </summary>
        public int P_id
        {
            get { return p_id; }
            set { p_id = value; }
        }
        private string p_company;
        /// <summary>
        /// 供应商公司名称
        /// </summary>
        public string P_company
        {
            get { return p_company; }
            set { p_company = value; }
        }
        private string p_manager;
        /// <summary>
        /// 负责人
        /// </summary>
        public string P_manager
        {
            get { return p_manager; }
            set { p_manager = value; }
        }
        private string p_tel;
        /// <summary>
        /// 供应商联系方式
        /// </summary>
        public string P_tel
        {
            get { return p_tel; }
            set { p_tel = value; }
        }
        private string p_cardname;
        /// <summary>
        /// 与供应商进行交易的银行名称
        /// </summary>
        public string P_cardname
        {
            get { return p_cardname; }
            set { p_cardname = value; }
        }
        private string card;
        /// <summary>
        /// 与供应商进行交易的银行卡号
        /// </summary>
        public string Card
        {
            get { return card; }
            set { card = value; }
        }
    }
}
