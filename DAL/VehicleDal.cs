using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using PublicClass;
namespace DAL
{
    public class VehicleDal
    {
        /// <summary>
        /// 车辆信息显示
        /// </summary>
        /// <returns></returns>

        public List<UVehicleInfo> GetVehicleInfos()
        {
            return DapperHelper.Query<UVehicleInfo>("select * from VehicleInfo join Users on Uid=Cuid join RepayMent on Cid=Pcid  and Puid=Users.Uid join Brand on Bid=Cbrand join Type on Tid =Ctype", null);
        }

        /// <summary>
        /// 车辆信息添加
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int VechcleAdd(VehicleInfo vehicle)
        {
            return DapperHelper.NonQuery<VehicleInfo>($"Insert into VehicleInfo(Cid,Cimg,Cuid,Cbrand,Ctype,Cvin,Cyear,Ckm,Csf,Ctime,Czt,Cqx,Cbj) values('{vehicle.Cid}','{vehicle.Cimg}','{vehicle.Cuid}','{vehicle.Cbrand}','{vehicle.Ctype}','{vehicle.Cvin}','{vehicle.Cyear}','{vehicle.Ckm}','{vehicle.Csf}','{vehicle.Ctime}','{vehicle.Czt}','{vehicle.Cqx}','{vehicle.Cbj}')", null);
        }

        /// <summary>
        /// 车辆信息删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelVehicleInfos(string id)
        {
            return DapperHelper.NonQuery($"delete from VehicleInfo where Cid in ({id})", null);
        }

        /// <summary>
        /// 车辆信息详情
        /// </summary>
        /// <returns></returns>

        public UVehicleInfo GetVehicleInfoById(int cid)
        {
            return DapperHelper.Query<UVehicleInfo>($"select * from VehicleInfo join Users on Uid = Cuid join RepayMent on Cid = Pcid  and Puid = Users.Uid join Brand on Bid = Cbrand join Type on Tid = Ctype where Cid ={ cid}", null).FirstOrDefault();
        }
    }
}
