using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using shopsoft.common.Logic;
using shopsoft.common.DB;
using shopsoft.common.Const;
using shopsoft.common;
using DevExpress.XtraEditors.Controls;
using DevExpress.Xpo;

namespace shopsoft.main.MemberManage
{
    public partial class Form071_QuickConsume : BaseForm
    {
        #region Logic信息
        // 会员信息
        private readonly MemberLogic memberLogic = new MemberLogic();
        // 会员等级信息
        private readonly MemberGradeLogic gradeLogic = new MemberGradeLogic();
        // 消费备注
        private readonly ConsumeContentLogic contentLogic = new ConsumeContentLogic();

        // 导购
        private readonly ShoppingGuideLogic shopLogic = new ShoppingGuideLogic();
        #endregion

        #region 私有信息
        // 会员信息
        private t_Member_Info memberInfo;
        // 会员消费信息
        private t_Member_Deal_History memberDealHis;
        // 会员ID
        private string MemberId = string.Empty;
        // 折扣
        private double zhekou = 0;
        // 折后金额
        private double zhehou = 0;
        // 消费金额
        private double xiaofei = 0;
        private double balance = 0;
        // 扣卡金额
        private double kouka = 0;
        // 应收金额
        private double yingshou = 0;
        // 实收金额
        private double shishou = 0;
        // 找零
        private double zhaoling = 0;

        // 消费记录ID
        private int hisId = 0;
        #endregion

        #region 初始化
        public Form071_QuickConsume()
        {
            InitializeComponent();
        }

        public Form071_QuickConsume(string memberId)
            : this()
        {
            // 会员ID
            this.MemberId = memberId; 
        }

