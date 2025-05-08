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
    public partial class frmTotalPago : Form
    {
        private Dictionary<string, double> comboBoxProducts = new()
        {
            { "Smartphone (gama media)", 450.00 },
            { "Laptop (uso general)", 750.00 },
            { "Tablet", 350.00 },
            { "Smartwatch", 250.00 },
            { "Televisor Smart TV (50\")", 550.00 },
            { "Auriculares inalámbricos", 120.00 },
            { "Bocina Bluetooth portátil", 80.00 },
            { "Consola de videojuegos", 450.00 },
            { "Cámara digital (DSLR)", 900.00 },
            { "Monitor para PC (24\")", 200.00 },
            { "Teclado mecánico", 100.00 },
            { "Mouse ergonómico", 50.00 },
            { "Enrutador Wi-Fi (router)", 120.00 },
            { "Disco duro externo (1 TB)", 80.00 },
            { "Impresora multifuncional", 150.00 }
        };

        private Dictionary<string, double> radioButtonValues = new()
        {
            {"D (11%)", 0.11},
            {"C (9%)", 0.09},
            {"B (7%)", 0.07},
            {"A (5%)", 0.05}
        };

        private double getSubTotal()
        {
            string? subtotal = txtSubTotal.Text.Trim();
            return !string.IsNullOrEmpty(subtotal) ? Convert.ToDouble(subtotal) : 0;
        }

        public frmTotalPago()
        {
            InitializeComponent();
            setInitialConfig();
            setComboBoxProducts();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double subTotal = Convert.ToDouble(txtSubTotal.Text);
            double discountAmount = Convert.ToDouble(txtDiscount.Text);
            double taxAmount = Convert.ToDouble(txtTax.Text);
            int deliveryAmount = Convert.ToInt16(txtTotalDelivery.Text);

            bool isEmptyDiscountCategory = isEmptyRadioButtonGroup(rbFivePercentage, rbSevenPercentage, rbNinePercentage, rbElevenPercentage);
            bool isEmptyReceiptType = isEmptyRadioButtonGroup(rbIsInvoice, rbIsTicket);

            if (string.IsNullOrEmpty(cbProducts.Text))
            {
                MessageBox.Show("Debes ingresar un producto.");
                cbProducts.Focus();
            }
            else if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Debes ingresar una cantidad.");
                txtQuantity.Focus();
            }
            else if (isEmptyDiscountCategory)
            {
                MessageBox.Show("Debes ingresar una categoria.");
                rbFivePercentage.Focus();
            }
            else if (isEmptyReceiptType)
            {
                MessageBox.Show("Debes ingresar un tipo de comprobante.");
                rbIsInvoice.Focus();
            }
            else
            {
                txtTotalToPay.Text = Math.Round(calculateTotalToPay(subTotal, taxAmount, deliveryAmount, discountAmount), 2).ToString();
            }
        }

        private void setInitialConfig()
        {
            StartPosition = FormStartPosition.CenterScreen;
            txtPrice.ReadOnly = true;
            txtSubTotal.ReadOnly = true;
            txtDiscount.ReadOnly = true;
            txtTax.ReadOnly = true;
            txtTotalDelivery.ReadOnly = true;
            txtTotalToPay.ReadOnly = true;
        }

        private void setComboBoxProducts()
        {
            foreach (var product in comboBoxProducts)
            {
                cbProducts.Items.Add(product.Key);
            }
        }

        private bool isEmptyRadioButtonGroup(params RadioButton[] fields)
        {
            foreach (var field in fields)
            {
                if (field.Checked)
                {
                    return false;
                }
            }
            return true;
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productKey = comboBoxProducts.First().Key;

            if (cbProducts.SelectedItem != null)
            {
                productKey = cbProducts.SelectedItem.ToString();
                txtPrice.Text = comboBoxProducts[productKey].ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                Int32 productQty = Convert.ToInt32(txtQuantity.Text);
                double subTotal = productQty * Convert.ToDouble(txtPrice.Text);
                txtSubTotal.Text = subTotal.ToString();
            }
            else
            {
                txtSubTotal.Clear();
            }

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                double discountPercentage = radioButtonValues[radioButton.Text];
                txtDiscount.Text = Math.Round(calculateDiscount(getSubTotal(), discountPercentage), 2).ToString();
            }
        }

        private void radioButtonReceiptType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton? radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                if (radioButton.Text == "Factura")
                {
                    txtTax.Text = Math.Round(calculateTaxes(getSubTotal()), 2).ToString();
                }
                else
                {
                    txtTax.Text = "0";
                }
            }
        }

        private double calculateDiscount(double subtotal, double discountPercentage)
        {
            return subtotal * discountPercentage;
        }

        private double calculateTaxes(double subtotal)
        {
            return subtotal * 0.18;
        }

        private double calculateTotalToPay(double subtotal, double taxAmount, int deliveryAmount, double discountAmount)
        {
            return (subtotal + taxAmount + deliveryAmount) - discountAmount;
        }

        private void cbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelivery.Checked)
            {
                txtTotalDelivery.Text = "7"; 
            }
            else
            {
                txtTotalDelivery.Text = "0";
            }
        }
    }
}
