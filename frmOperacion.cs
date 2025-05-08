using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio01
{
    public partial class frmOperacion : Form
    {
        double firstValue, secondValue, addition, subtraction, multiplication, division;

        public frmOperacion()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            txtAddition.ReadOnly = true;
            txtSubtraction.ReadOnly = true;
            txtMultiplication.ReadOnly = true;
            txtDivision.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstValue.Text) || string.IsNullOrEmpty(txtSecondValue.Text))
            {
                MessageBox.Show("Los campos Número 1 y Número 2 no pueden estar vacíos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                firstValue = Convert.ToDouble(txtFirstValue.Text);
                secondValue = Convert.ToDouble(txtSecondValue.Text);
                //
                addition = Convert.ToDouble(firstValue + secondValue);
                subtraction = Convert.ToDouble(firstValue - secondValue);
                multiplication = Convert.ToDouble(firstValue * secondValue);
                division = Convert.ToDouble(firstValue / secondValue);
                //
                txtAddition.Text = Convert.ToString(addition);
                txtSubtraction.Text = Convert.ToString(subtraction);
                txtMultiplication.Text = Convert.ToString(multiplication);
                txtDivision.Text = Convert.ToString(Math.Round(division, 2));
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAddition.Text = "";
            txtSubtraction.Text = "";
            txtMultiplication.Text = "";
            txtDivision.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
