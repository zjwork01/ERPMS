using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 入库
    /// </summary>
    public class Instorage
    {
        private int i_id;
        /// <summary>
        /// 入库编号
        /// </summary>
        public int I_id
        {
            get { return i_id; }
            set { i_id = value; }
        }
        private int i_material;
        /// <summary>
        /// 入库材料
        /// </summary>
        public int I_material
        {
            get { return i_material; }
            set { i_material = value; }
        }
        private int i_num;
        /// <summary>
        /// 入库数量
        /// </summary>
        public int I_num
        {
            get { return i_num; }
            set { i_num = value; }
        }
        private double i_volume;
        /// <summary>
        /// 入库体积
        /// </summary>
        public double I_volume
        {
            get { return i_volume; }
            set { i_volume = value; }
        }
        private double i_weight;
        /// <summary>
        /// 入库重量
        /// </summary>
        public double I_weight
        {
            get { return i_weight; }
            set { i_weight = value; }
        }
        private int i_satff;
        /// <summary>
        /// 负责人
        /// </summary>
        public int I_satff
        {
            get { return i_satff; }
            set { i_satff = value; }
        }
        private int i_warehouse;
        /// <summary>
        /// 仓库编号
        /// </summary>
        public int I_warehouse
        {
            get { return i_warehouse; }
            set { i_warehouse = value; }
        }
    }
}
