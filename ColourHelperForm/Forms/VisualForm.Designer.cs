namespace ColourHelperForm.Forms {
    partial class VisualForm {
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
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("SF Pro Rounded", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._labelName.Location = new System.Drawing.Point(50, 50);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(297, 39);
            this._labelName.TabIndex = 2;
            this._labelName.Text = "Painting visualized";
            // 
            // VisualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this._labelName);
            this.Name = "VisualForm";
            this.Text = "VisualForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VisualForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _labelName;
    }
}