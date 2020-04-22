using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PublicClass;

namespace DAL
{
    public class SignAndLogin
    {
        /// <summary>
        /// 注册(判断用户名和手机号是否注册过)
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Sign(Users u)
        {
            int i = 0;
            if (DapperHelper.NonQuery($"select count(1) from Users where Uname= '{u.Uname}'", null) > 0)
            {
                i += 3;
            }
            if (DapperHelper.NonQuery($"select count(1) from Users where Utel= '{u.Utel}'", null) > 0)
            {
                i+= 5;
            }
            if (i<0)
            {
                string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
                i = DapperHelper.NonQuery($"insert into Users values('{u.Uname}','{u.Utname}','{pwd}','{u.Utel}',80,GETDATE())", null);
            }
            return i;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Login(Users u)
        {
            string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
            return DapperHelper.NonQuery($"select count(1) from Users where Uname= '{u.Uname}' and Upwd='{pwd}'", null);
        }

        /// <summary>
        /// 查询车辆品牌信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrands()
        {
            return DapperHelper.Query<Brand>("select * from Brand", null);
        }

        /// <summary>
        /// 查询车辆型号信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrands(int bid)
        {
            return DapperHelper.Query<Brand>($"select * from Type where Tbid={bid}", null);
        }

    }
}
