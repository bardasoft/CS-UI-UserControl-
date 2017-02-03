using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace JASH.UI_Lib
{
    public partial class Door12 : UserControl
    {
        public ArrayList ALckb = new ArrayList();
        public ArrayList ALtxt = new ArrayList();
        public ArrayList ALgpb = new ArrayList();
        public void setDoorShow(int showNum)
        {
            for (int i = 0; i < ALgpb.Count; i++)
            {
                ((TextBox)ALtxt[i]).Enabled = false;
                ((TextBox)ALtxt[i]).Text = "";
                ((BorderGroupBox)ALgpb[i]).Visible = false;
            }
            for (int i = 0; i < showNum; i++)
            {
                ((BorderGroupBox)ALgpb[i]).Visible = true;
            }
        }
        public void initDoor12UI(ArrayList al, int showNum = 12)
        {

            gpbDoor12_01.Text = (String)al[00];
            gpbDoor12_02.Text = (String)al[01];
            gpbDoor12_03.Text = (String)al[02];
            gpbDoor12_04.Text = (String)al[03];
            gpbDoor12_05.Text = (String)al[04];
            gpbDoor12_06.Text = (String)al[05];
            gpbDoor12_07.Text = (String)al[06];
            gpbDoor12_08.Text = (String)al[07];
            gpbDoor12_09.Text = (String)al[08];
            gpbDoor12_10.Text = (String)al[09];
            gpbDoor12_11.Text = (String)al[10];
            gpbDoor12_12.Text = (String)al[11];

            labDoor12_01.Text = (String)al[12];
            labDoor12_02.Text = (String)al[13];
            labDoor12_03.Text = (String)al[14];
            labDoor12_04.Text = (String)al[15];
            labDoor12_05.Text = (String)al[16];
            labDoor12_06.Text = (String)al[17];
            labDoor12_07.Text = (String)al[18];
            labDoor12_08.Text = (String)al[19];
            labDoor12_09.Text = (String)al[20];
            labDoor12_10.Text = (String)al[21];
            labDoor12_11.Text = (String)al[22];
            labDoor12_12.Text = (String)al[23];
            labDoor12_13.Text = (String)al[24];
            labDoor12_14.Text = (String)al[24];
            labDoor12_15.Text = (String)al[24];
            labDoor12_16.Text = (String)al[24];
            labDoor12_17.Text = (String)al[24];
            labDoor12_18.Text = (String)al[24];
            labDoor12_19.Text = (String)al[24];
            labDoor12_20.Text = (String)al[24];
            labDoor12_21.Text = (String)al[24];
            labDoor12_22.Text = (String)al[24];
            labDoor12_23.Text = (String)al[24];
            labDoor12_24.Text = (String)al[24];

            ckbDoor12_01.Text = (String)al[25];
            ckbDoor12_02.Text = (String)al[25];
            ckbDoor12_03.Text = (String)al[25];
            ckbDoor12_04.Text = (String)al[25];
            ckbDoor12_05.Text = (String)al[25];
            ckbDoor12_06.Text = (String)al[25];
            ckbDoor12_07.Text = (String)al[25];
            ckbDoor12_08.Text = (String)al[25];
            ckbDoor12_09.Text = (String)al[25];
            ckbDoor12_10.Text = (String)al[25];
            ckbDoor12_11.Text = (String)al[25];
            ckbDoor12_12.Text = (String)al[25];

            //--
            txtDoor12_01.Enabled = false;
            txtDoor12_02.Enabled = false;
            txtDoor12_03.Enabled = false;
            txtDoor12_04.Enabled = false;
            txtDoor12_05.Enabled = false;
            txtDoor12_06.Enabled = false;
            txtDoor12_07.Enabled = false;
            txtDoor12_08.Enabled = false;
            txtDoor12_09.Enabled = false;
            txtDoor12_10.Enabled = false;
            txtDoor12_11.Enabled = false;
            txtDoor12_12.Enabled = false;
            for (int i = 0; i < ALgpb.Count; i++)
            {
                ((TextBox)ALtxt[i]).Enabled = false;
                ((TextBox)ALtxt[i]).Text = "";
                ((BorderGroupBox)ALgpb[i]).Visible = false;
            }
            for (int i = 0; i < showNum; i++)
            {
                ((BorderGroupBox)ALgpb[i]).Visible = true;
            }
            //--

        }
        public Door12()
        {
            InitializeComponent();
            ALckb.Clear();
            ALckb.Add(ckbDoor12_01);
            ALckb.Add(ckbDoor12_02);
            ALckb.Add(ckbDoor12_03);
            ALckb.Add(ckbDoor12_04);
            ALckb.Add(ckbDoor12_05);
            ALckb.Add(ckbDoor12_06);
            ALckb.Add(ckbDoor12_07);
            ALckb.Add(ckbDoor12_08);
            ALckb.Add(ckbDoor12_09);
            ALckb.Add(ckbDoor12_10);
            ALckb.Add(ckbDoor12_11);
            ALckb.Add(ckbDoor12_12);

            ALtxt.Clear();
            ALtxt.Add(txtDoor12_01);
            ALtxt.Add(txtDoor12_02);
            ALtxt.Add(txtDoor12_03);
            ALtxt.Add(txtDoor12_04);
            ALtxt.Add(txtDoor12_05);
            ALtxt.Add(txtDoor12_06);
            ALtxt.Add(txtDoor12_07);
            ALtxt.Add(txtDoor12_08);
            ALtxt.Add(txtDoor12_09);
            ALtxt.Add(txtDoor12_10);
            ALtxt.Add(txtDoor12_11);
            ALtxt.Add(txtDoor12_12);

            ALgpb.Clear();
            ALgpb.Add(gpbDoor12_01);
            ALgpb.Add(gpbDoor12_02);
            ALgpb.Add(gpbDoor12_03);
            ALgpb.Add(gpbDoor12_04);
            ALgpb.Add(gpbDoor12_05);
            ALgpb.Add(gpbDoor12_06);
            ALgpb.Add(gpbDoor12_07);
            ALgpb.Add(gpbDoor12_08);
            ALgpb.Add(gpbDoor12_09);
            ALgpb.Add(gpbDoor12_10);
            ALgpb.Add(gpbDoor12_11);
            ALgpb.Add(gpbDoor12_12);

        }

        private void ckbDoor12_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ALckb.Count; i++)
            {
                if (((CheckBox)ALckb[i]).Checked == true)
                {
                    ((TextBox)ALtxt[i]).Enabled = true;
                }
                else
                {
                    ((TextBox)ALtxt[i]).Enabled = false;
                    ((TextBox)ALtxt[i]).Text = "";
                }
            }
        }
    }
}
