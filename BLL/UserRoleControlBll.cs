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
        public List<Users> GetShen()
        {
            return dal.GetShen();
        }

        /// <summary>
        /// 显示客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUser()
        {
            return dal.GetUser();
        }

        /// <summary>
        /// 查询审核员
        /// </summary>
        /// <returns></returns>
        public List<Users> GetShenSearch(Users u)
        {
            return dal.GetShenSearch(u);
        }

        /// <summary>
        /// 查询客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUserSearch(Users u)
        {
            return dal.GetUserSearch(u);
        }

        /// <summary>
        /// 取消审核员身份
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public int CancelShen(int uid)
        {
            return dal.CancelShen(uid);
        }
    }
}
