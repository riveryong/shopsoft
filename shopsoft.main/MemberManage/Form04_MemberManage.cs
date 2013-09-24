using System;
using System.Collections.Generic;
using shopsoft.main.Base;
using shopsoft.common.DB;
using shopsoft.common.Const;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using shopsoft.common.util;
using shopsoft.common.Logic;
using System.Windows.Forms;


namespace shopsoft.main.MemberManage
{
    /// <summary>
    /// 会员管理页面：新建会员、修改会员、删除会员
    /// </summary>
    public partial class Form04_MemberManage : BaseFormX
    {
        #region Logic信息
        private MemberLogic memberLogic = new MemberLogic();
        private MemberGradeLogic gradeLogic = new MemberGradeLogic();
        #endregion

        #region 页面初始化
        public Form04_MemberManage()
        {
            InitializeComponent();
        }

        private void Form04_MemberManage_Load(object sender, EventArgs e)
        {
            // 读取会员等级列表
            using (XPCollection<t_Member_Grade> gradeCollect = gradeLogic.GetMemberGradeList())
            {
                foreach (t_Member_Grade mg in gradeCollect)
                {
                    ComboBoxEx cmbItem = new ComboBoxEx(mg.Grade_Name, mg.Member_Grade_ID.ToString());
                    this.cmbMemberGrade.Properties.Items.Add(cmbItem);
                }
            }
        }
        #endregion       

        #region 查询按钮按下
        /// <summary>
        /// 查询按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string gradeId = string.Empty;
            if(this.cmbMemberGrade.SelectedIndex != -1)
            {
                ComboBoxEx cmbItem = (ComboBoxEx)this.cmbMemberGrade.SelectedItem;
                gradeId = cmbItem.Key;
            }
            XPCollection<t_Member_Info> collection = memberLogic.SearchMember(this.txtSearchCondition.Text.Trim(),gradeId);

            this.gridCtrlMembers.DataSource = collection;
        }
        #endregion                        

        #region 添加会员按钮
        /// <summary>
        /// 添加会员按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            Form05_MemberInfo frmMemberInfo = checkFormIsOpened("Form05_MemberInfo") as Form05_MemberInfo;

            if (frmMemberInfo == null)
            {
                frmMemberInfo = new Form05_MemberInfo(1, string.Empty);
            }

            frmMemberInfo.ShowDialog();

        }
        #endregion

        #region 修改会员按钮
        /// <summary>
        /// 修改会员按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            string memberKey = this.gridViewMembers.GetRowCellDisplayText(this.gridViewMembers.FocusedRowHandle, "Member_ID");
            if (string.IsNullOrEmpty(memberKey))
            {
                ShowInfoMsgBox(MessageConst.errMsg_noSelect);
                return;
            }

            using (Form05_MemberInfo form05MemberInfo = new Form05_MemberInfo(2, memberKey))
            {
                form05MemberInfo.ShowDialog();
            }
        }
        #endregion

        #region 会员充值按钮
        /// <summary>
        /// 会员充值按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoneyRecharge_Click(object sender, EventArgs e)
        {
            string memberKey = this.gridViewMembers.GetRowCellDisplayText(this.gridViewMembers.FocusedRowHandle, "Member_ID");
            if (string.IsNullOrEmpty(memberKey))
            {
                ShowInfoMsgBox(MessageConst.errMsg_noSelect);
                return;
            }

            using (Form061_MoneyRecharge frm61_MoneyRecharge = new Form061_MoneyRecharge(string.Empty))
            {
                frm61_MoneyRecharge.ShowDialog();
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
        private string GetCellHintText(GridView view, int rowHandle, DevExpress.XtraGrid.Columns.GridColumn column)
        {
            string ret = "<b>双击即可修改!</b> \r\n";
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

        #region GridView行双击事件
        /// <summary>
        /// GridView行双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridViewMembers_RowClick(object sender, RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                // 主键
                string memberKey = this.gridViewMembers.GetRowCellDisplayText(e.RowHandle, "Member_ID");
                if (string.IsNullOrEmpty(memberKey))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    return;
                }

                Form05_MemberInfo f05 = checkFormIsOpened("Form05_MemberInfo") as Form05_MemberInfo;
                if (f05 != null)
                {
                    f05.Close();
                }

                f05 = new Form05_MemberInfo(2, memberKey);
                f05.ShowDialog();

            }

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
            // 性别
            if (e.Column.FieldName.Equals("Sex") && !Convert.IsDBNull(e.Value))
            {
                if (Convert.ToInt32(e.Value) == 1)
                {
                    e.DisplayText = "男";
                }
                else if (Convert.ToInt32(e.Value) == 2)
                {
                    e.DisplayText = "女";
                }
                else
                {
                    e.DisplayText = "";
                }
            }

            // 生日
            if (e.Column.FieldName.Equals("Birthday_Month_Day") && !Convert.IsDBNull(e.Value) && e.Value.ToString().Length == 4)
            {

                string strBirMonth = e.Value.ToString().Substring(0, 2);
                string strBirDay = e.Value.ToString().Substring(2);
                string displayTxt = "";
                if (e.Value.Equals("0000"))
                {
                    e.DisplayText = "";
                }
                else
                {
                    if (!strBirMonth.Equals("00"))
                    {
                        displayTxt = strBirMonth + "月";

                    }
                    if (!strBirDay.Equals("00"))
                    {
                        displayTxt = displayTxt + strBirDay + "日";
                    }
                    e.DisplayText = displayTxt;
                }
            }

        }
        #endregion

        #region 注册快捷键
        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form04_MemberManage_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
