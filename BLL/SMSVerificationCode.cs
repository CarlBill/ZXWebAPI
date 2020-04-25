using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SMSVerificationCode
    {
        DAL.SMSVerificationCode sMSVerificationCode = new DAL.SMSVerificationCode();
        /// <summary>
        /// 短信验证码
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <returns></returns>
        public int GetPost(string mobile)
        {
            return sMSVerificationCode.GetPost(mobile);
        }
    }
}
