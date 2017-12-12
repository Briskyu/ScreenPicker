namespace ScreenColorPicker
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelRGB = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.textBoxRGB = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonFresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(59, 10);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(117, 21);
            this.textBoxX.TabIndex = 0;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 19);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 12);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X：";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 44);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 12);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "Y：";
            // 
            // labelRGB
            // 
            this.labelRGB.AutoSize = true;
            this.labelRGB.Location = new System.Drawing.Point(12, 71);
            this.labelRGB.Name = "labelRGB";
            this.labelRGB.Size = new System.Drawing.Size(35, 12);
            this.labelRGB.TabIndex = 3;
            this.labelRGB.Text = "RGB：";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(12, 100);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(41, 12);
            this.labelBrightness.TabIndex = 4;
            this.labelBrightness.Text = "亮度：";
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(59, 91);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(117, 21);
            this.textBoxBrightness.TabIndex = 5;
            // 
            // textBoxRGB
            // 
            this.textBoxRGB.Location = new System.Drawing.Point(59, 62);
            this.textBoxRGB.Name = "textBoxRGB";
            this.textBoxRGB.Size = new System.Drawing.Size(117, 21);
            this.textBoxRGB.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(59, 35);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(117, 21);
            this.textBoxY.TabIndex = 7;
            // 
            // buttonFresh
            // 
            this.buttonFresh.Location = new System.Drawing.Point(12, 127);
            this.buttonFresh.Name = "buttonFresh";
            this.buttonFresh.Size = new System.Drawing.Size(164, 23);
            this.buttonFresh.TabIndex = 8;
            this.buttonFresh.Text = "重新截取屏幕";
            this.buttonFresh.UseVisualStyleBackColor = true;
            this.buttonFresh.Click += new System.EventHandler(this.buttonFresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 160);
            this.Controls.Add(this.buttonFresh);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxRGB);
            this.Controls.Add(this.textBoxBrightness);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.labelRGB);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "取色器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelRGB;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TextBox textBoxRGB;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonFresh;
    }
}

