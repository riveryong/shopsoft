using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shopsoft.common.DB;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace shopsoft.common.Logic
{
    public class MemberDealHistoryLogic
    {
        #region 根据会员ID检索会员消费记录
        /// <summary>
        /// 根据会员ID检索会员消费记录
        /// </summary>
        /// <param name="memberid"></param>
        /// <returns></returns>
        public XPCollection<t_Member_Deal_History> SearchDealHistoryByMemberId(String memberid)
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

            XPCollection<t_Member_Deal_History> dealHistory = new XPCollection<t_Member_Deal_History>(theCriteria: groupCriteria);
            return dealHistory;

        }

        #endregion

        /// <summary>
        /// 根据条件查询会员消费记录
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="consumeType"></param>
        /// <param name="timeStart"></param>
        /// <param name="timeEnd"></param>
        /// <returns></returns>
        public XPCollection<t_Member_Deal_History> SearchDealHistoryList(string memberId, int consumeType, DateTime timeStart, DateTime timeEnd)
        {
            string strSql = string.Empty;
            // 查询条件
            // 会员编号/姓名/手机号
            if (!string.IsNullOrEmpty(memberId))
            {
                strSql = String.Format("(Member_No like '%{0}%' OR Member_Name like '%{0}%') ", memberId);
            }

            // 会员等级
            if (consumeType >= 0)
            {
                if (!string.IsNullOrEmpty(strSql))
                {
                    strSql += " And ";
                }
                strSql += String.Format("Member_Grade_ID = '{0}'", consumeType);
            }

            // 消费时间
            if (null != timeStart && DateTime.MinValue != timeStart)
            {
                if (!string.IsNullOrEmpty(strSql))
                {
                    strSql += " And ";
                }
                strSql += string.Format("Deal_DateTime  >= '{0}'", timeStart); 
            }

            if (null != timeEnd && DateTime.MinValue != timeEnd)
            {
                if (!string.IsNullOrEmpty(strSql))
                {
                    strSql += " And ";
                }
                strSql += string.Format("Deal_DateTime  <= '{0}'", timeEnd);
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                strSql += "And State = '0'";
            }

            XPCollection<t_Member_Deal_History> collection = new XPCollection<t_Member_Deal_History>(CriteriaOperator.Parse(strSql));

            return collection;

        }
    }
}
