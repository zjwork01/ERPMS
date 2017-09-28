using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 员工信息
    /// </summary>
    public class Staff
    {
        private int s_id;
        /// <summary>
        /// 员工编号
        /// </summary>
        public int S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private string s_name;
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        private string s_sex;
        /// <summary>
        /// 员工性别
        /// </summary>
        public string S_sex
        {
            get { return s_sex; }
            set { s_sex = value; }
        }
        private DateTime s_birth;
        /// <summary>
        /// 员工生日
        /// </summary>
        public DateTime S_birth
        {
            get { return s_birth; }
            set { s_birth = value; }
        }
        private string s_nation;
        /// <summary>
        /// 民族
        /// </summary>
        public string S_nation
        {
            get { return s_nation; }
            set { s_nation = value; }
        }
        private string s_location;
        /// <summary>
        /// 籍贯
        /// </summary>
        public string S_location
        {
            get { return s_location; }
            set { s_location = value; }
        }
        private string s_address;
        /// <summary>
        /// 现居地
        /// </summary>
        public string S_address
        {
            get { return s_address; }
            set { s_address = value; }
        }
        private string s_politics;
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string S_politics
        {
            get { return s_politics; }
            set { s_politics = value; }
        }
        private string s_education;
        /// <summary>
        /// 学历
        /// </summary>
        public string S_education
        {
            get { return s_education; }
            set { s_education = value; }
        }
        private int s_section;
        /// <summary>
        /// 所属部门
        /// </summary>
        public int S_section
        {
            get { return s_section; }
            set { s_section = value; }
        }
        private int s_station;
        /// <summary>
        /// 所在岗位
        /// </summary>
        public int S_station
        {
            get { return s_station; }
            set { s_station = value; }
        }
        private string s_tel;
        /// <summary>
        /// 联系方式
        /// </summary>
        public string S_tel
        {
            get { return s_tel; }
            set { s_tel = value; }
        }
        private string s_note;
        /// <summary>
        /// 备注
        /// </summary>
        public string S_note
        {
            get { return s_note; }
            set { s_note = value; }
        }
        
    }
}
