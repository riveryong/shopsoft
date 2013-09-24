using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using shopsoft.common.DB;
using DevExpress.Data.Filtering;

namespace shopsoft.common.Logic
{
    public class BonusExchangeHistoryLogic
    {
        public XPCollection<t_Bonus_Exchange_History> SearchExchangeHistoryByMemberId(String memberid)
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

            XPCollection<t_Bonus_Exchange_History> exChangeHistory = new XPCollection<t_Bonus_Exchange_History>(theCriteria: groupCriteria);
            return exChangeHistory;

        }
    }
}
