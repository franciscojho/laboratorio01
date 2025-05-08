namespace laboratorio01
{
    partial class frmAnimales
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
            lstItems = new ListBox();
            txtInput = new TextBox();
            btnAddItem = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            cbBucleTypes = new ComboBox();
            label2 = new Label();
            btnClean = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Animal:";
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(22, 99);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(457, 319);
            lstItems.TabIndex = 1;
            lstItems.SelectedIndexChanged += lstItems_SelectedIndexChanged;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(112, 26);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(367, 23);
            txtInput.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(533, 26);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Agregar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(533, 68);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(533, 146);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Salir";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // cbBucleTypes
            // 
            cbBucleTypes.FormattingEnabled = true;
            cbBucleTypes.Location = new Point(112, 63);
            cbBucleTypes.Name = "cbBucleTypes";
            cbBucleTypes.Size = new Size(121, 23);
            cbBucleTypes.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 67);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Tipo de bucle:";
            // 
            // btnClean
            // 
            btnClean.Location = new Point(533, 107);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(75, 23);
            btnClean.TabIndex = 8;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // frmAnimales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(637, 450);
            Controls.Add(btnClean);
            Controls.Add(label2);
            Controls.Add(cbBucleTypes);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnAddItem);
            Controls.Add(txtInput);
            Controls.Add(lstItems);
            Controls.Add(label1);
            Name = "frmAnimales";
            Text = "frmAnimales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstItems;
        private TextBox txtInput;
        private Button btnAddItem;
        private Button btnDelete;
        private Button btnLogout;
        private ComboBox cbBucleTypes;
        private Label label2;
        private Button btnClean;
    }
}