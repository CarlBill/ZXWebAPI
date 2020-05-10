using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UVehicleInfo
    {
        public int Bid { get; set; }
        public string Bname { get; set; }
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
        public int Rid { get; set; }

        public string Rname { get; set; }
        public int Tid { get; set; }
        public string Tname { get; set; }
        public int Tprice { get; set; }
        public int Tbid { get; set; }
        public int Id { get; set; }
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Utname { get; set; }
        public string Upwd { get; set; }
        public string Utel { get; set; }
        public int Uxy { get; set; }
        public DateTime Utime { get; set; }
        public int Cid { get; set; }
        public string Cimg { get; set; }
        public int Cuid { get; set; }
        public int Cbrand { get; set; }
        public int Ctype { get; set; }
        public string Cvin { get; set; }
        public string Cyear { get; set; }
        public int Ckm { get; set; }
        public bool Csf { get; set; }
        public DateTime Ctime { get; set; }
        public int Czt { get; set; }
        public int Cqx { get; set; }
        public int Cbj { get; set; }
        public int Sid { get; set; }
        public string Sname { get; set; }
    }
}
