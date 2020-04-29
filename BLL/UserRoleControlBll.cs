using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserRoleControlBll
    {
        UserRoleControlDal dal = new UserRoleControlDal();

        /// <summary>
        /// 显示审核员
        /// </summary>
        /// <returns></returns>
        public List<Users> GetShen(string name, string tname)
        {
            return dal.GetShen(name,tname);
        }

        /// <summary>
        /// 显示客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUser(string name, string tname)
        {
            return dal.GetUser(name,tname);
        }
    }
}
