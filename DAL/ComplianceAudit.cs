using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PublicClass;

namespace DAL
{
    public class ComplianceAudit
    {
        /// <summary>
        /// 合规审核
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        public int UptState(int nuid, int ncid)
        {
            string sql = $"update VehicleInfo set Czt = 2 where Cuid ={nuid} and Cid = {ncid}";
            return DapperHelper.NonQuery(sql, null);
        }
    }
}
