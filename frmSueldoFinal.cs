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
    public partial class frmSueldoFinal : Form
    {
        double numOfHours, ratePerHour, baseSalary, totalBonification, totalDiscount;
        double bonificationPercentage = 0.05;
        double discountPercentage = 0.03;

        public frmSueldoFinal()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            txtBaseSalary.ReadOnly = true;
            txtBonification.ReadOnly = true;
            txtDiscount.ReadOnly = true;
            txtGrossSalary.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumOfHours.Text) || string.IsNullOrEmpty(txtRatePerHour.Text))
            {
                MessageBox.Show("Los campos Número de horas y Costo por hora no pueden estar vacíos.", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                numOfHours = Convert.ToDouble(txtNumOfHours.Text);
                ratePerHour = Convert.ToDouble(txtRatePerHour.Text);
                baseSalary = numOfHours * ratePerHour;
                totalBonification = calculateBonification(baseSalary);
                totalDiscount = calculateDiscount(baseSalary);

                txtBaseSalary.Text = (baseSalary).ToString();
                txtBonification.Text = totalBonification.ToString();
                txtDiscount.Text = totalDiscount.ToString();
                txtGrossSalary.Text = calculateGrossSalary(baseSalary, totalBonification, totalDiscount).ToString();
            }
        }

        private double calculateBonification(double baseSalary)
        {
            return baseSalary * bonificationPercentage;
        }

        private double calculateDiscount(double baseSalary)
        {
            return baseSalary * discountPercentage;
        }

        private double calculateGrossSalary(double baseSalary, double totalBonification, double totalDiscount)
        {
            return (baseSalary + totalBonification) - totalDiscount;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNumOfHours.Text = "";
            txtRatePerHour.Text = "";
            txtBaseSalary.Text = "";
            txtBonification.Text = "";
            txtDiscount.Text = "";
            txtGrossSalary.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
