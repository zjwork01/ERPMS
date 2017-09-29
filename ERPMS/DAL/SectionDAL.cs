using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

/**
*作者：赵进
*时间：2017/9/29 16:28:56
*描述：部门数据操作类
*版本：1.0.0
*/
namespace DAL
{
    public class SectionDAL
    {
        /// <summary>
        /// 添加部门信息
        /// </summary>
        /// <param name="section">部门</param>
        /// <returns>返回受影响的行数</returns>
        public bool Add(Section section)
        {
            try
            {
                string sql = "insert into section(s_name,s_owner,s_tel,s_note) values (@name,@owner,@tel,@note)";
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@name",section.S_name),
                    new SqlParameter("@owner",section.S_owner),
                    new SqlParameter("@tel",section.S_tel),
                    new SqlParameter("@note",section.S_note)
                };
                int n = SQLHelper.ExecuteNonQuery(SQLHelper.GetConnection(), System.Data.CommandType.Text, sql, para);
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
