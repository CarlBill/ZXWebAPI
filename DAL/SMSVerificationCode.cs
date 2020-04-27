using Model;
using PublicClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Web.ModelBinding;

namespace DAL
{
    public class SMSVerificationCode
    {

        public static string PostUrl = ConfigurationManager.AppSettings["WebReference.Service.PostUrl"];

        public int yzCode { get; set; }
        public string yzPhone { get; set; }
        /// <summary>
        /// 给手机号码发送验证短信
        /// </summary>
        /// <param name="mobile">待发送的手机号码</param>
        /// <param name="mobile_code">发送的验证码</param>
        /// <returns></returns>
        /// 
        public int GetPost(string mobile)
        {
            string account = "C96381815";//用户名是登录用户中心->验证码、通知短信->帐户及签名设置->APIID//C0628409
            string password = "edd490792d2e6329c15e0ee894b70d04"; //密码是请登录用户中心->验证码、通知短信->帐户及签名设置->APIKEY
            Random rad = new Random();
            int mobile_code = rad.Next(100000, 1000000);

            //定义发送至手机中显示的信息
            string content = "您的验证码是：" + mobile_code + " 。请不要把验证码泄露给其他人。";
            string postStrTpl = "account={0}&password={1}&mobile={2}&content={3}";

            UTF8Encoding encoding = new UTF8Encoding();
            byte[] postData = encoding.GetBytes(string.Format(postStrTpl, account, password, mobile, content));

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(PostUrl);
            myRequest.Method = "POST";
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.ContentLength = postData.Length;

            Stream newStream = myRequest.GetRequestStream();

            newStream.Write(postData, 0, postData.Length);
            newStream.Flush();
            newStream.Close();

            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            if (myResponse.StatusCode == HttpStatusCode.OK)
            {
                return mobile_code;
            }
            else
            {
                return -1;
            }
        }
    }
}
