using PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserReimbursement
    {
        /// <summary>
        /// 用户还款
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        public int UpdateState(int id)
        {
            string sql = "update VehicleInfo set Czt = 4 where Cuid =" + id;
            return DapperHelper.NonQuery(sql, null);
        }
    }
}
