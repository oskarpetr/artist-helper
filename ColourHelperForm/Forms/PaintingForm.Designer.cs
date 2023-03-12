namespace ColourHelperForm.Forms {
    partial class PaintingForm {
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
            this._labelName = new System.Windows.Forms.Label();
            this._picturePainting = new System.Windows.Forms.PictureBox();
            this._labelBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picturePainting)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("SF Pro Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelName.Location = new System.Drawing.Point(50, 50);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(230, 39);
            this._labelName.TabIndex = 1;
            this._labelName.Text = "Painting name";
            // 
            // _picturePainting
            // 
            this._picturePainting.Location = new System.Drawing.Point(50, 120);
            this._picturePainting.Name = "_picturePainting";
            this._picturePainting.Size = new System.Drawing.Size(300, 300);
            this._picturePainting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picturePainting.TabIndex = 2;
            this._picturePainting.TabStop = false;
            // 
            // _labelBack
            // 
            this._labelBack.AutoSize = true;
            this._labelBack.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this._labelBack.Location = new System.Drawing.Point(50, 25);
            this._labelBack.Name = "_labelBack";
            this._labelBack.Size = new System.Drawing.Size(63, 21);
            this._labelBack.TabIndex = 3;
            this._labelBack.Text = "< Back";
            this._labelBack.Click += new System.EventHandler(this._labelBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(379, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Colours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(379, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cyan — 3ml";
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonRemove.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonRemove.Location = new System.Drawing.Point(641, 55);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(89, 29);
            this._buttonRemove.TabIndex = 6;
            this._buttonRemove.Text = "Remove";
            this._buttonRemove.UseVisualStyleBackColor = true;
            this._buttonRemove.Click += new System.EventHandler(this._buttonRemove_Click);
            // 
            // _buttonExport
            // 
            this._buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonExport.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonExport.Location = new System.Drawing.Point(546, 55);
            this._buttonExport.Name = "_buttonExport";
            this._buttonExport.Size = new System.Drawing.Size(89, 29);
            this._buttonExport.TabIndex = 7;
            this._buttonExport.Text = "Export";
            this._buttonExport.UseVisualStyleBackColor = true;
            this._buttonExport.Click += new System.EventHandler(this._buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(379, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Crimson — 5ml";
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._buttonExport);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labelBack);
            this.Controls.Add(this._picturePainting);
            this.Controls.Add(this._labelName);
            this.Name = "PaintingForm";
            this.Text = "Painting";
            ((System.ComponentModel.ISupportInitialize)(this._picturePainting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelName;
        private PictureBox _picturePainting;
        private Label _labelBack;
        private Label label1;
        private Label label2;
        private Button _buttonRemove;
        private Button _buttonExport;
        private Label label3;
    }
}