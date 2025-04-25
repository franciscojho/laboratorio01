namespace laboratorio01
{
    partial class frmOperacion
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            txtAddition = new TextBox();
            txtSubtraction = new TextBox();
            txtMultiplication = new TextBox();
            txtDivision = new TextBox();
            txtSecondValue = new TextBox();
            txtFirstValue = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 37);
            label1.Name = "label1";
            label1.Size = new Size(385, 32);
            label1.TabIndex = 0;
            label1.Text = "CUATRO OPERACIONES BÁSICAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Número 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 2;
            label3.Text = "Número 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 19);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 3;
            label4.Text = "Resultados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 61);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 4;
            label5.Text = "Suma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 91);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 5;
            label6.Text = "Resta";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtDivision);
            groupBox1.Controls.Add(txtMultiplication);
            groupBox1.Controls.Add(txtSubtraction);
            groupBox1.Controls.Add(txtAddition);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 175);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 205);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 124);
            label7.Name = "label7";
            label7.Size = new Size(96, 17);
            label7.TabIndex = 6;
            label7.Text = "Multiplicación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(20, 158);
            label8.Name = "label8";
            label8.Size = new Size(59, 17);
            label8.TabIndex = 7;
            label8.Text = "División";
            // 
            // txtAddition
            // 
            txtAddition.Location = new Point(122, 62);
            txtAddition.Name = "txtAddition";
            txtAddition.Size = new Size(100, 23);
            txtAddition.TabIndex = 8;
            // 
            // txtSubtraction
            // 
            txtSubtraction.Location = new Point(122, 91);
            txtSubtraction.Name = "txtSubtraction";
            txtSubtraction.Size = new Size(100, 23);
            txtSubtraction.TabIndex = 9;
            // 
            // txtMultiplication
            // 
            txtMultiplication.Location = new Point(122, 123);
            txtMultiplication.Name = "txtMultiplication";
            txtMultiplication.Size = new Size(100, 23);
            txtMultiplication.TabIndex = 10;
            // 
            // txtDivision
            // 
            txtDivision.Location = new Point(122, 157);
            txtDivision.Name = "txtDivision";
            txtDivision.Size = new Size(100, 23);
            txtDivision.TabIndex = 11;
            // 
            // txtSecondValue
            // 
            txtSecondValue.Location = new Point(108, 128);
            txtSecondValue.Name = "txtSecondValue";
            txtSecondValue.Size = new Size(100, 23);
            txtSecondValue.TabIndex = 12;
            // 
            // txtFirstValue
            // 
            txtFirstValue.Location = new Point(108, 100);
            txtFirstValue.Name = "txtFirstValue";
            txtFirstValue.Size = new Size(100, 23);
            txtFirstValue.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(187, 396);
            button1.Name = "button1";
            button1.Size = new Size(79, 33);
            button1.TabIndex = 14;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(345, 396);
            button2.Name = "button2";
            button2.Size = new Size(81, 33);
            button2.TabIndex = 15;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(494, 396);
            button3.Name = "button3";
            button3.Size = new Size(74, 33);
            button3.TabIndex = 16;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmOperacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSecondValue);
            Controls.Add(txtFirstValue);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmOperacion";
            Text = "frmOperacion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private TextBox txtDivision;
        private TextBox txtMultiplication;
        private TextBox txtSubtraction;
        private TextBox txtAddition;
        private TextBox txtSecondValue;
        private TextBox txtFirstValue;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}