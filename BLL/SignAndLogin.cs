using Model;
using System.Collections.Generic;

namespace BLL
{
    public class SignAndLogin
    {
        DAL.SignAndLogin SAndL = new DAL.SignAndLogin();

        /// <summary>
        /// 用户名判重
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int ComName(string name)
        {
            return SAndL.ComName(name);
        }

        /// <summary>
        /// 手机号判重
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public int Ctel(string tel)
        {
            return SAndL.Ctel(tel);
        }

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
        /// 登录+判断角色
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Login(Users u)
        {
            return SAndL.Login(u);
        }

        /// <summary>
        /// 添加审核员
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddShen(Users u)
        {
            return SAndL.AddShen(u);
        }

        /// <summary>
        /// 绑定等级下拉
        /// </summary>
        /// <returns></returns>
        public List<ShenLevel> GetLevel()
        {
            return SAndL.GetLevel();
        }
    }
}
