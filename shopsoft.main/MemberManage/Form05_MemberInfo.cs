using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Windows.Forms;
using shopsoft.main.Base;
using shopsoft.common.Logic;
using shopsoft.common.DB;
using shopsoft.common.Const;
using shopsoft.common.util;
using System.Xml;
using shopsoft.common;

namespace shopsoft.main.MemberManage
{
    public partial class Form05_MemberInfo : BaseForm
    {

        // 操作类型：1：新建会员；2：修改会员
        private int operFlg { get; set; }
        // 会员ID
        private string memberId { get; set; }
        // 会员信息
        private t_Member_Info memberInfo;

        #region Logic信息
        private readonly MemberLogic memberLogic = new MemberLogic();
        private readonly MemberGradeLogic gradeLogic = new MemberGradeLogic();
        #endregion

        #region  画面初始化
        private Form05_MemberInfo()
        {
            InitializeComponent();
        }

        public Form05_MemberInfo(int oper, string memberId):this()
        {
            // 操作类型
            this.operFlg = oper;
            // 客户ID
            this.memberId = memberId;
        }

        private void Form05_MemberInfo_Load(object sender, EventArgs e)
        {
            // 加载生年月日信息
            LoadBirthdayCombo();

            string gradeId = string.Empty;

            // 加载证件类型列表
            ComboBoxEx cmbIdentyItem = new ComboBoxEx("", "");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("身份证", "1");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("护照", "2");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("驾驶本", "3");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("工作证", "4");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("军官证", "5");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);
            cmbIdentyItem = new ComboBoxEx("其他证件", "6");
            this.cmbIdentityType.Properties.Items.Add(cmbIdentyItem);

            // 操作类型
            if (operFlg == 2)
            {
                // 修改会员
                if (string.IsNullOrEmpty(memberId))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Close();
                    return;
                }

                this.Text = "会员信息-修改会员信息";
                // checkbox保存后继续  不显示
                this.chkIsContinue.Visible = false;
                // date会员有效期 不显示
                this.dateValidityDate.Visible = false;
                // lable会员有效期 不显示
                this.labelControl16.Visible = false;

                // 根据会员ID取得会员信息
                this.memberInfo = memberLogic.GetMemberInfoByMemberID(memberId, this.DBSession);
                if (memberInfo == null)
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Close();
                    return;
                }

                // 会员等级
                if (memberInfo.Member_Grade_ID.Member_Grade_ID != -1)
                {
                    gradeId = memberInfo.Member_Grade_ID.Member_Grade_ID.ToString();
                }

                // 会员编号
                this.txtMemberNo.Properties.ReadOnly = true;
                this.txtMemberNo.Text = memberInfo.Member_No;
                // 会员姓名
                this.txtMemberName.Text = memberInfo.Member_Name;
                // 地址
                this.txtAddress.Text = memberInfo.Address;
                // 电子邮件
                this.txtEmail.Text = memberInfo.Email;
                // 身份证
                this.txtIdentityNo.Text = memberInfo.Identity_No;
                // 手机号码
                this.txtMobile.Text = memberInfo.Mobile_No;
                // 座机
                this.txtPhone.Text = memberInfo.Tel;

