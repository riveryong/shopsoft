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
    public partial class UC212_ConsumeRank : BaseUserControl
    {
        #region 私有信息
        DateTime startTime = DateTime.MinValue;
        DateTime endTime = DateTime.MinValue;
        #endregion
		
        #region Logic信息
        private readonly MemberDealHistoryLogic dealLgic = new MemberDealHistoryLogic();
        #endregion


        public UC212_ConsumeRank()
        {
            InitializeComponent();
        }

        #region DBSession
        private Session _dbsession = null;

        public Session dbsession
        {
            set
            {
                this._dbsession = value;
            }

            get
            {
                return this._dbsession;
            }
        }
        #endregion

        #region 时间段 选择事件
        /// <summary>
        /// 时间段改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sIdx = this.cmbTime.SelectedIndex;
            /*
                今天1
                昨天2
                3天内3
                7天内4
                30天内5
                指定时间6
             */
            switch (sIdx)
            {
                case 0:
                    {
                        this.dateStart.Visible = true;
                        this.dateEnd.Visible = true;
                        this.labelControl3.Visible = true;
                        break;
                    }
                case 1: startTime = DateTime.Now;
                    break;
                    //  时间段指定需要修改，应该指定为这天的0点0分0秒
                case 2: startTime = DateTime.Now.AddDays(-1); break;
                case 3: startTime = DateTime.Now.AddDays(-1); break;
                case 4: startTime = DateTime.Now.AddDays(-1); break;
                case 5: startTime = DateTime.Now.AddDays(-1); break;
                case 6: startTime = DateTime.Now.AddDays(-1); break;
                default: break;
            }

        }
        #endregion

        /// <summary>
        /// 查询按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = dealLgic.statDealHistory(txtMemberNo.Text.Trim(), 
                cmbConsumeType.SelectedIndex, startTime, endTime);

            this.gridCtrlConsumeRank.DataSource = dt;
        }

    }
}
