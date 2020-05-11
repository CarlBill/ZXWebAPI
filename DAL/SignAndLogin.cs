using Model;
using PublicClass;
using System.Collections.Generic;

namespace DAL
{
    public class SignAndLogin
    {

        /// <summary>
        /// 用户名判重
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int ComName(string name)
        {
            int i=DapperHelper.Exists($"select count(1) from Users where Uname= '{name}'", null);
            return i;
        }

        /// <summary>
        /// 手机号判重
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public int Ctel(string tel)
        {
            return DapperHelper.Exists($"select count(1) from Users where Utel= '{tel}'", null);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Sign(Users u)
        {
                string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
                int i = DapperHelper.NonQuery($"insert into Users values('{u.Uname}','{u.Utname}','{pwd}','{u.Utel}',80,GETDATE(),'{null}')", null);
            return i;
        }

        /// <summary>
        /// 添加审核员
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int AddShen(Users u)
        {
            string p = "zx123456";
            string pwd = EncryptionHelper.Sha1(p);//Sha1加密密码
            DapperHelper.NonQuery($"insert into Users values('{u.Uname}','{u.Utname}','{pwd}','{u.Utel}',80,GETDATE(),'{u.Ulevel}')", null);
            int n= DapperHelper.Exists($"select Uid from Users where Uname = '{u.Uname}'", null);
            int a= DapperHelper.NonQuery("update UserRole set Rid= 2 where Uid=" + n, null);
            return a;
        }


        /// <summary>
        /// 登录+判断角色
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Login(Users u)
        {
            string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
            string sql = $"select UserRole.Rid from Users join UserRole on Users.Uid =UserRole.Uid join Roles on  Roles.Rid=UserRole.Rid  where Uname= '{u.Uname}' and Upwd='{pwd}'";
            return DapperHelper.Exists(sql,null);
        }


        /// <summary>
        /// 绑定等级下拉
        /// </summary>
        /// <returns></returns>
        public List<ShenLevel> GetLevel()
        {
            return DapperHelper.Query<ShenLevel>("select  * from slevel", null);
        }

        /// <summary>
        /// 找回密码时判断手机号和用户名是否匹配
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int ComTelName(Users u)
        {
            return DapperHelper.Exists($"select count(1) from Users where Uname='{u.Uname}' and Utel='{u.Utel}'", null);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int UptPwd(Users u)
        {
            string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
            return DapperHelper.NonQuery($"update Users set Upwd= '{pwd}' where Uname='{u.Uname}'", null);
        }
    }
}
