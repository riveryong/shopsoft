using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using shopsoft.main.MemberManage;
using DevExpress.XtraBars.Ribbon;
using shopsoft.main.Base;
using DevExpress.LookAndFeel;
using System.Xml;
using shopsoft.common;
using System.IO;
using shopsoft.common.Const;



namespace shopsoft.main
{
    public partial class Form01_mainForm : BaseForm
    {

        #region 各子窗口

        private Form04_MemberManage frmMemberManage;
        private Form06_MemberRecharge frmMemberRecharge;
        private testForm1 testF;

        #endregion

        #region 程序初始化
        public Form01_mainForm()
        {
            InitializeComponent();           

            //UserLookAndFeel.Default.SetSkinStyle("Money Twins");
        }

        private void main_Load(object sender, EventArgs e)
        {
            // 修改程序皮肤，
            //UserLookAndFeel.Default.SkinName = "Money Twins";        

            // 为快捷工具栏上的更换皮肤按钮添加事件
            GalleryDropDown skins = new GalleryDropDown() { Ribbon = this.ribbonCtrl };
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            this.barBtnSkin.DropDownControl = skins;

            //汉化
            DevExpress.Accessibility.AccLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressUtilsLocalizationCHS();
            DevExpress.XtraBars.Localization.BarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraBarsLocalizationCHS();
            //DevExpress.XtraCharts.Localization.ChartLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraChartsLocalizationCHS();
            DevExpress.XtraEditors.Controls.Localizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraEditorsLocalizationCHS();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraGridLocalizationCHS();
            DevExpress.XtraLayout.Localization.LayoutLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraLayoutLocalizationCHS();
            DevExpress.XtraNavBar.NavBarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraNavBarLocalizationCHS();
            //DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPivotGridLocalizationCHS();
            DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();
            //DevExpress.XtraReports.Localization.ReportLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraReportsLocalizationCHS();
            //DevExpress.XtraRichEdit.Localization.XtraRichEditLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichEditLocalizationCHS();
            //DevExpress.XtraRichEdit.Localization.RichEditExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichEditExtensionsLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerLocalizationCHS();
            //DevExpress.XtraScheduler.Localization.SchedulerExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerExtensionsLocalizationCHS();
            //DevExpress.XtraSpellChecker.Localization.SpellCheckerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSpellCheckerLocalizationCHS();
            //DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraTreeListLocalizationCHS();
            //DevExpress.XtraVerticalGrid.Localization.VGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraVerticalGridLocalizationCHS();
            //DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraWizardLocalizationCHS();
            //UserLookAndFeel.Default.SetSkinStyle(skins.Name);
            
            this.statusBarSysVersion.Caption = " 会员管理-免费版 ";
            this.statusBarOperator.Caption = " 操作员：系统管理员";

            // 读取预存数据
            InitSysData();

            // 程序打开时，默认打开会员管理画面
            //frmMemberManage = new Form04_MemberManage();
            //this.mainPanel.Controls.Clear();            
            //this.mainPanel.Controls.Add(frmMemberManage);
            //frmMemberManage.Dock = DockStyle.Fill;
            //frmMemberManage.Show();


            testF = new testForm1();
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(testF);
            testF.Dock = DockStyle.Fill;
            testF.Show();
            
            
        }
        #endregion


        #region 添加用户按钮
        /// <summary>
        /// 添加用户按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemberAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form03_MemberAdd formMemAdd = checkFormIsOpened("Form_MemberAdd") as Form03_MemberAdd;

            if (formMemAdd == null)
            {
                formMemAdd = new Form03_MemberAdd();
            }

            this.mainPanel.Controls.Clear();
            formMemAdd.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(formMemAdd);
            formMemAdd.Show();
        }
        #endregion


        #region 会员管理按钮
        /// <summary>
        /// 会员管理按钮按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemberManage_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMemberManage = checkFormIsOpened("Form04_MemberManage") as Form04_MemberManage;

            if (frmMemberManage == null)
            {
                frmMemberManage = new Form04_MemberManage();
            }

            this.mainPanel.Controls.Clear();            
            this.mainPanel.Controls.Add(frmMemberManage);
            frmMemberManage.Dock = DockStyle.Fill;
            frmMemberManage.Show();

        }
        #endregion


        #region 会员充值按钮
        /// <summary>
        /// 会员充值按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemberCharge_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMemberRecharge = checkFormIsOpened("Form06_MemberRecharge") as Form06_MemberRecharge;

            if (frmMemberRecharge == null)
            {
                frmMemberRecharge = new Form06_MemberRecharge();
            }

            this.mainPanel.Controls.Clear();            
            this.mainPanel.Controls.Add(frmMemberRecharge);
            frmMemberRecharge.Dock = DockStyle.Fill;
            frmMemberRecharge.Show();
        }
        #endregion


        #region 普通消费
        private void btnMemberConsume_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form07_MemberConsume from07 = checkFormIsOpened("Form07_MemberConsume") as Form07_MemberConsume;

            if (from07 == null)
            {
                from07 = new Form07_MemberConsume();

            }

            this.mainPanel.Controls.Clear();
            from07.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(from07);
            from07.Show();
        }
        #endregion


        #region 读入初始化数据
        /// <summary>
        /// 读入初始化数据
        /// </summary>
        private void InitSysData()
        {

            if (!Directory.Exists(Application.StartupPath + "\\ConfigFiles"))
            {
                ShowWarnMsgBox(MessageConst.errMsg_DirectErr);
                this.Close();
                //Application.Exit();
                return;
            }
            try
            {
                XmlDocument xmlYearData = new XmlDocument();
                xmlYearData.Load(Application.StartupPath + "\\ConfigFiles\\Year.xml");
                SysParam.xmlYearInfo = xmlYearData;

                XmlDocument xmlMonthData = new XmlDocument();
                xmlMonthData.Load(Application.StartupPath + "\\ConfigFiles\\Month.xml");
                SysParam.xmlMonthInfo = xmlMonthData;

                XmlDocument xmlDatData = new XmlDocument();
                xmlDatData.Load(Application.StartupPath + "\\ConfigFiles\\Day.xml");
                SysParam.xmlDayInfo = xmlDatData;
            }
            catch (DirectoryNotFoundException ex)
            {
                ShowWarnMsgBox(String.Format("{0}:{1}", MessageConst.errMsg_FileErr, ex.Message));
                this.Close();
                //Application.Exit();
                return;
            }


        }
        #endregion



        #region 商品统计
        private void btnProductStat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion



    }
}