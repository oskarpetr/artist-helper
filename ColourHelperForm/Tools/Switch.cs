using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourHelperForm.Tools {
    public class Switch {
        public static void Screen(Form form) {
            Form current = Application.OpenForms.Cast<Form>().Last();
            current.Hide();

            form.Show();

            int centerX = current.Left + (current.Width / 2) - (form.Width / 2);
            int centerY = current.Top + (current.Height / 2) - (form.Height / 2);
            form.DesktopLocation = new Point(centerX, centerY);
        }
    }
}
