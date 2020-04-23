using Model;
using System.Collections.Generic;

namespace BLL
{
    public class BrandAndTypes
    {
        DAL.BrandAndTypes BandT = new DAL.BrandAndTypes();
        /// <summary>
        /// 查询车辆品牌信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrands()
        {
            return BandT.GetBrands();
        }

        /// <summary>
        /// 查询车辆型号信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Types> GetType(int bid)
        {
            return BandT.GetType(bid);
        }
    }
}
