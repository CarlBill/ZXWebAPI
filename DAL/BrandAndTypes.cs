using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PublicClass;

namespace DAL
{
    public class BrandAndTypes
    {
        /// <summary>
        /// 查询车辆品牌信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Brand> GetBrands()
        {
            return DapperHelper.Query<Brand>("select * from Brand", null);
        }

        /// <summary>
        /// 查询车辆型号信息用于绑定下拉
        /// </summary>
        /// <returns></returns>
        public List<Types> GetType(int bid)
        {
            return DapperHelper.Query<Types>($"select * from Type where Tbid={bid}", null);
        }
    }
}
