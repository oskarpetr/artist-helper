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
            this._labelColours = new System.Windows.Forms.Label();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._buttonExport = new System.Windows.Forms.Button();
            this._labelSize = new System.Windows.Forms.Label();
            this._buttonVisual = new System.Windows.Forms.Button();
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
            this._picturePainting.BackColor = System.Drawing.SystemColors.Control;
            this._picturePainting.Location = new System.Drawing.Point(50, 160);
            this._picturePainting.Name = "_picturePainting";
            this._picturePainting.Size = new System.Drawing.Size(300, 302);
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
            // _labelColours
            // 
            this._labelColours.AutoSize = true;
            this._labelColours.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelColours.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelColours.Location = new System.Drawing.Point(379, 160);
            this._labelColours.Name = "_labelColours";
            this._labelColours.Size = new System.Drawing.Size(73, 21);
            this._labelColours.TabIndex = 4;
            this._labelColours.Text = "Colours";
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
            // _labelSize
            // 
            this._labelSize.AutoSize = true;
            this._labelSize.BackColor = System.Drawing.SystemColors.Control;
            this._labelSize.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelSize.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this._labelSize.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._labelSize.Location = new System.Drawing.Point(50, 96);
            this._labelSize.Name = "_labelSize";
            this._labelSize.Size = new System.Drawing.Size(42, 21);
            this._labelSize.TabIndex = 8;
            this._labelSize.Text = "Size";
            this._labelSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _buttonVisual
            // 
            this._buttonVisual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonVisual.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonVisual.Location = new System.Drawing.Point(379, 431);
            this._buttonVisual.Name = "_buttonVisual";
            this._buttonVisual.Size = new System.Drawing.Size(89, 31);
            this._buttonVisual.TabIndex = 9;
            this._buttonVisual.Text = "Visual";
            this._buttonVisual.UseVisualStyleBackColor = true;
            this._buttonVisual.Click += new System.EventHandler(this._buttonVisual_Click);
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this._buttonVisual);
            this.Controls.Add(this._labelSize);
            this.Controls.Add(this._buttonExport);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._labelColours);
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
        private Label _labelColours;
        private Label label2;
        private Button _buttonRemove;
        private Button _buttonExport;
        private Label label3;
        private Label _labelSize;
        private Button _buttonVisual;
    }
}