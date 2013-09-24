namespace shopsoft.main
{
    partial class Form01_mainForm
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
            DevExpress.XtraBars.BarButtonItem logout;
            this.ribbonCtrl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMemberManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberCharge = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberInport = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberExport = new DevExpress.XtraBars.BarButtonItem();
            this.statusBarSysVersion = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarOperator = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarPrompt = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnSkin = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberConsume = new DevExpress.XtraBars.BarButtonItem();
            this.btnBonusCharge = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimeConsume = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimerConsume = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductConsume = new DevExpress.XtraBars.BarButtonItem();
            this.btmConsumeRecord = new DevExpress.XtraBars.BarButtonItem();
            this.btnBonusMerger = new DevExpress.XtraBars.BarButtonItem();
            this.btnGradeManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnOperManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuideManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaseInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barPrintSet = new DevExpress.XtraBars.BarButtonItem();
            this.btnOtherSet = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnDataMaintenance = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdatePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberConusmeStat = new DevExpress.XtraBars.BarButtonItem();
            this.btnMemberChargeStat = new DevExpress.XtraBars.BarButtonItem();
            this.btnBonusStat = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductStat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.Manage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GroupMember = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GroupConsume = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GroupBonus = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.IntegrationStat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GroupStat = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.SystemSetting = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GroupBaseSet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            logout = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.DBSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            logout.Caption = "退出";
            logout.Glyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            logout.Id = 1;
            logout.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            logout.Name = "logout";
            logout.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
            // 
            // ribbonCtrl
            // 
            this.ribbonCtrl.AllowMinimizeRibbon = false;
            this.ribbonCtrl.ApplicationButtonText = null;
            this.ribbonCtrl.Cursor = System.Windows.Forms.Cursors.Hand;
            // 
            // 
            // 
            this.ribbonCtrl.ExpandCollapseItem.Id = 0;
            this.ribbonCtrl.ExpandCollapseItem.Name = "";
            this.ribbonCtrl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonCtrl.ExpandCollapseItem,
            logout,
            this.btnMemberManage,
            this.btnMemberCharge,
            this.btnMemberAdd,
            this.btnMemberInport,
            this.btnMemberExport,
            this.statusBarSysVersion,
            this.statusBarOperator,
            this.statusBarPrompt,
            this.barBtnSkin,
            this.btnMemberConsume,
            this.btnBonusCharge,
            this.btnTimeConsume,
            this.btnTimerConsume,
            this.btnProductConsume,
            this.btmConsumeRecord,
            this.btnBonusMerger,
            this.btnGradeManage,
            this.btnOperManage,
            this.btnGuideManage,
            this.btnBaseInfo,
            this.barPrintSet,
            this.btnOtherSet,
            this.btnViewLog,
            this.btnDataMaintenance,
            this.btnUpdatePassword,
            this.btnMemberConusmeStat,
            this.btnMemberChargeStat,
            this.btnBonusStat,
            this.btnProductStat});
            this.ribbonCtrl.Location = new System.Drawing.Point(0, 0);
            this.ribbonCtrl.MaxItemId = 45;
            this.ribbonCtrl.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonCtrl.Name = "ribbonCtrl";
            this.ribbonCtrl.PageHeaderItemLinks.Add(this.barBtnSkin);
            this.ribbonCtrl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Manage,
            this.IntegrationStat,
            this.SystemSetting});
            this.ribbonCtrl.SelectedPage = this.IntegrationStat;
            this.ribbonCtrl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonCtrl.ShowToolbarCustomizeItem = false;
            this.ribbonCtrl.Size = new System.Drawing.Size(1016, 124);
            this.ribbonCtrl.StatusBar = this.ribbonStatusBar;
            this.ribbonCtrl.Toolbar.ItemLinks.Add(logout);
            this.ribbonCtrl.Toolbar.ShowCustomizeItem = false;
            this.ribbonCtrl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnMemberManage
            // 
            this.btnMemberManage.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberManage.Appearance.Options.UseFont = true;
            this.btnMemberManage.Caption = "会员管理";
            this.btnMemberManage.Id = 4;
            this.btnMemberManage.LargeGlyph = global::shopsoft.main.Properties.Resources.users48;
            this.btnMemberManage.Name = "btnMemberManage";
            this.btnMemberManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMemberManage_ItemClick);
            // 
            // btnMemberCharge
            // 
            this.btnMemberCharge.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberCharge.Appearance.Options.UseFont = true;
            this.btnMemberCharge.Caption = "会员充值";
            this.btnMemberCharge.Id = 5;
            this.btnMemberCharge.LargeGlyph = global::shopsoft.main.Properties.Resources.coin_add48;
            this.btnMemberCharge.Name = "btnMemberCharge";
            this.btnMemberCharge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMemberCharge_ItemClick);
            // 
            // btnMemberAdd
            // 
            this.btnMemberAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberAdd.Appearance.Options.UseFont = true;
            this.btnMemberAdd.Caption = "新建会员";
            this.btnMemberAdd.Id = 2;
            this.btnMemberAdd.LargeGlyph = global::shopsoft.main.Properties.Resources.add48;
            this.btnMemberAdd.Name = "btnMemberAdd";
            this.btnMemberAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMemberAdd_ItemClick);
            // 
            // btnMemberInport
            // 
            this.btnMemberInport.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberInport.Appearance.Options.UseFont = true;
            this.btnMemberInport.Caption = "会员导入";
            this.btnMemberInport.Id = 7;
            this.btnMemberInport.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnMemberInport.Name = "btnMemberInport";
            // 
            // btnMemberExport
            // 
            this.btnMemberExport.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberExport.Appearance.Options.UseFont = true;
            this.btnMemberExport.Caption = "会员导出";
            this.btnMemberExport.Id = 8;
            this.btnMemberExport.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnMemberExport.Name = "btnMemberExport";
            // 
            // statusBarSysVersion
            // 
            this.statusBarSysVersion.Id = 16;
            this.statusBarSysVersion.Name = "statusBarSysVersion";
            this.statusBarSysVersion.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // statusBarOperator
            // 
            this.statusBarOperator.Id = 17;
            this.statusBarOperator.Name = "statusBarOperator";
            this.statusBarOperator.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // statusBarPrompt
            // 
            this.statusBarPrompt.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarPrompt.Caption = "3333";
            this.statusBarPrompt.Id = 18;
            this.statusBarPrompt.Name = "statusBarPrompt";
            this.statusBarPrompt.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barBtnSkin
            // 
            this.barBtnSkin.ActAsDropDown = true;
            this.barBtnSkin.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barBtnSkin.Caption = "换皮肤";
            this.barBtnSkin.Description = "换个皮肤吧！";
            this.barBtnSkin.Glyph = global::shopsoft.main.Properties.Resources.Clothes;
            this.barBtnSkin.Hint = "换个皮肤吧！";
            this.barBtnSkin.Id = 22;
            this.barBtnSkin.Name = "barBtnSkin";
            // 
            // btnMemberConsume
            // 
            this.btnMemberConsume.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMemberConsume.Appearance.Options.UseFont = true;
            this.btnMemberConsume.Caption = "普通消费";
            this.btnMemberConsume.Id = 23;
            this.btnMemberConsume.LargeGlyph = global::shopsoft.main.Properties.Resources.consume1_48;
            this.btnMemberConsume.Name = "btnMemberConsume";
            this.btnMemberConsume.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMemberConsume_ItemClick);
            // 
            // btnBonusCharge
            // 
            this.btnBonusCharge.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBonusCharge.Appearance.Options.UseFont = true;
            this.btnBonusCharge.Caption = "积分兑换";
            this.btnBonusCharge.Id = 24;
            this.btnBonusCharge.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.btnBonusCharge.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnBonusCharge.Name = "btnBonusCharge";
            // 
            // btnTimeConsume
            // 
            this.btnTimeConsume.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeConsume.Appearance.Options.UseFont = true;
            this.btnTimeConsume.Caption = "计次消费";
            this.btnTimeConsume.Id = 25;
            this.btnTimeConsume.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnTimeConsume.Name = "btnTimeConsume";
            // 
            // btnTimerConsume
            // 
            this.btnTimerConsume.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnTimerConsume.Appearance.Options.UseFont = true;
            this.btnTimerConsume.Caption = "计时消费";
            this.btnTimerConsume.Id = 26;
            this.btnTimerConsume.LargeGlyph = global::shopsoft.main.Properties.Resources.consum2_48;
            this.btnTimerConsume.Name = "btnTimerConsume";
            // 
            // btnProductConsume
            // 
            this.btnProductConsume.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductConsume.Appearance.Options.UseFont = true;
            this.btnProductConsume.Caption = "商品消费";
            this.btnProductConsume.Id = 27;
            this.btnProductConsume.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnProductConsume.Name = "btnProductConsume";
            // 
            // btmConsumeRecord
            // 
            this.btmConsumeRecord.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmConsumeRecord.Appearance.Options.UseFont = true;
            this.btmConsumeRecord.Caption = "消费记录";
            this.btmConsumeRecord.Id = 28;
            this.btmConsumeRecord.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btmConsumeRecord.Name = "btmConsumeRecord";
            // 
            // btnBonusMerger
            // 
            this.btnBonusMerger.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonusMerger.Appearance.Options.UseFont = true;
            this.btnBonusMerger.Caption = "积分合并";
            this.btnBonusMerger.Id = 29;
            this.btnBonusMerger.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnBonusMerger.Name = "btnBonusMerger";
            // 
            // btnGradeManage
            // 
            this.btnGradeManage.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeManage.Appearance.Options.UseFont = true;
            this.btnGradeManage.Caption = "会员等级";
            this.btnGradeManage.Description = "设置会员等级分类信息";
            this.btnGradeManage.Id = 30;
            this.btnGradeManage.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnGradeManage.Name = "btnGradeManage";
            // 
            // btnOperManage
            // 
            this.btnOperManage.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperManage.Appearance.Options.UseFont = true;
            this.btnOperManage.Caption = "操作员管理";
            this.btnOperManage.Description = "添加、修改、删除操作员信息";
            this.btnOperManage.Id = 31;
            this.btnOperManage.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnOperManage.Name = "btnOperManage";
            // 
            // btnGuideManage
            // 
            this.btnGuideManage.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuideManage.Appearance.Options.UseFont = true;
            this.btnGuideManage.Caption = "导购管理";
            this.btnGuideManage.Description = "添加、修改、删除导购信息";
            this.btnGuideManage.Id = 32;
            this.btnGuideManage.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnGuideManage.Name = "btnGuideManage";
            // 
            // btnBaseInfo
            // 
            this.btnBaseInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaseInfo.Appearance.Options.UseFont = true;
            this.btnBaseInfo.Caption = "基本信息";
            this.btnBaseInfo.Description = "设置系统基本信息";
            this.btnBaseInfo.Id = 33;
            this.btnBaseInfo.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnBaseInfo.Name = "btnBaseInfo";
            // 
            // barPrintSet
            // 
            this.barPrintSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barPrintSet.Appearance.Options.UseFont = true;
            this.barPrintSet.Caption = "打印设置";
            this.barPrintSet.Description = "设置打印相关信息";
            this.barPrintSet.Id = 34;
            this.barPrintSet.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.barPrintSet.Name = "barPrintSet";
            // 
            // btnOtherSet
            // 
            this.btnOtherSet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherSet.Appearance.Options.UseFont = true;
            this.btnOtherSet.Caption = "其他设置";
            this.btnOtherSet.Description = "系统其它信息设置";
            this.btnOtherSet.Id = 35;
            this.btnOtherSet.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnOtherSet.Name = "btnOtherSet";
            // 
            // btnViewLog
            // 
            this.btnViewLog.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLog.Appearance.Options.UseFont = true;
            this.btnViewLog.Caption = "查看日志";
            this.btnViewLog.Description = "查看操作员的操作日志";
            this.btnViewLog.Id = 36;
            this.btnViewLog.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnViewLog.Name = "btnViewLog";
            // 
            // btnDataMaintenance
            // 
            this.btnDataMaintenance.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataMaintenance.Appearance.Options.UseFont = true;
            this.btnDataMaintenance.Caption = "数据维护";
            this.btnDataMaintenance.Description = "数据库备份、还原";
            this.btnDataMaintenance.Id = 37;
            this.btnDataMaintenance.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnDataMaintenance.Name = "btnDataMaintenance";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Appearance.Options.UseFont = true;
            this.btnUpdatePassword.Caption = "修改密码";
            this.btnUpdatePassword.Description = "修改当前操作者登录密码";
            this.btnUpdatePassword.Id = 38;
            this.btnUpdatePassword.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            // 
            // btnMemberConusmeStat
            // 
            this.btnMemberConusmeStat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberConusmeStat.Appearance.Options.UseFont = true;
            this.btnMemberConusmeStat.Caption = "会员消费统计";
            this.btnMemberConusmeStat.Description = "从不同角度统计会员消费情况";
            this.btnMemberConusmeStat.Id = 41;
            this.btnMemberConusmeStat.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnMemberConusmeStat.Name = "btnMemberConusmeStat";
            // 
            // btnMemberChargeStat
            // 
            this.btnMemberChargeStat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberChargeStat.Appearance.Options.UseFont = true;
            this.btnMemberChargeStat.Caption = "会员充值统计";
            this.btnMemberChargeStat.Description = "从不同角度统计会员充值情况";
            this.btnMemberChargeStat.Id = 42;
            this.btnMemberChargeStat.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnMemberChargeStat.Name = "btnMemberChargeStat";
            // 
            // btnBonusStat
            // 
            this.btnBonusStat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonusStat.Appearance.Options.UseFont = true;
            this.btnBonusStat.Caption = "积分兑换统计";
            this.btnBonusStat.Description = "从不同角度统计积分兑换情况";
            this.btnBonusStat.Id = 43;
            this.btnBonusStat.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnBonusStat.Name = "btnBonusStat";
            // 
            // btnProductStat
            // 
            this.btnProductStat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductStat.Appearance.Options.UseFont = true;
            this.btnProductStat.Caption = "商品统计";
            this.btnProductStat.Description = "统计商品库存及消费等情况";
            this.btnProductStat.Id = 44;
            this.btnProductStat.LargeGlyph = global::shopsoft.main.Properties.Resources.temp_48x48;
            this.btnProductStat.Name = "btnProductStat";
            this.btnProductStat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductStat_ItemClick);
            // 
            // Manage
            // 
            this.Manage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GroupMember,
            this.GroupConsume,
            this.GroupBonus});
            this.Manage.Name = "Manage";
            this.Manage.Text = "会员管理";
            // 
            // GroupMember
            // 
            this.GroupMember.AllowMinimize = false;
            this.GroupMember.ItemLinks.Add(this.btnMemberManage);
            this.GroupMember.ItemLinks.Add(this.btnMemberCharge);
            this.GroupMember.Name = "GroupMember";
            this.GroupMember.Text = "会员管理";
            // 
            // GroupConsume
            // 
            this.GroupConsume.ItemLinks.Add(this.btnMemberConsume);
            this.GroupConsume.ItemLinks.Add(this.btnTimerConsume);
            this.GroupConsume.Name = "GroupConsume";
            this.GroupConsume.Text = "会员消费";
            // 
            // GroupBonus
            // 
            this.GroupBonus.ItemLinks.Add(this.btnBonusCharge);
            this.GroupBonus.ItemLinks.Add(this.btnBonusMerger);
            this.GroupBonus.Name = "GroupBonus";
            this.GroupBonus.Text = "积分";
            // 
            // IntegrationStat
            // 
            this.IntegrationStat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GroupStat});
            this.IntegrationStat.Name = "IntegrationStat";
            this.IntegrationStat.Text = "综合统计";
            // 
            // GroupStat
            // 
            this.GroupStat.ItemLinks.Add(this.btnMemberConusmeStat);
            this.GroupStat.ItemLinks.Add(this.btnMemberChargeStat);
            this.GroupStat.ItemLinks.Add(this.btnBonusStat);
            this.GroupStat.ItemLinks.Add(this.btnProductStat);
            this.GroupStat.Name = "GroupStat";
            this.GroupStat.Text = "综合统计";
            // 
            // SystemSetting
            // 
            this.SystemSetting.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GroupBaseSet});
            this.SystemSetting.Name = "SystemSetting";
            this.SystemSetting.Text = "系统设置";
            // 
            // GroupBaseSet
            // 
            this.GroupBaseSet.ItemLinks.Add(this.btnBaseInfo);
            this.GroupBaseSet.ItemLinks.Add(this.btnGradeManage);
            this.GroupBaseSet.ItemLinks.Add(this.btnOperManage);
            this.GroupBaseSet.ItemLinks.Add(this.btnGuideManage);
            this.GroupBaseSet.ItemLinks.Add(this.barPrintSet);
            this.GroupBaseSet.ItemLinks.Add(this.btnOtherSet);
            this.GroupBaseSet.ItemLinks.Add(this.btnViewLog);
            this.GroupBaseSet.ItemLinks.Add(this.btnDataMaintenance);
            this.GroupBaseSet.ItemLinks.Add(this.btnUpdatePassword);
            this.GroupBaseSet.Name = "GroupBaseSet";
            this.GroupBaseSet.Text = "系统设置";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ribbonStatusBar.ItemLinks.Add(this.statusBarSysVersion);
            this.ribbonStatusBar.ItemLinks.Add(this.statusBarOperator);
            this.ribbonStatusBar.ItemLinks.Add(this.statusBarPrompt);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 714);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonCtrl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1016, 27);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 124);
            this.mainPanel.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1016, 590);
            this.mainPanel.TabIndex = 3;
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            // 
            // Form01_mainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonCtrl);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form01_mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商普店铺管理系统(会员销售版)  ";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonCtrl;
        private DevExpress.XtraBars.Ribbon.RibbonPage Manage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupMember;
      
        private DevExpress.XtraBars.Ribbon.RibbonPage IntegrationStat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupStat;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
      
        private DevExpress.XtraBars.BarButtonItem btnMemberManage;
        private DevExpress.XtraBars.BarButtonItem btnMemberCharge;
        private DevExpress.XtraBars.BarButtonItem btnMemberAdd;
        private DevExpress.XtraBars.BarButtonItem btnMemberInport;
        private DevExpress.XtraBars.BarButtonItem btnMemberExport;
        private DevExpress.XtraEditors.PanelControl mainPanel;
        private DevExpress.XtraBars.BarStaticItem statusBarSysVersion;
        private DevExpress.XtraBars.BarStaticItem statusBarOperator;
        private DevExpress.XtraBars.BarStaticItem statusBarPrompt;
        private DevExpress.XtraBars.BarButtonItem barBtnSkin;
        private DevExpress.XtraBars.BarButtonItem btnMemberConsume;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem btnBonusCharge;
        private DevExpress.XtraBars.Ribbon.RibbonPage SystemSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupConsume;
        private DevExpress.XtraBars.BarButtonItem btnTimeConsume;
        private DevExpress.XtraBars.BarButtonItem btnTimerConsume;
        private DevExpress.XtraBars.BarButtonItem btnProductConsume;
        private DevExpress.XtraBars.BarButtonItem btmConsumeRecord;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupBonus;
        private DevExpress.XtraBars.BarButtonItem btnBonusMerger;
        private DevExpress.XtraBars.BarButtonItem btnGradeManage;
        private DevExpress.XtraBars.BarButtonItem btnOperManage;
        private DevExpress.XtraBars.BarButtonItem btnGuideManage;
        private DevExpress.XtraBars.BarButtonItem btnBaseInfo;
        private DevExpress.XtraBars.BarButtonItem barPrintSet;
        private DevExpress.XtraBars.BarButtonItem btnOtherSet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GroupBaseSet;
        private DevExpress.XtraBars.BarButtonItem btnViewLog;
        private DevExpress.XtraBars.BarButtonItem btnDataMaintenance;
        private DevExpress.XtraBars.BarButtonItem btnUpdatePassword;
        private DevExpress.XtraBars.BarButtonItem btnMemberConusmeStat;
        private DevExpress.XtraBars.BarButtonItem btnMemberChargeStat;
        private DevExpress.XtraBars.BarButtonItem btnBonusStat;
        private DevExpress.XtraBars.BarButtonItem btnProductStat;
    }
}