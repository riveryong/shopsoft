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
using shopsoft.common.Logic;
using shopsoft.common.Const;
using DevExpress.Xpo;
using shopsoft.common;

namespace shopsoft.main.MemberManage
{
    public partial class From092_BonusMerger : BaseForm
    {

        #region Logic信息
        // 会员信息
        private readonly MemberLogic memberLogic = new MemberLogic();
        #endregion

        #region 私有属性
        // 会员信息
        private t_Member_Info mInfo1;
        private t_Member_Info mInfo2;
        // 店铺信息
        private t_Store_Info storeInfo = null;
        // 会员积分兑换
        private t_Bonus_Exchange_History bonusExHis1;
        public t_Bonus_Exchange_History bonusExHis2;

        // 会员ID
        private string memberId1 = string.Empty;
        // 会员积分
        private int Bonus1 = 0;
        private int Bonus2 = 0;
        // 积分兑换记录ID
        private int hisId = 0;
        #endregion

        #region 初始化
        public From092_BonusMerger()
        {
            InitializeComponent();
        }

        public From092_BonusMerger(string mId):this()
        {
            this.memberId1 = mId;
 
        }

        private void From92_BonusMerger_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.memberId1))
            {
                return;
            }

            // 根据会员ID取得会员信息
            this.mInfo1 = memberLogic.GetMemberInfoByMemberID(this.memberId1, this.DBSession);

            if (mInfo1 != null)
            {
                // 会员编号
                this.txtMemberNo1.Text = this.mInfo1.Member_No;
                // 会员姓名
                this.lblMemberName1.Text = this.mInfo1.Member_Name;
                // 会员积分
                this.Bonus1 = this.mInfo1.Bouns;
                this.lblBouns1.Text = Convert.ToString(this.mInfo1.Bouns) + "分";
            }
            else
            {
                ShowWarnMsgBox(MessageConst.errMsg_memberExited);
                this.txtMemberNo1.Focus();
                this.txtMemberNo1.SelectAll();
                return;
            }
        }
        #endregion

        #region 会员卡1的按钮事件
        /// <summary>
        /// 会员卡1的确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMemberNo1.Text))
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_NoInput, "卡①"));
                this.txtMemberNo1.Focus();
                return;
            }

            // 根据会员ID取得会员信息
            this.mInfo1 = memberLogic.GetMemberInfoByMemberNo(this.txtMemberNo1.Text, this.DBSession);

            if (mInfo1 != null)
            {
                // 会员编号
                this.txtMemberNo1.Text = this.mInfo1.Member_No;
                // 会员姓名
                this.lblMemberName1.Text = this.mInfo1.Member_Name;
                // 会员积分
                this.Bonus1 = this.mInfo1.Bouns;
                this.lblBouns1.Text = Convert.ToString(this.mInfo1.Bouns) + "分";
            }
            else
            {
                ShowWarnMsgBox(MessageConst.errMsg_memberExited);
                this.txtMemberNo1.Focus();
                this.txtMemberNo1.SelectAll();
                return;
            }
        }
        
        /// <summary>
        /// 会员卡1的清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear1_Click(object sender, EventArgs e)
        {
            this.mInfo1 = null;
            this.Bonus1 = 0;
            this.txtMemberNo1.Text = string.Empty;
            this.lblBouns1.Text = string.Empty;
            this.lblMemberName1.Text = string.Empty;
        }

        /// <summary>
        /// 会员卡号1 键盘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMemberNo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnOK1_Click(sender, e); 
            }
        }
        #endregion


        #region 会员卡2的按钮事件
        /// <summary>
        /// 会员卡2的确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtMemberNo2.Text))
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_NoInput, "卡②"));
                this.txtMemberNo2.Focus();
                return;
            }

            // 根据会员ID取得会员信息
            this.mInfo2 = memberLogic.GetMemberInfoByMemberNo(this.txtMemberNo2.Text, this.DBSession);

            if (mInfo2 != null)
            {
                // 会员编号
                this.txtMemberNo2.Text = this.mInfo2.Member_No;
                // 会员姓名
                this.lblMemberName2.Text = this.mInfo2.Member_Name;
                // 会员积分
                this.Bonus2 = this.mInfo2.Bouns;
                this.lblBouns2.Text = Convert.ToString(this.mInfo2.Bouns) + "分";
            }
            else
            {
                ShowWarnMsgBox(MessageConst.errMsg_memberExited);
                this.txtMemberNo2.Focus();
                this.txtMemberNo2.SelectAll();
                return;
            }
        }
        
        /// <summary>
        /// 会员卡2的清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear2_Click(object sender, EventArgs e)
        {
            this.mInfo2 = null;
            this.Bonus2 = 0;
            this.txtMemberNo2.Text = string.Empty;
            this.lblBouns2.Text = string.Empty;
            this.lblMemberName2.Text = string.Empty;
        }

        /// <summary>
        /// 会员卡2 键盘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMemberNo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnOK2_Click(sender, e);
            }
        }
        #endregion


        #region 积分合并按钮
        // 卡1合并到卡2
        private void btnMerger1_Click(object sender, EventArgs e)
        {
            if (!checkCardInfo()) return;

            if (InsertBonusMergerHistory(mInfo1.Member_ID.ToString(), mInfo2.Member_ID.ToString()))
            {
                if(chkIsPrint.Checked)
                {
                    // 打印小票this.hisId;
                }
                this.Close();
            }
        }

        // 卡2合并到卡1
        private void btnMerger2_Click(object sender, EventArgs e)
        {
            if (!checkCardInfo()) return;

            if (InsertBonusMergerHistory(mInfo2.Member_ID.ToString(), mInfo1.Member_ID.ToString()))
            {
                if (chkIsPrint.Checked)
                {
                    // 打印小票this.hisId;
                }
                this.Close();
            }
        }

        // 检查卡①、②的信息
        private bool checkCardInfo()
        {
            bool res = false;

            // 检查卡①
            if (string.IsNullOrEmpty(this.txtMemberNo1.Text))
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_NoInput, "卡①"));
                this.txtMemberNo1.Focus();
                return res;
            }

            if (mInfo1 == null)
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_ErrorData, "卡①"));

                this.txtMemberNo1.Focus();
                return res;
            }

            // 检查卡②
            if (string.IsNullOrEmpty(this.txtMemberNo2.Text))
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_NoInput, "卡②"));
                this.txtMemberNo2.Focus();
                return res;
            }

            if (mInfo2 == null)
            {
                ShowWarnMsgBox(string.Format(MessageConst.errMsg_BonusMeger_ErrorData, "卡②"));
                this.txtMemberNo2.Focus();
                return res;
            }

            return true;
 
        }

        // 积分合并的DB操作  m1：积分并入的会员卡；m2:积分清空的会员卡;
        private bool InsertBonusMergerHistory(string m1id, string m2id)
        {
            bool res = false;
            
            // 积分 b1:是会员M1的积分；b2:是会员M2的积分
            int b1,b2;

            using (UnitOfWork uow = new UnitOfWork(DBSession.DataLayer))
            {
                DateTime updateTime = DateTime.Now;
                // 积分兑换历史记录
                this.bonusExHis1 = new t_Bonus_Exchange_History(uow);
                this.bonusExHis2 = new t_Bonus_Exchange_History(uow);
                // 会员信息
                t_Member_Info m1 = memberLogic.GetMemberInfoByMemberID(m1id, uow);
                t_Member_Info m2 = memberLogic.GetMemberInfoByMemberID(m2id, uow);
                b1 = m1.Bouns;
                b2 = m2.Bouns;

                // 会员1信息
                this.bonusExHis1.Member_ID = m1;
                this.bonusExHis1.Member_No = m1.Member_No;

                this.bonusExHis2.Member_ID = m2;
                this.bonusExHis2.Member_No = m2.Member_No;

                // 兑换日期
                this.bonusExHis1.Exchange_DateTime = updateTime;
                this.bonusExHis2.Exchange_DateTime = updateTime;

                // 合并积分数
                this.bonusExHis1.Bonus_Num = -1 * b2; // 增加积分
                this.bonusExHis2.Bonus_Num = b2; // 扣除积分
                // 合并后剩余积分
                m1.Bouns = b1 + b2;
                m2.Bouns = 0;

                // 兑换金额
                this.bonusExHis1.Money_Num = 0;
                this.bonusExHis2.Money_Num = 0;

                // 合并后剩余金额
                this.bonusExHis1.Surplus_Money = m1.Balance;
                this.bonusExHis2.Surplus_Money = m2.Balance;

                // 兑换类别:积分合并
                this.bonusExHis1.Bonus_Type = BonusExchangeType.BonusMerger;
                this.bonusExHis2.Bonus_Type = BonusExchangeType.BonusMerger;

                // 备注
                this.bonusExHis1.Comment = this.memoRemark1.Text;
                this.bonusExHis2.Comment = this.memoRemark2.Text;

                //数据状态-正常
                this.bonusExHis1.State = (int)RecordState.Normal;
                this.bonusExHis2.State = (int)RecordState.Normal;
                // 更新者
                this.bonusExHis1.Operator_No = SysParam.OperatorNo;
                this.bonusExHis2.Operator_No = SysParam.OperatorNo;
                m1.Operator_No = SysParam.OperatorNo;
                m2.Operator_No = SysParam.OperatorNo;
                // 更新时间
                m1.Update_DateTime = updateTime;
                m2.Update_DateTime = updateTime;

                try
                {
                    uow.ExplicitBeginTransaction();
                    uow.CommitChanges();

                    hisId = this.bonusExHis1.Exchange_History_ID;

                    uow.ExplicitCommitTransaction();

                    // 积分合并成功
                    ShowInfoMsgBox(MessageConst.info_bonusMegerSuccess);
                    res = true;
                }
                catch
                {
                    // 积分合并失败
                    uow.ExplicitRollbackTransaction();
                    ShowWarnMsgBox(MessageConst.errMsg_BonusMegerFaild);
                }
            }

            return res;
 
        }
        #endregion


        #region 注册快捷键
        private void From92_BonusMerger_KeyDown(object sender, KeyEventArgs e)
        {
            // F5键-卡1合并到卡2
            if (Keys.F5.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnMerger1_Click(sender, e);
                return;
            }

            // F6-卡2合并到卡1
            if (Keys.F6.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnMerger2_Click(sender, e);
                this.Close();
            }
        }
        #endregion

        

    }
}
