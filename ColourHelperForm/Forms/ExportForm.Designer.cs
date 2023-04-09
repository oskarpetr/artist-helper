namespace ColourHelperForm.Forms {
    partial class ExportForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this._labelBack = new System.Windows.Forms.Label();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._buttonSelect = new System.Windows.Forms.Button();
            this._labelPath = new System.Windows.Forms.Label();
            this._buttonExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Export colours";
            // 
            // _labelBack
            // 
            this._labelBack.AutoSize = true;
            this._labelBack.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this._labelBack.Location = new System.Drawing.Point(50, 25);
            this._labelBack.Name = "_labelBack";
            this._labelBack.Size = new System.Drawing.Size(63, 21);
            this._labelBack.TabIndex = 7;
            this._labelBack.Text = "< Back";
            this._labelBack.Click += new System.EventHandler(this._labelBack_Click);
            // 
            // _comboBox
            // 
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Items.AddRange(new object[] {
            "JSON",
            "Plain text"});
            this._comboBox.Location = new System.Drawing.Point(50, 146);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(151, 28);
            this._comboBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Export type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Export path";
            // 
            // _buttonSelect
            // 
            this._buttonSelect.Location = new System.Drawing.Point(249, 145);
            this._buttonSelect.Name = "_buttonSelect";
            this._buttonSelect.Size = new System.Drawing.Size(142, 29);
            this._buttonSelect.TabIndex = 11;
            this._buttonSelect.Text = "Select";
            this._buttonSelect.UseVisualStyleBackColor = true;
            this._buttonSelect.Click += new System.EventHandler(this._buttonSelect_Click);
            // 
            // _labelPath
            // 
            this._labelPath.AutoSize = true;
            this._labelPath.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._labelPath.Location = new System.Drawing.Point(403, 154);
            this._labelPath.Name = "_labelPath";
            this._labelPath.Size = new System.Drawing.Size(0, 20);
            this._labelPath.TabIndex = 12;
            // 
            // _buttonExport
            // 
            this._buttonExport.Location = new System.Drawing.Point(50, 250);
            this._buttonExport.Name = "_buttonExport";
            this._buttonExport.Size = new System.Drawing.Size(128, 29);
            this._buttonExport.TabIndex = 13;
            this._buttonExport.Text = "Export data";
            this._buttonExport.UseVisualStyleBackColor = true;
            this._buttonExport.Click += new System.EventHandler(this._buttonExport_Click);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 328);
            this.Controls.Add(this._buttonExport);
            this.Controls.Add(this._labelPath);
            this.Controls.Add(this._buttonSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._labelBack);
            this.Controls.Add(this.label1);
            this.Name = "ExportForm";
            this.Text = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label _labelBack;
        private ComboBox _comboBox;
        private Label label2;
        private Label label3;
        private Button _buttonSelect;
        private Label _labelPath;
        private Button _buttonExport;
    }
}