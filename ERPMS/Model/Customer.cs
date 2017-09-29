using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 客户
    /// </summary>
    public class Customer
    {
        private int c_id;
        /// <summary>
        /// 客户编号
        /// </summary>
        public int C_id
        {
            get { return c_id; }
            set { c_id = value; }
        }
        private string c_name;
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string C_name
        {
            get { return c_name; }
            set { c_name = value; }
        }
        private string c_company;
        /// <summary>
        /// 公司名称
        /// </summary>
        public string C_company
        {
            get { return c_company; }
            set { c_company = value; }
        }
        private string c_tel;
        /// <summary>
        /// 联系方式
        /// </summary>
        public string C_tel
        {
            get { return c_tel; }
            set { c_tel = value; }
        }
        private string c_type;
        /// <summary>
        /// 客户类型
        /// </summary>
        public string C_type
        {
            get { return c_type; }
            set { c_type = value; }
        }
    }
}
