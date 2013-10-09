namespace shopsoft.main.UserControls
{
    partial class UC211_ConsumeDetail
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
            this.gridCtrlConsume = new DevExpress.XtraGrid.GridControl();
            this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MemberNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DealDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YingShouMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YouHuiMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShiShouCash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ShouDaocash = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LooseCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KouChuCardBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LeaveBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KouChuDealTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LeaveDealTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GetBonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PayType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comment = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
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
            // gridCtrlConsume
            // 
            this.gridCtrlConsume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridCtrlConsume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlConsume.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCtrlConsume.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridCtrlConsume.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridCtrlConsume.EmbeddedNavigator.CausesValidation = false;
            this.gridCtrlConsume.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.End;
            this.gridCtrlConsume.Location = new System.Drawing.Point(0, 117);
            this.gridCtrlConsume.MainView = this.gridViewMembers;
            this.gridCtrlConsume.Margin = new System.Windows.Forms.Padding(0);
            this.gridCtrlConsume.Name = "gridCtrlConsume";
            this.gridCtrlConsume.Size = new System.Drawing.Size(975, 466);
            this.gridCtrlConsume.TabIndex = 2;
            this.gridCtrlConsume.UseEmbeddedNavigator = true;
            this.gridCtrlConsume.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
            // 
            // gridViewMembers
            // 
            this.gridViewMembers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MemberNo,
            this.MemberName,
            this.DealDateTime,
            this.YingShouMoney,
            this.YouHuiMoney,
            this.ShiShouCash,
            this.ShouDaocash,
            this.LooseCharge,
            this.KouChuCardBalance,
            this.LeaveBalance,
            this.KouChuDealTime,
            this.LeaveDealTime,
            this.GetBonus,
            this.PayType,
            this.Comment,
            this.Member_ID});
            this.gridViewMembers.GridControl = this.gridCtrlConsume;
            this.gridViewMembers.Name = "gridViewMembers";
            this.gridViewMembers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMembers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMembers.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMembers.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewMembers.OptionsCustomization.AllowFilter = false;
            this.gridViewMembers.OptionsCustomization.AllowGroup = false;
            this.gridViewMembers.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewMembers.OptionsFilter.AllowFilterEditor = false;
            this.gridViewMembers.OptionsFind.AllowFindPanel = false;
            this.gridViewMembers.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewMembers.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewMembers.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMembers.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMembers.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMembers.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewMembers.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gridViewMembers.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridViewMembers.OptionsView.ColumnAutoWidth = false;
            this.gridViewMembers.OptionsView.ShowDetailButtons = false;
            this.gridViewMembers.OptionsView.ShowFooter = true;
            this.gridViewMembers.OptionsView.ShowGroupPanel = false;
            // 
            // MemberNo
            // 
            this.MemberNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberNo.Caption = "会员编号";
            this.MemberNo.FieldName = "Member_ID.Member_No";
            this.MemberNo.MaxWidth = 200;
            this.MemberNo.Name = "MemberNo";
            this.MemberNo.OptionsColumn.AllowEdit = false;
            this.MemberNo.OptionsColumn.AllowFocus = false;
            this.MemberNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MemberNo.OptionsColumn.FixedWidth = true;
            this.MemberNo.OptionsFilter.AllowAutoFilter = false;
            this.MemberNo.OptionsFilter.AllowFilter = false;
            this.MemberNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Member_ID.Member_No", "记录数：{0:n0}")});
            this.MemberNo.Visible = true;
            this.MemberNo.VisibleIndex = 0;
            this.MemberNo.Width = 100;
            // 
            // MemberName
            // 
            this.MemberName.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberName.Caption = "姓名";
            this.MemberName.FieldName = "Member_ID.Member_Name";
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
            // DealDateTime
            // 
            this.DealDateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.DealDateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DealDateTime.Caption = "消费时间";
            this.DealDateTime.FieldName = "Deal_DateTime";
            this.DealDateTime.Name = "DealDateTime";
            this.DealDateTime.OptionsColumn.AllowEdit = false;
            this.DealDateTime.OptionsColumn.AllowFocus = false;
            this.DealDateTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.DealDateTime.OptionsColumn.FixedWidth = true;
            this.DealDateTime.OptionsFilter.AllowAutoFilter = false;
            this.DealDateTime.OptionsFilter.AllowFilter = false;
            this.DealDateTime.Visible = true;
            this.DealDateTime.VisibleIndex = 2;
            // 
            // YingShouMoney
            // 
            this.YingShouMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.YingShouMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.YingShouMoney.Caption = "消费金额";
            this.YingShouMoney.FieldName = "YingShou_Money";
            this.YingShouMoney.MaxWidth = 80;
            this.YingShouMoney.Name = "YingShouMoney";
            this.YingShouMoney.OptionsColumn.AllowEdit = false;
            this.YingShouMoney.OptionsColumn.AllowFocus = false;
            this.YingShouMoney.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.YingShouMoney.OptionsColumn.FixedWidth = true;
            this.YingShouMoney.OptionsFilter.AllowAutoFilter = false;
            this.YingShouMoney.OptionsFilter.AllowFilter = false;
            this.YingShouMoney.Visible = true;
            this.YingShouMoney.VisibleIndex = 3;
            this.YingShouMoney.Width = 70;
            // 
            // YouHuiMoney
            // 
            this.YouHuiMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.YouHuiMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.YouHuiMoney.Caption = "优惠";
            this.YouHuiMoney.FieldName = "YouHui_Money";
            this.YouHuiMoney.Name = "YouHuiMoney";
            this.YouHuiMoney.OptionsColumn.AllowEdit = false;
            this.YouHuiMoney.OptionsColumn.AllowFocus = false;
            this.YouHuiMoney.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.YouHuiMoney.OptionsColumn.FixedWidth = true;
            this.YouHuiMoney.OptionsFilter.AllowAutoFilter = false;
            this.YouHuiMoney.OptionsFilter.AllowFilter = false;
            this.YouHuiMoney.Visible = true;
            this.YouHuiMoney.VisibleIndex = 4;
            this.YouHuiMoney.Width = 70;
            // 
            // ShiShouCash
            // 
            this.ShiShouCash.AppearanceHeader.Options.UseTextOptions = true;
            this.ShiShouCash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ShiShouCash.Caption = "应收";
            this.ShiShouCash.FieldName = "ShiShou_Cash";
            this.ShiShouCash.Name = "ShiShouCash";
            this.ShiShouCash.OptionsColumn.AllowEdit = false;
            this.ShiShouCash.OptionsColumn.AllowFocus = false;
            this.ShiShouCash.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ShiShouCash.OptionsColumn.FixedWidth = true;
            this.ShiShouCash.OptionsFilter.AllowAutoFilter = false;
            this.ShiShouCash.OptionsFilter.AllowFilter = false;
            this.ShiShouCash.Visible = true;
            this.ShiShouCash.VisibleIndex = 5;
            // 
            // ShouDaocash
            // 
            this.ShouDaocash.AppearanceHeader.Options.UseTextOptions = true;
            this.ShouDaocash.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ShouDaocash.Caption = "实收";
            this.ShouDaocash.FieldName = "ShouDao_cash";
            this.ShouDaocash.Name = "ShouDaocash";
            this.ShouDaocash.OptionsColumn.AllowEdit = false;
            this.ShouDaocash.OptionsColumn.AllowFocus = false;
            this.ShouDaocash.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ShouDaocash.OptionsColumn.FixedWidth = true;
            this.ShouDaocash.OptionsFilter.AllowAutoFilter = false;
            this.ShouDaocash.OptionsFilter.AllowFilter = false;
            this.ShouDaocash.Visible = true;
            this.ShouDaocash.VisibleIndex = 6;
            // 
            // LooseCharge
            // 
            this.LooseCharge.AppearanceHeader.Options.UseTextOptions = true;
            this.LooseCharge.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LooseCharge.Caption = "找零";
            this.LooseCharge.FieldName = "LooseCharge";
            this.LooseCharge.Name = "LooseCharge";
            this.LooseCharge.OptionsColumn.AllowEdit = false;
            this.LooseCharge.OptionsColumn.AllowFocus = false;
            this.LooseCharge.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.LooseCharge.OptionsFilter.AllowAutoFilter = false;
            this.LooseCharge.OptionsFilter.AllowFilter = false;
            this.LooseCharge.Visible = true;
            this.LooseCharge.VisibleIndex = 7;
            // 
            // KouChuCardBalance
            // 
            this.KouChuCardBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.KouChuCardBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KouChuCardBalance.Caption = "扣除卡内金额";
            this.KouChuCardBalance.FieldName = "KouChu_Card_Balance";
            this.KouChuCardBalance.Name = "KouChuCardBalance";
            this.KouChuCardBalance.OptionsColumn.AllowEdit = false;
            this.KouChuCardBalance.OptionsColumn.AllowFocus = false;
            this.KouChuCardBalance.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.KouChuCardBalance.OptionsColumn.FixedWidth = true;
            this.KouChuCardBalance.OptionsFilter.AllowAutoFilter = false;
            this.KouChuCardBalance.OptionsFilter.AllowFilter = false;
            this.KouChuCardBalance.Visible = true;
            this.KouChuCardBalance.VisibleIndex = 8;
            this.KouChuCardBalance.Width = 80;
            // 
            // LeaveBalance
            // 
            this.LeaveBalance.AppearanceHeader.Options.UseTextOptions = true;
            this.LeaveBalance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LeaveBalance.Caption = "卡内余额";
            this.LeaveBalance.FieldName = "Leave_Balance";
            this.LeaveBalance.Name = "LeaveBalance";
            this.LeaveBalance.OptionsColumn.AllowEdit = false;
            this.LeaveBalance.OptionsColumn.AllowFocus = false;
            this.LeaveBalance.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.LeaveBalance.OptionsColumn.FixedWidth = true;
            this.LeaveBalance.OptionsFilter.AllowAutoFilter = false;
            this.LeaveBalance.OptionsFilter.AllowFilter = false;
            this.LeaveBalance.Visible = true;
            this.LeaveBalance.VisibleIndex = 9;
            // 
            // KouChuDealTime
            // 
            this.KouChuDealTime.AppearanceHeader.Options.UseTextOptions = true;
            this.KouChuDealTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KouChuDealTime.Caption = "扣除次数";
            this.KouChuDealTime.FieldName = "KouChu_Deal_Time";
            this.KouChuDealTime.Name = "KouChuDealTime";
            this.KouChuDealTime.OptionsColumn.AllowEdit = false;
            this.KouChuDealTime.OptionsColumn.AllowFocus = false;
            this.KouChuDealTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.KouChuDealTime.OptionsFilter.AllowAutoFilter = false;
            this.KouChuDealTime.OptionsFilter.AllowFilter = false;
            this.KouChuDealTime.Visible = true;
            this.KouChuDealTime.VisibleIndex = 11;
            // 
            // LeaveDealTime
            // 
            this.LeaveDealTime.AppearanceHeader.Options.UseTextOptions = true;
            this.LeaveDealTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LeaveDealTime.Caption = "剩余次数";
            this.LeaveDealTime.FieldName = "Leave_Deal_Time";
            this.LeaveDealTime.Name = "LeaveDealTime";
            this.LeaveDealTime.OptionsColumn.AllowEdit = false;
            this.LeaveDealTime.OptionsColumn.AllowFocus = false;
            this.LeaveDealTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.LeaveDealTime.OptionsFilter.AllowAutoFilter = false;
            this.LeaveDealTime.OptionsFilter.AllowFilter = false;
            this.LeaveDealTime.Visible = true;
            this.LeaveDealTime.VisibleIndex = 10;
            // 
            // GetBonus
            // 
            this.GetBonus.AppearanceHeader.Options.UseTextOptions = true;
            this.GetBonus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GetBonus.Caption = "获得积分";
            this.GetBonus.FieldName = "Get_Bonus";
            this.GetBonus.MaxWidth = 75;
            this.GetBonus.Name = "GetBonus";
            this.GetBonus.OptionsColumn.AllowEdit = false;
            this.GetBonus.OptionsColumn.AllowFocus = false;
            this.GetBonus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.GetBonus.OptionsColumn.FixedWidth = true;
            this.GetBonus.OptionsFilter.AllowAutoFilter = false;
            this.GetBonus.OptionsFilter.AllowFilter = false;
            this.GetBonus.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_Bonus", "{0:n0}分")});
            this.GetBonus.Visible = true;
            this.GetBonus.VisibleIndex = 12;
            this.GetBonus.Width = 71;
            // 
            // PayType
            // 
            this.PayType.AppearanceHeader.Options.UseTextOptions = true;
            this.PayType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PayType.Caption = "消费类型";
            this.PayType.FieldName = "Pay_Type";
            this.PayType.Name = "PayType";
            this.PayType.OptionsColumn.AllowEdit = false;
            this.PayType.OptionsColumn.AllowFocus = false;
            this.PayType.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.PayType.OptionsColumn.FixedWidth = true;
            this.PayType.OptionsFilter.AllowAutoFilter = false;
            this.PayType.OptionsFilter.AllowFilter = false;
            this.PayType.Visible = true;
            this.PayType.VisibleIndex = 13;
            // 
            // Comment
            // 
            this.Comment.AppearanceHeader.Options.UseTextOptions = true;
            this.Comment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Comment.Caption = "备  注";
            this.Comment.FieldName = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.OptionsColumn.AllowEdit = false;
            this.Comment.OptionsColumn.AllowFocus = false;
            this.Comment.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Comment.OptionsFilter.AllowAutoFilter = false;
            this.Comment.OptionsFilter.AllowFilter = false;
            this.Comment.Visible = true;
            this.Comment.VisibleIndex = 14;
            this.Comment.Width = 200;
            // 
            // Member_ID
            // 
            this.Member_ID.Caption = "会员ID";
            this.Member_ID.FieldName = "Member_ID.Member_ID";
            this.Member_ID.Name = "Member_ID";
            // 
            // UC211_ConsumeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCtrlConsume);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC211_ConsumeDetail";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridCtrlConsume;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
        private DevExpress.XtraGrid.Columns.GridColumn MemberNo;
        private DevExpress.XtraGrid.Columns.GridColumn MemberName;
        private DevExpress.XtraGrid.Columns.GridColumn DealDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn YingShouMoney;
        private DevExpress.XtraGrid.Columns.GridColumn YouHuiMoney;
        private DevExpress.XtraGrid.Columns.GridColumn ShiShouCash;
        private DevExpress.XtraGrid.Columns.GridColumn ShouDaocash;
        private DevExpress.XtraGrid.Columns.GridColumn LooseCharge;
        private DevExpress.XtraGrid.Columns.GridColumn KouChuCardBalance;
        private DevExpress.XtraGrid.Columns.GridColumn LeaveBalance;
        private DevExpress.XtraGrid.Columns.GridColumn KouChuDealTime;
        private DevExpress.XtraGrid.Columns.GridColumn LeaveDealTime;
        private DevExpress.XtraGrid.Columns.GridColumn GetBonus;
        private DevExpress.XtraGrid.Columns.GridColumn PayType;
        private DevExpress.XtraGrid.Columns.GridColumn Comment;
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
