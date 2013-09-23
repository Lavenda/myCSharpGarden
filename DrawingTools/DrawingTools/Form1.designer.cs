namespace WindowsFormsApplication2
{
    partial class mainFrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrom));
            this.numLab = new System.Windows.Forms.Label();
            this.uniBtn = new System.Windows.Forms.Button();
            this.authorLab = new System.Windows.Forms.Label();
            this.showNumTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numLab
            // 
            this.numLab.AutoSize = true;
            this.numLab.BackColor = System.Drawing.Color.Transparent;
            this.numLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numLab.Font = new System.Drawing.Font("微软雅黑", 238F);
            this.numLab.ForeColor = System.Drawing.Color.Silver;
            this.numLab.Location = new System.Drawing.Point(-55, 167);
            this.numLab.Name = "numLab";
            this.numLab.Size = new System.Drawing.Size(733, 419);
            this.numLab.TabIndex = 0;
            this.numLab.Text = "000";
            // 
            // uniBtn
            // 
            this.uniBtn.BackColor = System.Drawing.Color.Transparent;
            this.uniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uniBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.uniBtn.FlatAppearance.BorderSize = 0;
            this.uniBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uniBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uniBtn.Font = new System.Drawing.Font("宋体", 15F);
            this.uniBtn.ForeColor = System.Drawing.Color.Black;
            this.uniBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uniBtn.Location = new System.Drawing.Point(218, 606);
            this.uniBtn.Name = "uniBtn";
            this.uniBtn.Size = new System.Drawing.Size(169, 40);
            this.uniBtn.TabIndex = 2;
            this.uniBtn.Text = "Start";
            this.uniBtn.UseVisualStyleBackColor = false;
            this.uniBtn.Click += new System.EventHandler(this.uniBtn_Click);
            // 
            // authorLab
            // 
            this.authorLab.AutoSize = true;
            this.authorLab.BackColor = System.Drawing.Color.Transparent;
            this.authorLab.Location = new System.Drawing.Point(501, 798);
            this.authorLab.Name = "authorLab";
            this.authorLab.Size = new System.Drawing.Size(77, 12);
            this.authorLab.TabIndex = 3;
            this.authorLab.Text = "Made by Luke";
            this.authorLab.DoubleClick += new System.EventHandler(this.authorLab_DoubleClick);
            // 
            // showNumTimer
            // 
            this.showNumTimer.Interval = 50;
            this.showNumTimer.Tick += new System.EventHandler(this.showNumTimer_Tick);
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 819);
            this.Controls.Add(this.authorLab);
            this.Controls.Add(this.uniBtn);
            this.Controls.Add(this.numLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrom";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "熊猫婚礼抽奖工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numLab;
        private System.Windows.Forms.Button uniBtn;
        private System.Windows.Forms.Label authorLab;
        private System.Windows.Forms.Timer showNumTimer;
    }
}

