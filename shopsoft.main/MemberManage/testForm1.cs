using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shopsoft.main.Base;

namespace shopsoft.main.MemberManage
{
    public partial class testForm1 : BaseFormX
    {
        public testForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dt = ((DateTime)this.dateEdit1.EditValue).AddDays(0.99);
            this.textEdit1.Text = dt.ToString();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            popupControlContainer1.Show();
        }
    }
}
