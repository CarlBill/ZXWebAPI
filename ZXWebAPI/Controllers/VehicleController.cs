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

        /// <summary>
        /// 车辆信息删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public int DelVehicleInfos(string id)
        {
            return VehicleBll.DelVehicleInfos(id);
        }

        /// <summary>
        /// 车辆信息详情
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]

        public UVehicleInfo GetVehicleInfoById(int cid)
        {
            return VehicleBll.GetVehicleInfoById(cid);
        }
    }
}
