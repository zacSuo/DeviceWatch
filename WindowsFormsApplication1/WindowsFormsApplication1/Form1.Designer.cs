namespace WindowsFormsApplication1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnError = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnRepair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.LightSalmon;
            this.btnError.Location = new System.Drawing.Point(64, 79);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(146, 33);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "报告故障";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Enabled = false;
            this.tbNumber.Location = new System.Drawing.Point(134, 37);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(76, 25);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "设备编号";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 170);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 15);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "反馈";
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRepair.Location = new System.Drawing.Point(64, 118);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(146, 33);
            this.btnRepair.TabIndex = 0;
            this.btnRepair.Text = "已修复";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 194);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.btnError);
            this.Name = "Form1";
            this.Text = "我是设备";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnRepair;
    }
}

