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
    public partial class frmPromedio : Form
    {
        public frmPromedio()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtAverageScore.ReadOnly = true;
            txtConditions.ReadOnly = true;
        }

        private double parseStringToDouble(string value)
        {
            double parsedValue = 0;
            double.TryParse(value, out parsedValue);

            return parsedValue;
        }

        private double calculateAverage(double valueA, double valueB, double valueC, double valueD)
        {   
            return (valueA + valueB + valueC + valueD) / 4;
        }

        private TextBox? getEmptyField(params TextBox[] fields)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    return field;
                }
            }
            return null;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double scoreA, scoreB, scoreC, scoreD, averageScore;
            string conditions = "Aprobado";
            TextBox? currentEmptyField;
            Dictionary<TextBox, string> fieldValidations = new() {
                {txtScoreA, "Ingrese la nota 1"},
                {txtScoreB, "Ingrese la nota 2"},
                {txtScoreC, "Ingrese la nota 3"},
                {txtScoreD, "Ingrese la nota 4"},
            };

            currentEmptyField = getEmptyField(txtScoreA, txtScoreB, txtScoreC, txtScoreD);

            if (currentEmptyField != null)
            {
                MessageBox.Show(fieldValidations[currentEmptyField]);
            }
            else
            {
                scoreA = parseStringToDouble(txtScoreA.Text);
                scoreB = parseStringToDouble(txtScoreB.Text);
                scoreC = parseStringToDouble(txtScoreC.Text);
                scoreD = parseStringToDouble(txtScoreD.Text);

                averageScore = Math.Round(calculateAverage(scoreA, scoreB, scoreC, scoreD), 2);

                if (averageScore < 12.5)
                {
                    conditions = "Desaprobado";
                }

                txtAverageScore.Text = averageScore.ToString();
                txtConditions.Text = conditions;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtScoreA.Text = "";
            txtScoreB.Text = "";
            txtScoreC.Text = "";
            txtScoreD.Text = "";
            txtAverageScore.Text = "";
            txtConditions.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
