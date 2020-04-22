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
    }
}
