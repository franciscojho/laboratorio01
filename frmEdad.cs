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
    public partial class frmEdad : Form
    {
        public frmEdad()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtAge.Focus();
            txtMessage.ReadOnly = true;
        }

        private Int32 getParsedAge()
        {
            int parsedValue = 0;
            int.TryParse(txtAge.Text, out parsedValue);
            return parsedValue;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = getParsedAge();
            bool isLegalAge = age >= 18;

            if (isLegalAge)
            {
                txtMessage.Text = "Es mayor de edad";
            }
            else
            {
                txtMessage.Text = "Es menor de edad";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtMessage.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
