﻿namespace ScriptRunnerUI.src.UserControls
{
    partial class CheckBoxArg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxGroupName = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxGroupName.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxGroupName
            // 
            this.checkBoxGroupName.Controls.Add(this.checkBox1);
            this.checkBoxGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxGroupName.Location = new System.Drawing.Point(0, 0);
            this.checkBoxGroupName.Name = "checkBoxGroupName";
            this.checkBoxGroupName.Size = new System.Drawing.Size(200, 150);
            this.checkBoxGroupName.TabIndex = 0;
            this.checkBoxGroupName.TabStop = false;
            this.checkBoxGroupName.Text = "checkBoxGroupName";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CheckBoxArg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxGroupName);
            this.Name = "CheckBoxArg";
            this.Size = new System.Drawing.Size(200, 150);
            this.checkBoxGroupName.ResumeLayout(false);
            this.checkBoxGroupName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox checkBoxGroupName;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
