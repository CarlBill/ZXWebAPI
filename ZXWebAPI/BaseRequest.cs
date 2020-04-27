using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXWebAPI
{
    /// <summary>
    /// 请求的基类消息
    /// 表示，你要调用的我的接口，你就得吧这些传给我
    /// </summary>
    public  class BaseRequest
    {
        /// <summary>
        /// token参数，做验证用
        /// </summary>
        public string Token { get; set; }
        /// <summary>
        /// apiurl
        /// </summary>
        /// <returns></returns>
        public virtual string GetApiName()
        {
            return "";
        }
    }
}
