namespace ColourHelperForm.Forms {
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
            this._picturePainting = new System.Windows.Forms.PictureBox();
            this._buttonUpload = new System.Windows.Forms.Button();
            this._numericWidth = new System.Windows.Forms.NumericUpDown();
            this._labelWidthTitle = new System.Windows.Forms.Label();
            this._labelCm = new System.Windows.Forms.Label();
            this._buttonCreate = new System.Windows.Forms.Button();
            this._labelHeightTitle = new System.Windows.Forms.Label();
            this._labelHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._picturePainting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericWidth)).BeginInit();
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
            // _picturePainting
            // 
            this._picturePainting.Location = new System.Drawing.Point(442, 120);
            this._picturePainting.Name = "_picturePainting";
            this._picturePainting.Size = new System.Drawing.Size(300, 300);
            this._picturePainting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._picturePainting.TabIndex = 6;
            this._picturePainting.TabStop = false;
            // 
            // _buttonUpload
            // 
            this._buttonUpload.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonUpload.Location = new System.Drawing.Point(648, 60);
            this._buttonUpload.Name = "_buttonUpload";
            this._buttonUpload.Size = new System.Drawing.Size(94, 29);
            this._buttonUpload.TabIndex = 7;
            this._buttonUpload.Text = "Upload";
            this._buttonUpload.UseVisualStyleBackColor = true;
            this._buttonUpload.Click += new System.EventHandler(this._buttonUpload_Click);
            // 
            // _numericWidth
            // 
            this._numericWidth.Location = new System.Drawing.Point(50, 200);
            this._numericWidth.Name = "_numericWidth";
            this._numericWidth.Size = new System.Drawing.Size(75, 27);
            this._numericWidth.TabIndex = 8;
            this._numericWidth.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numericWidth.Visible = false;
            this._numericWidth.ValueChanged += new System.EventHandler(this._numericWidth_ValueChanged);
            // 
            // _labelWidthTitle
            // 
            this._labelWidthTitle.AutoSize = true;
            this._labelWidthTitle.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelWidthTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelWidthTitle.Location = new System.Drawing.Point(45, 171);
            this._labelWidthTitle.Name = "_labelWidthTitle";
            this._labelWidthTitle.Size = new System.Drawing.Size(124, 21);
            this._labelWidthTitle.TabIndex = 11;
            this._labelWidthTitle.Text = "Custom width";
            this._labelWidthTitle.Visible = false;
            // 
            // _labelCm
            // 
            this._labelCm.AutoSize = true;
            this._labelCm.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelCm.Location = new System.Drawing.Point(131, 204);
            this._labelCm.Name = "_labelCm";
            this._labelCm.Size = new System.Drawing.Size(28, 18);
            this._labelCm.TabIndex = 15;
            this._labelCm.Text = "cm";
            this._labelCm.Visible = false;
            // 
            // _buttonCreate
            // 
            this._buttonCreate.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._buttonCreate.Location = new System.Drawing.Point(50, 391);
            this._buttonCreate.Name = "_buttonCreate";
            this._buttonCreate.Size = new System.Drawing.Size(94, 29);
            this._buttonCreate.TabIndex = 16;
            this._buttonCreate.Text = "Create";
            this._buttonCreate.UseVisualStyleBackColor = true;
            this._buttonCreate.Visible = false;
            this._buttonCreate.Click += new System.EventHandler(this._buttonCreate_Click);
            // 
            // _labelHeightTitle
            // 
            this._labelHeightTitle.AutoSize = true;
            this._labelHeightTitle.Font = new System.Drawing.Font("SF Pro Rounded", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelHeightTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelHeightTitle.Location = new System.Drawing.Point(45, 270);
            this._labelHeightTitle.Name = "_labelHeightTitle";
            this._labelHeightTitle.Size = new System.Drawing.Size(151, 21);
            this._labelHeightTitle.TabIndex = 17;
            this._labelHeightTitle.Text = "Automatic height";
            this._labelHeightTitle.Visible = false;
            // 
            // _labelHeight
            // 
            this._labelHeight.AutoSize = true;
            this._labelHeight.Font = new System.Drawing.Font("SF Pro Rounded", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._labelHeight.Location = new System.Drawing.Point(50, 302);
            this._labelHeight.Name = "_labelHeight";
            this._labelHeight.Size = new System.Drawing.Size(40, 18);
            this._labelHeight.TabIndex = 18;
            this._labelHeight.Text = "0 cm";
            this._labelHeight.Visible = false;
            // 
            // CreatePaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelHeight);
            this.Controls.Add(this._labelHeightTitle);
            this.Controls.Add(this._buttonCreate);
            this.Controls.Add(this._labelCm);
            this.Controls.Add(this._labelWidthTitle);
            this.Controls.Add(this._numericWidth);
            this.Controls.Add(this._buttonUpload);
            this.Controls.Add(this._picturePainting);
            this.Controls.Add(this._labelBack);
            this.Controls.Add(this.label1);
            this.Name = "CreatePaintingForm";
            this.Text = "Create painting";
            ((System.ComponentModel.ISupportInitialize)(this._picturePainting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelBack;
        private Label label1;
        private PictureBox _picturePainting;
        private Button _buttonUpload;
        private NumericUpDown _numericWidth;
        private Label _labelWidthTitle;
        private Label _labelCm;
        private Button _buttonCreate;
        private Label _labelHeightTitle;
        private Label _labelHeight;
    }
}