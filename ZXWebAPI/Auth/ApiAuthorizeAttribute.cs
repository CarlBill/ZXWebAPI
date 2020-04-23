
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ECommerceApi
{
    public class ApiAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            //在api中使用权限过滤器，过滤请求的请求头中间是否包含key=token,
            //如果包含则验证token的值是否正确（1.token是不是从api中获取的，2.token是否过期）不包含返回失败
            //
            var authHeader = from t in actionContext.Request.Headers where t.Key == "token" select t.Value.FirstOrDefault();
            if (authHeader != null)
            {         
                string token = authHeader.FirstOrDefault();
                if (!string.IsNullOrEmpty(token))
                {    
                    try
                    {
                        const string secret = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4aKpVo2OHXPwb1R7duLgg";
                        //secret需要加密
                        IJsonSerializer serializer = new JsonNetSerializer();
                        IDateTimeProvider provider = new UtcDateTimeProvider();
                        IJwtValidator validator = new JwtValidator(serializer, provider);
                        IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();                                                                                     
                        IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
                        IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);
                        var json = decoder.DecodeToObject<object>(token, secret, verify: true);
                        if (json!=null)
                        {
                            return true;
                        }
                        return false;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
     


    }
}

