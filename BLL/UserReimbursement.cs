using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserReimbursement
    {
        DAL.UserReimbursement userReimbursement = new DAL.UserReimbursement();
        /// <summary>
        /// 用户还款
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        public int UpdateState(int id)
        {
            return userReimbursement.UpdateState(id);
        }
    }
}
