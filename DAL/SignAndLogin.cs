using Model;
using PublicClass;

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
            int i=DapperHelper.NonQuery($"select count(1) from Users where Uname= '{name}'", null);
            return i;
        }

        /// <summary>
        /// 手机号判重
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public int Ctel(string tel)
        {
            return DapperHelper.NonQuery($"select count(1) from Users where Utel= '{tel}'", null);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        public int Sign(Users u)
        {
             
                string pwd = EncryptionHelper.Sha1(u.Upwd);//Sha1加密密码
                int i = DapperHelper.NonQuery($"insert into Users values('{u.Uname}','{u.Utname}','{pwd}','{u.Utel}',80,GETDATE())", null);
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
            string sql = $"select COUNT(1) from Users join UserRole on Users.Uid =UserRole.Uid join Roles on  Roles.Rid=UserRole.Rid  where Uname= '{u.Uname}' and Upwd='{pwd}'";
            return DapperHelper.Exists(sql,null);
        }
    }
}
