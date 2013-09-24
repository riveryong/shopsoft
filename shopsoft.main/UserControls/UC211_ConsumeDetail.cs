using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;
using shopsoft.common.Logic;
using DevExpress.Xpo;
using shopsoft.common.DB;

namespace shopsoft.main.UserControls
{
    public partial class UC211_ConsumeDetail : BaseUserControl
    {
        #region Logic信息
        private MemberDealHistoryLogic dealHisLogic = new MemberDealHistoryLogic();
        #endregion

        #region 私有信息
        DateTime startTime = DateTime.MinValue;
        DateTime endTime = DateTime.MinValue;
        #endregion


        public UC211_ConsumeDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.MinValue;
            DateTime endTime = DateTime.MinValue;
            int sIdx = this.cmbTime.SelectedIndex;
            if(this.cmbTime.SelectedIndex > -1)// 选择时间段
            {
                /* 0今天;1三天;2七天;3一个月;4指定时间;*/
                switch (sIdx)
                {
                    case 0: break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    default: break;
                }

            }

            XPCollection<t_Member_Deal_History> collection = dealHisLogic.SearchDealHistoryList(this.txtMemberNo.Text.Trim(), this.cmbConsumeType.SelectedIndex, startTime, endTime);

            this.gridCtrlConsume.DataSource = collection;

        }

        /// <summary>
        /// 时间段改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sIdx = this.cmbTime.SelectedIndex;
            switch (sIdx)
            {
                case 0: break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                default: break;
            }

        }

    }
}
