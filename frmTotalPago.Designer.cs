namespace laboratorio01
{
    partial class frmTotalPago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbProducts = new ComboBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtSubTotal = new TextBox();
            rbFivePercentage = new RadioButton();
            label5 = new Label();
            gbRadioButtons = new GroupBox();
            rbElevenPercentage = new RadioButton();
            rbNinePercentage = new RadioButton();
            rbSevenPercentage = new RadioButton();
            label6 = new Label();
            groupBox2 = new GroupBox();
            rbIsTicket = new RadioButton();
            rbIsInvoice = new RadioButton();
            label7 = new Label();
            txtDiscount = new TextBox();
            label8 = new Label();
            txtTax = new TextBox();
            label9 = new Label();
            cbDelivery = new CheckBox();
            label10 = new Label();
            txtTotalDelivery = new TextBox();
            label12 = new Label();
            txtTotalToPay = new TextBox();
            btnCalculate = new Button();
            button2 = new Button();
            button3 = new Button();
            gbRadioButtons.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto:";
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(165, 20);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(469, 23);
            cbProducts.TabIndex = 1;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(165, 56);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 59);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(165, 98);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 4;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 142);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(165, 139);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 6;
            // 
            // rbFivePercentage
            // 
            rbFivePercentage.AutoSize = true;
            rbFivePercentage.Location = new Point(34, 11);
            rbFivePercentage.Name = "rbFivePercentage";
            rbFivePercentage.Size = new Size(60, 19);
            rbFivePercentage.TabIndex = 8;
            rbFivePercentage.TabStop = true;
            rbFivePercentage.Text = "A (5%)";
            rbFivePercentage.UseVisualStyleBackColor = true;
            rbFivePercentage.CheckedChanged += radioButton_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 181);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria:";
            // 
            // gbRadioButtons
            // 
            gbRadioButtons.Controls.Add(rbElevenPercentage);
            gbRadioButtons.Controls.Add(rbNinePercentage);
            gbRadioButtons.Controls.Add(rbSevenPercentage);
            gbRadioButtons.Controls.Add(rbFivePercentage);
            gbRadioButtons.Location = new Point(165, 168);
            gbRadioButtons.Name = "gbRadioButtons";
            gbRadioButtons.Size = new Size(492, 39);
            gbRadioButtons.TabIndex = 10;
            gbRadioButtons.TabStop = false;
            // 
            // rbElevenPercentage
            // 
            rbElevenPercentage.AutoSize = true;
            rbElevenPercentage.Location = new Point(389, 11);
            rbElevenPercentage.Name = "rbElevenPercentage";
            rbElevenPercentage.Size = new Size(66, 19);
            rbElevenPercentage.TabIndex = 11;
            rbElevenPercentage.TabStop = true;
            rbElevenPercentage.Text = "D (11%)";
            rbElevenPercentage.UseVisualStyleBackColor = true;
            rbElevenPercentage.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbNinePercentage
            // 
            rbNinePercentage.AutoSize = true;
            rbNinePercentage.Location = new Point(254, 11);
            rbNinePercentage.Name = "rbNinePercentage";
            rbNinePercentage.Size = new Size(60, 19);
            rbNinePercentage.TabIndex = 10;
            rbNinePercentage.TabStop = true;
            rbNinePercentage.Text = "C (9%)";
            rbNinePercentage.UseVisualStyleBackColor = true;
            rbNinePercentage.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbSevenPercentage
            // 
            rbSevenPercentage.AutoSize = true;
            rbSevenPercentage.Location = new Point(124, 11);
            rbSevenPercentage.Name = "rbSevenPercentage";
            rbSevenPercentage.Size = new Size(59, 19);
            rbSevenPercentage.TabIndex = 9;
            rbSevenPercentage.TabStop = true;
            rbSevenPercentage.Text = "B (7%)";
            rbSevenPercentage.UseVisualStyleBackColor = true;
            rbSevenPercentage.CheckedChanged += radioButton_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 258);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 11;
            label6.Text = "Tipo de Comprobante:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbIsTicket);
            groupBox2.Controls.Add(rbIsInvoice);
            groupBox2.Location = new Point(165, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(213, 34);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // rbIsTicket
            // 
            rbIsTicket.AutoSize = true;
            rbIsTicket.Location = new Point(124, 11);
            rbIsTicket.Name = "rbIsTicket";
            rbIsTicket.Size = new Size(58, 19);
            rbIsTicket.TabIndex = 9;
            rbIsTicket.TabStop = true;
            rbIsTicket.Text = "Boleta";
            rbIsTicket.UseVisualStyleBackColor = true;
            rbIsTicket.CheckedChanged += radioButtonReceiptType_CheckedChanged;
            // 
            // rbIsInvoice
            // 
            rbIsInvoice.AutoSize = true;
            rbIsInvoice.Location = new Point(34, 11);
            rbIsInvoice.Name = "rbIsInvoice";
            rbIsInvoice.Size = new Size(64, 19);
            rbIsInvoice.TabIndex = 8;
            rbIsInvoice.TabStop = true;
            rbIsInvoice.Text = "Factura";
            rbIsInvoice.UseVisualStyleBackColor = true;
            rbIsInvoice.CheckedChanged += radioButtonReceiptType_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 220);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(66, 15);
            label7.TabIndex = 14;
            label7.Text = "Descuento:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(165, 217);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 294);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(28, 15);
            label8.TabIndex = 16;
            label8.Text = "IGV:";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(165, 291);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(100, 23);
            txtTax.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 333);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 17;
            label9.Text = "Delivery:";
            // 
            // cbDelivery
            // 
            cbDelivery.AutoSize = true;
            cbDelivery.Location = new Point(165, 333);
            cbDelivery.Name = "cbDelivery";
            cbDelivery.Size = new Size(78, 19);
            cbDelivery.TabIndex = 18;
            cbDelivery.Text = "Sí (S/7.00)";
            cbDelivery.UseVisualStyleBackColor = true;
            cbDelivery.CheckedChanged += cbDelivery_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 375);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(67, 15);
            label10.TabIndex = 20;
            label10.Text = "Total Envío:";
            // 
            // txtTotalDelivery
            // 
            txtTotalDelivery.Location = new Point(165, 372);
            txtTotalDelivery.Name = "txtTotalDelivery";
            txtTotalDelivery.Size = new Size(100, 23);
            txtTotalDelivery.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 410);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(77, 15);
            label12.TabIndex = 24;
            label12.Text = "Total a Pagar:";
            // 
            // txtTotalToPay
            // 
            txtTotalToPay.Location = new Point(165, 407);
            txtTotalToPay.Name = "txtTotalToPay";
            txtTotalToPay.Size = new Size(100, 23);
            txtTotalToPay.TabIndex = 23;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(691, 23);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 25;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(691, 71);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(691, 121);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 27;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmTotalPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCalculate);
            Controls.Add(label12);
            Controls.Add(txtTotalToPay);
            Controls.Add(label10);
            Controls.Add(txtTotalDelivery);
            Controls.Add(cbDelivery);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTax);
            Controls.Add(label7);
            Controls.Add(txtDiscount);
            Controls.Add(groupBox2);
            Controls.Add(label6);
            Controls.Add(gbRadioButtons);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSubTotal);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(cbProducts);
            Controls.Add(label1);
            Name = "frmTotalPago";
            Text = "frmTotalPago";
            gbRadioButtons.ResumeLayout(false);
            gbRadioButtons.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbProducts;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtSubTotal;
        private RadioButton rbFivePercentage;
        private Label label5;
        private GroupBox gbRadioButtons;
        private RadioButton rbElevenPercentage;
        private RadioButton rbNinePercentage;
        private RadioButton rbSevenPercentage;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rbIsTicket;
        private RadioButton rbIsInvoice;
        private Label label7;
        private TextBox txtDiscount;
        private Label label8;
        private TextBox txtTax;
        private Label label9;
        private CheckBox cbDelivery;
        private Label label10;
        private TextBox txtTotalDelivery;
        private Label label12;
        private TextBox txtTotalToPay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnCalculate;
    }
}