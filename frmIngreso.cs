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
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtUserName.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            String myUserName, myPassword, inputUserName, inputPassword;
            String notificationMessage = "Algo inesperado ha ocurrido.";

            myUserName = "root";
            myPassword = "12345";
            inputUserName = txtUserName.Text.Trim();
            inputPassword = txtPassword.Text.Trim();

            bool isIncorrectUserName = string.IsNullOrEmpty(inputUserName) || inputUserName != myUserName;
            bool isIncorrectPassword = string.IsNullOrEmpty(inputPassword) || inputPassword != myPassword;

            if (isIncorrectUserName && isIncorrectPassword)
            {
                notificationMessage = "El usuario y contraseña son incorrectos.";
            }
            else if (isIncorrectUserName)
            {
                notificationMessage = "El usuario no es correcto.";
            }
            else if (isIncorrectPassword)
            {
                notificationMessage = "La contraseña no es correcta.";
            }
            else if (inputUserName == myUserName && inputPassword == myPassword)
            {
                notificationMessage = "Ingresaste a la matrix!";
            }

            MessageBox.Show(notificationMessage);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
