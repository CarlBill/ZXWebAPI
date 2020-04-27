﻿using Model;

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
