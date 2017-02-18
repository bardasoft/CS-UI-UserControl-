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
    public partial class AB12_LEVEL1 : UserControl
    {
        public ArrayList ALlab = new ArrayList();
        public ArrayList ALtxt = new ArrayList();
        public AB12_LEVEL1()
        {
            InitializeComponent();
            ALlab.Clear();
            ALlab.Add(label1);
            ALlab.Add(label2);
            ALlab.Add(label3);
            ALlab.Add(label4);
            ALlab.Add(label5);
            ALlab.Add(label6);
            ALlab.Add(label7);
            ALlab.Add(label8);
            ALlab.Add(label9);
            ALlab.Add(label10);
            ALlab.Add(label11);
            ALlab.Add(label12);
            ALlab.Add(label13);
            ALlab.Add(label14);
            ALtxt.Clear();
            ALtxt.Add(textBox1);
            ALtxt.Add(textBox2);
            ALtxt.Add(textBox3);
            ALtxt.Add(textBox4);
            ALtxt.Add(textBox5);
            ALtxt.Add(textBox6);
            ALtxt.Add(textBox7);
            ALtxt.Add(textBox8);
            ALtxt.Add(textBox9);
            ALtxt.Add(textBox10);
            ALtxt.Add(textBox11);
            ALtxt.Add(textBox12);
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
