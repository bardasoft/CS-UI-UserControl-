namespace JASH
{
    partial class AB_LEVEL2
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineX1 = new JASH.LineX();
            this.lineX2 = new JASH.LineX();
            this.label7 = new System.Windows.Forms.Label();
            this.jlNumEdit1 = new JASH.JLNumEdit();
            this.lineY1 = new JASH.LineY();
            this.lineY2 = new JASH.LineY();
            this.lineY3 = new JASH.LineY();
            this.label8 = new System.Windows.Forms.Label();
            this.jlNumEdit2 = new JASH.JLNumEdit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 29);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(306, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 29);
            this.textBox4.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 29);
            this.textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 29);
            this.textBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Location = new System.Drawing.Point(101, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Door 4 (門區 4)：";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(302, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Door 3 (門區 3)：";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(302, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Door 2 (門區 2)：";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(101, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Door 1 (門區 1)：";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(5, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1073, 5);
            this.label9.TabIndex = 13;
            this.label9.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(366, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(712, 68);
            this.label2.TabIndex = 12;
            this.label2.Text = "4 個門將&互相鎖定&，當開啟其中一門，其餘門區將產生&暫時鎖定&，\\r直至通行完畢恢復門位狀態。";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 68);
            this.label1.TabIndex = 11;
            this.label1.Text = "A/B 門區 LEVEL 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineX1
            // 
            this.lineX1.blnArrow = true;
            this.lineX1.blnDash = false;
            this.lineX1.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX1.LineWidth = 16;
            this.lineX1.Location = new System.Drawing.Point(235, 193);
            this.lineX1.Name = "lineX1";
            this.lineX1.Size = new System.Drawing.Size(71, 16);
            this.lineX1.TabIndex = 22;
            // 
            // lineX2
            // 
            this.lineX2.blnArrow = true;
            this.lineX2.blnDash = false;
            this.lineX2.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineX2.LineWidth = 16;
            this.lineX2.Location = new System.Drawing.Point(235, 264);
            this.lineX2.Name = "lineX2";
            this.lineX2.Size = new System.Drawing.Size(71, 16);
            this.lineX2.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Door 1 (門區 1)：";
            // 
            // jlNumEdit1
            // 
            this.jlNumEdit1.Location = new System.Drawing.Point(256, 120);
            this.jlNumEdit1.LoopValue = true;
            this.jlNumEdit1.MaxValue = 60;
            this.jlNumEdit1.MinValue = 0;
            this.jlNumEdit1.Name = "jlNumEdit1";
            this.jlNumEdit1.Size = new System.Drawing.Size(37, 26);
            this.jlNumEdit1.TabIndex = 25;
            this.jlNumEdit1.Value = 0;
            // 
            // lineY1
            // 
            this.lineY1.blnArrow = false;
            this.lineY1.blnDash = true;
            this.lineY1.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY1.LineWidth = 10;
            this.lineY1.Location = new System.Drawing.Point(266, 151);
            this.lineY1.Name = "lineY1";
            this.lineY1.Size = new System.Drawing.Size(10, 42);
            this.lineY1.TabIndex = 26;
            // 
            // lineY2
            // 
            this.lineY2.blnArrow = false;
            this.lineY2.blnDash = true;
            this.lineY2.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY2.LineWidth = 10;
            this.lineY2.Location = new System.Drawing.Point(266, 211);
            this.lineY2.Name = "lineY2";
            this.lineY2.Size = new System.Drawing.Size(10, 53);
            this.lineY2.TabIndex = 27;
            // 
            // lineY3
            // 
            this.lineY3.blnArrow = false;
            this.lineY3.blnDash = false;
            this.lineY3.LineColor = System.Drawing.SystemColors.ControlText;
            this.lineY3.LineWidth = 6;
            this.lineY3.Location = new System.Drawing.Point(443, 186);
            this.lineY3.Name = "lineY3";
            this.lineY3.Size = new System.Drawing.Size(6, 100);
            this.lineY3.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Door 1 (門區 1)：";
            // 
            // jlNumEdit2
            // 
            this.jlNumEdit2.Location = new System.Drawing.Point(459, 264);
            this.jlNumEdit2.LoopValue = true;
            this.jlNumEdit2.MaxValue = 60;
            this.jlNumEdit2.MinValue = 0;
            this.jlNumEdit2.Name = "jlNumEdit2";
            this.jlNumEdit2.Size = new System.Drawing.Size(37, 26);
            this.jlNumEdit2.TabIndex = 30;
            this.jlNumEdit2.Value = 0;
            // 
            // AB_LEVEL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "AB_LEVEL2";
            this.Size = new System.Drawing.Size(1083, 399);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private LineX lineX1;
        private LineX lineX2;
        private System.Windows.Forms.Label label7;
        private LineY lineY1;
        private LineY lineY2;
        private LineY lineY3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public JLNumEdit jlNumEdit1;
        public JLNumEdit jlNumEdit2;

    }
}
