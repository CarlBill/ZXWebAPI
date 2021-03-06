﻿using System;
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
        /// 贷款信息根据审核员名进行过滤显示
        /// </summary>
        /// <returns></returns>

        public List<UVehicleInfo> GetVehicleInfosFilterByName(string name)
        {
            return DapperHelper.Query<UVehicleInfo>($"select * from VehicleInfo join Users on Uid=Cuid join RepayMent on Cid=Pcid  and Puid=Users.Uid join Brand on Bid=Cbrand join Type on Tid =Ctype where Uname = '{name}' and Czt = 2", null);
        }

        /// <summary>
        /// 贷款信息显示根据未审核进行过滤显示
        /// </summary>
        /// <returns></returns>

        public List<UVehicleInfo> GetVehicleInfosFilterByState()
        {
            return DapperHelper.Query<UVehicleInfo>($"select * from VehicleInfo join Users on Uid=Cuid join RepayMent on Cid=Pcid  and Puid=Users.Uid join Brand on Bid=Cbrand join Type on Tid =Ctype where Czt = 1", null);
        }

        /// <summary>
        /// 车辆信息提交并申请贷款
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns></returns>
        public int VechcleAdd(VehicleInfo vehicle)
        {
            return DapperHelper.NonQuery<VehicleInfo>($"Insert into VehicleInfo(Cid,Cimg,Cuid,Cbrand,Ctype,Cvin,Cyear,Ckm,Csf,Ctime,Czt,Cqx,Cbj) values('{vehicle.Cid}','{vehicle.Cimg}','{vehicle.Cuid}','{vehicle.Cbrand}','{vehicle.Ctype}','{vehicle.Cvin}','{vehicle.Cyear}','{vehicle.Ckm}','{vehicle.Csf}','{DateTime.Now}',1,'{vehicle.Cqx}','{vehicle.Cbj}')", null);
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

        /// <summary>
        /// 根据品牌名和时间进行查询(我审核的申请)
        /// </summary>
        /// <param name="brangName"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<UVehicleInfo> GetVehicleInfosByBrandOrTime(string name, string brangName = "", string time = "")
        {
            string sql = $"select *,SUBSTRING(CONVERT(CHAR(19), Ctime, 120),1,10)as newTime from VehicleInfo join Users on Uid=Cuid join RepayMent on Cid=Pcid  and Puid=Users.Uid join Brand on Bid=Cbrand join Type on Tid =Ctype where Uname = '{name}' and Czt = 2 ";
            if (!string.IsNullOrWhiteSpace(brangName))
            {
                sql += $"and Bname like '%{brangName}%' ";
            }
            if (!string.IsNullOrWhiteSpace(time))
            {
                sql += $"and (select SUBSTRING(CONVERT(CHAR(19), Ctime, 120),1,10)) = '{time}'";
            }
            return DapperHelper.Query<UVehicleInfo>(sql, null);
        }

        /// <summary>
        /// 根据品牌名和时间进行查询(待审核的申请)
        /// </summary>
        /// <param name="brangName"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public List<UVehicleInfo> GetVehicleInfosByBrandNameOrTimes(string brangName = "", string time = "")
        {
            string sql = "select *,SUBSTRING(CONVERT(CHAR(19), Ctime, 120),1,10)as newTime from VehicleInfo join Users on Uid=Cuid join RepayMent on Cid=Pcid  and Puid=Users.Uid join Brand on Bid=Cbrand join Type on Tid =Ctype where Czt = 1 ";
            if (!string.IsNullOrWhiteSpace(brangName))
            {
                sql += $"and Bname like '%{brangName}%' ";
            }
            if (!string.IsNullOrWhiteSpace(time))
            {
                sql += $"and (select SUBSTRING(CONVERT(CHAR(19), Ctime, 120),1,10)) = '{time}'";
            }
            return DapperHelper.Query<UVehicleInfo>(sql, null);
        }
    }
}
