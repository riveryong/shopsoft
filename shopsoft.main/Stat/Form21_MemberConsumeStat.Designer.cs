namespace shopsoft.main.Stat
{
    partial class Form21_MemberConsumeStat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlStat = new DevExpress.XtraTab.XtraTabControl();
            this.tabConsumeDetail = new DevExpress.XtraTab.XtraTabPage();
            this.uC211_ConsumeDetail1 = new shopsoft.main.UserControls.UC211_ConsumeDetail();
            this.tabConsumeList = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.DBSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlStat)).BeginInit();
            this.TabControlStat.SuspendLayout();
            this.tabConsumeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlStat
            // 
            this.TabControlStat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TabControlStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlStat.Location = new System.Drawing.Point(0, 0);
            this.TabControlStat.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlStat.Name = "TabControlStat";
            this.TabControlStat.SelectedTabPage = this.tabConsumeDetail;
            this.TabControlStat.Size = new System.Drawing.Size(984, 542);
            this.TabControlStat.TabIndex = 0;
            this.TabControlStat.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabConsumeDetail,
            this.tabConsumeList});
            // 
            // tabConsumeDetail
            // 
            this.tabConsumeDetail.AlwaysScrollActiveControlIntoView = false;
            this.tabConsumeDetail.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsumeDetail.Appearance.Header.Options.UseFont = true;
            this.tabConsumeDetail.Controls.Add(this.uC211_ConsumeDetail1);
            this.tabConsumeDetail.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabConsumeDetail.Margin = new System.Windows.Forms.Padding(0);
            this.tabConsumeDetail.Name = "tabConsumeDetail";
            this.tabConsumeDetail.Size = new System.Drawing.Size(978, 508);
            this.tabConsumeDetail.Text = "会员消费明细";
            // 
            // uC211_ConsumeDetail1
            // 
            this.uC211_ConsumeDetail1.dbsession = null;
            this.uC211_ConsumeDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC211_ConsumeDetail1.Location = new System.Drawing.Point(0, 0);
            this.uC211_ConsumeDetail1.Margin = new System.Windows.Forms.Padding(0);
            this.uC211_ConsumeDetail1.Name = "uC211_ConsumeDetail1";
            this.uC211_ConsumeDetail1.Size = new System.Drawing.Size(978, 508);
            this.uC211_ConsumeDetail1.TabIndex = 0;
            // 
            // tabConsumeList
            // 
            this.tabConsumeList.Appearance.Header.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsumeList.Appearance.Header.Options.UseFont = true;
            this.tabConsumeList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsumeList.Name = "tabConsumeList";
            this.tabConsumeList.Size = new System.Drawing.Size(978, 508);
            this.tabConsumeList.Text = "会员消费排行";
            // 
            // Form21_MemberConsumeStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 542);
            this.Controls.Add(this.TabControlStat);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Name = "Form21_MemberConsumeStat";
            this.Text = "Form21_MemberConsumeStat";
            this.Load += new System.EventHandler(this.Form21_MemberConsumeStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlStat)).EndInit();
            this.TabControlStat.ResumeLayout(false);
            this.tabConsumeDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlStat;
        private DevExpress.XtraTab.XtraTabPage tabConsumeDetail;
        private DevExpress.XtraTab.XtraTabPage tabConsumeList;
        private UserControls.UC211_ConsumeDetail uC211_ConsumeDetail1;
    }
}