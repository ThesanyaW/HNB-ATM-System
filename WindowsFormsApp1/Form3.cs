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
    public partial class Form3 : Form
    {
        // Declare boolean variables for tracking service selection
        private bool withdrawMoneySelected = false;
        private bool changePINSelected = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            // Opening The Form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Check which service option is selected and take appropriate action
            if (withdrawMoneySelected)
            {
                // Instantiate and show the WithdrawForm
                FormWithdraw withdrawForm = new FormWithdraw();
                withdrawForm.Show();
                this.Hide();
            }
            else if (changePINSelected)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Set withdrawMoneySelected to true when the "Withdraw Money" button is clicked
            withdrawMoneySelected = true;
            changePINSelected = false;

            // Reset button appearances and highlight the selected one
            ResetButtonAppearances();
            ((Button)sender).BackColor = Color.Cyan;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            changePINSelected = true;
            withdrawMoneySelected = false;

            // Reset button appearances and highlight the selected one
            ResetButtonAppearances();
            ((Button)sender).BackColor = Color.Cyan;
        }

        private void ResetButtonAppearances()
        {
            foreach (Button button in panel1.Controls.OfType<Button>())
            {
                button.BackColor = SystemColors.Control; // Reset background color to default
            }
        }
    }
}
