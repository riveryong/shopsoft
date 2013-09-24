using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using shopsoft.common.DB;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace shopsoft.common.Logic
{
    public class ConsumeContentLogic
    {
        #region 检索消费备注项目列表
        /// <summary>
        /// 检索消费备注项目列表
        /// </summary>
        /// <returns></returns>
        public XPCollection<t_Consume_Content> SearchConsumItems()
        {
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal)
            );

            XPCollection<t_Consume_Content> res = new XPCollection<t_Consume_Content>(theCriteria: groupCriteria);
            return res;
        }
        #endregion

        #region 根据ID查询消费项目
        /// <summary>
        /// 根据ID查询消费项目
        /// </summary>
        /// <param name="ContentID"></param>
        /// <param name="DBSession"></param>
        /// <returns></returns>
        public t_Consume_Content GetContentByID(string ContentID, Session DBSession)
        {
            if (string.IsNullOrEmpty(ContentID))
            {
                return null;
            }

            // 查询条件
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Content_ID", ContentID, BinaryOperatorType.Equal)
            );

            return DBSession.FindObject<t_Consume_Content>(groupCriteria);
 
        }
        #endregion

        #region 检查消费备注是否已存在
        /// <summary>
        /// 检查消费备注是否已存在
        /// </summary>
        /// <param name="content">消费项目</param>
        /// <returns>存在;true；不存在;false</returns>
        public bool IsExitConsumeContent(string content)
        {
            bool res = false;

            // 查询条件
            GroupOperator groupCriteria = new GroupOperator(
                GroupOperatorType.And,
                new BinaryOperator("State", 0, BinaryOperatorType.Equal),
                new BinaryOperator("Content", content, BinaryOperatorType.Equal)
            );

            t_Consume_Content cc = Session.DefaultSession.FindObject<t_Consume_Content>(groupCriteria);

            if (cc != null)
            {
                res = true;
            }

            return res;
        }
        #endregion
    }
}
