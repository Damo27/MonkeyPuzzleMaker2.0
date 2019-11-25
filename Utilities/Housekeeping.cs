using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public class Housekeeping
    {
        //__________Method cycles through all controls in the control passed to it and resets them to the default state________
        public static void ResetForm(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }
                else
                {
                    if (control is RadioButton)
                    {
                        RadioButton rdButt = (RadioButton)control;
                        rdButt.Checked = false;
                    }
                    else
                    {
                        if (control is ListBox)
                        {
                            ListBox listBox = (ListBox)control;
                            listBox.ClearSelected();
                        }
                        else
                        {
                            if (control is ComboBox)
                            {
                                ComboBox comboBox = (ComboBox)control;
                                comboBox.SelectedIndex = 0;
                            }
                            else
                            {
                                if (control is Panel)
                                {
                                    ResetForm(control);
                                }
                            }
                        }
                    }
                }
            }
        }

        //__________Method cycles through all controls in the control passed to it and returns true if they all contain information_______
        public static bool CheckAllFields(Control form)
        {
            Boolean NotEmpty = true;
            int rbFlag = 0;

            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text == String.Empty)
                    {
                        NotEmpty = false;
                    }
                }
                else
                    if (control is Panel)
                {
                    NotEmpty = CheckAllFields(control);
                }
                else
                        if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;
                    if (rb.Checked == true)
                    {
                        rbFlag++;
                    }

                    if (rbFlag == 0)
                    {
                        NotEmpty = false;
                    }
                    else
                    {
                        NotEmpty = true;
                    }
                }
            }
            return NotEmpty;
        }
    }
}
