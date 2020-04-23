using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Bll
{
    public class UserReimbursement
    {
        DAL.UserReimbursement userReimbursement = new DAL.UserReimbursement();
        /// <summary>
        /// 修改状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptState(int id)
        {
            return userReimbursement.UptState(id);
        }
    }
}
