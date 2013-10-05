using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using shopsoft.main.Base;

namespace shopsoft.main.Stat
{
    public partial class Form21_MemberConsumeStat : BaseFormX
    {
        public Form21_MemberConsumeStat()
        {
            InitializeComponent();
        }

        private void Form21_MemberConsumeStat_Load(object sender, EventArgs e)
        {
            uC211_ConsumeDetail1.dbsession = this.DBSession;
        }




    }
}
