namespace laboratorio01
{
    partial class frmEdad
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
            txtAge = new TextBox();
            label2 = new Label();
            txtMessage = new TextBox();
            btnCalculate = new Button();
            btnReset = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Edad:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(90, 27);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Mensaje:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(90, 67);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(308, 23);
            txtMessage.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(20, 114);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(178, 114);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Limpiar";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(323, 114);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Salir";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmEdad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 169);
            Controls.Add(btnLogout);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(txtMessage);
            Controls.Add(label2);
            Controls.Add(txtAge);
            Controls.Add(label1);
            Name = "frmEdad";
            Text = "frmEdad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAge;
        private Label label2;
        private TextBox txtMessage;
        private Button btnCalculate;
        private Button btnReset;
        private Button btnLogout;
    }
}