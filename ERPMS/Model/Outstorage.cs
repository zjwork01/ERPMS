using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 出库
    /// </summary>
    public class Outstorage
    {
        private int o_id;
        /// <summary>
        /// 出库编号
        /// </summary>
        public int O_id
        {
            get { return o_id; }
            set { o_id = value; }
        }
        private int o_material;
        /// <summary>
        /// 出库货物
        /// </summary>
        public int O_material
        {
            get { return o_material; }
            set { o_material = value; }
        }
        private int o_num;
        /// <summary>
        /// 出库数量
        /// </summary>
        public int O_num
        {
            get { return o_num; }
            set { o_num = value; }
        }
        private double o_volume;
        /// <summary>
        /// 出库体积
        /// </summary>
        public double O_volume
        {
            get { return o_volume; }
            set { o_volume = value; }
        }
        private double o_weight;
        /// <summary>
        /// 出库重量
        /// </summary>
        public double O_weight
        {
            get { return o_weight; }
            set { o_weight = value; }
        }
        private int o_staff;
        /// <summary>
        /// 负责人
        /// </summary>
        public int O_staff
        {
            get { return o_staff; }
            set { o_staff = value; }
        }
        private int o_warehouse;
        /// <summary>
        /// 仓库
        /// </summary>
        public int O_warehouse
        {
            get { return o_warehouse; }
            set { o_warehouse = value; }
        }
    }
}
