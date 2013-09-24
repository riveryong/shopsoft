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
using shopsoft.common.Const;
using shopsoft.common.Logic;
using DevExpress.Xpo;
using shopsoft.common;

namespace shopsoft.main.MemberManage
{
    public partial class Form091_BonusEx : BaseForm
    {
        #region Logic信息
        // 会员信息
        private readonly MemberLogic memberLogic = new MemberLogic();
        #endregion

        #region 私有属性
        // 会员信息
        private t_Member_Info memberInfo;
        // 店铺信息
        private t_Store_Info storeInfo = null;
        // 会员积分兑换
        private t_Bonus_Exchange_History bonuxExHis;
        // 会员ID
        private string MemberId = string.Empty;
        // 会员积分
        private int Bonus = 0;
        // 积分兑换记录ID
        private int hisId = 0;

        #endregion

        #region 初始化
        public Form091_BonusEx()
        {
            InitializeComponent();
        }

        public Form091_BonusEx(string memberid)
            : this()
        {
            this.MemberId = memberid;
        }

        private void Form091_BonuxEx_Load(object sender, EventArgs e)
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
            // 会员积分
            this.Bonus = this.memberInfo.Bouns;
            this.lblBouns.Text = Convert.ToString(this.memberInfo.Bouns) + "分";
            this.spnBonus.Properties.MaxValue = this.memberInfo.Bouns;

            // 卡内余额
            this.lblBlance.Text = Convert.ToString(this.memberInfo.Balance) + "元";

            // 店铺信息
            this.storeInfo = SysParam.storeInfo;

        }
        #endregion

        #region 扣减积分改变事件
        private void spnBonus_EditValueChanged(object sender, EventArgs e)
        {
            if (this.spnBonus.Value == 0 || this.spnBonus.Text == null)
            {
                this.lblLeaveBonus.Text = string.Format("剩余{0}分", this.Bonus);
                return;
            }

            int temp1 = Convert.ToInt32(this.spnBonus.Value);
            this.lblLeaveBonus.Text = string.Format("剩余{0}分",this.Bonus-temp1);

        }
        #endregion

        #region 兑换积分按钮按下
        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (this.spnBonus.Value == 0 || this.spnBonus.Text == null)
            {
                ShowWarnMsgBox(MessageConst.errMsg_BonusExchange_NoInput);
                this.spnBonus.Focus();
                return;
            }

            if(this.spnBonus.Value > this.Bonus)
            {
                ShowWarnMsgBox(MessageConst.errMsg_BonusExchange_NoEnough);
                this.spnBonus.Focus();
                return;
            }

            // 消费成功
            if (InsertBonusExchangeHistory())
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

        #region 积分兑换DB操作
        private bool InsertBonusExchangeHistory()
        {
            bool res = false;

            using (UnitOfWork uow = new UnitOfWork(DBSession.DataLayer))
            {
                DateTime updateTime = DateTime.Now;
                // 积分兑换历史记录
                this.bonuxExHis = new t_Bonus_Exchange_History(uow);
                // 会员信息
                this.memberInfo = memberLogic.GetMemberInfoByMemberID(this.MemberId, uow);

                this.bonuxExHis.Member_ID = this.memberInfo;
                this.bonuxExHis.Member_No = this.memberInfo.Member_No;
                this.bonuxExHis.Operator_No = SysParam.OperatorNo;

                // 兑换日期
                this.bonuxExHis.Exchange_DateTime = updateTime;

                // 兑换积分数
                int tempBonus = Convert.ToInt32(this.spnBonus.Value);
                this.bonuxExHis.Bonus_Num = tempBonus;
                // 兑换后剩余积分
                this.bonuxExHis.Surplus_Bonus = this.Bonus - tempBonus;
                this.memberInfo.Bouns = this.Bonus - tempBonus;

                // 兑换金额
                double tempBalance = tempBonus * SysParam.storeInfo.Bonus_to_Money_Ratio;
                this.bonuxExHis.Money_Num = tempBalance;
                this.memberInfo.Balance = tempBalance;

                // 兑换后剩余金额
                this.bonuxExHis.Surplus_Money = this.memberInfo.Balance + tempBalance;  
                this.memberInfo.Balance += tempBalance;

                // 兑换类别:积分兑换金额
                this.bonuxExHis.Bonus_Type = BonusExchangeType.MoneyExchange;

                // 备注
                this.bonuxExHis.Comment = this.memoRemark.Text;

                //数据状态-正常
                this.bonuxExHis.State = (int)RecordState.Normal;
                // 更新者
                this.bonuxExHis.Operator_No = SysParam.OperatorNo;

                // 更新时间
                this.memberInfo.Update_DateTime = updateTime;
                // 更新者
                this.memberInfo.Operator_No = SysParam.OperatorNo;

                try
                {
                    uow.ExplicitBeginTransaction();
                    uow.CommitChanges();

                    hisId = this.bonuxExHis.Exchange_History_ID;

                    uow.ExplicitCommitTransaction();

                    // 兑换成功
                    ShowInfoMsgBox(MessageConst.info_BonusExchangeSucces);
                    res = true;
                }
                catch
                {
                    // 积分兑换失败
                    uow.ExplicitRollbackTransaction();
                    ShowWarnMsgBox(MessageConst.errMsg_BonusExchangeFaild);
                }
            }

            return res;
        }
        #endregion

        #region 兑换金额CheckBox改变事件
        private void chkIsExchangeMoney_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chkIsExchangeMoney.CheckState == CheckState.Checked)
            {
                double tempBalance = Convert.ToDouble(this.spnBonus.Value) * this.storeInfo.Bonus_to_Money_Ratio;
                this.txtExchangeMoney.Text = tempBalance.ToString();
                this.lblLeaveBlance.Text = (tempBalance + this.memberInfo.Balance).ToString();
            }
            else
            {
                this.txtExchangeMoney.Text = "0";
                this.lblLeaveBlance.Text = "0";
            }
        }
        #endregion

        #region 注册快捷键
        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form091_BonusEx_KeyDown(object sender, KeyEventArgs e)
        {
            // F3键-查询
            if (Keys.F5.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnExchange_Click(sender, e);
                return;
            }

            if (Keys.F4.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.Close();
            }
        }
        #endregion
    }
}
