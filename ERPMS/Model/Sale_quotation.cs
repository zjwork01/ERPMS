using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 销售报价单
    /// </summary>
    public class Sale_quotation
    {
        private int s_id;
        /// <summary>
        /// 报价单编号
        /// </summary>
        public int S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private int s_product;
        /// <summary>
        /// 产品编号
        /// </summary>
        public int S_product
        {
            get { return s_product; }
            set { s_product = value; }
        }
        private int s_staff;
        /// <summary>
        /// 报价人员
        /// </summary>
        public int S_staff
        {
            get { return s_staff; }
            set { s_staff = value; }
        }
        private double s_price;
        /// <summary>
        /// 定价
        /// </summary>
        public double S_price
        {
            get { return s_price; }
            set { s_price = value; }
        }
        private int p_num;
        /// <summary>
        /// 预销数量
        /// </summary>
        public int P_num
        {
            get { return p_num; }
            set { p_num = value; }
        }
        private double p_earning;
        /// <summary>
        /// 预计收入
        /// </summary>
        public double P_earning
        {
            get { return p_earning; }
            set { p_earning = value; }
        }
    }
}
