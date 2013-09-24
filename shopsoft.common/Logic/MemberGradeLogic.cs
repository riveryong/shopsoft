using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using shopsoft.common.DB;

namespace shopsoft.common.Logic
{
    public class MemberGradeLogic
    {
        /// <summary>
        /// 取得会员等级列表
        /// </summary>
        /// <returns></returns>
        public XPCollection<t_Member_Grade> GetMemberGradeList()
        {
            XPCollection<t_Member_Grade> gradeList = new XPCollection<t_Member_Grade>();
            return gradeList;
        }

        /// <summary>
        /// 根据会员等级ID取得会员等级信息
        /// </summary>
        /// <returns></returns>
        public t_Member_Grade GetMemberGradeByID(int gradeId)
        {
            if (gradeId == 0)
            {
                return null;
            }

            // 查询条件
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Member_Grade_ID", gradeId, BinaryOperatorType.Equal)
            );

            t_Member_Grade gradeInfo = Session.DefaultSession.FindObject<t_Member_Grade>(groupCriteria);
            return gradeInfo;
        }
    }
}
