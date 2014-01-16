namespace shopsoft.main.UserControls
{
    partial class UC212_ConsumeRank
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.txtMemberNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnMemberImport = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemberGrade = new DevExpress.XtraEditors.LabelControl();
            this.cmbTime = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbConsumeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridCtrlConsumeRank = new DevExpress.XtraGrid.GridControl();
            this.gridViewRank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MemberNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumDeal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumDealCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumDealTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sumBonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Member_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsumeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsumeRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRank)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.dateEnd);
            this.panelControl1.Controls.Add(this.dateStart);
            this.panelControl1.Controls.Add(this.txtMemberNo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Controls.Add(this.btnPrint);
            this.panelControl1.Controls.Add(this.btnMemberImport);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lblMemberGrade);
            this.panelControl1.Controls.Add(this.cmbTime);
            this.panelControl1.Controls.Add(this.cmbConsumeType);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(975, 117);
            this.panelControl1.TabIndex = 0;
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(429, 23);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Properties.Appearance.Options.UseFont = true;
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEnd.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(117, 23);
            this.dateEnd.TabIndex = 17;
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(278, 23);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dateStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.Appearance.Options.UseFont = true;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.dateStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateStart.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateStart.Size = new System.Drawing.Size(117, 23);
            this.dateStart.TabIndex = 17;
            // 
            // txtMemberNo
            // 
            this.txtMemberNo.Location = new System.Drawing.Point(430, 69);
            this.txtMemberNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtMemberNo.Name = "txtMemberNo";
            this.txtMemberNo.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtMemberNo.Properties.Appearance.Options.UseFont = true;
            this.txtMemberNo.Properties.MaxLength = 30;
            this.txtMemberNo.Size = new System.Drawing.Size(269, 28);
            this.txtMemberNo.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl1.Location = new System.Drawing.Point(286, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 21);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "会员编号或姓名:";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Location = new System.Drawing.Point(709, 63);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 47);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "查询(F3)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrint.Image = global::shopsoft.main.Properties.Resources.printer24;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(825, 5);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 35);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "打印";
            // 
            // btnMemberImport
            // 
            this.btnMemberImport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberImport.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMemberImport.Appearance.Options.UseBackColor = true;
            this.btnMemberImport.Appearance.Options.UseFont = true;
            this.btnMemberImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMemberImport.Image = global::shopsoft.main.Properties.Resources.export24;
            this.btnMemberImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnMemberImport.Location = new System.Drawing.Point(899, 5);
            this.btnMemberImport.Margin = new System.Windows.Forms.Padding(5);
            this.btnMemberImport.Name = "btnMemberImport";
            this.btnMemberImport.Size = new System.Drawing.Size(70, 35);
            this.btnMemberImport.TabIndex = 6;
            this.btnMemberImport.Text = "导出";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl3.Location = new System.Drawing.Point(402, 21);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 21);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "至";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl2.Location = new System.Drawing.Point(37, 23);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "时间段:";
            // 
            // lblMemberGrade
            // 
            this.lblMemberGrade.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblMemberGrade.Location = new System.Drawing.Point(19, 72);
            this.lblMemberGrade.Margin = new System.Windows.Forms.Padding(5);
            this.lblMemberGrade.Name = "lblMemberGrade";
            this.lblMemberGrade.Size = new System.Drawing.Size(68, 21);
            this.lblMemberGrade.TabIndex = 1;
            this.lblMemberGrade.Text = "消费类型:";
            // 
            // cmbTime
            // 
            this.cmbTime.EditValue = "今天";
            this.cmbTime.Location = new System.Drawing.Point(106, 20);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.Properties.Appearance.Options.UseFont = true;
            this.cmbTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTime.Properties.Items.AddRange(new object[] {
            "今天",
            "昨天",
            "3天内",
            "7天内",
            "30天内",
            "指定时间"});
            this.cmbTime.Size = new System.Drawing.Size(153, 28);
            this.cmbTime.TabIndex = 0;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // cmbConsumeType
            // 
            this.cmbConsumeType.Location = new System.Drawing.Point(106, 69);
            this.cmbConsumeType.Name = "cmbConsumeType";
            this.cmbConsumeType.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsumeType.Properties.Appearance.Options.UseFont = true;
            this.cmbConsumeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbConsumeType.Properties.Items.AddRange(new object[] {
            "全部",
            "快速消费",
            "计次消费"});
            this.cmbConsumeType.Size = new System.Drawing.Size(153, 28);
            this.cmbConsumeType.TabIndex = 0;
            // 
            // gridCtrlConsumeRank
            // 
            this.gridCtrlConsumeRank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridCtrlConsumeRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCtrlConsumeRank.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCtrlConsumeRank.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridCtrlConsumeRank.EmbeddedNavigator.CausesValidation = false;
            this.gridCtrlConsumeRank.Location = new System.Drawing.Point(0, 117);
            this.gridCtrlConsumeRank.MainView = this.gridViewRank;
            this.gridCtrlConsumeRank.Margin = new System.Windows.Forms.Padding(0);
            this.gridCtrlConsumeRank.Name = "gridCtrlConsumeRank";
            this.gridCtrlConsumeRank.Size = new System.Drawing.Size(975, 466);
            this.gridCtrlConsumeRank.TabIndex = 2;
            this.gridCtrlConsumeRank.UseEmbeddedNavigator = true;
            this.gridCtrlConsumeRank.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRank});
            // 
            // gridViewRank
            // 
            this.gridViewRank.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridViewRank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MemberNo,
            this.MemberName,
            this.sumDealCash,
            this.sumDealTime,
            this.sumBonus,
            this.sumDeal,
            this.Member_ID});
            this.gridViewRank.GridControl = this.gridCtrlConsumeRank;
            this.gridViewRank.Name = "gridViewRank";
            this.gridViewRank.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRank.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRank.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewRank.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewRank.OptionsCustomization.AllowFilter = false;
            this.gridViewRank.OptionsCustomization.AllowGroup = false;
            this.gridViewRank.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewRank.OptionsFilter.AllowFilterEditor = false;
            this.gridViewRank.OptionsFind.AllowFindPanel = false;
            this.gridViewRank.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewRank.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewRank.OptionsMenu.EnableColumnMenu = false;
            this.gridViewRank.OptionsMenu.EnableFooterMenu = false;
            this.gridViewRank.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewRank.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewRank.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridViewRank.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewRank.OptionsView.ColumnAutoWidth = false;
            this.gridViewRank.OptionsView.ShowDetailButtons = false;
            this.gridViewRank.OptionsView.ShowFooter = true;
            this.gridViewRank.OptionsView.ShowGroupPanel = false;
            // 
            // MemberNo
            // 
            this.MemberNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberNo.Caption = "会员编号";
            this.MemberNo.FieldName = "Member_No";
            this.MemberNo.MaxWidth = 200;
            this.MemberNo.Name = "MemberNo";
            this.MemberNo.OptionsColumn.AllowEdit = false;
            this.MemberNo.OptionsColumn.AllowFocus = false;
            this.MemberNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MemberNo.OptionsColumn.FixedWidth = true;
            this.MemberNo.OptionsFilter.AllowAutoFilter = false;
            this.MemberNo.OptionsFilter.AllowFilter = false;
            this.MemberNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Member_No", "记录数：{0:n0}")});
            this.MemberNo.Visible = true;
            this.MemberNo.VisibleIndex = 0;
            this.MemberNo.Width = 100;
            // 
            // MemberName
            // 
            this.MemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberName.Caption = "姓名";
            this.MemberName.FieldName = "Member_Name";
            this.MemberName.MaxWidth = 75;
            this.MemberName.Name = "MemberName";
            this.MemberName.OptionsColumn.AllowEdit = false;
            this.MemberName.OptionsColumn.AllowFocus = false;
            this.MemberName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MemberName.OptionsColumn.FixedWidth = true;
            this.MemberName.OptionsFilter.AllowAutoFilter = false;
            this.MemberName.OptionsFilter.AllowFilter = false;
            this.MemberName.Visible = true;
            this.MemberName.VisibleIndex = 1;
            this.MemberName.Width = 73;
            // 
            // sumDeal
            // 
            this.sumDeal.AppearanceHeader.Options.UseTextOptions = true;
            this.sumDeal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumDeal.Caption = "消费频率(次）";
            this.sumDeal.FieldName = "sumDeal";
            this.sumDeal.Name = "sumDeal";
            this.sumDeal.OptionsColumn.AllowEdit = false;
            this.sumDeal.OptionsColumn.AllowFocus = false;
            this.sumDeal.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.sumDeal.OptionsColumn.FixedWidth = true;
            this.sumDeal.OptionsFilter.AllowAutoFilter = false;
            this.sumDeal.OptionsFilter.AllowFilter = false;
            this.sumDeal.Visible = true;
            this.sumDeal.VisibleIndex = 5;
            this.sumDeal.Width = 90;
            // 
            // sumDealCash
            // 
            this.sumDealCash.AppearanceHeader.Options.UseTextOptions = true;
            this.sumDealCash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumDealCash.Caption = "消费总金额";
            this.sumDealCash.FieldName = "sumDealCash";
            this.sumDealCash.MaxWidth = 80;
            this.sumDealCash.Name = "sumDealCash";
            this.sumDealCash.OptionsColumn.AllowEdit = false;
            this.sumDealCash.OptionsColumn.AllowFocus = false;
            this.sumDealCash.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.sumDealCash.OptionsColumn.FixedWidth = true;
            this.sumDealCash.OptionsFilter.AllowAutoFilter = false;
            this.sumDealCash.OptionsFilter.AllowFilter = false;
            this.sumDealCash.Visible = true;
            this.sumDealCash.VisibleIndex = 2;
            this.sumDealCash.Width = 70;
            // 
            // sumDealTime
            // 
            this.sumDealTime.AppearanceHeader.Options.UseTextOptions = true;
            this.sumDealTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumDealTime.Caption = "消费总次数";
            this.sumDealTime.FieldName = "sumDealTime";
            this.sumDealTime.Name = "sumDealTime";
            this.sumDealTime.OptionsColumn.AllowEdit = false;
            this.sumDealTime.OptionsColumn.AllowFocus = false;
            this.sumDealTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.sumDealTime.OptionsFilter.AllowAutoFilter = false;
            this.sumDealTime.OptionsFilter.AllowFilter = false;
            this.sumDealTime.Visible = true;
            this.sumDealTime.VisibleIndex = 3;
            // 
            // sumBonus
            // 
            this.sumBonus.AppearanceHeader.Options.UseTextOptions = true;
            this.sumBonus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.sumBonus.Caption = "获得总积分";
            this.sumBonus.FieldName = "sumBonus";
            this.sumBonus.MaxWidth = 75;
            this.sumBonus.Name = "sumBonus";
            this.sumBonus.OptionsColumn.AllowEdit = false;
            this.sumBonus.OptionsColumn.AllowFocus = false;
            this.sumBonus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.sumBonus.OptionsColumn.FixedWidth = true;
            this.sumBonus.OptionsFilter.AllowAutoFilter = false;
            this.sumBonus.OptionsFilter.AllowFilter = false;
            this.sumBonus.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_Bonus", "{0:n0}分")});
            this.sumBonus.Visible = true;
            this.sumBonus.VisibleIndex = 4;
            this.sumBonus.Width = 71;
            // 
            // Member_ID
            // 
            this.Member_ID.Caption = "会员ID";
            this.Member_ID.FieldName = "Member_ID.Member_ID";
            this.Member_ID.Name = "Member_ID";
            // 
            // UC212_ConsumeRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCtrlConsumeRank);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC212_ConsumeRank";
            this.Size = new System.Drawing.Size(975, 583);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemberNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbConsumeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsumeRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridCtrlConsumeRank;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRank;
        private DevExpress.XtraGrid.Columns.GridColumn MemberNo;
        private DevExpress.XtraGrid.Columns.GridColumn MemberName;
        private DevExpress.XtraGrid.Columns.GridColumn sumDeal;
        private DevExpress.XtraGrid.Columns.GridColumn sumDealCash;
        private DevExpress.XtraGrid.Columns.GridColumn sumDealTime;
        private DevExpress.XtraGrid.Columns.GridColumn sumBonus;
        private DevExpress.XtraGrid.Columns.GridColumn Member_ID;
        private DevExpress.XtraEditors.ComboBoxEdit cmbConsumeType;
        private DevExpress.XtraEditors.LabelControl lblMemberGrade;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnMemberImport;
        private DevExpress.XtraEditors.TextEdit txtMemberNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTime;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
