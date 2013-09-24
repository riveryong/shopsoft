using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using shopsoft.common.DB;

namespace shopsoft.common.Logic
{
    public class MemberLogic
    {
        #region 根据会员编号/会员姓名/会员手机号、会员等级ID，查询会员
        /// <summary>
        /// 根据会员编号/会员姓名/会员手机号、会员等级ID，查询会员
        /// </summary>
        /// <param name="strMemberNo">会员编号/会员姓名/会员手机号</param>
        /// <param name="memberGradeId">会员等级</param>
        /// <param name="dbConn"></param>
        /// <returns></returns>
        public XPCollection<t_Member_Info> SearchMember(string strMemberNo, string memberGradeId)
        {
            string strSql = string.Empty;
            // 查询条件
            // 会员编号/姓名/手机号
            if (!string.IsNullOrEmpty(strMemberNo))
            {
                strSql = String.Format("Member_No like '%{0}%' OR Member_Name like '%{0}%' OR Mobile_No like '%{0}%'", strMemberNo);
            }

            // 会员等级
            if (!string.IsNullOrEmpty(memberGradeId))
            {
                if (!string.IsNullOrEmpty(strSql))
                {
                    strSql += " And ";
                }
                strSql += String.Format("Member_Grade_ID = '{0}'", memberGradeId);
            }
            if (!string.IsNullOrEmpty(strSql))
            {
                strSql += "And State = '0'";
            }

            XPCollection<t_Member_Info> collection = new XPCollection<t_Member_Info>(CriteriaOperator.Parse(strSql));

            return collection;

        }
        #endregion


        #region 判断会员编号是否存在
        /// <summary>
        /// 判断会员编号是否存在
        /// </summary>
        /// <param name="memberNo">会员编号</param>
        /// <returns>存在;true；不存在;false</returns>
        public bool IsExistMember(string memberNo)
        {
            bool result = false;

            if (string.IsNullOrEmpty(memberNo))
            {
                return result;
            }

            // 查询条件
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Member_No", memberNo, BinaryOperatorType.Equal)
            );

            t_Member_Info memberInfo = Session.DefaultSession.FindObject<t_Member_Info>(groupCriteria);

            if (memberInfo != null)
            {
                result = true;
            }

            return result;
        }
        #endregion

        #region 根据会员ID取得会员信息
        /// <summary>
        /// 根据会员ID取得会员信息
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public t_Member_Info GetMemberInfoByMemberID(string MemberID,Session DBSession)
        {
            if (string.IsNullOrEmpty(MemberID))
            {
                return null;
            }

            // 查询条件：会员ID，数据状态正常
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Member_ID", MemberID, BinaryOperatorType.Equal)
            );

            t_Member_Info memberInfo = DBSession.FindObject<t_Member_Info>(groupCriteria);

            return memberInfo;

        }
        #endregion

        #region 根据会员编号取得会员信息
        /// <summary>
        /// 根据会员编号取得会员信息
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public t_Member_Info GetMemberInfoByMemberNo(string MemberNo, Session DBSession)
        {
            if (string.IsNullOrEmpty(MemberNo))
            {
                return null;
            }

            // 查询条件：会员ID，数据状态正常
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Member_NO", MemberNo, BinaryOperatorType.Equal)
            );

            t_Member_Info memberInfo = DBSession.FindObject<t_Member_Info>(groupCriteria);

            return memberInfo;

        }
        #endregion


    }
}
