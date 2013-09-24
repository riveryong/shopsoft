namespace shopsoft.main.MemberManage
{
    partial class Form04_MemberManage
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
            this.components = new System.ComponentModel.Container();
            this.pnlOperation = new DevExpress.XtraEditors.PanelControl();
            this.txtSearchCondition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMemberGrade = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblMemberGrade = new DevExpress.XtraEditors.LabelControl();
            this.btnMoneyRecharge = new DevExpress.XtraEditors.SimpleButton();
            this.btnMemberExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnMemberImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteMember = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifyMember = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateMember = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.pnlSearchResult = new DevExpress.XtraEditors.PanelControl();
            this.gridCtrlMembers = new DevExpress.XtraGrid.GridControl();
            this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MemberNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Member_Grade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bouns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LeavingDealtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RemainingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BirthdayMonthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Member_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipGridMember = new DevExpress.Utils.ToolTipController(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlSearchCondition = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).BeginInit();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMemberGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchResult)).BeginInit();
            this.pnlSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchCondition)).BeginInit();
            this.pnlSearchCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.txtSearchCondition);
            this.pnlOperation.Controls.Add(this.labelControl1);
            this.pnlOperation.Controls.Add(this.cmbMemberGrade);
            this.pnlOperation.Controls.Add(this.btnSearch);
            this.pnlOperation.Controls.Add(this.lblMemberGrade);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(1000, 70);
            this.pnlOperation.TabIndex = 0;
            // 
            // txtSearchCondition
            // 
            this.txtSearchCondition.Location = new System.Drawing.Point(401, 19);
            this.txtSearchCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCondition.Name = "txtSearchCondition";
            this.txtSearchCondition.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSearchCondition.Properties.Appearance.Options.UseFont = true;
            this.txtSearchCondition.Size = new System.Drawing.Size(231, 28);
            this.txtSearchCondition.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl1.Location = new System.Drawing.Point(277, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "会员编号或姓名:";
            // 
            // cmbMemberGrade
            // 
            this.cmbMemberGrade.Location = new System.Drawing.Point(106, 19);
            this.cmbMemberGrade.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMemberGrade.Name = "cmbMemberGrade";
            this.cmbMemberGrade.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbMemberGrade.Properties.Appearance.Options.UseFont = true;
            this.cmbMemberGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMemberGrade.Size = new System.Drawing.Size(143, 28);
            this.cmbMemberGrade.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(648, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查询(F3)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMemberGrade
            // 
            this.lblMemberGrade.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblMemberGrade.Location = new System.Drawing.Point(30, 22);
            this.lblMemberGrade.Margin = new System.Windows.Forms.Padding(4);
            this.lblMemberGrade.Name = "lblMemberGrade";
            this.lblMemberGrade.Size = new System.Drawing.Size(68, 21);
            this.lblMemberGrade.TabIndex = 0;
            this.lblMemberGrade.Text = "会员等级:";
            // 
            // btnMoneyRecharge
            // 
            this.btnMoneyRecharge.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMoneyRecharge.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMoneyRecharge.Appearance.Options.UseBackColor = true;
            this.btnMoneyRecharge.Appearance.Options.UseFont = true;
            this.btnMoneyRecharge.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMoneyRecharge.Image = global::shopsoft.main.Properties.Resources.coin_add48;
            this.btnMoneyRecharge.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMoneyRecharge.Location = new System.Drawing.Point(379, 3);
            this.btnMoneyRecharge.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoneyRecharge.Name = "btnMoneyRecharge";
            this.btnMoneyRecharge.Size = new System.Drawing.Size(80, 80);
            this.btnMoneyRecharge.TabIndex = 6;
            this.btnMoneyRecharge.Text = "会员充值";
            this.btnMoneyRecharge.Click += new System.EventHandler(this.btnMoneyRecharge_Click);
            // 
            // btnMemberExport
            // 
            this.btnMemberExport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberExport.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMemberExport.Appearance.Options.UseBackColor = true;
            this.btnMemberExport.Appearance.Options.UseFont = true;
            this.btnMemberExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMemberExport.Image = global::shopsoft.main.Properties.Resources.import48;
            this.btnMemberExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMemberExport.Location = new System.Drawing.Point(721, 3);
            this.btnMemberExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberExport.Name = "btnMemberExport";
            this.btnMemberExport.Size = new System.Drawing.Size(80, 80);
            this.btnMemberExport.TabIndex = 5;
            this.btnMemberExport.Text = "导入";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrint.Image = global::shopsoft.main.Properties.Resources.printer48;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(493, 3);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 80);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "打印";
            // 
            // btnMemberImport
            // 
            this.btnMemberImport.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMemberImport.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMemberImport.Appearance.Options.UseBackColor = true;
            this.btnMemberImport.Appearance.Options.UseFont = true;
            this.btnMemberImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMemberImport.Image = global::shopsoft.main.Properties.Resources.export48;
            this.btnMemberImport.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnMemberImport.Location = new System.Drawing.Point(607, 3);
            this.btnMemberImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnMemberImport.Name = "btnMemberImport";
            this.btnMemberImport.Size = new System.Drawing.Size(80, 80);
            this.btnMemberImport.TabIndex = 4;
            this.btnMemberImport.Text = "导出";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteMember.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDeleteMember.Appearance.Options.UseBackColor = true;
            this.btnDeleteMember.Appearance.Options.UseFont = true;
            this.btnDeleteMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteMember.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDeleteMember.Image = global::shopsoft.main.Properties.Resources.delete48;
            this.btnDeleteMember.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnDeleteMember.Location = new System.Drawing.Point(265, 3);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(80, 80);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "删除会员";
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyMember.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnModifyMember.Appearance.Options.UseBackColor = true;
            this.btnModifyMember.Appearance.Options.UseFont = true;
            this.btnModifyMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModifyMember.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnModifyMember.Image = global::shopsoft.main.Properties.Resources.configure48;
            this.btnModifyMember.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnModifyMember.Location = new System.Drawing.Point(151, 3);
            this.btnModifyMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(80, 80);
            this.btnModifyMember.TabIndex = 1;
            this.btnModifyMember.Text = "修改会员";
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateMember.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCreateMember.Appearance.Options.UseBackColor = true;
            this.btnCreateMember.Appearance.Options.UseFont = true;
            this.btnCreateMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateMember.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCreateMember.Image = global::shopsoft.main.Properties.Resources.add48;
            this.btnCreateMember.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCreateMember.Location = new System.Drawing.Point(37, 3);
            this.btnCreateMember.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(80, 80);
            this.btnCreateMember.TabIndex = 0;
            this.btnCreateMember.Text = "添加会员";
            this.btnCreateMember.ToolTip = "添加会员";
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSearch.Controls.Add(this.pnlSearchResult);
            this.pnlSearch.Controls.Add(this.pnlSearchCondition);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 70);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1000, 510);
            this.pnlSearch.TabIndex = 1;
            // 
            // pnlSearchResult
            // 
            this.pnlSearchResult.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSearchResult.Controls.Add(this.gridCtrlMembers);
            this.pnlSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchResult.Location = new System.Drawing.Point(0, 86);
            this.pnlSearchResult.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.Size = new System.Drawing.Size(1000, 424);
            this.pnlSearchResult.TabIndex = 1;
            // 
            // gridCtrlMembers
            // 
            this.gridCtrlMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridCtrlMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlMembers.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlMembers.MainView = this.gridViewMembers;
            this.gridCtrlMembers.Margin = new System.Windows.Forms.Padding(0);
            this.gridCtrlMembers.Name = "gridCtrlMembers";
            this.gridCtrlMembers.Size = new System.Drawing.Size(1000, 424);
            this.gridCtrlMembers.TabIndex = 0;
            this.gridCtrlMembers.ToolTipController = this.toolTipGridMember;
            this.gridCtrlMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers,
            this.gridView1});
            // 
            // gridViewMembers
            // 
            this.gridViewMembers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MemberNo,
            this.MemberName,
            this.Member_Grade,
            this.Sex,
            this.Bouns,
            this.Balance,
            this.LeavingDealtime,
            this.RemainingTime,
            this.MobileNo,
            this.BirthdayMonthDay,
            this.RegDate,
            this.Address,
            this.Comment,
            this.Member_ID});
            this.gridViewMembers.GridControl = this.gridCtrlMembers;
            this.gridViewMembers.Name = "gridViewMembers";
            this.gridViewMembers.OptionsCustomization.AllowFilter = false;
            this.gridViewMembers.OptionsCustomization.AllowGroup = false;
            this.gridViewMembers.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewMembers.OptionsFilter.AllowFilterEditor = false;
            this.gridViewMembers.OptionsLayout.Columns.AddNewColumns = false;
            this.gridViewMembers.OptionsLayout.Columns.RemoveOldColumns = false;
            this.gridViewMembers.OptionsView.ColumnAutoWidth = false;
            this.gridViewMembers.OptionsView.ShowDetailButtons = false;
            this.gridViewMembers.OptionsView.ShowFooter = true;
            this.gridViewMembers.OptionsView.ShowGroupPanel = false;
            this.gridViewMembers.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewMembers_RowClick);
            this.gridViewMembers.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridViewMembers_CustomColumnDisplayText);
            // 
            // MemberNo
            // 
            this.MemberNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberNo.Caption = "会员编号";
            this.MemberNo.FieldName = "Member_No";
            this.MemberNo.MaxWidth = 100;
            this.MemberNo.Name = "MemberNo";
            this.MemberNo.OptionsColumn.AllowEdit = false;
            this.MemberNo.OptionsColumn.AllowFocus = false;
            this.MemberNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MemberNo.OptionsColumn.FixedWidth = true;
            this.MemberNo.OptionsFilter.AllowAutoFilter = false;
            this.MemberNo.OptionsFilter.AllowFilter = false;
            this.MemberNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
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
            // Member_Grade
            // 
            this.Member_Grade.AppearanceHeader.Options.UseTextOptions = true;
            this.Member_Grade.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Member_Grade.Caption = "会员等级";
            this.Member_Grade.FieldName = "Member_Grade_ID.Grade_Name";
            this.Member_Grade.MaxWidth = 75;
            this.Member_Grade.Name = "Member_Grade";
            this.Member_Grade.OptionsColumn.AllowEdit = false;
            this.Member_Grade.OptionsColumn.AllowFocus = false;
            this.Member_Grade.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Member_Grade.OptionsColumn.FixedWidth = true;
            this.Member_Grade.OptionsFilter.AllowAutoFilter = false;
            this.Member_Grade.OptionsFilter.AllowFilter = false;
            this.Member_Grade.Visible = true;
            this.Member_Grade.VisibleIndex = 2;
            this.Member_Grade.Width = 70;
            // 
            // Sex
            // 
            this.Sex.AppearanceHeader.Options.UseTextOptions = true;
            this.Sex.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Sex.Caption = "性别";
            this.Sex.FieldName = "Sex";
            this.Sex.MaxWidth = 60;
            this.Sex.Name = "Sex";
            this.Sex.OptionsColumn.AllowEdit = false;
            this.Sex.OptionsColumn.AllowFocus = false;
            this.Sex.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Sex.OptionsColumn.FixedWidth = true;
            this.Sex.OptionsFilter.AllowAutoFilter = false;
            this.Sex.OptionsFilter.AllowFilter = false;
            this.Sex.Visible = true;
            this.Sex.VisibleIndex = 3;
            this.Sex.Width = 60;
            // 
            // Bouns
            // 
            this.Bouns.AppearanceHeader.Options.UseTextOptions = true;
            this.Bouns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Bouns.Caption = "积分";
            this.Bouns.FieldName = "Bouns";
            this.Bouns.MaxWidth = 60;
            this.Bouns.Name = "Bouns";
            this.Bouns.OptionsColumn.AllowEdit = false;
            this.Bouns.OptionsColumn.AllowFocus = false;
            this.Bouns.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Bouns.OptionsColumn.FixedWidth = true;
            this.Bouns.OptionsFilter.AllowAutoFilter = false;
            this.Bouns.OptionsFilter.AllowFilter = false;
            this.Bouns.Visible = true;
            this.Bouns.VisibleIndex = 4;
            this.Bouns.Width = 55;
            // 
            // Balance
            // 
            this.Balance.AppearanceHeader.Options.UseTextOptions = true;
            this.Balance.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Balance.Caption = "卡内余额";
            this.Balance.FieldName = "Balance";
            this.Balance.MaxWidth = 75;
            this.Balance.Name = "Balance";
            this.Balance.OptionsColumn.AllowEdit = false;
            this.Balance.OptionsColumn.AllowFocus = false;
            this.Balance.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Balance.OptionsColumn.FixedWidth = true;
            this.Balance.OptionsFilter.AllowAutoFilter = false;
            this.Balance.OptionsFilter.AllowFilter = false;
            this.Balance.Visible = true;
            this.Balance.VisibleIndex = 5;
            this.Balance.Width = 70;
            // 
            // LeavingDealtime
            // 
            this.LeavingDealtime.AppearanceHeader.Options.UseTextOptions = true;
            this.LeavingDealtime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LeavingDealtime.Caption = "剩余次数";
            this.LeavingDealtime.FieldName = "Leaving_Deal_time";
            this.LeavingDealtime.MaxWidth = 75;
            this.LeavingDealtime.Name = "LeavingDealtime";
            this.LeavingDealtime.OptionsColumn.AllowEdit = false;
            this.LeavingDealtime.OptionsColumn.AllowFocus = false;
            this.LeavingDealtime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.LeavingDealtime.OptionsColumn.FixedWidth = true;
            this.LeavingDealtime.OptionsFilter.AllowAutoFilter = false;
            this.LeavingDealtime.OptionsFilter.AllowFilter = false;
            this.LeavingDealtime.Visible = true;
            this.LeavingDealtime.VisibleIndex = 6;
            this.LeavingDealtime.Width = 70;
            // 
            // RemainingTime
            // 
            this.RemainingTime.AppearanceHeader.Options.UseTextOptions = true;
            this.RemainingTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainingTime.Caption = "剩余时长";
            this.RemainingTime.FieldName = "Remaining_Time";
            this.RemainingTime.MaxWidth = 80;
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.OptionsColumn.AllowEdit = false;
            this.RemainingTime.OptionsColumn.AllowFocus = false;
            this.RemainingTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.RemainingTime.OptionsColumn.FixedWidth = true;
            this.RemainingTime.OptionsFilter.AllowAutoFilter = false;
            this.RemainingTime.OptionsFilter.AllowFilter = false;
            this.RemainingTime.Visible = true;
            this.RemainingTime.VisibleIndex = 7;
            this.RemainingTime.Width = 70;
            // 
            // MobileNo
            // 
            this.MobileNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MobileNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MobileNo.Caption = "联系电话";
            this.MobileNo.FieldName = "Mobile_No";
            this.MobileNo.MaxWidth = 80;
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.OptionsColumn.AllowEdit = false;
            this.MobileNo.OptionsColumn.AllowFocus = false;
            this.MobileNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MobileNo.OptionsColumn.FixedWidth = true;
            this.MobileNo.OptionsFilter.AllowAutoFilter = false;
            this.MobileNo.OptionsFilter.AllowFilter = false;
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 8;
            this.MobileNo.Width = 70;
            // 
            // BirthdayMonthDay
            // 
            this.BirthdayMonthDay.AppearanceHeader.Options.UseTextOptions = true;
            this.BirthdayMonthDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BirthdayMonthDay.Caption = "生日";
            this.BirthdayMonthDay.FieldName = "Birthday_Month_Day";
            this.BirthdayMonthDay.MaxWidth = 80;
            this.BirthdayMonthDay.Name = "BirthdayMonthDay";
            this.BirthdayMonthDay.OptionsColumn.AllowEdit = false;
            this.BirthdayMonthDay.OptionsColumn.AllowFocus = false;
            this.BirthdayMonthDay.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.BirthdayMonthDay.OptionsColumn.FixedWidth = true;
            this.BirthdayMonthDay.OptionsFilter.AllowAutoFilter = false;
            this.BirthdayMonthDay.OptionsFilter.AllowFilter = false;
            this.BirthdayMonthDay.Visible = true;
            this.BirthdayMonthDay.VisibleIndex = 9;
            this.BirthdayMonthDay.Width = 70;
            // 
            // RegDate
            // 
            this.RegDate.AppearanceHeader.Options.UseTextOptions = true;
            this.RegDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RegDate.Caption = "注册日期";
            this.RegDate.FieldName = "Reg_Date";
            this.RegDate.MaxWidth = 100;
            this.RegDate.MinWidth = 70;
            this.RegDate.Name = "RegDate";
            this.RegDate.OptionsColumn.AllowEdit = false;
            this.RegDate.OptionsColumn.AllowFocus = false;
            this.RegDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.RegDate.OptionsColumn.FixedWidth = true;
            this.RegDate.OptionsFilter.AllowAutoFilter = false;
            this.RegDate.OptionsFilter.AllowFilter = false;
            this.RegDate.Visible = true;
            this.RegDate.VisibleIndex = 10;
            this.RegDate.Width = 70;
            // 
            // Address
            // 
            this.Address.AppearanceHeader.Options.UseTextOptions = true;
            this.Address.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Address.Caption = "地址";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 120;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.AllowEdit = false;
            this.Address.OptionsColumn.AllowFocus = false;
            this.Address.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Address.OptionsColumn.FixedWidth = true;
            this.Address.OptionsFilter.AllowAutoFilter = false;
            this.Address.OptionsFilter.AllowFilter = false;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 11;
            this.Address.Width = 150;
            // 
            // Comment
            // 
            this.Comment.AppearanceHeader.Options.UseTextOptions = true;
            this.Comment.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Comment.Caption = "备注";
            this.Comment.FieldName = "Comment";
            this.Comment.MinWidth = 150;
            this.Comment.Name = "Comment";
            this.Comment.OptionsColumn.AllowEdit = false;
            this.Comment.OptionsColumn.AllowFocus = false;
            this.Comment.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Comment.OptionsColumn.FixedWidth = true;
            this.Comment.OptionsFilter.AllowAutoFilter = false;
            this.Comment.OptionsFilter.AllowFilter = false;
            this.Comment.Visible = true;
            this.Comment.VisibleIndex = 12;
            this.Comment.Width = 200;
            // 
            // Member_ID
            // 
            this.Member_ID.Caption = "会员ID";
            this.Member_ID.FieldName = "Member_ID";
            this.Member_ID.Name = "Member_ID";
            this.Member_ID.OptionsColumn.AllowEdit = false;
            this.Member_ID.OptionsColumn.AllowFocus = false;
            this.Member_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Member_ID.OptionsFilter.AllowAutoFilter = false;
            this.Member_ID.OptionsFilter.AllowFilter = false;
            // 
            // toolTipGridMember
            // 
            this.toolTipGridMember.AllowHtmlText = true;
            this.toolTipGridMember.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipGridMember_GetActiveObjectInfo);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrlMembers;
            this.gridView1.Name = "gridView1";
            // 
            // pnlSearchCondition
            // 
            this.pnlSearchCondition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSearchCondition.Controls.Add(this.btnPrint);
            this.pnlSearchCondition.Controls.Add(this.btnMoneyRecharge);
            this.pnlSearchCondition.Controls.Add(this.btnCreateMember);
            this.pnlSearchCondition.Controls.Add(this.btnModifyMember);
            this.pnlSearchCondition.Controls.Add(this.btnMemberExport);
            this.pnlSearchCondition.Controls.Add(this.btnDeleteMember);
            this.pnlSearchCondition.Controls.Add(this.btnMemberImport);
            this.pnlSearchCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchCondition.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSearchCondition.Name = "pnlSearchCondition";
            this.pnlSearchCondition.Size = new System.Drawing.Size(1000, 86);
            this.pnlSearchCondition.TabIndex = 0;
            // 
            // Form04_MemberManage
            // 
            this.AcceptButton = this.btnSearch;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlOperation);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form04_MemberManage";
            this.Text = "Form_MemberManage";
            this.Load += new System.EventHandler(this.Form04_MemberManage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form04_MemberManage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMemberGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchResult)).EndInit();
            this.pnlSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchCondition)).EndInit();
            this.pnlSearchCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlOperation;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraEditors.PanelControl pnlSearchCondition;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.PanelControl pnlSearchResult;
        private DevExpress.XtraGrid.GridControl gridCtrlMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
        private DevExpress.XtraGrid.Columns.GridColumn MemberNo;
        private DevExpress.XtraGrid.Columns.GridColumn MemberName;
        private DevExpress.XtraEditors.SimpleButton btnCreateMember;
        private DevExpress.XtraEditors.SimpleButton btnModifyMember;
        private DevExpress.XtraEditors.SimpleButton btnDeleteMember;
        private DevExpress.XtraEditors.SimpleButton btnMemberExport;
        private DevExpress.XtraEditors.SimpleButton btnMemberImport;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl lblMemberGrade;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMemberGrade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSearchCondition;
        private DevExpress.XtraGrid.Columns.GridColumn Member_Grade;
        private DevExpress.XtraGrid.Columns.GridColumn Sex;
        private DevExpress.XtraGrid.Columns.GridColumn Bouns;
        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn LeavingDealtime;
        private DevExpress.XtraGrid.Columns.GridColumn BirthdayMonthDay;
        private DevExpress.XtraGrid.Columns.GridColumn RegDate;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Comment;
        private DevExpress.XtraGrid.Columns.GridColumn Member_ID;
        private DevExpress.Utils.ToolTipController toolTipGridMember;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn RemainingTime;
        private DevExpress.XtraEditors.SimpleButton btnMoneyRecharge;

    }
}