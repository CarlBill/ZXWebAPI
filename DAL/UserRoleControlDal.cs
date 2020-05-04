﻿using System;
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
        public List<Users> GetShen(string name,string tname)
        {
            return DapperHelper.Query<Users>($"select * from GetShen where Uname like '%{name}%' and Utname like '%{tname}%'", null);
        }

        /// <summary>
        /// 显示客户
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUser(string name, string tname)
        {
            return DapperHelper.Query<Users>($"select * from GetUser  where Uname like '%{name}%' and Utname like '%{tname}%'", null);
        }
    }
}