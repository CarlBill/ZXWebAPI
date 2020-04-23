namespace BLL
{
    public class ComplianceAudit
    {
        DAL.ComplianceAudit complianceAudit = new DAL.ComplianceAudit();
        /// <summary>
        /// 合规审核
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptState(int id)
        {
            return complianceAudit.UptState(id);
        }
    }
}