                // 生日
                // 年
                this.cmbBirthYear.Text = memberInfo.Birthday_Year;
                string birthMD = memberInfo.Birthday_Month_Day;
                if(!string.IsNullOrEmpty(birthMD) && birthMD.Length==4)
                {
                    this.cmbBirthMonth.Text = birthMD.Substring(0, 2).Equals("00") ? string.Empty : birthMD.Substring(0, 2);
                    this.cmbBirthDay.Text = birthMD.Substring(2, 2).Equals("00") ? string.Empty : birthMD.Substring(2, 2);
                }

            }
            else if (operFlg == 1)
            {
                //  新建会员
                this.Text = "会员信息-添加会员信息";
                this.dateValidityDate.EditValue = DateTime.Now.AddYears(3);
            }

            // 装在会员等级列表
            LoadMemberGradeCombo(gradeId);

        }

        #region 装载生日数据-年月日
        /// <summary>
        /// 装载生日数据-年月日
        /// </summary>
        private void LoadBirthdayCombo()
        {
            // 装载Year信息
            XmlNodeList yearNodeList = SysParam.xmlYearInfo.SelectNodes("//year//yearItem");

            string strYearItem = string.Empty;

            foreach (XmlNode yearNode in yearNodeList)
            {
                strYearItem = yearNode.Attributes["text"].Value;
                this.cmbBirthYear.Properties.Items.Add(strYearItem);
            }

            // 装载Month信息
            XmlNodeList monthNodeList = SysParam.xmlMonthInfo.SelectNodes("//month//monthItem");

            string strMonthItem = string.Empty;

            foreach (XmlNode monthNode in monthNodeList)
            {
                strMonthItem = monthNode.Attributes["text"].Value;
                this.cmbBirthMonth.Properties.Items.Add(strMonthItem);
            }

            // 装载Day信息
            XmlNodeList dayNodeList = SysParam.xmlDayInfo.SelectNodes("//day//dayItem");

            string strDayItem = string.Empty;

            foreach (XmlNode dayNode in dayNodeList)
            {
                strDayItem = dayNode.Attributes["text"].Value;
                this.cmbBirthDay.Properties.Items.Add(strDayItem);
            }
        }
        #endregion

        #region 装载会员等级列表
        /// <summary>
        /// 装载会员等级列表
        /// </summary>
        /// <param name="selectKey"></param>
        private void LoadMemberGradeCombo(string selectKey)
        {
            int sIdx = -1;
            int i = 0;
            // 装在会员等级列表
            using (XPCollection<t_Member_Grade> gradeCollect = gradeLogic.GetMemberGradeList())
            {
                foreach (t_Member_Grade mg in gradeCollect)
                {
                    ComboBoxEx cmbItem = new ComboBoxEx(mg.Grade_Name, mg.Member_Grade_ID.ToString());
                    this.cmbMemberGrade.Properties.Items.Add(cmbItem);
                    if (!string.IsNullOrEmpty(selectKey) && selectKey.Equals(mg.Member_Grade_ID.ToString()))
                        sIdx = i;

                    i++;
                }
                this.cmbMemberGrade.SelectedIndex = sIdx;
            }

        }
        #endregion

        #endregion

        #region 保存按钮事件
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            // 检查输入项
            if (!checkCondition())
            {
                return;
            }

            // 新建会员/修改会员-DB操作
            MemberOperate();

            if (this.operFlg == 1)
            {
                // 新建会员，如果继续新建，清空画面上的内容
                if (this.chkIsContinue.Checked)
                {
                    this.txtMemberNo.Text = string.Empty;
                    this.txtMemberName.Text = string.Empty;
                    this.txtAddress.Text = string.Empty;
                    this.txtEmail.Text = string.Empty;
                    this.txtIdentityNo.Text = string.Empty;
                    this.txtInstantMessage.Text = string.Empty;
                    this.txtMobile.Text = string.Empty;
                    this.txtPhone.Text = string.Empty;
                    this.cmbMemberGrade.SelectedIndex = -1;
                    this.cmbIdentityType.SelectedIndex = -1;
                    this.cmbBirthYear.SelectedIndex = -1;
                    this.cmbBirthMonth.SelectedIndex = -1;
                    this.cmbBirthDay.SelectedIndex = -1;
                    this.cmbSex.SelectedIndex = -1;
                    this.spinMemberBonus.Value = 0;
                    this.dateValidityDate.EditValue = DateTime.Now.AddYears(3);
                    this.memoComment.Text = string.Empty;
                }
                else
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }

        }
        #endregion

        #region 新建会员/修改会员-DB操作
        /// <summary>
        /// 新建会员/修改会员-DB操作
        /// </summary>
        private void MemberOperate()
        {
            if (operFlg == 2)
            {
                // 修改会员
                if (this.memberInfo == null)
                {
                    ShowWarnMsgBox(MessageConst.errMsg_DataError);
                    this.Close();
                    return;
                }
            }
            else
            {
                // 新建会员
                this.memberInfo = new t_Member_Info();
            }

            // 会员编号
            memberInfo.Member_No = this.txtMemberNo.Text;
            //会员姓名
            memberInfo.Member_Name = this.txtMemberName.Text.Trim();

            //性别
            if (this.cmbSex.SelectedIndex != -1)
            {
                memberInfo.Sex = this.cmbSex.SelectedIndex;
            }

            // 会员等级
            string gradeId = ((ComboBoxEx)this.cmbMemberGrade.SelectedItem).Key;
            t_Member_Grade gradeInfo = gradeLogic.GetMemberGradeByID(Convert.ToInt16(gradeId));
            memberInfo.Member_Grade_ID = gradeInfo;

            // 会员积分
            memberInfo.Bouns = Convert.ToInt32(this.spinMemberBonus.Text);

            //手机
            memberInfo.Mobile_No = string.IsNullOrEmpty(this.txtMobile.Text.Trim()) ? null : this.txtMobile.Text.Trim();

            //固定电话
            memberInfo.Tel = string.IsNullOrEmpty(this.txtPhone.Text.Trim()) ? null : this.txtPhone.Text.Trim();

            //电子邮件
            memberInfo.Email = string.IsNullOrEmpty(this.txtEmail.Text.Trim()) ? null : this.txtEmail.Text.Trim();

            //即时通讯
            memberInfo.Instant_Message = string.IsNullOrEmpty(this.txtInstantMessage.Text.Trim()) ? null : this.txtInstantMessage.Text.Trim();

            // 证件类型
            if (this.cmbIdentityType.SelectedIndex > 0)
            {
                memberInfo.Identity_Type = Convert.ToInt16(((ComboBoxEx)this.cmbIdentityType.SelectedItem).Key);
            }

            //证件号码
            memberInfo.Identity_No = string.IsNullOrEmpty(this.txtIdentityNo.Text.Trim()) ? null : this.txtIdentityNo.Text.Trim();

            // 生日-年
            memberInfo.Birthday_Year = string.IsNullOrEmpty(this.cmbBirthYear.Text) ? null : this.cmbBirthYear.Text;

            // 生日-月日
            string birMD = "";
            if (string.IsNullOrEmpty(this.cmbBirthMonth.Text))
            {
                birMD = "00";
            }
            else
            {
                birMD = this.cmbBirthMonth.Text;
            }
            if (string.IsNullOrEmpty(this.cmbBirthDay.Text))
            {
                birMD = birMD + "00";
            }
            else
            {
                birMD = birMD + this.cmbBirthDay.Text;
            }
            memberInfo.Birthday_Month_Day = birMD;

            // 地址
            memberInfo.Address = string.IsNullOrEmpty(this.txtAddress.Text.Trim()) ? null : this.txtAddress.Text.Trim();

            // 备注
            memberInfo.Comment = string.IsNullOrEmpty(this.memoComment.Text.Trim()) ? null : this.memoComment.Text.Trim();

            // 有效期
            memberInfo.Validity_Date = this.dateValidityDate.DateTime;

            //数据更新时间
            memberInfo.Update_DateTime = DateTime.Now;

            //数据状态-正常
            memberInfo.State = (int)RecordState.Normal;

            memberInfo.Save();

            if (operFlg == 1)
            {
                // 新建会员成功
                ShowInfoMsgBox(MessageConst.info_MemberCreateSuccess);
            }
            else
            {
                // 修改会员成功
                ShowInfoMsgBox(MessageConst.info_MemberUpdateSuccess);
            }
            return;
        }
        #endregion

        #region 项目输入检查
        /// <summary>
        /// 项目输入检查
        /// </summary>
        /// <returns>true:正确；false:不正确</returns>
        private bool checkCondition()
        {
            bool res = false;

            // 如果是新建会员，则对会员编号进行检查
            if (this.operFlg == 1)
            {
                // 检查是否输入会员编号
                if (string.IsNullOrEmpty(this.txtMemberNo.Text))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_noInput);
                    this.txtMemberNo.Focus();
                    return res;
                }

                // 检查会员编号是否存在
                if (memberLogic.IsExistMember(this.txtMemberNo.Text.Trim()))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_memberExited);
                    this.txtMemberNo.Focus();
                    return res;
                }
            }            

            // 检查会员等级
            if (this.cmbMemberGrade.SelectedIndex == -1)
            {
                ShowWarnMsgBox(MessageConst.errMsg_noMemberGrade);
                this.cmbMemberGrade.Focus();
                return res;
            }

            // 检查积分是否大于等于0
            if (this.spinMemberBonus.Value < 0)
            {
                ShowWarnMsgBox(MessageConst.errMsg_BonusErr);
                this.spinMemberBonus.Focus();
                return res;
            }

            // 检查手机号是否正确
            if (!string.IsNullOrEmpty(this.txtMobile.Text.Trim()) || !FormUtil.CheckPhone(this.txtMobile.Text.Trim()))
            {
                ShowWarnMsgBox(MessageConst.errMsg_MobileErr);
                this.txtMobile.Focus();
                return res;
            }

            // 如果是新建会员，则对会员有效期进行检查
            if (this.operFlg == 1)
            {
                // 检查是否输入有效日期
                if (string.IsNullOrEmpty(this.dateValidityDate.Text))
                {
                    ShowWarnMsgBox(MessageConst.errMsg_noValidityDate);
                    this.dateValidityDate.Focus();
                    return res;
                }

                // 检查有效期是否合法
                if (Convert.ToDateTime(this.dateValidityDate.EditValue).CompareTo(DateTime.Now) < 0)
                {
                    ShowWarnMsgBox(MessageConst.errMsg_ValidityDateErr);
                    this.dateValidityDate.Focus();
                    return res;
                }
            }

            res = true;
            return res;

        }
        #endregion

        #region 退出按钮
        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region 注册快捷键：确定-F5;取消-F4
        /// <summary>
        /// 注册快捷键：确定-F5;取消-F4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form05_MemberInfo_KeyDown(object sender, KeyEventArgs e)
        {
            // 如果点击F5，则保存会员。
            if (Keys.F5.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnCreateMember_Click(sender, e);
                return;
            }

            // 如果点击F4，则取消
            if (Keys.F4.Equals(e.KeyCode))
            {
                e.Handled = true;
                this.btnCancle_Click(sender, e);
                return;
            }
        }
        #endregion

    }

}
