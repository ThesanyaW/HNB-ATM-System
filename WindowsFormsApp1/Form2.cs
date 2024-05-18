using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnNxt1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void txtBoxPIN_TextChanged(object sender, EventArgs e)
        {
            txtBoxPIN.PasswordChar = '.';

                //Check if the length of the PIN is exactly four digits
                if (txtBoxPIN.Text.Length == 4)
                {
                    // Check if all characters are digits (0 to 9)
                    if (txtBoxPIN.Text.All(char.IsDigit))
                    {
                        // PIN is valid, remove error message if displayed
                        errorProvider1.SetError(txtBoxPIN, ""); // Clear any previous error message

                        // Enable the "Next" button since the PIN is valid
                        btnNxt1.Enabled = true;
                    }
                    else
                    {
                        // Display error message if any character is not a digit
                        errorProvider1.SetError(txtBoxPIN, "PIN must contain only digits (0 to 9).");
                        btnNxt1.Enabled = false; // Disable the "Next" button
                    }
                }
                else
                {
                    // Display error message if PIN length is not exactly four digits
                    errorProvider1.SetError(txtBoxPIN, "PIN must be exactly four digits.");
                    btnNxt1.Enabled = false; // Disable the "Next" button
                }

        }
    }
}
