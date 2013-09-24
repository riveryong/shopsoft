using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shopsoft.common.DB;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace shopsoft.common.Logic
{
    public class ProductInfoLogic
    {
        public XPCollection<t_Product_Info> SearchProductList()
        {
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal)
            );

            XPCollection<t_Product_Info> res = new XPCollection<t_Product_Info>(theCriteria: groupCriteria);

            return res;
        }
    }
}
