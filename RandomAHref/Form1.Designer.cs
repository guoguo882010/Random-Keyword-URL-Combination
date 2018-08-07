namespace RandomAHref
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.AHrefButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearKeywordButton = new System.Windows.Forms.Button();
            this.ClearURLButton = new System.Windows.Forms.Button();
            this.ClearResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(232, 199);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(232, 199);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 228);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(471, 210);
            this.textBox3.TabIndex = 2;
            // 
            // AHrefButton
            // 
            this.AHrefButton.Location = new System.Drawing.Point(409, 444);
            this.AHrefButton.Name = "AHrefButton";
            this.AHrefButton.Size = new System.Drawing.Size(75, 23);
            this.AHrefButton.TabIndex = 3;
            this.AHrefButton.Text = "随机组合";
            this.AHrefButton.UseVisualStyleBackColor = true;
            this.AHrefButton.Click += new System.EventHandler(this.AHrefButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 444);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "全部清空";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "关键字（一行一个）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "网站（一行一个，例：http://baidu.com）";
            // 
            // ClearKeywordButton
            // 
            this.ClearKeywordButton.Location = new System.Drawing.Point(93, 444);
            this.ClearKeywordButton.Name = "ClearKeywordButton";
            this.ClearKeywordButton.Size = new System.Drawing.Size(89, 23);
            this.ClearKeywordButton.TabIndex = 7;
            this.ClearKeywordButton.Text = "清空 关键词";
            this.ClearKeywordButton.UseVisualStyleBackColor = true;
            this.ClearKeywordButton.Click += new System.EventHandler(this.ClearKeywordButton_Click);
            // 
            // ClearURLButton
            // 
            this.ClearURLButton.Location = new System.Drawing.Point(188, 444);
            this.ClearURLButton.Name = "ClearURLButton";
            this.ClearURLButton.Size = new System.Drawing.Size(75, 23);
            this.ClearURLButton.TabIndex = 8;
            this.ClearURLButton.Text = "清空 网址";
            this.ClearURLButton.UseVisualStyleBackColor = true;
            this.ClearURLButton.Click += new System.EventHandler(this.ClearURLButton_Click);
            // 
            // ClearResultButton
            // 
            this.ClearResultButton.Location = new System.Drawing.Point(269, 444);
            this.ClearResultButton.Name = "ClearResultButton";
            this.ClearResultButton.Size = new System.Drawing.Size(75, 23);
            this.ClearResultButton.TabIndex = 9;
            this.ClearResultButton.Text = "清空 结果";
            this.ClearResultButton.UseVisualStyleBackColor = true;
            this.ClearResultButton.Click += new System.EventHandler(this.ClearResultButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 470);
            this.Controls.Add(this.ClearResultButton);
            this.Controls.Add(this.ClearURLButton);
            this.Controls.Add(this.ClearKeywordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AHrefButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "关键字，URL随机组合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button AHrefButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ClearKeywordButton;
        private System.Windows.Forms.Button ClearURLButton;
        private System.Windows.Forms.Button ClearResultButton;
    }
}

