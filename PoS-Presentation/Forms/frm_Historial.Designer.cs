namespace PoS_Presentation.Forms
{
    partial class frm_Historial
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
            BuscarButton = new Button();
            EncontrarTextBox = new TextBox();
            label6 = new Label();
            rucLabel = new Label();
            label2 = new Label();
            FechaInicioDTP = new DateTimePicker();
            FechaFinDTP = new DateTimePicker();
            VentaDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)VentaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(37, 54);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 42;
            label4.Text = "Fecha de inicio:";
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.White;
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.ForeColor = Color.FromArgb(30, 90, 195);
            BuscarButton.Location = new Point(632, 77);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 41;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // EncontrarTextBox
            // 
            EncontrarTextBox.BackColor = Color.White;
            EncontrarTextBox.Location = new Point(452, 77);
            EncontrarTextBox.Name = "EncontrarTextBox";
            EncontrarTextBox.Size = new Size(138, 27);
            EncontrarTextBox.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(452, 54);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 30;
            label6.Text = "Encontrar:";
            // 
            // rucLabel
            // 
            rucLabel.AutoSize = true;
            rucLabel.BackColor = Color.White;
            rucLabel.Location = new Point(245, 54);
            rucLabel.Name = "rucLabel";
            rucLabel.Size = new Size(83, 20);
            rucLabel.TabIndex = 26;
            rucLabel.Text = "Fecha final:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 24;
            label2.Text = "Historial de ventas";
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Format = DateTimePickerFormat.Short;
            FechaInicioDTP.Location = new Point(37, 77);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(168, 27);
            FechaInicioDTP.TabIndex = 43;
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Format = DateTimePickerFormat.Short;
            FechaFinDTP.Location = new Point(245, 77);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(168, 27);
            FechaFinDTP.TabIndex = 44;
            // 
            // VentaDataGridView
            // 
            VentaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VentaDataGridView.Location = new Point(12, 120);
            VentaDataGridView.Name = "VentaDataGridView";
            VentaDataGridView.RowHeadersWidth = 51;
            VentaDataGridView.Size = new Size(740, 275);
            VentaDataGridView.TabIndex = 45;
            VentaDataGridView.CellContentClick += VentaDataGridView_CellContentClick;
            // 
            // frm_Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(VentaDataGridView);
            Controls.Add(FechaFinDTP);
            Controls.Add(FechaInicioDTP);
            Controls.Add(label4);
            Controls.Add(BuscarButton);
            Controls.Add(EncontrarTextBox);
            Controls.Add(label6);
            Controls.Add(rucLabel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Historial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Historial";
            Load += frm_Historial_Load;
            ((System.ComponentModel.ISupportInitialize)VentaDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button BuscarButton;
        private TextBox EncontrarTextBox;
        private Label label6;
        private Label rucLabel;
        private Label label2;
        private DateTimePicker FechaInicioDTP;
        private DateTimePicker FechaFinDTP;
        private DataGridView VentaDataGridView;
    }
}