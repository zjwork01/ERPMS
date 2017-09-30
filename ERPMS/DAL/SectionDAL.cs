using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Tool;

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
                    Log.WriteLog(LogType.SQL, "添加部门信息"+section.ToString()+"出错，未知错误");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Log.WriteLog(LogType.SQL, "添加部门信息" + section.ToString() + "出错，原因：" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 修改部门信息
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public bool Alter(Section section)
        {
            try
            {
                string sql = "update dbo.section set s_name = @name,s_owner=@owner,s_tel=@tel,s_note=@note where s_id=@id";
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@id",section.S_id), 
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
                    Log.WriteLog(LogType.SQL, "修改部门信息" + section.ToString() + "出错，未知错误");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Log.WriteLog(LogType.SQL, "修改部门信息" + section.ToString() + "出错，原因：" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 根据ID删除部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            try
            {
                string sql = "delete from dbo.section where s_id=@id";
                SqlParameter[] para = new SqlParameter[]{
                    new SqlParameter("@id",id) 
                };
                int n = SQLHelper.ExecuteNonQuery(SQLHelper.GetConnection(), System.Data.CommandType.Text, sql, para);
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    Log.WriteLog(LogType.SQL, "删除部门信息，编号为" + id + "出错，未知错误");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(LogType.SQL, "删除部门信息，编号为" + id + "出错，原因："+ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 获取全部部门信息
        /// </summary>
        public List<Section> GetSections()
        {
            List<Section> list = new List<Section>();
            try
            {
                string sql = "select * from dbo.section";
                DataSet ds = SQLHelper.ExecuteDataset(SQLHelper.GetConnection(), CommandType.Text, sql);
                DataTable table = new DataTable();
                if (ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Section()
                    {
                        S_id = Int32.Parse(row["s_id"].ToString()),
                        S_name = row["s_name"].ToString(),
                        S_tel = row["s_tel"].ToString(),
                        S_owner = row["s_owner"].ToString(),
                        S_note = row["s_note"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(LogType.Trace, "查询数据失败，原因:" + ex.ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据部门编号查询部门信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Section> GetSectionById(int id)
        {
            List<Section> list = new List<Section>();
            try
            {
                string sql = "select * from dbo.section where s_id=@id";
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@id",id) 
                };
                DataSet ds = SQLHelper.ExecuteDataset(SQLHelper.GetConnection(), CommandType.Text, sql, para);
                DataTable table = new DataTable();
                if (ds.Tables.Count > 0)
                {
                    table = ds.Tables[0];
                }
                foreach (DataRow row in table.Rows)
                {
                    list.Add(new Section()
                    {
                        S_id = Int32.Parse(row["s_id"].ToString()),
                        S_name = row["s_name"].ToString(),
                        S_tel = row["s_tel"].ToString(),
                        S_owner = row["s_owner"].ToString(),
                        S_note = row["s_note"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Log.WriteLog(LogType.Trace, "查询数据失败，原因:" + ex.ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据条件查询部门信息
        /// </summary>
        /// <returns></returns>
        public List<Section> GetSectionByCondition(Expression<Func<Section,bool>> condition)
        {
            
        }
    }
}
