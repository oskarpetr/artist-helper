﻿namespace ColourHelperForm.Forms {
    partial class CreatePaintingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._labelBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelBack
            // 
            this._labelBack.AutoSize = true;
            this._labelBack.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this._labelBack.Location = new System.Drawing.Point(50, 25);
            this._labelBack.Name = "_labelBack";
            this._labelBack.Size = new System.Drawing.Size(63, 21);
            this._labelBack.TabIndex = 5;
            this._labelBack.Text = "< Back";
            this._labelBack.Click += new System.EventHandler(this._labelBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create painting";
            // 
            // CreatePaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelBack);
            this.Controls.Add(this.label1);
            this.Name = "CreatePaintingForm";
            this.Text = "Create painting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelBack;
        private Label label1;
    }
}