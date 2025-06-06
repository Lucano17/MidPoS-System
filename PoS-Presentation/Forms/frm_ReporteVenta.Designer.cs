namespace PoS_Presentation.Forms
{
    partial class frm_ReporteVenta
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
            ReporteDataGridView = new DataGridView();
            FechaFinDTP = new DateTimePicker();
            FechaInicioDTP = new DateTimePicker();
            label4 = new Label();
            ExcelButton = new Button();
            rucLabel = new Label();
            label2 = new Label();
            BuscarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ReporteDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ReporteDataGridView
            // 
            ReporteDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReporteDataGridView.Location = new Point(12, 117);
            ReporteDataGridView.Name = "ReporteDataGridView";
            ReporteDataGridView.RowHeadersWidth = 51;
            ReporteDataGridView.Size = new Size(740, 278);
            ReporteDataGridView.TabIndex = 55;
            // 
            // FechaFinDTP
            // 
            FechaFinDTP.Format = DateTimePickerFormat.Short;
            FechaFinDTP.Location = new Point(245, 74);
            FechaFinDTP.Name = "FechaFinDTP";
            FechaFinDTP.Size = new Size(168, 27);
            FechaFinDTP.TabIndex = 54;
            // 
            // FechaInicioDTP
            // 
            FechaInicioDTP.Format = DateTimePickerFormat.Short;
            FechaInicioDTP.Location = new Point(37, 74);
            FechaInicioDTP.Name = "FechaInicioDTP";
            FechaInicioDTP.Size = new Size(168, 27);
            FechaInicioDTP.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(37, 51);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 52;
            label4.Text = "Fecha de inicio:";
            // 
            // ExcelButton
            // 
            ExcelButton.BackColor = Color.White;
            ExcelButton.Cursor = Cursors.Hand;
            ExcelButton.FlatStyle = FlatStyle.Flat;
            ExcelButton.ForeColor = Color.Green;
            ExcelButton.Location = new Point(632, 74);
            ExcelButton.Name = "ExcelButton";
            ExcelButton.Size = new Size(94, 27);
            ExcelButton.TabIndex = 51;
            ExcelButton.Text = "Excel";
            ExcelButton.UseVisualStyleBackColor = false;
            ExcelButton.Click += ExcelButton_Click;
            // 
            // rucLabel
            // 
            rucLabel.AutoSize = true;
            rucLabel.BackColor = Color.White;
            rucLabel.Location = new Point(245, 51);
            rucLabel.Name = "rucLabel";
            rucLabel.Size = new Size(83, 20);
            rucLabel.TabIndex = 47;
            rucLabel.Text = "Fecha final:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 46;
            label2.Text = "Reporte de ventas";
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.White;
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Location = new Point(462, 74);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 56;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // frm_ReporteVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(BuscarButton);
            Controls.Add(ReporteDataGridView);
            Controls.Add(FechaFinDTP);
            Controls.Add(FechaInicioDTP);
            Controls.Add(label4);
            Controls.Add(ExcelButton);
            Controls.Add(rucLabel);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_ReporteVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_ReporteVenta";
            Load += frm_ReporteVenta_Load;
            ((System.ComponentModel.ISupportInitialize)ReporteDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ReporteDataGridView;
        private DateTimePicker FechaFinDTP;
        private DateTimePicker FechaInicioDTP;
        private Label label4;
        private Button ExcelButton;
        private Label rucLabel;
        private Label label2;
        private Button BuscarButton;
    }
}