        private void Form071_QuickConsume_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.MemberId))
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                this.Close();
                return;
            }

            // 根据会员ID取得会员信息
            this.memberInfo = memberLogic.GetMemberInfoByMemberID(this.MemberId, this.DBSession);

            if (memberInfo == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                this.Close();
                return;
            }

            // 会员编号
            this.lblMemberNo.Text = this.memberInfo.Member_No;
            // 会员姓名
            this.lblMemberName.Text = this.memberInfo.Member_Name;
            // 会员等级
            this.lblMemberGrade.Text = this.memberInfo.Member_Grade_ID.Grade_Name;
            // 会员积分
            this.lblBouns.Text = Convert.ToString(this.memberInfo.Bouns) + "分";
            // 卡内余额
            this.lblBlance.Text = Convert.ToString(this.memberInfo.Balance) +"元";
            this.balance = memberInfo.Balance;

            // 设置扣卡金额上限
            this.spnKouka.Properties.MaxValue = Convert.ToDecimal(this.balance);

            // 折扣
            this.lblZheKou.Text = this.memberInfo.Member_Grade_ID.Discount_Percent.ToString();
            this.zhekou = this.memberInfo.Member_Grade_ID.Discount_Percent;

            // 查询消费备注项目
            chklistConsumItems.DataSource = contentLogic.SearchConsumItems();
            if (chklistConsumItems.DataSource != null)
            {
                chklistConsumItems.DisplayMember = "Content";
                chklistConsumItems.ValueMember = "Content_ID";
            }

            // 查询导购列表
            chklistGuide.DataSource = shopLogic.GetGuideList();
            if (chklistGuide.DataSource != null) 
            {
                chklistGuide.DisplayMember = "Guide_Name";
                chklistGuide.ValueMember = "Guide_No";
            }

        }
        #endregion

        #region 消费项目-增加、修改、删除按钮事件
        /// <summary>
        /// 消费项目-增加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            Form079_ConsumeItem itemDialg = new Form079_ConsumeItem("", 1);
            itemDialg.ShowDialog();
            return;
        }

        /// <summary>
        /// 消费项目-修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemModify_Click(object sender, EventArgs e)
        {
            t_Consume_Content item = (t_Consume_Content)chklistConsumItems.SelectedItem;

            // 打开消费项目修改窗口
            if (item != null)
            {
                Form079_ConsumeItem itemDialg = new Form079_ConsumeItem(item.Content_ID.ToString(), 2);
                itemDialg.ShowDialog();
                return;
            }
            else
            {
                ShowInfoMsgBox(MessageConst.errMsg_ConsumeItemUnselect);
                return;
            }            
        }

        /// <summary>
        /// 消费项目-删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemDel_Click(object sender, EventArgs e)
        {
            t_Consume_Content item = (t_Consume_Content)chklistConsumItems.SelectedItem;
            
            // 删除消费项目
            if (item == null)
            {
                ShowInfoMsgBox(MessageConst.errMsg_ConsumeItemUnselect);
                return;
            }

            if (DialogResult.Yes == ShowInfoMsgBox2Btn(MessageConst.errMsg_ConsumeItemIsDel + item.Content))
            {
                item.Delete();
                return;
            }
        }
        #endregion

        #region 消费项目点击事件
        private void chklistConsumItems_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (CheckState.Checked.Equals(chklistConsumItems.GetItemCheckState(e.Index)))
            {
                AddResumeContent(chklistConsumItems.GetItemText(e.Index));

            }
            else
            {
                DelResumContent(chklistConsumItems.GetItemText(e.Index));
            }

        }
        #endregion

        #region 消费金额改变事件
        private void spnConsumeSum_EditValueChanged(object sender, EventArgs e)
        {
            CalculateMoney();
        }
        #endregion
    
        #region 不打折checkbox改变
        private void chkNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            CalculateMoney();
        }
        #endregion

        #region 不使用卡内金额checkbox
        private void chkUseCard_CheckedChanged(object sender, EventArgs e)
        {
            CalculateMoney();
        }
        #endregion

        #region 扣卡金额改变事件
        private void spnKouka_EditValueChanged(object sender, EventArgs e)
        {
            CalculateMoney();
        }
        #endregion

        #region 金额计算
        private void CalculateMoney()
        {
            // 消费金额
            this.xiaofei = Convert.ToDouble(this.spnConsumeSum.Value);

            // 折后金额
            if (this.chkNoDiscount.Checked)
            {
                this.zhehou = xiaofei;
            }
            else
            {
                this.zhehou = xiaofei * zhekou;
            }
            this.lblzhehou.Text = this.zhehou.ToString("0.00");

            // 计算扣卡金额和应收金额
            if (!this.chkUseCard.Checked)
            {
                if (balance < zhehou) // 卡内金额小于等于折后金额
                {
                    // 扣除卡内金额 = 卡内余额
                    kouka = balance;
                    // 应收现金 = 折后金额 - 卡内余额
                    yingshou = zhehou - kouka;

                }
                else
                {
                    // 卡内余额大于折后金额
                    // 扣除卡内金额 = 折后金额
                    kouka = zhehou;
                    // 实收现金设置为0
                    yingshou = 0;
                }
            }
            else
            {
                this.kouka = 0;
                // 折后金额=应收金额
                this.yingshou = this.zhehou;
            }
            this.spnKouka.Value = Convert.ToDecimal(this.kouka);
            this.spnYingShou.Value = Convert.ToDecimal(this.yingshou);

            // 计算获得积分
            //this.spnBonus = 

            // 计算找零
            if (this.spnShiShou.Value != 0)
                this.lblLooseChange.Text = Convert.ToString(this.spnShiShou.Value - this.spnYingShou.Value);
        }
        #endregion

        #region 实收金额改变
        private void spnShiShou_EditValueChanged(object sender, EventArgs e)
        {
            // 计算找零
            if (this.spnShiShou.Value != 0)
            {
                this.lblLooseChange.Text = Convert.ToString(this.spnShiShou.Value - this.spnYingShou.Value) + "元";
            }
            else
            {
                this.lblLooseChange.Text = "0元";
            }
        }
        #endregion

        #region 保存按钮事件
        private void btnSave_Click(object sender, EventArgs e)
        {
            



        }
        #endregion

        #region 结账按钮事件
        private void btnConsume_Click(object sender, EventArgs e)
        {
            // 消费金额必须输入
            if (this.spnConsumeSum.Value <= 0 || string.IsNullOrEmpty(this.spnConsumeSum.Text))
            {
                ShowWarnMsgBox(MessageConst.errMsg_MemberConsum_InputConsum);
                this.spnConsumeSum.Focus();
                return; 
            }

            // 消费成功
            if (InsertConsumeHistory())
            {
                // 打印小票
                if (chkConsumPrint.Checked)
                {
                    // hisId 消费记录ID
 
                }

                this.Close();
            }
        }
        #endregion

        #region 结账按钮DB操作
        private bool InsertConsumeHistory()
        {
            bool res = false;

            using (UnitOfWork uow = new UnitOfWork(DBSession.DataLayer))
            {
                DateTime updateTime = DateTime.Now;
                this.memberDealHis = new t_Member_Deal_History(uow);
                this.memberInfo = memberLogic.GetMemberInfoByMemberID(this.MemberId, uow);

                this.memberDealHis.Member_ID = this.memberInfo;
                this.memberDealHis.Member_No = this.memberInfo.Member_No;
                this.memberDealHis.Operator_No = SysParam.OperatorNo;

                // 导购
                int guidCnt = 0;
                foreach (CheckedListBoxItem guidItem in this.chklistGuide.SelectedItems)
                {
                    guidCnt += 1;
                    if (guidCnt == 1)
                    {
                        // 导购1
                        this.memberDealHis.Guide_No = guidItem.Value.ToString();
                        this.memberDealHis.Guide_Name = guidItem.Description;
                    }
                    else if (guidCnt == 2)
                    {
                        // 导购2
                        this.memberDealHis.Guide2_No = guidItem.Value.ToString();
                        this.memberDealHis.Guide2_Name = guidItem.Description;
                    }
                    else if (guidCnt == 3)
                    {
                        // 导购3
                        this.memberDealHis.Guide3_No = guidItem.Value.ToString();
                        this.memberDealHis.Guide3_Name = guidItem.Description;
                    }
                    else if (guidCnt == 4)
                    {
                        // 导购4
                        this.memberDealHis.Guide4_No = guidItem.Value.ToString();
                        this.memberDealHis.Guide4_Name = guidItem.Description;
                    }
                }

                // 应收金额
                this.memberDealHis.YingShou_Money = Convert.ToDouble(this.spnConsumeSum.Value);
                // 折后金额
                this.memberDealHis.ZheHou_Money = Convert.ToDouble(this.lblzhehou);

                // 应收现金
                this.memberDealHis.ShiShou_Cash = Convert.ToDouble(this.spnYingShou.Value);

                // 实收现金
                this.memberDealHis.ShouDao_cash = Convert.ToDouble(this.spnShiShou.Value);

                // 找零
                this.memberDealHis.LooseCharge = Convert.ToDouble(this.lblLooseChange);

                // 扣卡金额
                this.memberDealHis.KouChu_Card_Balance = Convert.ToDouble(this.spnKouka.Value);

                // 卡内剩余金额
                this.memberDealHis.Leave_Balance = this.balance - this.kouka;
                this.memberInfo.Balance = this.balance - this.kouka;

                // 获得积分
                int tempBonus = Convert.ToInt32(this.spnBonus.Value);
                this.memberDealHis.Get_Bonus = tempBonus;
                this.memberInfo.Bouns += tempBonus;

                // 支付方式
                this.memberDealHis.Pay_Type = PayType.WorkPay;

                // 备注
                this.memberDealHis.Comment = this.memoRemark.Text;

                //数据状态-正常
                this.memberDealHis.State = (int)RecordState.Normal;
                // 更新者
                this.memberDealHis.Operator_No = SysParam.OperatorNo;

                // 更新时间
                this.memberInfo.Update_DateTime = updateTime;
                // 更新者
                this.memberInfo.Operator_No = SysParam.OperatorNo;

                try
                {
                    uow.ExplicitBeginTransaction();
                    uow.CommitChanges();

                    hisId = this.memberDealHis.Deal_History_ID;


                    uow.ExplicitCommitTransaction();

                    // 充值成功
                    ShowInfoMsgBox(MessageConst.info_MemberConsumeSucces);
                    res = true;
                }
                catch
                {
                    uow.ExplicitRollbackTransaction();
                    ShowWarnMsgBox(MessageConst.errMsg_ConsumeFaild);
                }
            }

            return res;
        }
        #endregion

        #region 修改消费备注
        /// <summary>
        /// 添加消费备注
        /// </summary>
        /// <param name="addText">要添加的备注内容</param>
        private void AddResumeContent(string addText)
        {
            if(string.IsNullOrEmpty(this.memoRemark.Text))
            {
                this.memoRemark.Text = addText + ";";
            }
            else if (this.memoRemark.Text.EndsWith(";"))
            {
                this.memoRemark.Text += addText + ";";
            }
            else
            {
                this.memoRemark.Text += ";" + addText + ";"; 
            }
        }

        /// <summary>
        /// 删除消费备注
        /// </summary>
        /// <param name="delText"></param>
        private void DelResumContent(string delText)
        {
            string findText = delText + ";";
            string txtReplace = this.memoRemark.Text.Replace(findText, "");
            this.memoRemark.Text = txtReplace;
            
        }
        #endregion

        #region 注册快捷键
        private void Form071_QuickConsume_KeyDown(object sender, KeyEventArgs e)
        {
            // F5键-保存
            if (Keys.F5.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnConsume_Click(sender, e);
                return;
            }
            else if (Keys.F4.Equals(e.KeyCode))
            {
                // F4键-退出
                this.Close();
            }
        }
        #endregion

        #region 填充checkListBox例子
        //void InitListBox()
        //{
        //    listBoxControlSample.DataSource = TutorialHelper.Countries;
        //    //
        //    // <checkedListBoxControlSample>
        //    checkedListBoxControlSample.DataSource = GetData();
        //    if (checkedListBoxControlSample.DataSource != null)
        //    {
        //        checkedListBoxControlSample.DisplayMember = "ProductName";
        //        checkedListBoxControlSample.ValueMember = "Discontinued";
        //        int i = 0;
        //        while (checkedListBoxControlSample.GetItem(i) != null)
        //        {
        //            i++;
        //            checkedListBoxControlSample.SetItemCheckState(i, (true.Equals(checkedListBoxControlSample.GetItemValue(i)) ? CheckState.Unchecked : CheckState.Checked));
        //        }
        //    }
        //    // </checkedListBoxControlSample>
        //    //
        //    DevExpress.Tutorials.TutorialHelper.InitFont(imageListBoxControlSample);
        //    imageListBoxControlSample.SelectedIndex = 0;
        //}
        #endregion



    }
}
