namespace BLL
{
    public class ComplianceAudit
    {
        DAL.ComplianceAudit complianceAudit = new DAL.ComplianceAudit();
        /// <summary>
        /// 合规审核
        /// </summary>
        /// <param name="id">对应的用户id</param>
        /// <returns></returns>
        public int UptState(int nuid, int ncid)
        {
            return complianceAudit.UptState(nuid, ncid);
        }
    }
}
