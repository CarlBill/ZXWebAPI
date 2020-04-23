using System;
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
        /// 登录
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
        public int UptState(int id)
        {
            return complianceAudit.UptState(id);
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
    }
}
