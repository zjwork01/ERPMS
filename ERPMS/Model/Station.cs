using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 岗位信息
    /// </summary>
    public class Station
    {
        private int s_id;
        /// <summary>
        /// 岗位编号
        /// </summary>
        public int S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private string s_name;
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        private double s_salary;
        /// <summary>
        /// 岗位薪资
        /// </summary>
        public double S_salary
        {
            get { return s_salary; }
            set { s_salary = value; }
        }
        private string s_lmit;
        /// <summary>
        /// 岗位权限
        /// </summary>
        public string S_lmit
        {
            get { return s_lmit; }
            set { s_lmit = value; }
        }
    }
}
