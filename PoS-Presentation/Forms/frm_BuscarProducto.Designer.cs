namespace PoS_Presentation.Forms
{
    partial class frm_BuscarProducto
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
            ProductosDGV = new DataGridView();
            BuscarButton = new Button();
            BuscarTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductosDGV).BeginInit();
            SuspendLayout();
            // 
            // ProductosDGV
            // 
            ProductosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDGV.Location = new Point(25, 49);
            ProductosDGV.Name = "ProductosDGV";
            ProductosDGV.RowHeadersWidth = 51;
            ProductosDGV.Size = new Size(691, 257);
            ProductosDGV.TabIndex = 6;
            ProductosDGV.CellDoubleClick += ProductosDGV_CellDoubleClick;
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.White;
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Location = new Point(219, 12);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 5;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // BuscarTextBox
            // 
            BuscarTextBox.Location = new Point(25, 12);
            BuscarTextBox.Name = "BuscarTextBox";
            BuscarTextBox.Size = new Size(175, 27);
            BuscarTextBox.TabIndex = 4;
            // 
            // frm_BuscarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(741, 313);
            Controls.Add(ProductosDGV);
            Controls.Add(BuscarButton);
            Controls.Add(BuscarTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(759, 360);
            MinimizeBox = false;
            MinimumSize = new Size(759, 360);
            Name = "frm_BuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Producto";
            Load += frm_BuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)ProductosDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductosDGV;
        private Button BuscarButton;
        private TextBox BuscarTextBox;
    }
}