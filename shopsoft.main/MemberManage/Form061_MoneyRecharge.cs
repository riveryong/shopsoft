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
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using shopsoft.common.Const;
using shopsoft.common.Logic;
using shopsoft.common.util;
using shopsoft.common.Model;
using shopsoft.common;

namespace shopsoft.main.MemberManage
{
    public partial class Form061_MoneyRecharge : BaseForm
    {

        #region 私有属性
        // 会员ID
        private string MemberId = string.Empty;
        // 操作类型
        //private int operFlg = 0;
        // 会员信息
        private t_Member_Info memberInfo;
        // 会员充值记录
        private t_Member_Charge_History memChgHis;
        #endregion

        #region Logic信息
        private readonly MemberLogic memberLogic = new MemberLogic();
        private readonly MemberGradeLogic gradeLogic = new MemberGradeLogic();
        #endregion

        #region 窗口初始化
        private Form061_MoneyRecharge()
        {
            InitializeComponent();
        }

        public Form061_MoneyRecharge(string memberid):this()
        {
            // 客户ID
            this.MemberId = memberid;
        }

        private void Form61_MoneyRecharge_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.MemberId))
            {
                ShowWarnMsgBox(MessageConst.errMsg_DataError);
                this.Close();
                return;
            }

            // 根据会员ID取得会员信息
            this.memberInfo = memberLogic.GetMemberInfoByMemberID(this.MemberId,this.DBSession);
            
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
            this.lblBlance.Text = Convert.ToString(this.memberInfo.Balance) + "元";
            // 消费次数
            this.lblDealTime.Text = Convert.ToString(this.memberInfo.Leaving_Deal_time) + "次";
            // 可用时长
            this.lblRemainTime.Text = FormUtil.HourToMinute(this.memberInfo.Remaining_Time).ToString();

        }
        #endregion

        #region 设置按钮的状态
        /// <summary>
        /// 设置按钮的状态
        /// </summary>
        private void SetBtnStat()
        {
            if (CheckIsInput())
            {
                this.btnSave.Visible = true;
            }
            else
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region 检查充值项目是否输入内容
        /// <summary>
        /// 检查充值项目是否输入内容
        /// </summary>
        /// <returns></returns>
        private bool CheckIsInput()
        {
            bool res = false;

            if (this.spinBalance.Value != 0)
            {
                return true;
            }

            if (this.spinDealTime.Value != 0)
            {
                return true;
            }

            if (this.spinChgHours.Value != 0)
            {
                return true;
            }

            if (this.spinBonus.Value != 0)
            {
                return true;
            }

            return res;
        }
        #endregion


        #region 保存按钮按下
        /// <summary>
        /// 保存按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckIsInput())
            {
                ShowWarnMsgBox(MessageConst.errMsg_noInputCharge);
            }

            int hisId = 0;

            using(UnitOfWork uow = new UnitOfWork(Session.DefaultSession.DataLayer))
            {
                DateTime updateTime = DateTime.Now;                

                // 充值记录
                this.memChgHis = new t_Member_Charge_History(uow);
                this.memberInfo = memberLogic.GetMemberInfoByMemberID(this.MemberId, uow);

                memChgHis.Member_ID = this.memberInfo;
                memChgHis.Member_No = this.memberInfo.Member_No;
                // 操作者
                memChgHis.Operator_No = null;
                // 充值日期
                memChgHis.Charge_DateTime = updateTime;
                // 充现金
                memChgHis.Charge_Money = Convert.ToDouble(this.spinBalance.Value);

                // 会员余额 =  现有金额 + 充值金额 
                double leaveMoney = memberInfo.Balance + memChgHis.Charge_Money;
                memberInfo.Balance = leaveMoney;
                memChgHis.Balance = leaveMoney;

                // 充消费次数
                memChgHis.Charge_Deal_Time = Convert.ToInt32(this.spinDealTime.Value);

                // 剩余消费次数 =  现有消费次数 + 增加积分
                int dealTime = memberInfo.Leaving_Deal_time + memChgHis.Charge_Deal_Time;
                memberInfo.Leaving_Deal_time = dealTime;
                memChgHis.Deal_Time = dealTime;

                // 充小时
                memChgHis.Charge_UseTime = Convert.ToInt32(this.spinChgHours.Value);
                // 剩余可用小时数                
                int remainTime = this.memberInfo.Remaining_Time + memChgHis.Charge_UseTime;
                memChgHis.Remaining_Time = remainTime;
                memberInfo.Remaining_Time = remainTime;

                // 增加积分
                memChgHis.Charge_Bonus = Convert.ToInt32(this.spinBonus.Value);
                // 剩余积分 =  现有积分 + 增加积分
                int leaveBonus = memberInfo.Bouns + memChgHis.Charge_Bonus;
                memberInfo.Bouns = leaveBonus;
                memChgHis.Bonus = leaveBonus;

                // 备注
                memChgHis.Comment = string.IsNullOrEmpty(this.memoComment.Text.Trim()) ? null : this.memoComment.Text.Trim();
                // 实收现金
                memChgHis.YingShouCash = Convert.ToDouble(this.spinYingShou.Value);
                //数据状态-正常
                memChgHis.State = (int)RecordState.Normal;
                // 更新者
                memChgHis.Operator_No = SysParam.OperatorNo;

                // 更新时间
                memberInfo.Update_DateTime = updateTime;
                // 更新者
                memberInfo.Operator_No = SysParam.OperatorNo;

                try
                {
                    uow.ExplicitBeginTransaction();
                    uow.CommitChanges();

                    hisId = memChgHis.Charge_History_ID;


                    uow.ExplicitCommitTransaction();

                    // 充值成功
                    ShowInfoMsgBox(MessageConst.info_MemberChargeSuccess);
                }
                catch
                {
                    uow.ExplicitRollbackTransaction();
                    ShowWarnMsgBox(MessageConst.errMsg_chargeFaild);
                }

            }

            if (chkPrint.Checked)
            {
                // 打印小票
                //hisId  充值记录ID
            }
            this.Close();

        }
        #endregion

        #region 退出按钮事件
        /// <summary>
        /// 退出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        #region 注册快捷键
        /// <summary>
        /// 注册快捷键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form61_MemberRecharge_KeyDown(object sender, KeyEventArgs e)
        {
            // F5键-保存
            if (Keys.F5.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnSave_Click(sender, e);
                return;
            }
            else if (Keys.F4.Equals(e.KeyCode))
            {
                // F4键-退出
                this.Close();
            }
        }
        #endregion

        #region 充值项目输入框获得焦点事件
        private void spinBalance_Enter(object sender, EventArgs e)
        {
            this.spinBalance.SelectAll();
        }       

        private void spinDealTime_Enter(object sender, EventArgs e)
        {
            this.spinDealTime.SelectAll();
        }

        private void spinChgHours_Enter(object sender, EventArgs e)
        {
            this.spinChgHours.SelectAll();
        }

        private void spinBonus_Enter(object sender, EventArgs e)
        {
            this.spinBonus.SelectAll();
        }

        private void spinYingShou_Enter(object sender, EventArgs e)
        {
            this.spinYingShou.SelectAll();
        }

        #endregion



    }
}
