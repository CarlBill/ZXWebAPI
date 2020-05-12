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
        /// 贷款信息根据审核员名进行过滤显示
        /// </summary>
        /// <returns></returns>

        public List<UVehicleInfo> GetVehicleInfosFilterByName(string name)
        {
            return VehicleDal.GetVehicleInfosFilterByName(name);

        }
        /// <summary>
        /// 贷款信息显示根据待审核进行过滤显示
        /// </summary>
        /// <returns></returns>

        public List<UVehicleInfo> GetVehicleInfosFilterByState()
        {
            return VehicleDal.GetVehicleInfosFilterByState();
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

        /// <summary>
        /// 车辆信息删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelVehicleInfos(string id)
        {
            return VehicleDal.DelVehicleInfos(id);
        }

        /// <summary>
        /// 车辆信息详情
        /// </summary>
        /// <returns></returns>

        public UVehicleInfo GetVehicleInfoById(int cid)
        {
            return VehicleDal.GetVehicleInfoById(cid);
        }

        /// <summary>
        /// 根据品牌名和时间进行查询(我审核的申请)
        /// </summary>
        /// <param name="brangName"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<UVehicleInfo> GetVehicleInfosByBrandOrTime(string name, string brangName = "", string time = "")
        {
            return VehicleDal.GetVehicleInfosByBrandOrTime(name, brangName, time);
        }

        /// <summary>
        /// 根据品牌名和时间进行查询(待审核的申请)
        /// </summary>
        /// <param name="brangName"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<UVehicleInfo> GetVehicleInfosByBrandNameOrTimes(string brangName = "", string time = "")
        {
            return VehicleDal.GetVehicleInfosByBrandNameOrTimes(brangName, time);
        }
    }
}
