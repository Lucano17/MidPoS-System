namespace PoS_Presentation.Forms
{
    partial class frm_Producto
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
            GuardarNuevoButton = new Button();
            VolverNuevoButton = new Button();
            TabEditar = new TabPage();
            HabilitadoCmbBox = new ComboBox();
            label16 = new Label();
            DescripcionEditarTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CantidadEditarUpDown = new NumericUpDown();
            PrecioCompraEditarTextBox = new TextBox();
            label6 = new Label();
            PrecioVentaEditarTextBox = new TextBox();
            label12 = new Label();
            CategoriaEditarCmbBox = new ComboBox();
            label13 = new Label();
            NombreEditarTextBox = new TextBox();
            label14 = new Label();
            GuardarEditarButton = new Button();
            VolverEditarButton = new Button();
            CodigoEditarTextBox = new TextBox();
            label15 = new Label();
            CodigoNuevoTextBox = new TextBox();
            TabNuevo = new TabPage();
            DescripcionNuevoTextBox = new TextBox();
            label11 = new Label();
            label3 = new Label();
            CantidadNuevoUpDown = new NumericUpDown();
            PrecioCompraNuevoTextBox = new TextBox();
            label10 = new Label();
            PrecioVentaNuevoTextBox = new TextBox();
            label9 = new Label();
            CategoriaNuevoCmbBox = new ComboBox();
            label8 = new Label();
            NombreNuevoTextBox = new TextBox();
            label7 = new Label();
            label2 = new Label();
            ProductosDGV = new DataGridView();
            BuscarButton = new Button();
            BuscarTextBox = new TextBox();
            NuevoListaButton = new Button();
            TabLista = new TabPage();
            tabControlMain = new TabControl();
            TabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadEditarUpDown).BeginInit();
            TabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadNuevoUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductosDGV).BeginInit();
            TabLista.SuspendLayout();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 3;
            label1.Text = "Inventario / Producto";
            // 
            // GuardarNuevoButton
            // 
            GuardarNuevoButton.BackColor = Color.White;
            GuardarNuevoButton.Cursor = Cursors.Hand;
            GuardarNuevoButton.FlatStyle = FlatStyle.Flat;
            GuardarNuevoButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarNuevoButton.Location = new Point(411, 272);
            GuardarNuevoButton.Name = "GuardarNuevoButton";
            GuardarNuevoButton.Size = new Size(94, 27);
            GuardarNuevoButton.TabIndex = 5;
            GuardarNuevoButton.Text = "Guardar";
            GuardarNuevoButton.UseVisualStyleBackColor = false;
            GuardarNuevoButton.Click += GuardarNuevoButton_Click;
            // 
            // VolverNuevoButton
            // 
            VolverNuevoButton.BackColor = Color.White;
            VolverNuevoButton.Cursor = Cursors.Hand;
            VolverNuevoButton.FlatStyle = FlatStyle.Flat;
            VolverNuevoButton.Location = new Point(235, 272);
            VolverNuevoButton.Name = "VolverNuevoButton";
            VolverNuevoButton.Size = new Size(94, 27);
            VolverNuevoButton.TabIndex = 4;
            VolverNuevoButton.Text = "Volver";
            VolverNuevoButton.UseVisualStyleBackColor = false;
            VolverNuevoButton.Click += VolverNuevoButton_Click;
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(HabilitadoCmbBox);
            TabEditar.Controls.Add(label16);
            TabEditar.Controls.Add(DescripcionEditarTextBox);
            TabEditar.Controls.Add(label4);
            TabEditar.Controls.Add(label5);
            TabEditar.Controls.Add(CantidadEditarUpDown);
            TabEditar.Controls.Add(PrecioCompraEditarTextBox);
            TabEditar.Controls.Add(label6);
            TabEditar.Controls.Add(PrecioVentaEditarTextBox);
            TabEditar.Controls.Add(label12);
            TabEditar.Controls.Add(CategoriaEditarCmbBox);
            TabEditar.Controls.Add(label13);
            TabEditar.Controls.Add(NombreEditarTextBox);
            TabEditar.Controls.Add(label14);
            TabEditar.Controls.Add(GuardarEditarButton);
            TabEditar.Controls.Add(VolverEditarButton);
            TabEditar.Controls.Add(CodigoEditarTextBox);
            TabEditar.Controls.Add(label15);
            TabEditar.Location = new Point(4, 24);
            TabEditar.Name = "TabEditar";
            TabEditar.Padding = new Padding(3);
            TabEditar.Size = new Size(732, 316);
            TabEditar.TabIndex = 2;
            TabEditar.Text = "Editar";
            TabEditar.UseVisualStyleBackColor = true;
            // 
            // HabilitadoCmbBox
            // 
            HabilitadoCmbBox.Cursor = Cursors.Hand;
            HabilitadoCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HabilitadoCmbBox.FormattingEnabled = true;
            HabilitadoCmbBox.Location = new Point(407, 225);
            HabilitadoCmbBox.Name = "HabilitadoCmbBox";
            HabilitadoCmbBox.Size = new Size(270, 28);
            HabilitadoCmbBox.TabIndex = 36;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(410, 206);
            label16.Name = "label16";
            label16.Size = new Size(83, 20);
            label16.TabIndex = 35;
            label16.Text = "Habilitado:";
            // 
            // DescripcionEditarTextBox
            // 
            DescripcionEditarTextBox.Location = new Point(55, 226);
            DescripcionEditarTextBox.Multiline = true;
            DescripcionEditarTextBox.Name = "DescripcionEditarTextBox";
            DescripcionEditarTextBox.Size = new Size(270, 27);
            DescripcionEditarTextBox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 206);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 33;
            label4.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 21);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 32;
            label5.Text = "Cantidad:";
            // 
            // CantidadEditarUpDown
            // 
            CantidadEditarUpDown.Location = new Point(407, 44);
            CantidadEditarUpDown.Name = "CantidadEditarUpDown";
            CantidadEditarUpDown.Size = new Size(270, 27);
            CantidadEditarUpDown.TabIndex = 31;
            // 
            // PrecioCompraEditarTextBox
            // 
            PrecioCompraEditarTextBox.Location = new Point(407, 101);
            PrecioCompraEditarTextBox.Name = "PrecioCompraEditarTextBox";
            PrecioCompraEditarTextBox.Size = new Size(270, 27);
            PrecioCompraEditarTextBox.TabIndex = 29;
            // 
            // label6
            // 
            label6.Location = new Point(410, 77);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 30;
            label6.Text = "Precio de compra:";
            // 
            // PrecioVentaEditarTextBox
            // 
            PrecioVentaEditarTextBox.Location = new Point(407, 164);
            PrecioVentaEditarTextBox.Name = "PrecioVentaEditarTextBox";
            PrecioVentaEditarTextBox.Size = new Size(270, 27);
            PrecioVentaEditarTextBox.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(410, 144);
            label12.Name = "label12";
            label12.Size = new Size(114, 20);
            label12.TabIndex = 27;
            label12.Text = "Precio de venta:";
            // 
            // CategoriaEditarCmbBox
            // 
            CategoriaEditarCmbBox.Cursor = Cursors.Hand;
            CategoriaEditarCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaEditarCmbBox.FormattingEnabled = true;
            CategoriaEditarCmbBox.Location = new Point(55, 163);
            CategoriaEditarCmbBox.Name = "CategoriaEditarCmbBox";
            CategoriaEditarCmbBox.Size = new Size(270, 28);
            CategoriaEditarCmbBox.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 143);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 25;
            label13.Text = "Categoría:";
            // 
            // NombreEditarTextBox
            // 
            NombreEditarTextBox.Location = new Point(55, 101);
            NombreEditarTextBox.Name = "NombreEditarTextBox";
            NombreEditarTextBox.Size = new Size(270, 27);
            NombreEditarTextBox.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(58, 81);
            label14.Name = "label14";
            label14.Size = new Size(67, 20);
            label14.TabIndex = 23;
            label14.Text = "Nombre:";
            // 
            // GuardarEditarButton
            // 
            GuardarEditarButton.BackColor = Color.White;
            GuardarEditarButton.Cursor = Cursors.Hand;
            GuardarEditarButton.FlatStyle = FlatStyle.Flat;
            GuardarEditarButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarEditarButton.Location = new Point(407, 268);
            GuardarEditarButton.Name = "GuardarEditarButton";
            GuardarEditarButton.Size = new Size(94, 27);
            GuardarEditarButton.TabIndex = 22;
            GuardarEditarButton.Text = "Guardar";
            GuardarEditarButton.UseVisualStyleBackColor = false;
            // 
            // VolverEditarButton
            // 
            VolverEditarButton.BackColor = Color.White;
            VolverEditarButton.Cursor = Cursors.Hand;
            VolverEditarButton.FlatStyle = FlatStyle.Flat;
            VolverEditarButton.Location = new Point(231, 268);
            VolverEditarButton.Name = "VolverEditarButton";
            VolverEditarButton.Size = new Size(94, 27);
            VolverEditarButton.TabIndex = 21;
            VolverEditarButton.Text = "Volver";
            VolverEditarButton.UseVisualStyleBackColor = false;
            // 
            // CodigoEditarTextBox
            // 
            CodigoEditarTextBox.Location = new Point(55, 43);
            CodigoEditarTextBox.Name = "CodigoEditarTextBox";
            CodigoEditarTextBox.Size = new Size(270, 27);
            CodigoEditarTextBox.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(58, 23);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 19;
            label15.Text = "Código:";
            // 
            // CodigoNuevoTextBox
            // 
            CodigoNuevoTextBox.Location = new Point(59, 47);
            CodigoNuevoTextBox.Name = "CodigoNuevoTextBox";
            CodigoNuevoTextBox.Size = new Size(270, 27);
            CodigoNuevoTextBox.TabIndex = 1;
            // 
            // TabNuevo
            // 
            TabNuevo.Controls.Add(DescripcionNuevoTextBox);
            TabNuevo.Controls.Add(label11);
            TabNuevo.Controls.Add(label3);
            TabNuevo.Controls.Add(CantidadNuevoUpDown);
            TabNuevo.Controls.Add(PrecioCompraNuevoTextBox);
            TabNuevo.Controls.Add(label10);
            TabNuevo.Controls.Add(PrecioVentaNuevoTextBox);
            TabNuevo.Controls.Add(label9);
            TabNuevo.Controls.Add(CategoriaNuevoCmbBox);
            TabNuevo.Controls.Add(label8);
            TabNuevo.Controls.Add(NombreNuevoTextBox);
            TabNuevo.Controls.Add(label7);
            TabNuevo.Controls.Add(GuardarNuevoButton);
            TabNuevo.Controls.Add(VolverNuevoButton);
            TabNuevo.Controls.Add(CodigoNuevoTextBox);
            TabNuevo.Controls.Add(label2);
            TabNuevo.Location = new Point(4, 24);
            TabNuevo.Name = "TabNuevo";
            TabNuevo.Padding = new Padding(3);
            TabNuevo.Size = new Size(732, 316);
            TabNuevo.TabIndex = 1;
            TabNuevo.Text = "Nuevo";
            TabNuevo.UseVisualStyleBackColor = true;
            // 
            // DescripcionNuevoTextBox
            // 
            DescripcionNuevoTextBox.Location = new Point(59, 230);
            DescripcionNuevoTextBox.Multiline = true;
            DescripcionNuevoTextBox.Name = "DescripcionNuevoTextBox";
            DescripcionNuevoTextBox.Size = new Size(270, 27);
            DescripcionNuevoTextBox.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(62, 210);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 17;
            label11.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 25);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 16;
            label3.Text = "Cantidad:";
            // 
            // CantidadNuevoUpDown
            // 
            CantidadNuevoUpDown.Location = new Point(411, 48);
            CantidadNuevoUpDown.Name = "CantidadNuevoUpDown";
            CantidadNuevoUpDown.Size = new Size(270, 27);
            CantidadNuevoUpDown.TabIndex = 15;
            // 
            // PrecioCompraNuevoTextBox
            // 
            PrecioCompraNuevoTextBox.Location = new Point(411, 105);
            PrecioCompraNuevoTextBox.Name = "PrecioCompraNuevoTextBox";
            PrecioCompraNuevoTextBox.Size = new Size(270, 27);
            PrecioCompraNuevoTextBox.TabIndex = 13;
            // 
            // label10
            // 
            label10.Location = new Point(414, 81);
            label10.Name = "label10";
            label10.Size = new Size(148, 23);
            label10.TabIndex = 14;
            label10.Text = "Precio de compra:";
            // 
            // PrecioVentaNuevoTextBox
            // 
            PrecioVentaNuevoTextBox.Location = new Point(411, 168);
            PrecioVentaNuevoTextBox.Name = "PrecioVentaNuevoTextBox";
            PrecioVentaNuevoTextBox.Size = new Size(270, 27);
            PrecioVentaNuevoTextBox.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 148);
            label9.Name = "label9";
            label9.Size = new Size(114, 20);
            label9.TabIndex = 10;
            label9.Text = "Precio de venta:";
            // 
            // CategoriaNuevoCmbBox
            // 
            CategoriaNuevoCmbBox.Cursor = Cursors.Hand;
            CategoriaNuevoCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoriaNuevoCmbBox.FormattingEnabled = true;
            CategoriaNuevoCmbBox.Location = new Point(59, 167);
            CategoriaNuevoCmbBox.Name = "CategoriaNuevoCmbBox";
            CategoriaNuevoCmbBox.Size = new Size(270, 28);
            CategoriaNuevoCmbBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 147);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 8;
            label8.Text = "Categoría:";
            // 
            // NombreNuevoTextBox
            // 
            NombreNuevoTextBox.Location = new Point(59, 105);
            NombreNuevoTextBox.Name = "NombreNuevoTextBox";
            NombreNuevoTextBox.Size = new Size(270, 27);
            NombreNuevoTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 85);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 6;
            label7.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 27);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // ProductosDGV
            // 
            ProductosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductosDGV.Location = new Point(20, 53);
            ProductosDGV.Name = "ProductosDGV";
            ProductosDGV.RowHeadersWidth = 51;
            ProductosDGV.Size = new Size(691, 257);
            ProductosDGV.TabIndex = 3;
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.White;
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Location = new Point(617, 10);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // BuscarTextBox
            // 
            BuscarTextBox.Location = new Point(423, 10);
            BuscarTextBox.Name = "BuscarTextBox";
            BuscarTextBox.Size = new Size(175, 27);
            BuscarTextBox.TabIndex = 1;
            // 
            // NuevoListaButton
            // 
            NuevoListaButton.BackColor = Color.White;
            NuevoListaButton.Cursor = Cursors.Hand;
            NuevoListaButton.FlatStyle = FlatStyle.Flat;
            NuevoListaButton.Location = new Point(20, 10);
            NuevoListaButton.Name = "NuevoListaButton";
            NuevoListaButton.Size = new Size(94, 27);
            NuevoListaButton.TabIndex = 0;
            NuevoListaButton.Text = "Nuevo";
            NuevoListaButton.UseVisualStyleBackColor = false;
            NuevoListaButton.Click += NuevoListaButton_Click;
            // 
            // TabLista
            // 
            TabLista.Controls.Add(ProductosDGV);
            TabLista.Controls.Add(BuscarButton);
            TabLista.Controls.Add(BuscarTextBox);
            TabLista.Controls.Add(NuevoListaButton);
            TabLista.Location = new Point(4, 24);
            TabLista.Name = "TabLista";
            TabLista.Padding = new Padding(3);
            TabLista.Size = new Size(732, 316);
            TabLista.TabIndex = 0;
            TabLista.Text = "Lista";
            TabLista.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(TabLista);
            tabControlMain.Controls.Add(TabNuevo);
            tabControlMain.Controls.Add(TabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 48);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // frm_Producto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Producto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Producto";
            Load += frm_Producto_Load;
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadEditarUpDown).EndInit();
            TabNuevo.ResumeLayout(false);
            TabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadNuevoUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductosDGV).EndInit();
            TabLista.ResumeLayout(false);
            TabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button GuardarNuevoButton;
        private Button VolverNuevoButton;
        private TabPage TabEditar;
        private TextBox CodigoNuevoTextBox;
        private TabPage TabNuevo;
        private Label label2;
        private DataGridView ProductosDGV;
        private Button BuscarButton;
        private TextBox BuscarTextBox;
        private Button NuevoListaButton;
        private TabPage TabLista;
        private TabControl tabControlMain;
        private TextBox NombreNuevoTextBox;
        private Label label7;
        private ComboBox CategoriaNuevoCmbBox;
        private Label label8;
        private TextBox PrecioCompraNuevoTextBox;
        private Label label10;
        private TextBox PrecioVentaNuevoTextBox;
        private Label label9;
        private Label label3;
        private NumericUpDown CantidadNuevoUpDown;
        private TextBox DescripcionNuevoTextBox;
        private Label label11;
        private Label label16;
        private TextBox DescripcionEditarTextBox;
        private Label label4;
        private Label label5;
        private NumericUpDown CantidadEditarUpDown;
        private TextBox PrecioCompraEditarTextBox;
        private Label label6;
        private TextBox PrecioVentaEditarTextBox;
        private Label label12;
        private ComboBox CategoriaEditarCmbBox;
        private Label label13;
        private TextBox NombreEditarTextBox;
        private Label label14;
        private Button GuardarEditarButton;
        private Button VolverEditarButton;
        private TextBox CodigoEditarTextBox;
        private Label label15;
        private ComboBox HabilitadoCmbBox;
    }
}