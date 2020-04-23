using BLL;
using Model;
using System.Collections.Generic;
using System.Web.Http;

namespace ZXWebAPI.Controllers
{
    public class ZXLoanController : ApiController
    {

        BrandAndTypes brand = new BrandAndTypes();
        SignAndLogin sal = new SignAndLogin();

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
        /// 获取汽车型号
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Brand> GetBrands()
        {
            return brand.GetBrands();
        }

        [HttpGet]
        public List<Types> GetTypes(int bid)
        {
            return brand.GetType(bid);
        }
    }
}
