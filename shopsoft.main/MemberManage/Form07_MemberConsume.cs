using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using shopsoft.common.DB;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using shopsoft.common.util;
using shopsoft.common.Logic;
using DevExpress.Xpo;
using shopsoft.common.Const;

namespace shopsoft.main.MemberManage
{
    /// <summary>
    /// 会员消费页面：快速消费、按次消费、按时消费
    /// </summary>
    public partial class Form07_MemberConsume : BaseFormX
    {
        #region Logic信息
        private readonly MemberDealHistoryLogic dealLgic = new MemberDealHistoryLogic();
        private readonly MemberLogic memberLogic = new MemberLogic();
        #endregion

        #region 私有属性
        private t_Member_Info memberInfo;
        #endregion


        public Form07_MemberConsume()
        {
            InitializeComponent();
        }


        #region GridView行事件：鼠标悬停时提示信息
        /// <summary>
        /// GridView行事件：鼠标悬停时提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTipGridMember_GetActiveObjectInfo(object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e)
        {
            if (e.SelectedControl != this.gridCtrlMembers) return;
            ToolTipControlInfo info = null;
            try
            {
                GridView view = this.gridCtrlMembers.GetViewAt(e.ControlMousePosition) as GridView;
                if (view == null) return;
                GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
                if (hi.InRowCell)
                {
                    info = new ToolTipControlInfo(new CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), GetCellHintText(view, hi.RowHandle, hi.Column));
                    return;
                }
                if (hi.Column != null)
                {
                    info = new ToolTipControlInfo(hi.Column, hi.Column.GetTextCaption());
                    return;
                }
                if (hi.HitTest == GridHitTest.GroupPanel)
                {
                    info = new ToolTipControlInfo(hi.HitTest, "会员信息");
                    return;
                }

                if (hi.HitTest == GridHitTest.RowIndicator)
                {
                    info = new ToolTipControlInfo(GridHitTest.RowIndicator.ToString() + hi.RowHandle.ToString(), "行 " + (hi.RowHandle + 1).ToString());
                    return;
                }
            }
            finally
            {
                e.Info = info;
            }
        }
        private string GetCellHintText(GridView view, int rowHandle, GridColumn column)
        {
            string ret = "<b>双击进行默认充值!</b> \r\n";
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in view.Columns)
            {
                if (!col.FieldName.Equals("Member_ID"))
                {
                    ret += string.Format("{0}: {1} \r\n", col.GetTextCaption(), view.GetRowCellDisplayText(rowHandle, col));
                }

            }
            return ret;
        }
        #endregion

        #region GridView行事件：翻译
        /// <summary>
        /// GridView行事件：翻译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMembers_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {

        }
        #endregion

        #region GridView行事件：点击
        /// <summary>
        /// GridView行事件：点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMembers_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                //OpenMoneyRechargeForm();

                #region 本页面只显示一个会员的充值记录，不是多个会员记录，所以不适用下面的方法
                // 主键
                //string memberKey = this.gridViewMembers.GetRowCellDisplayText(e.RowHandle, "Member_ID.Member_ID");
                //if (string.IsNullOrEmpty(memberKey))
                //{
                //    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                //    return;
                //}

                //Form61_MoneyRecharge f61 = checkFormIsOpened("Form61_MoneyRecharge") as Form61_MoneyRecharge;
                //if (f61 != null)
                //{
                //    f61.ShowDialog();
                //}
                //else
                //{
                //    f61 = new Form61_MoneyRecharge(memberKey);
                //    f61.ShowDialog();
                //}
                #endregion

            }
        }
        #endregion


        #region 查询按钮点击事件
        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            XPCollection<t_Member_Info> collection = memberLogic.SearchMember(this.txtSearchCondition.Text.Trim(), string.Empty);

            string memberKey = string.Empty;
            foreach (t_Member_Info mem in collection)
            {
                memberInfo = mem;
                break;
            }

            if (memberInfo == null)
            {
                ShowWarnMsgBox("没有会员！");
                return;
            }

            // 取得会员信息
            memberKey = memberInfo.Member_ID.ToString();
            // 设置页面上的会员信息
            SetMemberInfo();
            // 取得会员消费记录
            getMemberDealHistory(memberKey);
            if (collection.Count > 1)
            {
                // this.popupContainerControl1.Show();
                // this.popupContainerControl1.Hide();
            }
        }

        private void getMemberDealHistory(string memberKey)
        {
            XPCollection<t_Member_Deal_History> dealHisColl = dealLgic.SearchDealHistoryByMemberId(memberKey);

            this.gridCtrlMembers.DataSource = dealHisColl;
        }


        private void SetMemberInfo()
        {
            this.lblMemberNo.Text = memberInfo.Member_No;
            this.lblMemberName.Text = memberInfo.Member_Name;
            this.lblMemberGrade.Text = memberInfo.Member_Grade_ID.Grade_Name;
            this.lblMobileNo.Text = memberInfo.Mobile_No;
            this.lblBouns.Text = String.Format("{0}分", memberInfo.Bouns);
            this.lblBlance.Text = String.Format("{0}元", memberInfo.Balance);
            this.lblDealTimes.Text = String.Format("{0}次", memberInfo.Leaving_Deal_time);
            this.lblUseTime.Text = FormUtil.HourToMinute(this.memberInfo.Remaining_Time).ToString();
            this.lblContent.Text = memberInfo.Comment;
        }
        #endregion


        #region 注册快捷键
        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form07_MemberConsume_KeyDown(object sender, KeyEventArgs e)
        {
            // F3键-查询
            if (Keys.F3.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnSearch_Click(sender, e);
                return;
            }
        }
        #endregion
        
        #region 点击快速消费按钮
        /// <summary>
        /// 点击快速消费按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuiceConsume_Click(object sender, EventArgs e)
        {
            if (this.memberInfo == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                return;
            }

            string memberKey = this.memberInfo.Member_ID.ToString();

            Form071_QuickConsume f71 = checkFormIsOpened("Form071_QuickConsume") as Form071_QuickConsume;
            if (f71 == null)
            {
                f71 = new Form071_QuickConsume(memberKey);
            }
            f71.ShowDialog();
            getMemberDealHistory(memberKey);

        }
        #endregion

        #region 计次消费按钮
        /// <summary>
        /// 点击计次消费按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimeConsume_Click(object sender, EventArgs e)
        {
            if (this.memberInfo == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                return;
            }

            string memberKey = this.memberInfo.Member_ID.ToString();

            Form072_TimesConsume f72 = checkFormIsOpened("Form072_TimesConsume") as Form072_TimesConsume;
            if(f72 == null)
            {
                f72 = new Form072_TimesConsume(memberKey);
            }
            f72.ShowDialog();
            getMemberDealHistory(memberKey);
        }
        #endregion

    }
}
