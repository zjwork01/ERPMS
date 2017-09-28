using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 仓库
    /// </summary>
    public class WareHouse
    {
        private int w_id;
        /// <summary>
        /// 仓库编号
        /// </summary>
        public int W_id
        {
            get { return w_id; }
            set { w_id = value; }
        }
        private string w_location;
        /// <summary>
        /// 仓库地址
        /// </summary>
        public string W_location
        {
            get { return w_location; }
            set { w_location = value; }
        }
        private double w_capacity;
        /// <summary>
        /// 仓库容量
        /// </summary>
        public double W_capacity
        {
            get { return w_capacity; }
            set { w_capacity = value; }
        }
        private int w_type;
        /// <summary>
        /// 仓库类型
        /// </summary>
        public int W_type
        {
            get { return w_type; }
            set { w_type = value; }
        }
        private double w_freecapacity;
        /// <summary>
        /// 仓库剩余容量
        /// </summary>
        public double W_freecapacity
        {
            get { return w_freecapacity; }
            set { w_freecapacity = value; }
        }
    }
}
