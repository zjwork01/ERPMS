using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 实体类
 * 赵进
 * 2017-09-28
 * */
namespace Model
{
    /// <summary>
    /// 部门信息
    /// </summary>
    public class Section
    {
        private int s_id;
        /// <summary>
        /// 部门编号
        /// </summary>
        public int S_id
        {
            get { return s_id; }
            set { s_id = value; }
        }
        private string s_name;
        /// <summary>
        /// 部门名称
        /// </summary>
        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }
        private string s_owner;
        /// <summary>
        /// 部门负责人
        /// </summary>
        public string S_owner
        {
            get { return s_owner; }
            set { s_owner = value; }
        }
        private string s_tel;
        /// <summary>
        /// 部门联系电话
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
