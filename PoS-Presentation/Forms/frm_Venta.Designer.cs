namespace PoS_Presentation.Forms
{
    partial class frm_Venta
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
            label4 = new Label();
            RegistrarButton = new Button();
            VolverButton = new Button();
            BuscarButton = new Button();
            PagoConTextBox = new TextBox();
            label5 = new Label();
            NombreClienteTextBox = new TextBox();
            rucLabel = new Label();
            CodigoProductoTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            CambioTextBox = new TextBox();
            label9 = new Label();
            label6 = new Label();
            TotalPriceLabel = new Label();
            DetalleVentaDGV = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)DetalleVentaDGV).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 44;
            label4.Text = "Código de producto:";
            // 
            // RegistrarButton
            // 
            RegistrarButton.BackColor = Color.White;
            RegistrarButton.Cursor = Cursors.Hand;
            RegistrarButton.FlatStyle = FlatStyle.Flat;
            RegistrarButton.ForeColor = Color.FromArgb(30, 90, 195);
            RegistrarButton.Location = new Point(654, 141);
            RegistrarButton.Name = "RegistrarButton";
            RegistrarButton.Size = new Size(94, 27);
            RegistrarButton.TabIndex = 41;
            RegistrarButton.Text = "Registrar";
            RegistrarButton.UseVisualStyleBackColor = false;
            RegistrarButton.Click += RegistrarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.BackColor = Color.White;
            VolverButton.Cursor = Cursors.Hand;
            VolverButton.FlatStyle = FlatStyle.Flat;
            VolverButton.Location = new Point(554, 141);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(94, 27);
            VolverButton.TabIndex = 40;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = false;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(199, 71);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(86, 30);
            BuscarButton.TabIndex = 49;
            BuscarButton.Text = "Buscar";
            BuscarButton.Click += BuscarButton_Click;
            // 
            // PagoConTextBox
            // 
            PagoConTextBox.BackColor = Color.White;
            PagoConTextBox.Location = new Point(199, 141);
            PagoConTextBox.Name = "PagoConTextBox";
            PagoConTextBox.Size = new Size(159, 27);
            PagoConTextBox.TabIndex = 29;
            PagoConTextBox.KeyDown += PagoConTextBox_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(199, 118);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 28;
            label5.Text = "Pagó con:";
            // 
            // NombreClienteTextBox
            // 
            NombreClienteTextBox.BackColor = Color.White;
            NombreClienteTextBox.Location = new Point(12, 141);
            NombreClienteTextBox.Name = "NombreClienteTextBox";
            NombreClienteTextBox.Size = new Size(158, 27);
            NombreClienteTextBox.TabIndex = 27;
            // 
            // rucLabel
            // 
            rucLabel.AutoSize = true;
            rucLabel.BackColor = Color.White;
            rucLabel.Location = new Point(12, 118);
            rucLabel.Name = "rucLabel";
            rucLabel.Size = new Size(140, 20);
            rucLabel.TabIndex = 26;
            rucLabel.Text = "Nombre del cliente:\r\n";
            // 
            // CodigoProductoTextBox
            // 
            CodigoProductoTextBox.Location = new Point(12, 77);
            CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            CodigoProductoTextBox.Size = new Size(158, 27);
            CodigoProductoTextBox.TabIndex = 50;
            CodigoProductoTextBox.KeyDown += CodigoProductoTextBox_KeyDown;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 50;
            // 
            // label1
            // 
            label1.Location = new Point(44, 13);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 43;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(58, 49, 69);
            label3.Location = new Point(561, 16);
            label3.Name = "label3";
            label3.Size = new Size(174, 97);
            label3.TabIndex = 45;
            // 
            // CambioTextBox
            // 
            CambioTextBox.BackColor = Color.White;
            CambioTextBox.Location = new Point(388, 141);
            CambioTextBox.Name = "CambioTextBox";
            CambioTextBox.ReadOnly = true;
            CambioTextBox.Size = new Size(151, 27);
            CambioTextBox.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(388, 118);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 38;
            label9.Text = "Cambio:";
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(58, 49, 69);
            label6.Font = new Font("Segoe UI", 18F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(604, 16);
            label6.Name = "label6";
            label6.Size = new Size(88, 38);
            label6.TabIndex = 46;
            label6.Text = "Total:";
            // 
            // TotalPriceLabel
            // 
            TotalPriceLabel.BackColor = Color.FromArgb(58, 49, 69);
            TotalPriceLabel.Font = new Font("Segoe UI", 18F);
            TotalPriceLabel.ForeColor = Color.White;
            TotalPriceLabel.Location = new Point(561, 54);
            TotalPriceLabel.Name = "TotalPriceLabel";
            TotalPriceLabel.Size = new Size(174, 50);
            TotalPriceLabel.TabIndex = 47;
            TotalPriceLabel.Text = "0";
            TotalPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetalleVentaDGV
            // 
            DetalleVentaDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetalleVentaDGV.Location = new Point(12, 180);
            DetalleVentaDGV.Name = "DetalleVentaDGV";
            DetalleVentaDGV.RowHeadersWidth = 51;
            DetalleVentaDGV.Size = new Size(740, 215);
            DetalleVentaDGV.TabIndex = 48;
            DetalleVentaDGV.CellContentClick += DetalleVentaDGV_CellContentClick;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(305, 9);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 0;
            label7.Text = "NUEVA VENTA";
            // 
            // frm_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label7);
            Controls.Add(DetalleVentaDGV);
            Controls.Add(TotalPriceLabel);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(RegistrarButton);
            Controls.Add(VolverButton);
            Controls.Add(CambioTextBox);
            Controls.Add(label9);
            Controls.Add(BuscarButton);
            Controls.Add(PagoConTextBox);
            Controls.Add(label5);
            Controls.Add(NombreClienteTextBox);
            Controls.Add(rucLabel);
            Controls.Add(CodigoProductoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Venta";
            Load += frm_Venta_Load;
            ((System.ComponentModel.ISupportInitialize)DetalleVentaDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button RegistrarButton;
        private Button VolverButton;
        private Button BuscarButton;
        private TextBox PagoConTextBox;
        private Label label5;
        private TextBox NombreClienteTextBox;
        private Label rucLabel;
        private TextBox CodigoProductoTextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox CambioTextBox;
        private Label label9;
        private Label label6;
        private Label TotalPriceLabel;
        private DataGridView DetalleVentaDGV;
        private Label label7;
    }
}