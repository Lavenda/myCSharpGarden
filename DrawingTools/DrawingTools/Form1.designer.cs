﻿namespace WindowsFormsApplication2
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
            this.numLab.Font = new System.Drawing.Font("微软雅黑", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLab.Location = new System.Drawing.Point(-15, 1);
            this.numLab.Name = "numLab";
            this.numLab.Size = new System.Drawing.Size(460, 259);
            this.numLab.TabIndex = 0;
            this.numLab.Text = "000";
            // 
            // uniBtn
            // 
            this.uniBtn.Location = new System.Drawing.Point(124, 275);
            this.uniBtn.Name = "uniBtn";
            this.uniBtn.Size = new System.Drawing.Size(176, 63);
            this.uniBtn.TabIndex = 2;
            this.uniBtn.Text = "Start";
            this.uniBtn.UseVisualStyleBackColor = true;
            this.uniBtn.Click += new System.EventHandler(this.uniBtn_Click);
            // 
            // authorLab
            // 
            this.authorLab.AutoSize = true;
            this.authorLab.Location = new System.Drawing.Point(316, 402);
            this.authorLab.Name = "authorLab";
            this.authorLab.Size = new System.Drawing.Size(95, 12);
            this.authorLab.TabIndex = 3;
            this.authorLab.Text = "Made by Lavenda";
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
            this.ClientSize = new System.Drawing.Size(422, 426);
            this.Controls.Add(this.authorLab);
            this.Controls.Add(this.uniBtn);
            this.Controls.Add(this.numLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "熊猫婚礼抽奖工具";
            this.Load += new System.EventHandler(this.Form1_Load);
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
