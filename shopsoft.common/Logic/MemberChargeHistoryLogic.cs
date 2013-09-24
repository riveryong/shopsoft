using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using shopsoft.common.DB;

namespace shopsoft.common.Logic
{
    public class MemberChargeHistoryLogic
    {

        #region 根据会员ID检索会员充值记录
        /// <summary>
        /// 根据会员ID检索会员充值记录
        /// </summary>
        /// <param name="memberid"></param>
        /// <returns></returns>
        public XPCollection<t_Member_Charge_History> SearchChargeHistoryByMemberId(String memberid)
        {
            if (string.IsNullOrEmpty(memberid))
            {
                return null;
            }

            // 查询条件：会员ID，数据状态正常
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Member_ID", memberid, BinaryOperatorType.Equal)
            );

            XPCollection<t_Member_Charge_History> chgHistory = new XPCollection<t_Member_Charge_History>(theCriteria: groupCriteria);
            return chgHistory;

        }
        #endregion


       


    }
}
