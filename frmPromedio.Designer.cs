namespace laboratorio01
{
    partial class frmPromedio
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
            txtScoreA = new TextBox();
            txtScoreB = new TextBox();
            label2 = new Label();
            txtScoreC = new TextBox();
            label3 = new Label();
            txtScoreD = new TextBox();
            label4 = new Label();
            txtAverageScore = new TextBox();
            label5 = new Label();
            txtConditions = new TextBox();
            label6 = new Label();
            btnCalculate = new Button();
            btnClean = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 62);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota 1:";
            // 
            // txtScoreA
            // 
            txtScoreA.Location = new Point(154, 59);
            txtScoreA.Name = "txtScoreA";
            txtScoreA.Size = new Size(102, 23);
            txtScoreA.TabIndex = 1;
            // 
            // txtScoreB
            // 
            txtScoreB.Location = new Point(154, 101);
            txtScoreB.Name = "txtScoreB";
            txtScoreB.Size = new Size(102, 23);
            txtScoreB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 104);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota 2:";
            // 
            // txtScoreC
            // 
            txtScoreC.Location = new Point(154, 145);
            txtScoreC.Name = "txtScoreC";
            txtScoreC.Size = new Size(102, 23);
            txtScoreC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 148);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota 3:";
            // 
            // txtScoreD
            // 
            txtScoreD.Location = new Point(154, 186);
            txtScoreD.Name = "txtScoreD";
            txtScoreD.Size = new Size(102, 23);
            txtScoreD.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 189);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Nota 4:";
            // 
            // txtAverageScore
            // 
            txtAverageScore.Location = new Point(154, 230);
            txtAverageScore.Name = "txtAverageScore";
            txtAverageScore.Size = new Size(102, 23);
            txtAverageScore.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 233);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "Promedio:";
            // 
            // txtConditions
            // 
            txtConditions.Location = new Point(154, 273);
            txtConditions.Name = "txtConditions";
            txtConditions.Size = new Size(168, 23);
            txtConditions.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 276);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 10;
            label6.Text = "Condiciones:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(65, 340);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(264, 340);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 13;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(452, 340);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Salir";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 433);
            Controls.Add(btnLogout);
            Controls.Add(btnClean);
            Controls.Add(btnCalculate);
            Controls.Add(txtConditions);
            Controls.Add(label6);
            Controls.Add(txtAverageScore);
            Controls.Add(label5);
            Controls.Add(txtScoreD);
            Controls.Add(label4);
            Controls.Add(txtScoreC);
            Controls.Add(label3);
            Controls.Add(txtScoreB);
            Controls.Add(label2);
            Controls.Add(txtScoreA);
            Controls.Add(label1);
            Name = "frmPromedio";
            Text = "frmPromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScoreA;
        private TextBox txtScoreB;
        private Label label2;
        private TextBox txtScoreC;
        private Label label3;
        private TextBox txtScoreD;
        private Label label4;
        private TextBox txtAverageScore;
        private Label label5;
        private TextBox txtConditions;
        private Label label6;
        private Button btnCalculate;
        private Button btnClean;
        private Button btnLogout;
    }
}