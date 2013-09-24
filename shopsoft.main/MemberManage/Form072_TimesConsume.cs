using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using shopsoft.common.Logic;
using shopsoft.common.DB;
using shopsoft.common.Const;
using DevExpress.Xpo;
using shopsoft.common;
using DevExpress.XtraEditors.Controls;

namespace shopsoft.main.MemberManage
{
    public partial class Form072_TimesConsume : BaseForm
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
        // 可用消费次数
        private int ConsumeTimes = 0;
        // 消费记录ID
        private int hisId = 0;
        #endregion

        #region 初始化
        public Form072_TimesConsume()
        {
            InitializeComponent();
        }

        public Form072_TimesConsume(string memberid)
            : this()
        {
            this.MemberId = memberid;
        }

        private void Form072_TimesConsume_Load(object sender, EventArgs e)
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
            // 剩余次数
            this.lblLeaveTimes.Text = Convert.ToString(this.memberInfo.Leaving_Deal_time) + "次";
            this.ConsumeTimes = this.memberInfo.Leaving_Deal_time;
            // 设置消费次数上限
            this.spnConsumeTimes.Properties.MaxValue = this.memberInfo.Leaving_Deal_time;
            if (this.ConsumeTimes > 0)
            {
                this.spnConsumeTimes.Value = 1;
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

        #region 消费次数变化事件
        private void spnConsumeTimes_EditValueChanged(object sender, EventArgs e)
        {
            if (this.spnConsumeTimes.Value == 0 || "".Equals(this.spnConsumeTimes.Text))
            {
                this.lblTimes.Text = this.ConsumeTimes.ToString();
                return;
            }

            int temp1 = Convert.ToInt32(spnConsumeTimes.Value);
            this.lblTimes.Text = (this.ConsumeTimes - temp1).ToString();

        }
        #endregion
        
        #region 结账按钮点击事件
        private void btnConsume_Click(object sender, EventArgs e)
        {
            if(this.spnConsumeTimes.Value == 0 || string.IsNullOrEmpty(this.spnConsumeTimes.Text)) 
            {
                ShowWarnMsgBox(MessageConst.errMsg_MemberTimesConsum_InputTimes);
                this.spnConsumeTimes.Focus();
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

        #region 取消按钮点击事件
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
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

                // 扣除消费次数
                this.memberDealHis.KouChu_Deal_Time = Convert.ToInt32(this.spnConsumeTimes.Value);

                // 卡内剩余次数
                this.memberDealHis.Leave_Deal_Time = this.ConsumeTimes - Convert.ToInt32(this.spnConsumeTimes.Value);
                this.memberInfo.Leaving_Deal_time = this.ConsumeTimes - Convert.ToInt32(this.spnConsumeTimes.Value);

                // 获得积分
                int tempBonus = Convert.ToInt32(this.spnBonus.Value);
                this.memberDealHis.Get_Bonus = tempBonus;
                this.memberInfo.Bouns += tempBonus;

                // 支付方式
                this.memberDealHis.Pay_Type = PayType.TimePay;

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

        #region 注册快捷键
        private void Form072_TimesConsume_KeyDown(object sender, KeyEventArgs e)
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

    }
}
