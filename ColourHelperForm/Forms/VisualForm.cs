using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColourHelperForm.Models;
using ColourHelperForm.Components;
using ColourHelperForm.Tools;

namespace ColourHelperForm.Forms {
    public partial class VisualForm : Form {
        private Detail _detail;
        private string _path;
        public VisualForm(Detail detail) {
            InitializeComponent();

            _detail = detail;
            _path = Files.GetPath(_detail.Name);
        }

        private void VisualForm_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Bar bar = new(g, _detail, 50, 320);
            Controls.Add(bar);

            Histogram histogram = new(g, _path, 50, 150);
            Controls.Add(histogram);
        }

        private void _labelBack_Click(object sender, EventArgs e) {
            Switch.Screen(new PaintingForm(_path));
        }
    }
}
