using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace JASH
{
    class JLNumEdit : Panel
    {
        public Button m_butUp;
        public Button m_butDown;
        public TextBox m_TxtValue;
		
		private bool m_blnLoopValue=false;
        [Browsable(true), Category("自訂屬性"), Description("數值循環設定")]
        /// <summary>
        /// 數值循環設定
        /// </summary>
        ///        
		public bool LoopValue
		{
            get { return m_blnLoopValue; }
            set { m_blnLoopValue = value; }
		}
        private int m_intValue;
        [Browsable(true), Category("自訂屬性"), Description("元件的目前值")]
        /// <summary>
        /// 元件的目前值
        /// </summary>
        /// 
        public int Value
        {
            get { return m_intValue; }
            set { m_intValue = value; m_TxtValue.Text = "" + m_intValue; }
        }
        private int m_intMaxValue=4;
        [Browsable(true), Category("自訂屬性"), Description("元件設定的最大值")]
        /// <summary>
        /// 元件設定的最大值
        /// </summary>
        public int MaxValue
        {
            get { return m_intMaxValue; }
            set { m_intMaxValue = value; }
        }

        private int m_intMinValue=1;
        [Browsable(true), Category("自訂屬性"), Description("元件設定的最小值")]
        /// <summary>
        /// 元件設定的最小值
        /// </summary>
        public int MinValue
        {
            get { return m_intMinValue; }
            set { m_intMinValue = value; }
        }

        public JLNumEdit(): base()
        {
            Size = new Size(50, 26);//設定元件大小
            //m_intValue = m_intMinValue;

            m_TxtValue = new TextBox();
            m_TxtValue.Size = new Size(25, 26);
            m_TxtValue.Multiline = true;
            m_TxtValue.Location = new Point(0, 0);
            m_TxtValue.ReadOnly = true;
            m_TxtValue.BorderStyle = BorderStyle.FixedSingle;
            m_TxtValue.Text = "" + m_intValue;
            m_TxtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            m_TxtValue.TextChanged += new System.EventHandler(txt_TextChanged);
            Controls.Add(m_TxtValue);

            m_butUp = new Button();
            m_butUp.Text = "▲";
            m_butUp.Font = new System.Drawing.Font("新細明體", 9, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));//---->2017/01/25-從微軟正黑體改成新細明體，4->9
            m_butUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            m_butUp.Size = new Size(25, 13);
            m_butUp.Location = new Point(25, 0);
            m_butUp.Click += Up_Click;
            Controls.Add(m_butUp);

            m_butDown = new Button();
            m_butDown.Text = "▼";
            m_butDown.Font = new System.Drawing.Font("新細明體", 4, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));//---->2017/01/25-從微軟正黑體改成新細明體
            m_butDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            m_butDown.Size = new Size(25, 13);
            m_butDown.Location = new Point(25, 13);
            m_butDown.Click += Down_Click;
            Controls.Add(m_butDown);

        }

        public event EventHandler Value_Changed;//20170209 將內部事件轉傳
        private void txt_TextChanged(object sender, EventArgs e)
        {
            //正規作法 把內部事件轉到表單事件 2017/01/13
            if (Value_Changed != null)
            {
                Value_Changed(m_TxtValue, e);
                return;
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            m_intValue++;
            if (m_intMaxValue >= m_intValue)
            {
                m_TxtValue.Text = "" + m_intValue;
            }
            else
            {
				if(m_blnLoopValue==false)
				{
					m_TxtValue.Text = "" + m_intMaxValue;
					m_intValue = m_intMaxValue;					
				}
				else
				{
					m_TxtValue.Text = "" + m_intMinValue;//產生循環
					m_intValue = m_intMinValue;//產生循環					
				}
            }
        }
        private void Down_Click(object sender, EventArgs e)
        {
            m_intValue--;
            if (m_intMinValue <= m_intValue)
            {
                m_TxtValue.Text = "" + m_intValue;
            }
            else
            {
				if(m_blnLoopValue==false)
				{
					m_TxtValue.Text = "" + m_intMinValue;
					m_intValue = m_intMinValue;				
				}
				else
				{
					m_TxtValue.Text = "" + m_intMaxValue;//產生循環
					m_intValue = m_intMaxValue;//產生循環					
				}				

            }
        }
    }
}
