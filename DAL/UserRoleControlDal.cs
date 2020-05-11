using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PublicClass;

namespace DAL
{
    public class UserRoleControlDal
    {
        /// <summary>
        /// 显示审核员
        /// </summary>
        /// <returns></returns>
        public List<Users> GetShen()
        {
            return DapperHelper.Query<Users>($"select * from GetShen", null);
        }

        /// <summary>
        /// 显示客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUser()
        {
            return DapperHelper.Query<Users>($"select * from GetUser", null);
        }


        /// <summary>
        /// 查询审核员
        /// </summary>
        /// <returns></returns>
        public List<Users> GetShenSearch(Users u)
        {
            return DapperHelper.Query<Users>($"select * from GetShen where Uname like '%{u.Uname}%' and Utname like '%{u.Utname}%'", null);
        }

        /// <summary>
        /// 查询客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUserSearch(Users u)
        {
            return DapperHelper.Query<Users>($"select * from GetUser  where Uname like '%{u.Uname}%' and Utname like '%{u.Utname}%'", null);
        }

        /// <summary>
        /// 取消审核员身份
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public int CancelShen(int uid)
        {
            return DapperHelper.NonQuery("update UserRole set Rid= 3 where Uid="+uid,null);
        }
    }
}
