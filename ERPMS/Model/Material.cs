using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 原材料
    /// </summary>
    public class Material
    {
        private int m_id;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        private string m_name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        private string m_unit;
        /// <summary>
        /// 计量单位
        /// </summary>
        public string Unit
        {
            get { return m_unit; }
            set { m_unit = value; }
        }
        private double m_price;
        /// <summary>
        /// 价格
        /// </summary>
        public double Price
        {
            get { return m_price; }
            set { m_price = value; }
        }
        private int m_number;
        /// <summary>
        /// 现有数量
        /// </summary>
        public int Number
        {
            get { return m_number; }
            set { m_number = value; }
        }
        private int m_warehouse;
        /// <summary>
        /// 所属仓库
        /// </summary>
        public int Warehouse
        {
            get { return m_warehouse; }
            set { m_warehouse = value; }
        }
        private int m_provider;
        /// <summary>
        /// 供应商
        /// </summary>
        public int Provider
        {
            get { return m_provider; }
            set { m_provider = value; }
        }
        private string m_note;
        /// <summary>
        /// 备注
        /// </summary>
        public string Note
        {
            get { return m_note; }
            set { m_note = value; }
        }
    }
}
