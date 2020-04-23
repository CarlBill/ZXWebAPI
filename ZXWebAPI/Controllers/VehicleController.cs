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
    public class VehicleController : ApiController
    {
        VehicleBll VehicleBll = new VehicleBll();

        /// <summary>
        /// 车辆显示信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<UVehicleInfo> GetVehicleInfos()
        {
            return VehicleBll.GetVehicleInfos();
        }

        /// <summary>
        /// 车辆信息添加
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        [HttpPost]
        public int VechcleAdd(VehicleInfo vehicle)
        {
            return VehicleBll.VechcleAdd(vehicle);
        }
    }
}
