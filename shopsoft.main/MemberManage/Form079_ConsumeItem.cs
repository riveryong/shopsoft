using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using shopsoft.common.DB;
using shopsoft.common.Logic;
using shopsoft.common.Const;
using shopsoft.common;

namespace shopsoft.main.MemberManage
{
    public partial class Form079_ConsumeItem : BaseForm
    {
        private ConsumeContentLogic consumLogic = new ConsumeContentLogic();

        // 操作类型：1：新增消费项目；2：修改消费项目
        private int op = 0;
        // 消费项目ID
        private string cID;
        private t_Consume_Content tcc;

        #region 页面初始化
        //public Form079_ConsumeItem()
        //{
        //    InitializeComponent();
        //}
        
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="contentID">消费备注ID</param>
        /// <param name="opFlg">操作类型 1：新增；2：修改</param>
        public Form079_ConsumeItem(String contentID,int opFlg)
        {
            InitializeComponent();
            if(opFlg == 1)
            {
                this.op = opFlg;
                this.cID = contentID;
                this.Text = "增加消费项目";
            }
            else if (opFlg == 2)
            {
                this.Text = "修改消费项目";
                this.btnSave.Text = "修改";
                if (String.IsNullOrEmpty(contentID))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Close();
                }
                this.op = opFlg;
                this.cID = contentID;
                this.textItem.Text = contentID;
            }
            
        }

        //页面Load
        private void Form079_ConsumeItem_Load(object sender, EventArgs e)
        {
            if (this.op == 2)
            {
                this.tcc = consumLogic.GetContentByID(this.cID, this.DBSession);
                if (tcc == null)
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Close();
                    return;
                }
            }
        }
        #endregion

        #region 保存按钮点击事件
        /// <summary>
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 输入内容检查
            if (!CheckCondition())
            {
                return;
            }

            if (this.op == 2)// 修改消费备注
            {
                if (this.tcc == null)
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Dispose();
                    this.Close();
                    return;
                }
            }
            else // 新增消费备注
            {
                this.tcc = new t_Consume_Content();
            }

            // 消费备注
            tcc.Content = this.textItem.Text.Trim();
            // 备注类别
            tcc.Content_Type = ContentType.Consume;
            // 更新时间
            tcc.Update_DateTime = DateTime.Now;
            // 记录状态
            tcc.State = RecordState.Normal;
            // 更新者
            tcc.Operator_No = SysParam.OperatorNo;

            tcc.Save();

            this.Close();

        }
        #endregion

        // 取消按钮点击事件
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 输入检查项目
        private bool CheckCondition()
        {
            if(String.IsNullOrEmpty(this.textItem.Text))
            {
                return false;
            }
            // 检查消费备注是否存在
            if (consumLogic.IsExitConsumeContent(this.textItem.Text.Trim()))
            {
                ShowWarnMsgBox(MessageConst.errMsg_ConsumeItemExited);
                this.textItem.Focus();
                return false;
            }

            return true;
        }
        #endregion
    }
}
