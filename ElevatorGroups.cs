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
    public partial class ElevatorGroups : UserControl
    {
        public ArrayList m_ALGrp_ckbtext = new ArrayList();
        private String m_StrText;
        [Browsable(true), Category("自訂屬性"), Description("元件顯示文字")]
        public String StrText
        {
            get
            {
                m_StrText = borderGroupBox1.Text;
                return m_StrText;
            }
            set
            {
                m_StrText = value;
                borderGroupBox1.Text = m_StrText;
            }
        }
        public ElevatorGroups()
        {
            InitializeComponent();
            m_StrText = "";
            m_ALGrp_ckbtext.Clear();
            m_ALGrp_ckbtext.Add(grp_ckbtext1);
            m_ALGrp_ckbtext.Add(grp_ckbtext2);
            m_ALGrp_ckbtext.Add(grp_ckbtext3);
            m_ALGrp_ckbtext.Add(grp_ckbtext4);
            m_ALGrp_ckbtext.Add(grp_ckbtext5);
            m_ALGrp_ckbtext.Add(grp_ckbtext6);
            m_ALGrp_ckbtext.Add(grp_ckbtext7);
            m_ALGrp_ckbtext.Add(grp_ckbtext8);
            m_ALGrp_ckbtext.Add(grp_ckbtext9);
            m_ALGrp_ckbtext.Add(grp_ckbtext10);
            m_ALGrp_ckbtext.Add(grp_ckbtext11);
            m_ALGrp_ckbtext.Add(grp_ckbtext12);
            m_ALGrp_ckbtext.Add(grp_ckbtext13);
            m_ALGrp_ckbtext.Add(grp_ckbtext14);
            m_ALGrp_ckbtext.Add(grp_ckbtext15);
            m_ALGrp_ckbtext.Add(grp_ckbtext16);
        }

        //--
        //add 2017/10/19
        public ArrayList m_ALAllName = new ArrayList();

        public void ClearUI()
        {
            for (int i = 0; i < m_ALGrp_ckbtext.Count; i++)
            {
                Grp_ckbtext tmp = ((Grp_ckbtext)m_ALGrp_ckbtext[i]);
                tmp.ClearUI();
            }
        }

        public void SetAllName()
        {
            ClearUI();
            for (int i = 0; i < m_ALAllName.Count; i++)
            {
                String StrName = m_ALAllName[i].ToString();
                if (StrName != "ElevatorGroups-null")
                {
                    int j = i / 8;
                    int k = i % 8;
                    Grp_ckbtext tmp = ((Grp_ckbtext)m_ALGrp_ckbtext[j]);
                    tmp.blnChildsEnabled = true;
                    ((ckbtext)tmp.m_ALckvtext[k]).StrText = StrName;
                    ((ckbtext)tmp.m_ALckvtext[k]).blnUsed = true;
                }
            }
        }

        public void GetAllName()
        {
            m_ALAllName.Clear();
            for (int i = 0; i < m_ALGrp_ckbtext.Count; i++)
            {
                Grp_ckbtext tmp = ((Grp_ckbtext)m_ALGrp_ckbtext[i]);
                for (int j = 0; j < tmp.m_ALckvtext.Count; j++)
                {
                    String StrName = ((ckbtext)tmp.m_ALckvtext[j]).StrText;
                    if (StrName == "")
                    {
                        StrName = "ElevatorGroups-null";
                    }
                    m_ALAllName.Add(StrName);
                }
            }
        }
        //--
    }
}
