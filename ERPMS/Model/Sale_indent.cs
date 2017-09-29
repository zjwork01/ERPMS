using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 销售订单
    /// </summary>
    public class Sale_indent
    {
        private int s_id;
        /// <summary>
        /// 订单编号
        /// </summary>
        public int S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private int s_staff;
        /// <summary>
        /// 销售人员
        /// </summary>
        public int S_staff
        {
            get { return s_staff; }
            set { s_staff = value; }
        }
        private int s_product;
        /// <summary>
        /// 销售的产品
        /// </summary>
        public int S_product
        {
            get { return s_product; }
            set { s_product = value; }
        }
        private int s_num;
        /// <summary>
        /// 销售数量
        /// </summary>
        public int S_num
        {
            get { return s_num; }
            set { s_num = value; }
        }
        private int s_customer;
        /// <summary>
        /// 客户
        /// </summary>
        public int S_customer
        {
            get { return s_customer; }
            set { s_customer = value; }
        }
        private double s_price;
        /// <summary>
        /// 销售价格
        /// </summary>
        public double S_price
        {
            get { return s_price; }
            set { s_price = value; }
        }
        private DateTime s_data;
        /// <summary>
        /// 销售日期
        /// </summary>
        public DateTime S_data
        {
            get { return s_data; }
            set { s_data = value; }
        }
        private int s_state;
        /// <summary>
        /// 订单状态
        /// </summary>
        public int S_state
        {
            get { return s_state; }
            set { s_state = value; }
        }
        private string s_logistics;
        /// <summary>
        /// 物流名称
        /// </summary>
        public string S_logistics
        {
            get { return s_logistics; }
            set { s_logistics = value; }
        }
        private string s_logisticsid;
        /// <summary>
        /// 物流单号
        /// </summary>
        public string S_logisticsid
        {
            get { return s_logisticsid; }
            set { s_logisticsid = value; }
        }
        private string s_address;
        /// <summary>
        /// 收货地址
        /// </summary>
        public string S_address
        {
            get { return s_address; }
            set { s_address = value; }
        }
    }
}
