using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace JASH
{
    internal class BandTagInfo
    {
        public OutlookBar outlookBar;
        public int index;

        public BandTagInfo(OutlookBar ob, int index)
        {
            outlookBar = ob;
            this.index = index;
        }
    }

    public class OutlookBar : Panel
    {
        private int buttonHeight;
        private int selectedBand;
        private int selectedBandHeight;

        public int ButtonHeight
        {
            get
            {
                return buttonHeight;
            }

            set
            {
                buttonHeight = value;
                // do recalc layout for entire bar
            }
        }

        public int SelectedBand
        {
            get
            {
                return selectedBand;
            }
            set
            {
                SelectBand(value);
            }
        }

        public OutlookBar()
        {
            buttonHeight = 25;
            selectedBand = 0;
            selectedBandHeight = 0;
        }

        public void Initialize()
        {
            // parent must exist!
            Parent.SizeChanged += new EventHandler(SizeChangedEvent);
        }

        public void AddBand(string caption, ContentPanel content, int setIndex=-1)
        {
            content.outlookBar = this;
            int index;
            if (setIndex < 0)//為了日後手動指定做修改 at 2017/09/11
            {
                index = Controls.Count;
            }
            else
            {
                index = setIndex;
            }
            BandTagInfo bti = new BandTagInfo(this, index);
            BandPanel bandPanel = new BandPanel(caption, content, bti);
            Controls.Add(bandPanel);
            UpdateBarInfo();
            RecalcLayout(bandPanel, index);
        }
        public void AddBand(Image im, string caption, ContentPanel content, int setIndex = -1)
        {
            content.outlookBar = this;
            int index;
            if (setIndex < 0)//為了日後手動指定做修改 at 2017/09/11
            {
                index = Controls.Count;
            }
            else
            {
                index = setIndex;
            }
            BandTagInfo bti = new BandTagInfo(this, index);
            BandPanel bandPanel = new BandPanel(im, caption, content, bti);
            Controls.Add(bandPanel);
            UpdateBarInfo();
            RecalcLayout(bandPanel, index);
        }
        public void DelAllBand()
        {
            Controls.Clear();
        }
        public void SelectBand(int index)
        {
            selectedBand = index;
            RedrawBands();
            RedrawBands();//2017/01/08 多一次 讓系統繪圖正常
        }

        private void RedrawBands()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                BandPanel bp = Controls[i] as BandPanel;
                RecalcLayout(bp, i);
            }
        }

        private void UpdateBarInfo()
        {
            selectedBandHeight = ClientRectangle.Height - (Controls.Count * buttonHeight);
        }

        private void RecalcLayout(BandPanel bandPanel, int index)
        {
            int vPos = (index <= selectedBand) ? buttonHeight * index : buttonHeight * index + selectedBandHeight;
            int height = selectedBand == index ? selectedBandHeight + buttonHeight : buttonHeight;

            // the band dimensions
            bandPanel.Location = new Point(0, vPos);
            bandPanel.Size = new Size(ClientRectangle.Width, height);

            // the contained button dimensions
            bandPanel.Controls[0].Location = new Point(0, 0);
            bandPanel.Controls[0].Size = new Size(ClientRectangle.Width, buttonHeight);

            // the contained content panel dimensions
            bandPanel.Controls[1].Location = new Point(0, buttonHeight);
            bandPanel.Controls[1].Size = new Size(ClientRectangle.Width - 2, height - 8);
            
            IconPanel IP = (IconPanel)bandPanel.Controls[1];
            IP.resetPanelTextBackColor(1);//2016/01/08  避免系統反應太慢，造成畫面出現一個以上的選擇UI
        }

        private void SizeChangedEvent(object sender, EventArgs e)
        {
            Size = new Size(Size.Width, ((Control)sender).ClientRectangle.Size.Height);
            UpdateBarInfo();
            RedrawBands();
        }
    }

    internal class BandPanel : Panel
    {
        public BandPanel(Image im, string caption, ContentPanel content, BandTagInfo bti)
        {
            BandButton bandButton = new BandButton(im, caption, bti);
            bandButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;//設定文字對其方式
            Controls.Add(bandButton);
            Controls.Add(content);
        }
        public BandPanel(string caption, ContentPanel content, BandTagInfo bti)
        {
            BandButton bandButton = new BandButton(caption, bti);
            bandButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;//設定文字對其方式
            Controls.Add(bandButton);
            Controls.Add(content);
        }
    }

    internal class BandButton : Button//Outlook 主按鈕
    {
        public BandTagInfo bti;//2017/01/10 讓Outlook 主按鈕的事件呼叫UI的事件函數 private BandTagInfo bti;

        public BandButton(Image im, string caption, BandTagInfo bti)
        {
            Image = im;
            Text = caption;
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleCenter;
            FlatStyle = FlatStyle.Standard;
            Visible = true;
            this.bti = bti;
            Click += new EventHandler(SelectBand);
            Click += Main_Frm.pForm1.OutlookMenuMain_Click;//2017/01/10 讓Outlook 主按鈕的事件呼叫UI的事件函數
            MouseLeave += new EventHandler(OnMouseLeave);
            MouseMove += new MouseEventHandler(OnMouseMove);
        }
        public BandButton(string caption, BandTagInfo bti)
        {
            Text = caption;
            FlatStyle = FlatStyle.Standard;
            Visible = true;
            this.bti = bti;
            Click += new EventHandler(SelectBand);
            Click += Main_Frm.pForm1.OutlookMenuMain_Click;//2017/01/10 讓Outlook 主按鈕的事件呼叫UI的事件函數
            MouseLeave += new EventHandler(OnMouseLeave);
            MouseMove += new MouseEventHandler(OnMouseMove);
        }
        private void OnMouseMove(object sender, MouseEventArgs args)
        {
            Cursor.Current = Cursors.Hand;//變換滑鼠
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;//換回滑鼠游標
        }
        private void SelectBand(object sender, EventArgs e)
        {
            bti.outlookBar.SelectBand(bti.index);
        }
    }

    public abstract class ContentPanel : Panel
    {
        public OutlookBar outlookBar;

        public ContentPanel()
        {
            // initial state
            Visible = true;
        }
    }

    public class PanelText : Label
    {
        public IconPanel m_IconPanel;////2017/01/09
        public PanelIcon m_PanelIcon;
        private Color bckgColor;
        public PanelText()
        {
            m_IconPanel = null;//2017/01/09
            m_PanelIcon = null;
            bckgColor = BackColor;
            MouseLeave += new EventHandler(OnMouseLeave);
            MouseMove += new MouseEventHandler(OnMouseMove);
        }
        private void OnMouseMove(object sender, MouseEventArgs args)
        {
            m_IconPanel.resetPanelTextBackColor();////2017/01/09
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;//Color.LightCyan;
            BorderStyle = BorderStyle.FixedSingle;
            if (m_PanelIcon != null)
            {
                m_PanelIcon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;//Color.LightCyan;
                //2016/01/08 disable-> m_PanelIcon.BorderStyle = BorderStyle.FixedSingle;
            }
            Cursor.Current = Cursors.Hand;//變換滑鼠
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            BackColor = bckgColor;
            BorderStyle = BorderStyle.None;
            if (m_PanelIcon != null)
            {
                m_PanelIcon.BackColor = bckgColor;
                //2016/01/08 disable-> m_PanelIcon.BorderStyle = BorderStyle.None;
            }
            Cursor.Current = Cursors.Default;//換回滑鼠游標
        }
    }

    public class IconPanel : ContentPanel//子選單
    {
        protected int iconSpacing;
        protected int margin;
        //private Color bckgColor;
        public ArrayList m_ArrayList;
        
        public void resetPanelTextBackColor(int state=0)
        {
            for (int i = 0; i < m_ArrayList.Count; i++)
            {
                ((PanelText)m_ArrayList[i]).BackColor = System.Drawing.SystemColors.Control;
                ((PanelText)m_ArrayList[i]).m_PanelIcon.BackColor = System.Drawing.SystemColors.Control;
                if (state == 1)
                {
                    ((PanelText)m_ArrayList[i]).BorderStyle = BorderStyle.None;
                }
            }
        }

        public int IconSpacing
        {
            get
            {
                return iconSpacing;
            }
        }

        public int Margin
        {
            get
            {
                return margin;
            }
        }

        public IconPanel()
        {
            margin = 10;
            iconSpacing = 32 + 15 + 10;	// icon height + text height + margin
            BackColor = System.Drawing.SystemColors.Control;//MENU 顏色
            AutoScroll = true;
            m_ArrayList = new ArrayList();
            m_ArrayList.Clear();
        }

        public void AddIcon(string caption, Image image, EventHandler onClickEvent, int Height, int Placed=0,int setindex=-1)
        {
            int index = Controls.Count / 2;	// two entries per icon
            int Index;
            if (setindex < 0)//為了日後手動指定做修改 at 2017/09/11
            {
                Index = index;
            }
            else
            {
                Index = setindex;
            }
            PanelIcon panelIcon=null;
            if (Placed == 0)
            {
                panelIcon = new PanelIcon(this, image, Index, index, index * (Height + image.Height));//panelIcon = new PanelIcon(this, image, index, onClickEvent, index * (Height + image.Height));
            }
            else
            {
                panelIcon = new PanelIcon(this, image, Index, index, index * (Height + image.Height), Placed);
            }
            panelIcon.Enabled = false;//2016/01/08
            Controls.Add(panelIcon);

            PanelText label = new PanelText();
            label.Text = caption;
            label.Visible = true;
            if (Placed == 0)
            {
                label.Location = new Point(0, margin + image.Size.Height + panelIcon.Location.Y);
            }
            else
            {
                Point data=new Point(panelIcon.Location.X,panelIcon.Location.Y-1);//2016/01/08
                label.Location = data;//2016/01/08
            }
            label.Size = new Size(Size.Width, image.Size.Height + 2);//2016/01/08 +2
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += onClickEvent;//實際項目事件
            label.Tag = panelIcon;
            Controls.Add(label);
            m_ArrayList.Add(label);

            panelIcon.m_Label = label;
            label.m_PanelIcon = panelIcon;
            label.m_IconPanel = this;
        }
    }

    public class PanelIcon : PictureBox//MENU上的圖片元件
    {
        public int index;
        public IconPanel iconPanel;
        private Color bckgColor;

        public Label m_Label;

        public int Index
        {
            get
            {
                return index;
            }
        }

        public PanelIcon(IconPanel parent, Image image, int index,int size, int Height, int Placed = 0)
        {
            this.index = index;
            this.iconPanel = parent;
            Image = image;
            Visible = true;
            if (Placed == 0)
            {
                Location = new Point(iconPanel.outlookBar.Size.Width / 2 - image.Size.Width / 2,
                                iconPanel.Margin + size * iconPanel.IconSpacing + Height);
            }
            else
            {
                Location = new Point(0, iconPanel.Margin + size * iconPanel.IconSpacing + Height);
            }
            Size = image.Size;
            //Click += onClickEvent;
            Tag = this;

            bckgColor = iconPanel.BackColor;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;//2016/01/08
        }
    }

}
