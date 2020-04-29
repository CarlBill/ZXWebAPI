using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InstrumentTray
    {
        DAL.InstrumentTray instrumentTray = new DAL.InstrumentTray();
        /// <summary>
        /// 用户数量
        /// </summary>
        /// <returns></returns>
        public int PostUserValue()
        {
            return instrumentTray.PostUserValue();
        }
        /// <summary>
        /// 成交量
        /// </summary>
        /// <returns></returns>
        public int PostCjCount()
        {
            return instrumentTray.PostCjCount();
        }
        /// <summary>
        /// 成交额
        /// </summary>
        /// <returns></returns>
        public int PostCjMoney()
        {
            return instrumentTray.PostCjMoney();
        }
    }
}
