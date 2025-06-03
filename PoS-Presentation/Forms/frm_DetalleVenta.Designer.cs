namespace PoS_Presentation.Forms
{
    partial class frm_DetalleVenta
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
            DetalleDataGridView = new DataGridView();
            VerPDFButton = new Button();
            label2 = new Label();
            NumeroVentaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DetalleDataGridView).BeginInit();
            SuspendLayout();
            // 
            // DetalleDataGridView
            // 
            DetalleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DetalleDataGridView.Location = new Point(25, 46);
            DetalleDataGridView.Name = "DetalleDataGridView";
            DetalleDataGridView.RowHeadersWidth = 51;
            DetalleDataGridView.Size = new Size(691, 257);
            DetalleDataGridView.TabIndex = 9;
            // 
            // VerPDFButton
            // 
            VerPDFButton.BackColor = Color.White;
            VerPDFButton.Cursor = Cursors.Hand;
            VerPDFButton.FlatStyle = FlatStyle.Flat;
            VerPDFButton.Location = new Point(622, 10);
            VerPDFButton.Name = "VerPDFButton";
            VerPDFButton.Size = new Size(94, 27);
            VerPDFButton.TabIndex = 8;
            VerPDFButton.Text = "Ver PDF";
            VerPDFButton.UseVisualStyleBackColor = false;
            VerPDFButton.Click += VerPDFButton_Click;
            // 
            // label2
            // 
            label2.Location = new Point(25, 13);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 10;
            label2.Text = "Número de Venta:";
            // 
            // NumeroVentaLabel
            // 
            NumeroVentaLabel.BorderStyle = BorderStyle.Fixed3D;
            NumeroVentaLabel.Location = new Point(161, 12);
            NumeroVentaLabel.Name = "NumeroVentaLabel";
            NumeroVentaLabel.Size = new Size(163, 25);
            NumeroVentaLabel.TabIndex = 11;
            NumeroVentaLabel.Text = "0";
            // 
            // frm_DetalleVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(741, 313);
            Controls.Add(NumeroVentaLabel);
            Controls.Add(label2);
            Controls.Add(DetalleDataGridView);
            Controls.Add(VerPDFButton);
            MaximizeBox = false;
            MaximumSize = new Size(759, 360);
            MinimizeBox = false;
            MinimumSize = new Size(759, 360);
            Name = "frm_DetalleVenta";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de venta";
            Load += frm_DetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DetalleDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DetalleDataGridView;
        private Button VerPDFButton;
        private Label label2;
        private Label NumeroVentaLabel;
    }
}