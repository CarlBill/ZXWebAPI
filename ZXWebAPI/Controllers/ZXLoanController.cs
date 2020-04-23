using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
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
        /// 获取汽车型号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Brand> GetBrands()
        {
            return brand.GetBrands();
        }

        public List<Types> GetTypes(int bid)
        {
            return brand.GetType(bid);
        }

        /// <summary>
        /// 合规审核
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public int UptState(int id)
        {
            return complianceAudit.UptState(id);
        }

        /// <summary>
        /// 用户还款
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public int UpdateState(int id)
        {
            return userReimbursement.UpdateState(id);
        }
    }
}
