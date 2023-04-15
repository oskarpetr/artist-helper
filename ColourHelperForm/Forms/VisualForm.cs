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

namespace ColourHelperForm.Forms {
    public partial class VisualForm : Form {
        private Detail _detail;
        public VisualForm(Detail detail) {
            InitializeComponent();

            _detail = detail;
        }

        private void VisualForm_Paint(object sender, PaintEventArgs e) {

        }
    }
}
