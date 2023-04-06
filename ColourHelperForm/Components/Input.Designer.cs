namespace ColourHelperForm.Components {
    partial class Input {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._numeric = new System.Windows.Forms.NumericUpDown();
            this._label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // _numeric
            // 
            this._numeric.Location = new System.Drawing.Point(3, 3);
            this._numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this._numeric.Name = "_numeric";
            this._numeric.Size = new System.Drawing.Size(114, 27);
            this._numeric.TabIndex = 0;
            this._numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this._numeric.ValueChanged += new System.EventHandler(this._numeric_ValueChanged);
            // 
            // _label
            // 
            this._label.AutoSize = true;
            this._label.Location = new System.Drawing.Point(122, 5);
            this._label.Name = "_label";
            this._label.Size = new System.Drawing.Size(29, 20);
            this._label.TabIndex = 1;
            this._label.Text = "cm";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._label);
            this.Controls.Add(this._numeric);
            this.Name = "Input";
            this.Size = new System.Drawing.Size(157, 33);
            ((System.ComponentModel.ISupportInitialize)(this._numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown _numeric;
        private Label _label;
    }
}
