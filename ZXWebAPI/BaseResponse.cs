using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZXWebAPI
{
    public class BaseResponseT<T>
    {
        #region 表示请求相关的
        /// <summary>
        /// 状态
        /// 表示请求状态
        /// 默认为1 表示正常
        /// 为-1时 表示错误
        /// </summary>
        public int Status = 1;
        /// <summary>
        /// 消息
        /// 指的时返回的一些消息消息 当状态-1 时显示此消息
        /// </summary>
        public string Msg { get; set; }
        #endregion
        #region 业务相关的返回
        /// <summary>
        /// 一种状态返回
        /// 比如 ，添加是否成功，删除是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        ///返回一条数据 比如说查询一条消息
        /// </summary>
        public T Info { get; set; }
        /// <summary>
        /// 返回一个集合 比如下课绑定
        /// </summary>
        public List<T> DateList { get; set; }
        #endregion

    }
    public class BaseResponse
    {
        #region 表示请求相关的
        /// <summary>
        /// 状态
        /// 表示请求状态
        /// 默认为1 表示正常
        /// 为-1时 表示错误
        /// </summary>
        public int Status = 1;
        /// <summary>
        /// 消息
        /// 指的时返回的一些消息消息 当状态-1 时显示此消息
        /// </summary>
        public string Msg { get; set; }
        #endregion
        #region 业务相关的返回
        /// <summary>
        /// 一种状态返回
        /// 比如 ，添加是否成功，删除是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        #endregion
    }
}
