using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JASH
{
    public partial class editpassword : UserControl
    {
        private String m_StrValue;
        [Browsable(true), Category("自訂屬性"), Description("元件設定的數值")]
        public String StrValue
        {
            get { return m_StrValue = txtpassword.Text; }
            set { m_StrValue = value; txtpassword.Text = m_StrValue; }
        }
        public editpassword()
        {
            InitializeComponent();
        }

        private void viewpassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '\0';
        }

        private void viewpassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
    }
}
