﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace ZXWebAPI.Controllers
{
    public class ZXLoanController : ApiController
    {
        BrandAndTypes brand = new BrandAndTypes();
        SignAndLogin sal = new SignAndLogin();
        ComplianceAudit complianceAudit = new ComplianceAudit();
        UserReimbursement userReimbursement = new UserReimbursement();
        SMSVerificationCode sMSVerificationCode = new SMSVerificationCode();
        UserRoleControlBll bll = new UserRoleControlBll();
        InstrumentTray instrumentTray = new InstrumentTray();


        /// 用户名判重
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPost]
        public int ComName(string name)
        {
            return sal.ComName(name);
        }

        /// <summary>
        /// 手机号判重
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        [HttpPost]
        public int Ctel(string tel)
        {
            return sal.Ctel(tel);
        }


        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPost]
        public int Sign(Users u)
        {
            return sal.Sign(u);
        }

        /// <summary>
        /// 登录+判断角色
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPost]
        public int Login(Users u)
        {
            return sal.Login(u);
        }


        /// <summary>
        /// 获取汽车品牌
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Brand> GetBrands()
        {
            return brand.GetBrands();
        }
        /// <summary>
        /// 获取汽车型号
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        [HttpGet]
        public List<Types> GetTypes(int bid)
        {
            return brand.GetType(bid);
        }

        /// <summary>
        /// 合规审核
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        [HttpPost]
        public int UptState(int nuid, int ncid)
        {
            return complianceAudit.UptState(nuid, ncid);
        }

        /// <summary>
        /// 用户还款
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public int UpdateState(int id)
        {
            return userReimbursement.UpdateState(id);
        }

        /// <summary>
        /// 短信验证码
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <returns></returns>
        [HttpPost]
        public int GetPost(string mobile)
        {
            return sMSVerificationCode.GetPost(mobile);
        }



        /// <summary>
        /// 显示审核员
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetShen()
        {
            return bll.GetShen();
        }

        /// <summary>
        /// 显示客户
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> GetUser()
        {
            return bll.GetUser();
        }

        
        /// <summary>
        /// 取消审核员身份
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        [HttpPost]
        public int CancelShen(int uid)
        {
            return bll.CancelShen(uid);
        }

        /// <summary>
        /// 用户数量
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public int PostUserValue()
        {
            return instrumentTray.PostUserValue();
        }
        /// <summary>
        /// 成交量
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int PostCjCount()
        {
            return instrumentTray.PostCjCount();
        }
        /// <summary>
        /// 成交额
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public int PostCjMoney()
        {
            return instrumentTray.PostCjMoney();
        }


        /// <summary>
        /// 添加审核员
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddShen(Users u)
        {
            return sal.AddShen(u);
        }


        /// <summary>
        /// 绑定等级下拉
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ShenLevel> GetLevel()
        {
            return sal.GetLevel();
        }

        /// <summary>
        /// 找回密码时判断手机号和用户名是否匹配
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPost]
        public int ComTelName(Users u)
        {
            return sal.ComTelName(u);
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="u"></param>
        /// <returns></returns>
        [HttpPost]
        public int UptPwd(Users u)
        {
            return sal.UptPwd(u);
        }


        /// <summary>
        /// 查询审核员
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public List<Users> GetShenSearch(Users u)
        {
            return bll.GetShenSearch(u);
        }

        /// <summary>
        /// 查询客户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public List<Users> GetUserSearch(Users u)
        {
            return bll.GetUserSearch(u);
        }
    }
}
