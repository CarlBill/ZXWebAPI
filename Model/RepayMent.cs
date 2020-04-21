using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 还款表
    /// </summary>
    public class RepayMent
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 自动生成的一个编号
        /// </summary>
        public string Pbh { get; set; }
        /// <summary>
        /// 车辆信息编号
        /// </summary>
        public int Pcid { get; set; }
        /// <summary>
        /// 审核员编号
        /// </summary>
        public int Puid { get; set; }
        /// <summary>
        /// 审核通过时间
        /// </summary>
        public DateTime Ptime { get; set; }
        /// <summary>
        /// 规定还款时间
        /// </summary>
        public DateTime Pgtime { get; set; }
        /// <summary>
        /// 还款的时间
        /// </summary>
        public DateTime Phtime { get; set; }

    }
}
