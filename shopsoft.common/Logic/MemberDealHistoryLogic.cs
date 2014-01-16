using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shopsoft.common.DB;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

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

        #region 根据条件查询会员消费记录
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
            string strSql = "1=1";
            // 查询条件
            // 会员编号/姓名/手机号
            if (!string.IsNullOrEmpty(memberId))
            {
                strSql = String.Format(" And (Member_No like '%{0}%' OR Member_Name like '%{0}%') ", memberId);
            }

            // 会员等级
            if (consumeType >= 0)
            {

                strSql += String.Format(" And Member_Grade_ID = '{0}' ", consumeType);
            }

            // 消费时间
            if (null != timeStart && DateTime.MinValue != timeStart)
            {
                strSql += string.Format(" And Deal_DateTime  >= '{0}' ", timeStart); 
            }

            if (null != timeEnd && DateTime.MinValue != timeEnd)
            {
                strSql += string.Format(" And Deal_DateTime  <= '{0}' ", timeEnd);
            }

            if (!string.IsNullOrEmpty(strSql))
            {
                strSql += "And State = '0'";
            }

            XPCollection<t_Member_Deal_History> collection = new XPCollection<t_Member_Deal_History>(CriteriaOperator.Parse(strSql));

            return collection;

        }
        #endregion

        #region 根据条件统计会员消费
        /// <summary>
        /// 根据条件统计会员消费数据
        /// </summary>
        /// <param name="memberId">会员编号或会员姓名</param>
        /// <param name="payType">消费类型</param>
        /// <param name="timeStart">统计时间开始</param>
        /// <param name="timeEnd">统计时间结束</param>
        /// <returns></returns>
        public DataTable statDealHistory(string memberId, int payType, DateTime timeStart, DateTime timeEnd)
        {
            Database db = DBHelper.getDataBase();
            DataSet dsResult = new DataSet();
            DataTable dt = new DataTable();
            // 分类汇总sql语句
            /*SELECT Member_ID, Member_No, 
               SUM(ShouDao_cash) AS sumDealCash,
               SUM(KouChu_Deal_Time) AS sumDealTime, 
               SUM(Get_Bonus) AS sumBonus, 
               count(*) AS sumDeal
                FROM t_Member_Deal_History
                WHERE Member_No like '%1% '
                GROUP BY Member_ID, Member_No
                ORDER BY SUM(ShouDao_cash);*/
            string strSql = "SELECT Member_ID, Member_No, Pay_Type, ";
            strSql += " SUM(ShouDao_cash) AS sumDealCash,";
            strSql += " SUM(KouChu_Deal_Time) AS sumDealTime,";
            strSql += " SUM(Get_Bonus) AS sumBonus,";
            strSql += " count(Deal_History_ID) AS sumDeal ";
            strSql += "FROM t_Member_Deal_Hisory ";
            strSql += "WHERE 1=1 ";
            if (!String.IsNullOrEmpty(memberId))
            {
                strSql += String.Format(" and Member_No like '%{0}% '", memberId);
            }
            if (null == payType || 0 == payType || 1 == payType)
            {
                strSql += String.Format(" and Pay_Type="+payType);
            }
            if (null == timeStart)
            {
                strSql += String.Format(" and Deal_DateTime >= "+ timeStart.ToString());
            }
            if (null == timeEnd)
            {
                strSql += String.Format(" and Deal_DateTime <= " + timeEnd.ToString());
            }

            strSql += " GROUP BY Member_ID, Member_No  ORDER BY sumDealCash;";

            using (DbCommand dbCommand = db.GetSqlStringCommand(strSql))
            {
                dsResult = db.ExecuteDataSet(dbCommand);
                if (dsResult != null && 
                    dsResult.Tables.Count > 0 && 
                    dsResult.Tables[0].Rows.Count > 0)
                {
                    dt = dsResult.Tables[0]; 
                }                
            }
            
            return dt;

        }

        #endregion
    }
}
