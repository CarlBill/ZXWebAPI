using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class SignAndLogin
    {
        DAL.SignAndLogin SAndL = new DAL.SignAndLogin();
        /// <summary>
        /// 注册(判断用户名和手机号是否注册过)
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Sign(Users u)
        {
            return SAndL.Sign(u);
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Login(Users u)
        {
            return SAndL.Login(u);
        }
    }
}
