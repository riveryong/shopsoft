using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Xpo;
using shopsoft.common.DB;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using shopsoft.common.Logic;
using shopsoft.common.Const;
using shopsoft.common.util;

namespace shopsoft.main.MemberManage
{
    /// <summary>
    /// 会员充值页面：查询会员充值记录、会员充值、补打小票
    /// </summary>
    public partial class Form06_MemberRecharge : BaseFormX
    {
        #region 私有属性
        private t_Member_Info memberInfo = null;
        #endregion

        #region Logic信息
        private MemberLogic memberLogic = new MemberLogic();
        private MemberChargeHistoryLogic memberChgHisLogic = new MemberChargeHistoryLogic();
        #endregion

        public Form06_MemberRecharge()
        {
            InitializeComponent();
        }

        #region 查询按钮按下
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            XPCollection<t_Member_Charge_History> chgHisColl = memberChgHisLogic.SearchChargeHistoryByMemberId(memberKey);
            this.gridCtrlMembers.DataSource = chgHisColl;
            
            
        }

        private void SetMemberInfo()
        {
            this.lblMemberNo.Text = memberInfo.Member_No;
            this.lblMemberName.Text = memberInfo.Member_Name;
            this.lblMemberGrade.Text = memberInfo.Member_Grade_ID.Grade_Name;
            this.lblBouns.Text = String.Format("{0}分", memberInfo.Bouns);
            this.lblBlance.Text = String.Format("{0}元", memberInfo.Balance);
            this.lblDealTimes.Text = String.Format("{0}次", memberInfo.Leaving_Deal_time);
            this.lblUseTime.Text =  FormUtil.HourToMinute(this.memberInfo.Remaining_Time).ToString();
        }

        #endregion

        #region 会员充值按钮事件
        /// <summary>
        /// 会员充值按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecharge_Click(object sender, EventArgs e)
        {
            OpenMoneyRechargeForm();

            #region 本页面只显示一个会员的充值记录，不是多个会员记录，所以不适用下面的方法
            // 取得选择项的主键
            //string memberKey = this.gridViewMembers.GetRowCellDisplayText(this.gridViewMembers.FocusedRowHandle, "Member_ID.Member_ID");
            //if (string.IsNullOrEmpty(memberKey))
            //{
            //    ShowInfoMsgBox(MessageConst.errMsg_noSelect);
            //    return;
            //}

            //using (Form61_MoneyRecharge frm61_MoneyRecharge = new Form61_MoneyRecharge(memberKey))
            //{
            //    frm61_MoneyRecharge.ShowDialog();
            //}
            #endregion
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
                OpenMoneyRechargeForm();

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

        #region 打开会员充值页面
        private void OpenMoneyRechargeForm()
        {
            if (this.memberInfo == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                return;
            }

            string memberKey = this.memberInfo.Member_ID.ToString();
            Form061_MoneyRecharge f61 = checkFormIsOpened("Form61_MoneyRecharge") as Form061_MoneyRecharge;
            if (f61 != null)
            {
                f61.ShowDialog();
            }
            else
            {
                f61 = new Form061_MoneyRecharge(memberKey);
                f61.ShowDialog();
            }

        }
        #endregion

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
