using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace JASH
{
    public partial class AB_LEVEL1 : UserControl
    {
        public ArrayList ALlab = new ArrayList();
        public ArrayList ALtxt = new ArrayList();
        public AB_LEVEL1()
        {
            InitializeComponent();
            ALlab.Clear();
            ALlab.Add(label1);
            ALlab.Add(label2);
            ALlab.Add(label3);
            ALlab.Add(label4);
            ALlab.Add(label5);
            ALlab.Add(label6);
            ALtxt.Clear();
            ALtxt.Add(textBox1);
            ALtxt.Add(textBox2);
            ALtxt.Add(textBox3);
            ALtxt.Add(textBox4);
        }
        public void iniAB_LEVELUI(ArrayList al)
        {
            for (int i = 0; i < ALlab.Count; i++)
            {
                ((Label)ALlab[i]).Text = (String)al[i];
            }
        }
    }
}
