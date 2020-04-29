using Model;
using PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstrumentTray
    {
        /// <summary>
        /// 用户数量
        /// </summary>
        /// <returns></returns>
        public int PostUserValue()
        {
            string sql = " select count(*) from Users";
            return Convert.ToInt32(SqlDbHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 成交量
        /// </summary>
        /// <returns></returns>
        public int PostCjCount()
        {
            string sql = "select count(*) from RepayMent join VehicleInfo on VehicleInfo.Cid=RepayMent.Pcid";
            return Convert.ToInt32(SqlDbHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 成交额
        /// </summary>
        /// <returns></returns>
        public int PostCjMoney()
        {
            string sql = "select Sum(Cbj) from RepayMent join VehicleInfo on VehicleInfo.Cid=RepayMent.Pcid";
            return Convert.ToInt32(SqlDbHelper.ExecuteScalar(sql));
        }

    }
}
