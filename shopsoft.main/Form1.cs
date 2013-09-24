using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using DevExpress.LookAndFeel;

namespace shopsoft.main
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");          
           
        }
    }
}
