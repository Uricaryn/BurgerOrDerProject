using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerWFA
{
    public class Functions
    {
        
        public static void ResetForm(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                }
                else if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Name=="rdbKucuk")
                    {
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Checked= false;
                    }
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is GroupBox)
                {
                    ResetForm(((GroupBox)control).Controls);
                }
                else if (control is FlowLayoutPanel)
                {
                    ResetForm(((FlowLayoutPanel)control).Controls);
                }
            }

        }
    }
}
