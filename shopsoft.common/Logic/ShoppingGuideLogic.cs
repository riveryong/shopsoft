using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using shopsoft.common.Const;
using shopsoft.common.DB;

namespace shopsoft.common.Logic
{
    public class ShoppingGuideLogic
    {

        #region 查询导购信息列表
        /// <summary>
        /// 获得店铺列表
        /// </summary>
        /// <returns>XPCollection</returns>
        public XPCollection<t_Shopping_Guide> GetGuideList()
        {
            // 拼接查询条件
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", RecordState.Normal, BinaryOperatorType.Equal)
                );
            // 根据条件查询店铺列表
            XPCollection<t_Shopping_Guide> xpGuideList = new XPCollection<t_Shopping_Guide>(theCriteria: groupCriteria);

            // 返回查询结果
            return xpGuideList;
        }
        #endregion

    }
}
