using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using shopsoft.main.Base;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using shopsoft.common.Logic;
using shopsoft.common.DB;
using DevExpress.Xpo;
using shopsoft.common.util;
using shopsoft.common.Const;

namespace shopsoft.main.MemberManage
{
    public partial class Form09_BonusExchange : BaseFormX
    {
        #region 私有属性
        private t_Member_Info memberInfo = null;
        private t_Bonus_Exchange_History bonusChgHis = null;
        #endregion

        #region Logic信息
        private MemberLogic memberLogic = new MemberLogic();
        private BonusExchangeHistoryLogic bonusHisLogic = new BonusExchangeHistoryLogic();
        #endregion


        public Form09_BonusExchange()
        {
            InitializeComponent();
        }

        #region 查询按钮点击
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string memberKey = string.Empty;
            using (XPCollection<t_Member_Info> collection = memberLogic.SearchMember(this.txtSearchCondition.Text.Trim(), string.Empty))
            {
                if (collection.Count == 1)
                {
                    //this.popupContainerControl1.Show();
                    //this.popupControlContainer1.ShowPopup(pt);
                }

                foreach (t_Member_Info mem in collection)
                {
                    memberInfo = mem;
                    break;
                }
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
            XPCollection<t_Bonus_Exchange_History> bonusChgHisColl = bonusHisLogic.SearchExchangeHistoryByMemberId(memberKey);
            this.gridCtrlMembers.DataSource = bonusChgHisColl;

        }
        private void SetMemberInfo()
        {
            this.lblMemberNo.Text = memberInfo.Member_No;
            this.lblMemberName.Text = memberInfo.Member_Name;
            this.lblMemberGrade.Text = memberInfo.Member_Grade_ID.Grade_Name;
            this.lblBouns.Text = String.Format("{0}分", memberInfo.Bouns);
            this.lblBlance.Text = String.Format("{0}元", memberInfo.Balance);
            this.lblDealTimes.Text = String.Format("{0}次", memberInfo.Leaving_Deal_time);
            this.lblUseTime.Text = FormUtil.HourToMinute(this.memberInfo.Remaining_Time).ToString();
        }
        #endregion

        #region 积分兑换按钮点击事件
        private void btnBonusExchange_Click(object sender, EventArgs e)
        {
            if (this.memberInfo == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                return;
            }

            string memberKey = this.memberInfo.Member_ID.ToString();
            Form091_BonusEx f91 = checkFormIsOpened("Form091_BonusEx") as Form091_BonusEx;
            if (f91 != null)
            {
                f91.ShowDialog();
            }
            else
            {
                f91 = new Form091_BonusEx(memberKey);
                f91.ShowDialog();
            }
        }
        #endregion


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
            string ret = "<b>右键点击还有更多操作!</b> \r\n";
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


        #region GridView行时间：翻译
        /// <summary>
        /// GridView行时间：翻译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMembers_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            // 生日
            if (e.Column.FieldName.Equals("Exchange_DateTime") && !Convert.IsDBNull(e.Value) && e.Value.ToString().Length == 4)
            {
                DateTime dt;

                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    e.DisplayText = dt.ToShortDateString();
                }
                else
                {
                    e.DisplayText = "";
                }
            }
        }
        #endregion


        private void gridViewMembers_RowClick(object sender, RowClickEventArgs e)
        {

        }

        #region 注册快捷键
        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form06_MemberRecharge_KeyDown(object sender, KeyEventArgs e)
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

    }
}