using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourHelperForm.Components {
    public partial class Input : UserControl {
        public Input() {
            InitializeComponent();

            _numeric.Visible = false;
            _label.Visible = false;
        }

        public void SetVisibility(bool value) {
            _numeric.Visible = value;
            _label.Visible = value;
        }

        private bool _set = false;
        public void SetValue(int value) {
            _numeric.Value = value;
            _set = true;
            
        }

        public int GetValue() {
            return (int)_numeric.Value;
        }

        public delegate void ValueChanged();
        public event ValueChanged OnValueChanged;

        private void _numeric_ValueChanged(object sender, EventArgs e) {
            if(!_set) {
                OnValueChanged?.Invoke();
            }

            _set = false;
        }
    }
}
