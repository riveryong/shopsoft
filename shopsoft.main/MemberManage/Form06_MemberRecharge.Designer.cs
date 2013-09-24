namespace shopsoft.main.MemberManage
{
    partial class Form06_MemberRecharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form06_MemberRecharge));
            this.pnlOperation = new DevExpress.XtraEditors.PanelControl();
            this.pnlMemberInfo = new DevExpress.XtraEditors.PanelControl();
            this.lblContent = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lblMobileNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemberGrade = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblUseTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblDealTimes = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblBlance = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lblBouns = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemberName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemberNo = new DevExpress.XtraEditors.LabelControl();
            this.txtSearchCondition = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.pnlSearchResult = new DevExpress.XtraEditors.PanelControl();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.gridCtrlMembers = new DevExpress.XtraGrid.GridControl();
            this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MemberNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemberName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MobileNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChargeBonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bonus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChargeMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChargeDealTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Charge_Deal_Time = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChargeUseTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RemainingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Member_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipGridMember = new DevExpress.Utils.ToolTipController(this.components);
            this.pnlSearchCondition = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrintReceipt = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecharge = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).BeginInit();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMemberInfo)).BeginInit();
            this.pnlMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchResult)).BeginInit();
            this.pnlSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchCondition)).BeginInit();
            this.pnlSearchCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperation
            // 
            this.pnlOperation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlOperation.Controls.Add(this.pnlMemberInfo);
            this.pnlOperation.Controls.Add(this.txtSearchCondition);
            this.pnlOperation.Controls.Add(this.labelControl1);
            this.pnlOperation.Controls.Add(this.btnSearch);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperation.Location = new System.Drawing.Point(0, 0);
            this.pnlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(1000, 160);
            this.pnlOperation.TabIndex = 0;
            // 
            // pnlMemberInfo
            // 
            this.pnlMemberInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMemberInfo.Appearance.Options.UseFont = true;
            this.pnlMemberInfo.Controls.Add(this.lblContent);
            this.pnlMemberInfo.Controls.Add(this.labelControl6);
            this.pnlMemberInfo.Controls.Add(this.lblMobileNo);
            this.pnlMemberInfo.Controls.Add(this.labelControl5);
            this.pnlMemberInfo.Controls.Add(this.lblMemberGrade);
            this.pnlMemberInfo.Controls.Add(this.labelControl2);
            this.pnlMemberInfo.Controls.Add(this.lblUseTime);
            this.pnlMemberInfo.Controls.Add(this.labelControl3);
            this.pnlMemberInfo.Controls.Add(this.lblDealTimes);
            this.pnlMemberInfo.Controls.Add(this.labelControl8);
            this.pnlMemberInfo.Controls.Add(this.lblBlance);
            this.pnlMemberInfo.Controls.Add(this.labelControl4);
            this.pnlMemberInfo.Controls.Add(this.lblBouns);
            this.pnlMemberInfo.Controls.Add(this.labelControl10);
            this.pnlMemberInfo.Controls.Add(this.lblMemberName);
            this.pnlMemberInfo.Controls.Add(this.labelControl12);
            this.pnlMemberInfo.Controls.Add(this.labelControl14);
            this.pnlMemberInfo.Controls.Add(this.lblMemberNo);
            this.pnlMemberInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMemberInfo.Location = new System.Drawing.Point(0, 80);
            this.pnlMemberInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMemberInfo.Name = "pnlMemberInfo";
            this.pnlMemberInfo.Size = new System.Drawing.Size(1000, 80);
            this.pnlMemberInfo.TabIndex = 15;
            // 
            // lblContent
            // 
            this.lblContent.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblContent.Location = new System.Drawing.Point(749, 48);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(96, 21);
            this.lblContent.TabIndex = 16;
            this.lblContent.Text = "备注信息内容";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(707, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 21);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "备注:";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNo.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMobileNo.Location = new System.Drawing.Point(733, 14);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(99, 21);
            this.lblMobileNo.TabIndex = 14;
            this.lblMobileNo.Text = "13821335990";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(675, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 21);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "手机号:";
            // 
            // lblMemberGrade
            // 
            this.lblMemberGrade.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberGrade.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMemberGrade.Location = new System.Drawing.Point(572, 14);
            this.lblMemberGrade.Name = "lblMemberGrade";
            this.lblMemberGrade.Size = new System.Drawing.Size(64, 21);
            this.lblMemberGrade.TabIndex = 2;
            this.lblMemberGrade.Text = "普通会员";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl2.Location = new System.Drawing.Point(34, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "会员编号:";
            // 
            // lblUseTime
            // 
            this.lblUseTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUseTime.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblUseTime.Location = new System.Drawing.Point(570, 48);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(109, 21);
            this.lblUseTime.TabIndex = 2;
            this.lblUseTime.Text = "999小时45分钟";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl3.Location = new System.Drawing.Point(374, 14);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 21);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "姓名:";
            // 
            // lblDealTimes
            // 
            this.lblDealTimes.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDealTimes.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblDealTimes.Location = new System.Drawing.Point(399, 48);
            this.lblDealTimes.Name = "lblDealTimes";
            this.lblDealTimes.Size = new System.Drawing.Size(61, 21);
            this.lblDealTimes.TabIndex = 2;
            this.lblDealTimes.Text = "99999次";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl8.Location = new System.Drawing.Point(34, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 21);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "积分:";
            // 
            // lblBlance
            // 
            this.lblBlance.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBlance.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblBlance.Location = new System.Drawing.Point(241, 48);
            this.lblBlance.Name = "lblBlance";
            this.lblBlance.Size = new System.Drawing.Size(61, 21);
            this.lblBlance.TabIndex = 2;
            this.lblBlance.Text = "99999元";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl4.Location = new System.Drawing.Point(498, 14);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 21);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "会员等级:";
            // 
            // lblBouns
            // 
            this.lblBouns.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBouns.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblBouns.Location = new System.Drawing.Point(76, 48);
            this.lblBouns.Name = "lblBouns";
            this.lblBouns.Size = new System.Drawing.Size(61, 21);
            this.lblBouns.TabIndex = 2;
            this.lblBouns.Text = "99999分";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl10.Location = new System.Drawing.Point(167, 48);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(68, 21);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "卡内余额:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberName.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMemberName.Location = new System.Drawing.Point(416, 14);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(32, 21);
            this.lblMemberName.TabIndex = 2;
            this.lblMemberName.Text = "张三";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl12.Location = new System.Drawing.Point(325, 48);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(68, 21);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "剩余次数:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl14.Location = new System.Drawing.Point(496, 48);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(68, 21);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "可用时长:";
            // 
            // lblMemberNo
            // 
            this.lblMemberNo.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberNo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblMemberNo.Location = new System.Drawing.Point(108, 10);
            this.lblMemberNo.Name = "lblMemberNo";
            this.lblMemberNo.Size = new System.Drawing.Size(240, 27);
            this.lblMemberNo.TabIndex = 2;
            this.lblMemberNo.Text = "12345678901234567890";
            // 
            // txtSearchCondition
            // 
            this.txtSearchCondition.Location = new System.Drawing.Point(224, 22);
            this.txtSearchCondition.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCondition.Name = "txtSearchCondition";
            this.txtSearchCondition.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSearchCondition.Properties.Appearance.Options.UseFont = true;
            this.txtSearchCondition.Size = new System.Drawing.Size(231, 28);
            this.txtSearchCondition.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.labelControl1.Location = new System.Drawing.Point(34, 23);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(180, 21);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "会员编号或姓名或手机号:";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Location = new System.Drawing.Point(463, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询(F3)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSearch.Controls.Add(this.pnlSearchResult);
            this.pnlSearch.Controls.Add(this.pnlSearchCondition);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 160);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1000, 420);
            this.pnlSearch.TabIndex = 1;
            // 
            // pnlSearchResult
            // 
            this.pnlSearchResult.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSearchResult.Controls.Add(this.controlNavigator1);
            this.pnlSearchResult.Controls.Add(this.gridCtrlMembers);
            this.pnlSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchResult.Location = new System.Drawing.Point(0, 80);
            this.pnlSearchResult.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.Size = new System.Drawing.Size(1000, 340);
            this.pnlSearchResult.TabIndex = 1;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Buttons.Append.Enabled = false;
            this.controlNavigator1.Buttons.CancelEdit.Enabled = false;
            this.controlNavigator1.Buttons.Edit.Enabled = false;
            this.controlNavigator1.Buttons.EndEdit.Enabled = false;
            this.controlNavigator1.Buttons.Remove.Enabled = false;
            this.controlNavigator1.Location = new System.Drawing.Point(0, 370);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.Size = new System.Drawing.Size(268, 20);
            this.controlNavigator1.TabIndex = 2;
            this.controlNavigator1.Text = "翻页";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            // 
            // gridCtrlMembers
            // 
            this.gridCtrlMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridCtrlMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlMembers.Location = new System.Drawing.Point(0, 0);
            this.gridCtrlMembers.MainView = this.gridViewMembers;
            this.gridCtrlMembers.Margin = new System.Windows.Forms.Padding(0);
            this.gridCtrlMembers.Name = "gridCtrlMembers";
            this.gridCtrlMembers.Size = new System.Drawing.Size(1000, 340);
            this.gridCtrlMembers.TabIndex = 1;
            this.gridCtrlMembers.ToolTipController = this.toolTipGridMember;
            this.gridCtrlMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
            // 
            // gridViewMembers
            // 
            this.gridViewMembers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MemberNo,
            this.MemberName,
            this.MobileNo,
            this.ChargeBonus,
            this.Bonus,
            this.ChargeMoney,
            this.Balance,
            this.ChargeDealTime,
            this.Charge_Deal_Time,
            this.ChargeUseTime,
            this.RemainingTime,
            this.Comment,
            this.Member_ID});
            this.gridViewMembers.GridControl = this.gridCtrlMembers;
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
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Member_ID.Member_No", "充值{0:n0}次")});
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
            // MobileNo
            // 
            this.MobileNo.AppearanceHeader.Options.UseTextOptions = true;
            this.MobileNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MobileNo.Caption = "联系电话";
            this.MobileNo.FieldName = "Member_ID.Mobile_No";
            this.MobileNo.MaxWidth = 80;
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.OptionsColumn.AllowEdit = false;
            this.MobileNo.OptionsColumn.AllowFocus = false;
            this.MobileNo.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.MobileNo.OptionsColumn.FixedWidth = true;
            this.MobileNo.OptionsFilter.AllowAutoFilter = false;
            this.MobileNo.OptionsFilter.AllowFilter = false;
            this.MobileNo.Visible = true;
            this.MobileNo.VisibleIndex = 2;
            this.MobileNo.Width = 76;
            // 
            // ChargeBonus
            // 
            this.ChargeBonus.AppearanceHeader.Options.UseTextOptions = true;
            this.ChargeBonus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ChargeBonus.Caption = "增加积分";
            this.ChargeBonus.FieldName = "Charge_Bonus";
            this.ChargeBonus.MaxWidth = 75;
            this.ChargeBonus.Name = "ChargeBonus";
            this.ChargeBonus.OptionsColumn.AllowEdit = false;
            this.ChargeBonus.OptionsColumn.AllowFocus = false;
            this.ChargeBonus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ChargeBonus.OptionsColumn.FixedWidth = true;
            this.ChargeBonus.OptionsFilter.AllowAutoFilter = false;
            this.ChargeBonus.OptionsFilter.AllowFilter = false;
            this.ChargeBonus.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_Bonus", "{0:n0}分")});
            this.ChargeBonus.Visible = true;
            this.ChargeBonus.VisibleIndex = 3;
            this.ChargeBonus.Width = 71;
            // 
            // Bonus
            // 
            this.Bonus.AppearanceHeader.Options.UseTextOptions = true;
            this.Bonus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Bonus.Caption = "积分";
            this.Bonus.FieldName = "Bonus";
            this.Bonus.MaxWidth = 60;
            this.Bonus.Name = "Bonus";
            this.Bonus.OptionsColumn.AllowEdit = false;
            this.Bonus.OptionsColumn.AllowFocus = false;
            this.Bonus.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Bonus.OptionsColumn.FixedWidth = true;
            this.Bonus.OptionsFilter.AllowAutoFilter = false;
            this.Bonus.OptionsFilter.AllowFilter = false;
            this.Bonus.Visible = true;
            this.Bonus.VisibleIndex = 4;
            this.Bonus.Width = 58;
            // 
            // ChargeMoney
            // 
            this.ChargeMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.ChargeMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ChargeMoney.Caption = "充值金额";
            this.ChargeMoney.FieldName = "Charge_Money";
            this.ChargeMoney.Name = "ChargeMoney";
            this.ChargeMoney.OptionsColumn.AllowEdit = false;
            this.ChargeMoney.OptionsColumn.AllowFocus = false;
            this.ChargeMoney.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ChargeMoney.OptionsColumn.FixedWidth = true;
            this.ChargeMoney.OptionsFilter.AllowAutoFilter = false;
            this.ChargeMoney.OptionsFilter.AllowFilter = false;
            this.ChargeMoney.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_Money", "{0:c2}元")});
            this.ChargeMoney.Visible = true;
            this.ChargeMoney.VisibleIndex = 5;
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
            this.Balance.VisibleIndex = 6;
            this.Balance.Width = 73;
            // 
            // ChargeDealTime
            // 
            this.ChargeDealTime.AppearanceHeader.Options.UseTextOptions = true;
            this.ChargeDealTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ChargeDealTime.Caption = "充次数";
            this.ChargeDealTime.FieldName = "Charge_Deal_Time";
            this.ChargeDealTime.MaxWidth = 70;
            this.ChargeDealTime.Name = "ChargeDealTime";
            this.ChargeDealTime.OptionsColumn.AllowEdit = false;
            this.ChargeDealTime.OptionsColumn.AllowFocus = false;
            this.ChargeDealTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ChargeDealTime.OptionsColumn.FixedWidth = true;
            this.ChargeDealTime.OptionsFilter.AllowAutoFilter = false;
            this.ChargeDealTime.OptionsFilter.AllowFilter = false;
            this.ChargeDealTime.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_Deal_Time", "{0:n2}次")});
            this.ChargeDealTime.Visible = true;
            this.ChargeDealTime.VisibleIndex = 7;
            this.ChargeDealTime.Width = 60;
            // 
            // Charge_Deal_Time
            // 
            this.Charge_Deal_Time.AppearanceHeader.Options.UseTextOptions = true;
            this.Charge_Deal_Time.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Charge_Deal_Time.Caption = "剩余次数";
            this.Charge_Deal_Time.FieldName = "Charge_Deal_Time";
            this.Charge_Deal_Time.MaxWidth = 75;
            this.Charge_Deal_Time.Name = "Charge_Deal_Time";
            this.Charge_Deal_Time.OptionsColumn.AllowEdit = false;
            this.Charge_Deal_Time.OptionsColumn.AllowFocus = false;
            this.Charge_Deal_Time.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Charge_Deal_Time.OptionsColumn.FixedWidth = true;
            this.Charge_Deal_Time.OptionsFilter.AllowAutoFilter = false;
            this.Charge_Deal_Time.OptionsFilter.AllowFilter = false;
            this.Charge_Deal_Time.Visible = true;
            this.Charge_Deal_Time.VisibleIndex = 8;
            this.Charge_Deal_Time.Width = 71;
            // 
            // ChargeUseTime
            // 
            this.ChargeUseTime.AppearanceHeader.Options.UseTextOptions = true;
            this.ChargeUseTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ChargeUseTime.Caption = "充小时";
            this.ChargeUseTime.FieldName = "Charge_UseTime";
            this.ChargeUseTime.MaxWidth = 70;
            this.ChargeUseTime.Name = "ChargeUseTime";
            this.ChargeUseTime.OptionsColumn.AllowEdit = false;
            this.ChargeUseTime.OptionsColumn.AllowFocus = false;
            this.ChargeUseTime.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ChargeUseTime.OptionsColumn.FixedWidth = true;
            this.ChargeUseTime.OptionsFilter.AllowAutoFilter = false;
            this.ChargeUseTime.OptionsFilter.AllowFilter = false;
            this.ChargeUseTime.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Charge_UseTime", "{0:n2}小时")});
            this.ChargeUseTime.Visible = true;
            this.ChargeUseTime.VisibleIndex = 9;
            this.ChargeUseTime.Width = 60;
            // 
            // RemainingTime
            // 
            this.RemainingTime.AppearanceHeader.Options.UseTextOptions = true;
            this.RemainingTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainingTime.Caption = "可用时长";
            this.RemainingTime.FieldName = "Remaining_Time";
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.OptionsColumn.FixedWidth = true;
            this.RemainingTime.Visible = true;
            this.RemainingTime.VisibleIndex = 10;
            this.RemainingTime.Width = 70;
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
            this.Comment.VisibleIndex = 11;
            this.Comment.Width = 200;
            // 
            // Member_ID
            // 
            this.Member_ID.Caption = "会员ID";
            this.Member_ID.FieldName = "Member_ID.Member_ID";
            this.Member_ID.Name = "Member_ID";
            // 
            // toolTipGridMember
            // 
            this.toolTipGridMember.AllowHtmlText = true;
            this.toolTipGridMember.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipGridMember_GetActiveObjectInfo);
            // 
            // pnlSearchCondition
            // 
            this.pnlSearchCondition.Controls.Add(this.simpleButton2);
            this.pnlSearchCondition.Controls.Add(this.simpleButton1);
            this.pnlSearchCondition.Controls.Add(this.btnPrintReceipt);
            this.pnlSearchCondition.Controls.Add(this.btnRecharge);
            this.pnlSearchCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchCondition.Name = "pnlSearchCondition";
            this.pnlSearchCondition.Size = new System.Drawing.Size(1000, 80);
            this.pnlSearchCondition.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(357, 0);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(80, 80);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "导出";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(246, 0);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 80);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "补打小票";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPrintReceipt.Appearance.Options.UseFont = true;
            this.btnPrintReceipt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrintReceipt.Image = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnPrintReceipt.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrintReceipt.Location = new System.Drawing.Point(135, 0);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(80, 80);
            this.btnPrintReceipt.TabIndex = 0;
            this.btnPrintReceipt.Text = "补打小票";
            // 
            // btnRecharge
            // 
            this.btnRecharge.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnRecharge.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRecharge.Appearance.Options.UseBackColor = true;
            this.btnRecharge.Appearance.Options.UseFont = true;
            this.btnRecharge.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRecharge.Image = ((System.Drawing.Image)(resources.GetObject("btnRecharge.Image")));
            this.btnRecharge.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnRecharge.Location = new System.Drawing.Point(24, 0);
            this.btnRecharge.Margin = new System.Windows.Forms.Padding(0);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(80, 80);
            this.btnRecharge.TabIndex = 0;
            this.btnRecharge.Text = "会员充值";
            this.btnRecharge.ToolTip = "请先查询会员充值记录，再进行充值。";
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // Form06_MemberRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlOperation);
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form06_MemberRecharge";
            this.Text = "Form06_MemberRecharge";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form06_MemberRecharge_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMemberInfo)).EndInit();
            this.pnlMemberInfo.ResumeLayout(false);
            this.pnlMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchResult)).EndInit();
            this.pnlSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearchCondition)).EndInit();
            this.pnlSearchCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlOperation;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraEditors.PanelControl pnlSearchCondition;
        private DevExpress.XtraEditors.PanelControl pnlSearchResult;
        private DevExpress.Utils.ToolTipController toolTipGridMember;
        private DevExpress.XtraEditors.TextEdit txtSearchCondition;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnRecharge;
        private DevExpress.XtraEditors.SimpleButton btnPrintReceipt;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblMemberNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblMemberGrade;
        private DevExpress.XtraEditors.LabelControl lblMemberName;
        private DevExpress.XtraEditors.LabelControl lblUseTime;
        private DevExpress.XtraEditors.LabelControl lblDealTimes;
        private DevExpress.XtraEditors.LabelControl lblBlance;
        private DevExpress.XtraEditors.LabelControl lblBouns;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.GridControl gridCtrlMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
        private DevExpress.XtraGrid.Columns.GridColumn MemberNo;
        private DevExpress.XtraGrid.Columns.GridColumn MemberName;
        private DevExpress.XtraGrid.Columns.GridColumn MobileNo;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeBonus;
        private DevExpress.XtraGrid.Columns.GridColumn Bonus;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeMoney;
        private DevExpress.XtraGrid.Columns.GridColumn Balance;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeDealTime;
        private DevExpress.XtraGrid.Columns.GridColumn Charge_Deal_Time;
        private DevExpress.XtraGrid.Columns.GridColumn ChargeUseTime;
        private DevExpress.XtraGrid.Columns.GridColumn RemainingTime;
        private DevExpress.XtraGrid.Columns.GridColumn Comment;
        private DevExpress.XtraGrid.Columns.GridColumn Member_ID;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraEditors.PanelControl pnlMemberInfo;
        private DevExpress.XtraEditors.LabelControl lblMobileNo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblContent;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}