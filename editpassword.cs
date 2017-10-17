﻿using System;
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

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)//限制密碼輸入
        {
            if (e.KeyChar == 8)//刪除鍵要直接允許
            {
                e.Handled = false;
            }
            else
            {
                if (txtpassword.Text.Length < 16)//長度限制在16
                {
                    if ((e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F') || (e.KeyChar >= '0' && e.KeyChar <= '9'))//限制0~9和A~F
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
