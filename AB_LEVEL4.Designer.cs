namespace JASH
{
    partial class AB_LEVEL4
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lineX4 = new JASH.LineX();
            this.lineX3 = new JASH.LineX();
            this.jlNumEdit2 = new JASH.JLNumEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.lineY3 = new JASH.LineY();
            this.lineY2 = new JASH.LineY();
            this.lineY1 = new JASH.LineY();
            this.jlNumEdit1 = new JASH.JLNumEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.lineX2 = new JASH.LineX();
            this.lineX1 = new JASH.LineX();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineX5 = new JASH.LineX();
            this.lineY4 = new JASH.LineY();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "A/B 門區 LEVEL 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(366, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "4 個門將&互相鎖定&，當開啟其中一門，其餘門區將產生&暫時鎖定&，\\r直至通行完畢恢復門位狀態。";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1073, 5);
            this.label9.TabIndex = 2;
            this.label9.Text = "label3";
            // 
            // lineX4
            // 
            this.lineX4.blnArrow = false;
            this.lineX4.blnDash = true;
            this.lineX4.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX4.LineWidth = 10;
            this.lineX4.Location = new System.Drawing.Point(413, 131);
            this.lineX4.Name = "lineX4";
            this.lineX4.Size = new System.Drawing.Size(181, 10);
            this.lineX4.TabIndex = 71;
            // 
            // lineX3
            // 
            this.lineX3.blnArrow = false;
            this.lineX3.blnDash = true;
            this.lineX3.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX3.LineWidth = 10;
            this.lineX3.Location = new System.Drawing.Point(186, 132);
            this.lineX3.Name = "lineX3";
            this.lineX3.Size = new System.Drawing.Size(178, 10);
            this.lineX3.TabIndex = 70;
            // 
            // jlNumEdit2
            // 
            this.jlNumEdit2.Location = new System.Drawing.Point(788, 191);
            this.jlNumEdit2.LoopValue = true;
            this.jlNumEdit2.MaxValue = 60;
            this.jlNumEdit2.MinValue = 0;
            this.jlNumEdit2.Name = "jlNumEdit2";
            this.jlNumEdit2.Size = new System.Drawing.Size(37, 26);
            this.jlNumEdit2.TabIndex = 69;
            this.jlNumEdit2.Value = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(784, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Door 1 (門區 1)：";
            // 
            // lineY3
            // 
            this.lineY3.blnArrow = false;
            this.lineY3.blnDash = false;
            this.lineY3.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY3.LineWidth = 6;
            this.lineY3.Location = new System.Drawing.Point(763, 168);
            this.lineY3.Name = "lineY3";
            this.lineY3.Size = new System.Drawing.Size(6, 52);
            this.lineY3.TabIndex = 67;
            // 
            // lineY2
            // 
            this.lineY2.blnArrow = false;
            this.lineY2.blnDash = true;
            this.lineY2.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY2.LineWidth = 10;
            this.lineY2.Location = new System.Drawing.Point(586, 145);
            this.lineY2.Name = "lineY2";
            this.lineY2.Size = new System.Drawing.Size(10, 53);
            this.lineY2.TabIndex = 66;
            // 
            // lineY1
            // 
            this.lineY1.blnArrow = false;
            this.lineY1.blnDash = true;
            this.lineY1.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY1.LineWidth = 10;
            this.lineY1.Location = new System.Drawing.Point(184, 145);
            this.lineY1.Name = "lineY1";
            this.lineY1.Size = new System.Drawing.Size(10, 53);
            this.lineY1.TabIndex = 65;
            // 
            // jlNumEdit1
            // 
            this.jlNumEdit1.Location = new System.Drawing.Point(370, 121);
            this.jlNumEdit1.LoopValue = true;
            this.jlNumEdit1.MaxValue = 60;
            this.jlNumEdit1.MinValue = 0;
            this.jlNumEdit1.Name = "jlNumEdit1";
            this.jlNumEdit1.Size = new System.Drawing.Size(37, 26);
            this.jlNumEdit1.TabIndex = 64;
            this.jlNumEdit1.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Door 1 (門區 1)：";
            // 
            // lineX2
            // 
            this.lineX2.blnArrow = true;
            this.lineX2.blnDash = false;
            this.lineX2.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX2.LineWidth = 16;
            this.lineX2.Location = new System.Drawing.Point(352, 198);
            this.lineX2.Name = "lineX2";
            this.lineX2.Size = new System.Drawing.Size(71, 16);
            this.lineX2.TabIndex = 62;
            // 
            // lineX1
            // 
            this.lineX1.blnArrow = true;
            this.lineX1.blnDash = false;
            this.lineX1.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX1.LineWidth = 16;
            this.lineX1.Location = new System.Drawing.Point(153, 198);
            this.lineX1.Name = "lineX1";
            this.lineX1.Size = new System.Drawing.Size(71, 16);
            this.lineX1.TabIndex = 61;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(429, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 29);
            this.textBox3.TabIndex = 60;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(630, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 29);
            this.textBox4.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 29);
            this.textBox2.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 29);
            this.textBox1.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Location = new System.Drawing.Point(425, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Door 4 (門區 4)：";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(626, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Door 3 (門區 3)：";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(220, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Door 2 (門區 2)：";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(19, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Door 1 (門區 1)：";
            // 
            // lineX5
            // 
            this.lineX5.blnArrow = true;
            this.lineX5.blnDash = false;
            this.lineX5.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX5.LineWidth = 16;
            this.lineX5.Location = new System.Drawing.Point(557, 198);
            this.lineX5.Name = "lineX5";
            this.lineX5.Size = new System.Drawing.Size(71, 16);
            this.lineX5.TabIndex = 72;
            // 
            // lineY4
            // 
            this.lineY4.blnArrow = false;
            this.lineY4.blnDash = true;
            this.lineY4.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY4.LineWidth = 10;
            this.lineY4.Location = new System.Drawing.Point(384, 153);
            this.lineY4.Name = "lineY4";
            this.lineY4.Size = new System.Drawing.Size(10, 43);
            this.lineY4.TabIndex = 73;
            // 
            // AB_LEVEL4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lineY4);
            this.Controls.Add(this.lineX5);
            this.Controls.Add(this.lineX4);
            this.Controls.Add(this.lineX3);
            this.Controls.Add(this.jlNumEdit2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lineY3);
            this.Controls.Add(this.lineY2);
            this.Controls.Add(this.lineY1);
            this.Controls.Add(this.jlNumEdit1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lineX2);
            this.Controls.Add(this.lineX1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AB_LEVEL4";
            this.Size = new System.Drawing.Size(1083, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private LineX lineX4;
        private LineX lineX3;
        private System.Windows.Forms.Label label8;
        private LineY lineY3;
        private LineY lineY2;
        private LineY lineY1;
        private System.Windows.Forms.Label label7;
        private LineX lineX2;
        private LineX lineX1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LineX lineX5;
        private LineY lineY4;
        public JLNumEdit jlNumEdit2;
        public JLNumEdit jlNumEdit1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
    }
}
