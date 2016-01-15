namespace SimpleNetkeeper_ChinaNetValidationCode
{
    partial class MainWin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getCode = new System.Windows.Forms.Button();
            this.validCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机号";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(77, 96);
            this.tbNum.MaxLength = 11;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(176, 21);
            this.tbNum.TabIndex = 1;
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(77, 136);
            this.tbCode.MaxLength = 10;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(176, 21);
            this.tbCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "验证码";
            // 
            // getCode
            // 
            this.getCode.Location = new System.Drawing.Point(263, 96);
            this.getCode.Name = "getCode";
            this.getCode.Size = new System.Drawing.Size(75, 23);
            this.getCode.TabIndex = 4;
            this.getCode.Text = "获取验证码";
            this.getCode.UseVisualStyleBackColor = true;
            this.getCode.Click += new System.EventHandler(this.getCode_Click);
            // 
            // validCode
            // 
            this.validCode.Location = new System.Drawing.Point(263, 136);
            this.validCode.Name = "validCode";
            this.validCode.Size = new System.Drawing.Size(75, 23);
            this.validCode.TabIndex = 5;
            this.validCode.Text = "确认验证码";
            this.validCode.UseVisualStyleBackColor = true;
            this.validCode.Click += new System.EventHandler(this.validCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "By CrazyChen @ CQUT . https://sunflyer.cn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "此程序用于帮助新疆电信天翼宽带**路由器**用户获取\r\n\r\n短信验证码，避免出现登录后3分钟掉线的情况。\r\n\r\n请不要滥用此软件！";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 195);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.validCode);
            this.Controls.Add(this.getCode);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWin";
            this.Text = "新疆电信天翼宽带验证码获取程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getCode;
        private System.Windows.Forms.Button validCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

