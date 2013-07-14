namespace WindowsFormsApplication2
{
    partial class confirmFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLab = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // promptLab
            // 
            this.promptLab.AutoSize = true;
            this.promptLab.Location = new System.Drawing.Point(12, 19);
            this.promptLab.Name = "promptLab";
            this.promptLab.Size = new System.Drawing.Size(71, 12);
            this.promptLab.TabIndex = 0;
            this.promptLab.Text = "来了多少人?";
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(98, 16);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(100, 21);
            this.totalTxt.TabIndex = 1;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(68, 54);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(85, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "确认";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // confirmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 97);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.promptLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "confirmFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置范围";
            this.Load += new System.EventHandler(this.confirmFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLab;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Button confirmBtn;
    }
}