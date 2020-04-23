using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SMS_Alerts
    {
        DAL.YMethod yMethod = new DAL.YMethod();
        public string GetPostUrl(string smsMob, string smsText)
        {
            return yMethod.GetPostUrl(smsMob, smsText);
        }

        /// <summary> 发送短信，得到返回值</summary>
        public string PostSmsInfo(string url)
        {
            return yMethod.PostSmsInfo(url);
        }

        /// <summary>确认返回信息 </summary>
        public string GetResult(string strRet)
        {
            return yMethod.GetResult(strRet);
        }
    }
}
