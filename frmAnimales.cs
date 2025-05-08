using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio01
{
    public partial class frmAnimales : Form
    {
        int selectedItemIndex;
        public frmAnimales()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            cbBucleTypes.Items.Add("while");
            cbBucleTypes.Items.Add("do/while");
            cbBucleTypes.Items.Add("for");

            cbBucleTypes.SelectedItem = "while";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool hasItems = lstItems.Items.Count != 0;
            string animalName = txtInput.Text.Trim();

            if (!string.IsNullOrEmpty(animalName))
            {
                if (!hasItems)
                {
                    if (cbBucleTypes.SelectedItem == "do/while")
                    {
                        doWhileLoop(animalName);
                        MessageBox.Show("You used do/while loop");
                    }
                    else if (cbBucleTypes.SelectedItem == "for")
                    {
                        forLoop(animalName);
                        MessageBox.Show("You used for loop");
                    }
                    else
                    {
                        whileLoop(animalName);
                        MessageBox.Show("You used while loop");
                    }
                }
                else
                {
                    MessageBox.Show("Ya tienes animales agregados a la lista.");
                }

            }
            else
            {
                MessageBox.Show("Debes agregar un Animal.");
                txtInput.Focus();
            }
        }

        private void whileLoop(string animalName)
        {
            int counter = 0;
            while (counter < 5)
            {
                lstItems.Items.Add(animalName);
                counter += 1;
            }
            txtInput.Text = "";
        }

        private void doWhileLoop(string animalName)
        {
            int counter = 0;
            do
            {
                lstItems.Items.Add(animalName);
                counter += 1;
            }
            while (counter < 5);
            txtInput.Text = "";
        }

        private void forLoop(string animalName)
        {
            int counter = 0;
            for (int i = 0; i < 5; i += 1)
            {
                lstItems.Items.Add(animalName);
                counter += 1;
            }
            txtInput.Text = "";
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox? listBox = sender as ListBox;

            if (listBox != null && listBox.SelectedIndex >= 0)
            {
                selectedItemIndex = listBox.SelectedIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int itemsCount = lstItems.Items.Count;

            if (itemsCount != 0)
            {
                lstItems.Items.RemoveAt(selectedItemIndex);
            }
            else
            {
                MessageBox.Show("Ya no tienes Animales!");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (lstItems.Items.Count > 0 )
            {
                lstItems.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ya no tienes Animales!");
            }
        }
    }
}
