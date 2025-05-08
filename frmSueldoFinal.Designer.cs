namespace laboratorio01
{
    partial class frmSueldoFinal
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnCalculate = new Button();
            btnClean = new Button();
            btnLogout = new Button();
            txtNumOfHours = new TextBox();
            txtRatePerHour = new TextBox();
            txtBaseSalary = new TextBox();
            txtBonification = new TextBox();
            txtDiscount = new TextBox();
            txtGrossSalary = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 74);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de horas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Costo por hora:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Sueldo Básico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Bonificación (5%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "Descuento (3%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 293);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 5;
            label6.Text = "Sueldo Final:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 258);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(40, 369);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(212, 369);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 8;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(391, 369);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Salir";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // txtNumOfHours
            // 
            txtNumOfHours.Location = new Point(142, 71);
            txtNumOfHours.Name = "txtNumOfHours";
            txtNumOfHours.Size = new Size(100, 23);
            txtNumOfHours.TabIndex = 10;
            // 
            // txtRatePerHour
            // 
            txtRatePerHour.Location = new Point(142, 116);
            txtRatePerHour.Name = "txtRatePerHour";
            txtRatePerHour.Size = new Size(100, 23);
            txtRatePerHour.TabIndex = 11;
            // 
            // txtBaseSalary
            // 
            txtBaseSalary.Location = new Point(142, 159);
            txtBaseSalary.Name = "txtBaseSalary";
            txtBaseSalary.Size = new Size(100, 23);
            txtBaseSalary.TabIndex = 12;
            // 
            // txtBonification
            // 
            txtBonification.Location = new Point(142, 202);
            txtBonification.Name = "txtBonification";
            txtBonification.Size = new Size(100, 23);
            txtBonification.TabIndex = 13;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(142, 247);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 14;
            // 
            // txtGrossSalary
            // 
            txtGrossSalary.Location = new Point(142, 290);
            txtGrossSalary.Name = "txtGrossSalary";
            txtGrossSalary.Size = new Size(100, 23);
            txtGrossSalary.TabIndex = 15;
            // 
            // frmSueldoFinal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(txtGrossSalary);
            Controls.Add(txtDiscount);
            Controls.Add(txtBonification);
            Controls.Add(txtBaseSalary);
            Controls.Add(txtRatePerHour);
            Controls.Add(txtNumOfHours);
            Controls.Add(btnLogout);
            Controls.Add(btnClean);
            Controls.Add(btnCalculate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSueldoFinal";
            Text = "frmSueldoFinal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCalculate;
        private Button btnClean;
        private Button btnLogout;
        private TextBox txtNumOfHours;
        private TextBox txtRatePerHour;
        private TextBox txtBaseSalary;
        private TextBox txtBonification;
        private TextBox txtDiscount;
        private TextBox txtGrossSalary;
    }
}