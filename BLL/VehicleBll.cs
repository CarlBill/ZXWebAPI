using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class VehicleBll
    {
        VehicleDal VehicleDal = new VehicleDal();

        /// <summary>
        /// 车辆信息显示
        /// </summary>
        /// <returns></returns>
        public List<UVehicleInfo> GetVehicleInfos()
        {
            return VehicleDal.GetVehicleInfos();
        }

        /// <summary>
        /// 车辆信息添加
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int VechcleAdd(VehicleInfo vehicle)
        {
            return VehicleDal.VechcleAdd(vehicle);
        }
    }
}
