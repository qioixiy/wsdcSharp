﻿namespace wsdcSharp
{
    partial class FormManager
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
            this.button_chongzhi = new System.Windows.Forms.Button();
            this.textBox_chongzhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_settingID = new System.Windows.Forms.TextBox();
            this.button_setID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_chongzhi
            // 
            this.button_chongzhi.Location = new System.Drawing.Point(203, 22);
            this.button_chongzhi.Name = "button_chongzhi";
            this.button_chongzhi.Size = new System.Drawing.Size(75, 23);
            this.button_chongzhi.TabIndex = 0;
            this.button_chongzhi.Text = "充值";
            this.button_chongzhi.UseVisualStyleBackColor = true;
            this.button_chongzhi.Click += new System.EventHandler(this.button_chongzhi_Click);
            // 
            // textBox_chongzhi
            // 
            this.textBox_chongzhi.Location = new System.Drawing.Point(66, 24);
            this.textBox_chongzhi.Name = "textBox_chongzhi";
            this.textBox_chongzhi.Size = new System.Drawing.Size(100, 21);
            this.textBox_chongzhi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "金额";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "设置ID";
            // 
            // textBox_settingID
            // 
            this.textBox_settingID.Location = new System.Drawing.Point(66, 67);
            this.textBox_settingID.Name = "textBox_settingID";
            this.textBox_settingID.Size = new System.Drawing.Size(100, 21);
            this.textBox_settingID.TabIndex = 4;
            // 
            // button_setID
            // 
            this.button_setID.Location = new System.Drawing.Point(203, 64);
            this.button_setID.Name = "button_setID";
            this.button_setID.Size = new System.Drawing.Size(75, 23);
            this.button_setID.TabIndex = 5;
            this.button_setID.Text = "设置";
            this.button_setID.UseVisualStyleBackColor = true;
            this.button_setID.Click += new System.EventHandler(this.button_setID_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 320);
            this.Controls.Add(this.button_setID);
            this.Controls.Add(this.textBox_settingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_chongzhi);
            this.Controls.Add(this.button_chongzhi);
            this.MaximizeBox = false;
            this.Name = "FormManager";
            this.Text = "管理";
            this.Load += new System.EventHandler(this.FormManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_chongzhi;
        private System.Windows.Forms.TextBox textBox_chongzhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_settingID;
        private System.Windows.Forms.Button button_setID;
    }
}