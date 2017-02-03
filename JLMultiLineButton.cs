using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace JASH
{
    class JLMultiLineButton:RoundPanel
    {
        public Form pForm;
        public Color oldColor;

        public JLLabel txtSub;
        public JLLabel txtMain;
        public PictureBox imIcon;

        //--
        //正規作法 把內部事件轉到表單事件 的 對應建構子 2017/01/13
        public JLMultiLineButton(): base()
        {
            pForm = null;
            Font SysFont = this.Font;//
            this.m_intIndex = 0;


            //產生紫元件實體
            txtSub = new JASH.JLLabel();
            txtMain = new JASH.JLLabel();
            imIcon = new System.Windows.Forms.PictureBox();

            //txtSub.Enabled = false;
            txtSub.AutoSize = true;
            txtSub.Font = new System.Drawing.Font("微軟正黑體", (SysFont.Size - 5), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            txtSub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            txtSub.Location = new System.Drawing.Point(75, 41);
            txtSub.Size = new System.Drawing.Size(46, 16);
            txtSub.Text = "label2";

            //txtMain.Enabled = false;
            txtMain.AutoSize = true;
            txtMain.Location = new System.Drawing.Point(74, 10);
            txtMain.Size = new System.Drawing.Size(33, 12);
            txtMain.Text = "label1";

            imIcon.Enabled = false;
            imIcon.Location = new System.Drawing.Point(18, 10);
            imIcon.Size = new System.Drawing.Size(50, 50);


            //外框
            BorderColor = System.Drawing.Color.Black;
            Controls.Add(this.txtSub);
            Controls.Add(this.txtMain);
            Controls.Add(this.imIcon);
            Radius = 35;
            RoundeStyle = JASH.RoundPanel.RoundStyle.All;
            Size = new System.Drawing.Size(250, 70);

            //事件回應區
            this.MouseHover += Object_MouseHover;
            this.MouseLeave += Object_MouseLeave;
            txtSub.MouseHover += Object_MouseHover;
            txtSub.MouseLeave += Object_MouseLeave;
            txtMain.MouseHover += Object_MouseHover;
            txtMain.MouseLeave += Object_MouseLeave;

            this.Click += Object_Click;
            txtSub.Click += Object_Click;
            txtMain.Click += Object_Click;
            imIcon.Click += Object_Click;
        }
        //--

        public JLMultiLineButton(Form pf):base()//建構子建立外框和元件加載與擺放
        {
            pForm = pf;
            Font SysFont = ((Form1)pForm).Font;//
            this.m_intIndex = 0;


            //產生紫元件實體
            txtSub = new JASH.JLLabel();
            txtMain = new JASH.JLLabel();
            imIcon = new System.Windows.Forms.PictureBox();
            
            //txtSub.Enabled = false;
            txtSub.AutoSize = true;
            txtSub.Font = new System.Drawing.Font("微軟正黑體", (SysFont.Size-5), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            txtSub.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            txtSub.Location = new System.Drawing.Point(75, 41);
            txtSub.Size = new System.Drawing.Size(46, 16);
            txtSub.Text = "label2";

            //txtMain.Enabled = false;
            txtMain.AutoSize = true;
            txtMain.Location = new System.Drawing.Point(74, 10);
            txtMain.Size = new System.Drawing.Size(33, 12);
            txtMain.Text = "label1";

            imIcon.Enabled = false;
            imIcon.Location = new System.Drawing.Point(18, 10);
            imIcon.Size = new System.Drawing.Size(50, 50);


            //外框
            BorderColor = System.Drawing.Color.Black;
            Controls.Add(this.txtSub);
            Controls.Add(this.txtMain);
            Controls.Add(this.imIcon);
            Radius = 35;
            RoundeStyle = JASH.RoundPanel.RoundStyle.All;
            Size = new System.Drawing.Size(250, 70);

            //事件回應區
            this.MouseHover+=Object_MouseHover;
            this.MouseLeave += Object_MouseLeave;
            txtSub.MouseHover += Object_MouseHover;
            txtSub.MouseLeave += Object_MouseLeave;
            txtMain.MouseHover += Object_MouseHover;
            txtMain.MouseLeave += Object_MouseLeave;

            this.Click += Object_Click;
            txtSub.Click += Object_Click;
            txtMain.Click += Object_Click;
            imIcon.Click += Object_Click;
        }

        public void Object_MouseHover(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            Rectangle r = new Rectangle();
            r.Width = this.Width;
            r.Height = this.Height;
            Draw(r, g, 35, false, System.Drawing.SystemColors.ActiveCaption, System.Drawing.SystemColors.ActiveCaption);//35要配合元件的角度做修改

            oldColor = this.BackColor;
            imIcon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txtMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            txtSub.BackColor = System.Drawing.SystemColors.ActiveCaption;
            Cursor.Current = Cursors.Hand;//變換滑鼠
        }
        public void Object_MouseLeave(object sender, EventArgs e)
        {
            this.BorderColor = Color.Black;
            Graphics g = Graphics.FromHwnd(this.Handle);
            Rectangle r = new Rectangle();
            r.Width = this.Width;
            r.Height = this.Height;
            Draw(r, g, 35, false, System.Drawing.SystemColors.ButtonFace, System.Drawing.SystemColors.ButtonFace);//35要配合元件的角度做修改

            imIcon.BackColor = oldColor;
            txtMain.BackColor = oldColor;
            txtSub.BackColor = oldColor;
            Cursor.Current = Cursors.Default;//換回滑鼠游標
        }
        public void Draw(Rectangle rectangle, Graphics g, int _radius, bool cusp, Color begin_color, Color end_color)
        {
            int span = 2;
            //抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            //渐变填充
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(rectangle, begin_color, end_color, LinearGradientMode.Vertical);
            //画尖角
            if (cusp)
            {
                span = 10;
                PointF p1 = new PointF(rectangle.Width - 12, rectangle.Y + 10);
                PointF p2 = new PointF(rectangle.Width - 12, rectangle.Y + 30);
                PointF p3 = new PointF(rectangle.Width, rectangle.Y + 20);
                PointF[] ptsArray = { p1, p2, p3 };
                g.FillPolygon(myLinearGradientBrush, ptsArray);
            }
            //填充
            g.FillPath(myLinearGradientBrush, DrawRoundRect(rectangle.X, rectangle.Y, rectangle.Width - span, rectangle.Height - 1, _radius));
        }
        public GraphicsPath DrawRoundRect(int x, int y, int width, int height, int radius)
        {
            //四边圆角
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(x, y, radius, radius, 180, 90);
            gp.AddArc(width - radius, y, radius, radius, 270, 90);
            gp.AddArc(width - radius, height - radius, radius, radius, 0, 90);
            gp.AddArc(x, height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            return gp;
        }

        public event EventHandler Objects_Click;
        public void Object_Click(object sender, EventArgs e)
        {
            //--
            //正規作法 把內部事件轉到表單事件 2017/01/13
            if (Objects_Click != null)
            {
                Objects_Click(this, e);
                return;
                /*對應使用發法 2017/01/13
                        private void jlMultiLineButton1_Objects_Click(object sender, EventArgs e)
                        {
                            MessageBox.Show("test");
                        }
                 */
            }
            //--
            ((Form1)pForm).JLMultiLineButton(m_intIndex);
        }
    }
}
