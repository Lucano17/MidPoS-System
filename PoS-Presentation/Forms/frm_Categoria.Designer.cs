namespace PoS_Presentation.Forms
{
    partial class frm_Categoria
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
            tabControlMain = new TabControl();
            TabLista = new TabPage();
            CategoriasDGV = new DataGridView();
            BuscarButton = new Button();
            BuscarTextBox = new TextBox();
            NuevoListaButton = new Button();
            TabNuevo = new TabPage();
            GuardarNuevoButton = new Button();
            VolverNuevoButton = new Button();
            MedidaNuevoCmbBox = new ComboBox();
            label3 = new Label();
            NombreNuevoTextBox = new TextBox();
            label2 = new Label();
            TabEditar = new TabPage();
            HabilitadoCmbBox = new ComboBox();
            label6 = new Label();
            GuardarEditarButton = new Button();
            VolverEditarButton = new Button();
            MedidaEditarCmbBox = new ComboBox();
            label4 = new Label();
            NombreEditarTextBox = new TextBox();
            label5 = new Label();
            label1 = new Label();
            tabControlMain.SuspendLayout();
            TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriasDGV).BeginInit();
            TabNuevo.SuspendLayout();
            TabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(TabLista);
            tabControlMain.Controls.Add(TabNuevo);
            tabControlMain.Controls.Add(TabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 51);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // TabLista
            // 
            TabLista.Controls.Add(CategoriasDGV);
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
            // CategoriasDGV
            // 
            CategoriasDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriasDGV.Location = new Point(20, 53);
            CategoriasDGV.Name = "CategoriasDGV";
            CategoriasDGV.RowHeadersWidth = 51;
            CategoriasDGV.Size = new Size(691, 257);
            CategoriasDGV.TabIndex = 3;
            CategoriasDGV.CellContentClick += CategoriasDGV_CellContentClick;
            // 
            // BuscarButton
            // 
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Location = new Point(617, 10);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 2;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
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
            NuevoListaButton.Cursor = Cursors.Hand;
            NuevoListaButton.FlatStyle = FlatStyle.Flat;
            NuevoListaButton.Location = new Point(20, 10);
            NuevoListaButton.Name = "NuevoListaButton";
            NuevoListaButton.Size = new Size(94, 27);
            NuevoListaButton.TabIndex = 0;
            NuevoListaButton.Text = "Nuevo";
            NuevoListaButton.UseVisualStyleBackColor = true;
            NuevoListaButton.Click += NuevoListaButton_Click;
            // 
            // TabNuevo
            // 
            TabNuevo.Controls.Add(GuardarNuevoButton);
            TabNuevo.Controls.Add(VolverNuevoButton);
            TabNuevo.Controls.Add(MedidaNuevoCmbBox);
            TabNuevo.Controls.Add(label3);
            TabNuevo.Controls.Add(NombreNuevoTextBox);
            TabNuevo.Controls.Add(label2);
            TabNuevo.Location = new Point(4, 24);
            TabNuevo.Name = "TabNuevo";
            TabNuevo.Padding = new Padding(3);
            TabNuevo.Size = new Size(732, 316);
            TabNuevo.TabIndex = 1;
            TabNuevo.Text = "Nuevo";
            TabNuevo.UseVisualStyleBackColor = true;
            // 
            // GuardarNuevoButton
            // 
            GuardarNuevoButton.Cursor = Cursors.Hand;
            GuardarNuevoButton.FlatStyle = FlatStyle.Flat;
            GuardarNuevoButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarNuevoButton.Location = new Point(417, 215);
            GuardarNuevoButton.Name = "GuardarNuevoButton";
            GuardarNuevoButton.Size = new Size(94, 27);
            GuardarNuevoButton.TabIndex = 5;
            GuardarNuevoButton.Text = "Guardar";
            GuardarNuevoButton.UseVisualStyleBackColor = true;
            GuardarNuevoButton.Click += GuardarNuevoButton_Click;
            // 
            // VolverNuevoButton
            // 
            VolverNuevoButton.Cursor = Cursors.Hand;
            VolverNuevoButton.FlatStyle = FlatStyle.Flat;
            VolverNuevoButton.Location = new Point(241, 215);
            VolverNuevoButton.Name = "VolverNuevoButton";
            VolverNuevoButton.Size = new Size(94, 27);
            VolverNuevoButton.TabIndex = 4;
            VolverNuevoButton.Text = "Volver";
            VolverNuevoButton.UseVisualStyleBackColor = true;
            VolverNuevoButton.Click += VolverNuevoButton_Click;
            // 
            // MedidaNuevoCmbBox
            // 
            MedidaNuevoCmbBox.Cursor = Cursors.Hand;
            MedidaNuevoCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MedidaNuevoCmbBox.FormattingEnabled = true;
            MedidaNuevoCmbBox.Location = new Point(241, 136);
            MedidaNuevoCmbBox.Name = "MedidaNuevoCmbBox";
            MedidaNuevoCmbBox.Size = new Size(270, 28);
            MedidaNuevoCmbBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 113);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Medida:";
            // 
            // NombreNuevoTextBox
            // 
            NombreNuevoTextBox.Location = new Point(241, 72);
            NombreNuevoTextBox.Name = "NombreNuevoTextBox";
            NombreNuevoTextBox.Size = new Size(270, 27);
            NombreNuevoTextBox.TabIndex = 1;
            NombreNuevoTextBox.TextChanged += NombreNuevoTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(HabilitadoCmbBox);
            TabEditar.Controls.Add(label6);
            TabEditar.Controls.Add(GuardarEditarButton);
            TabEditar.Controls.Add(VolverEditarButton);
            TabEditar.Controls.Add(MedidaEditarCmbBox);
            TabEditar.Controls.Add(label4);
            TabEditar.Controls.Add(NombreEditarTextBox);
            TabEditar.Controls.Add(label5);
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
            HabilitadoCmbBox.Location = new Point(227, 190);
            HabilitadoCmbBox.Name = "HabilitadoCmbBox";
            HabilitadoCmbBox.Size = new Size(270, 28);
            HabilitadoCmbBox.TabIndex = 13;
            HabilitadoCmbBox.SelectedIndexChanged += HabilitadoCmbBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 167);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 12;
            label6.Text = "Habliditado:";
            // 
            // GuardarEditarButton
            // 
            GuardarEditarButton.Cursor = Cursors.Hand;
            GuardarEditarButton.FlatStyle = FlatStyle.Flat;
            GuardarEditarButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarEditarButton.Location = new Point(407, 256);
            GuardarEditarButton.Name = "GuardarEditarButton";
            GuardarEditarButton.Size = new Size(94, 27);
            GuardarEditarButton.TabIndex = 11;
            GuardarEditarButton.Text = "Guardar";
            GuardarEditarButton.UseVisualStyleBackColor = true;
            GuardarEditarButton.Click += GuardarEditarButton_Click;
            // 
            // VolverEditarButton
            // 
            VolverEditarButton.Cursor = Cursors.Hand;
            VolverEditarButton.FlatStyle = FlatStyle.Flat;
            VolverEditarButton.Location = new Point(231, 256);
            VolverEditarButton.Name = "VolverEditarButton";
            VolverEditarButton.Size = new Size(94, 27);
            VolverEditarButton.TabIndex = 10;
            VolverEditarButton.Text = "Volver";
            VolverEditarButton.UseVisualStyleBackColor = true;
            VolverEditarButton.Click += VolverEditarButton_Click;
            // 
            // MedidaEditarCmbBox
            // 
            MedidaEditarCmbBox.Cursor = Cursors.Hand;
            MedidaEditarCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MedidaEditarCmbBox.FormattingEnabled = true;
            MedidaEditarCmbBox.Location = new Point(227, 119);
            MedidaEditarCmbBox.Name = "MedidaEditarCmbBox";
            MedidaEditarCmbBox.Size = new Size(270, 28);
            MedidaEditarCmbBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 96);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Medida:";
            // 
            // NombreEditarTextBox
            // 
            NombreEditarTextBox.Location = new Point(227, 55);
            NombreEditarTextBox.Name = "NombreEditarTextBox";
            NombreEditarTextBox.Size = new Size(270, 27);
            NombreEditarTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 32);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Inventario / Categoría";
            // 
            // frm_Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Categoria";
            Load += frm_Categoria_Load;
            tabControlMain.ResumeLayout(false);
            TabLista.ResumeLayout(false);
            TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriasDGV).EndInit();
            TabNuevo.ResumeLayout(false);
            TabNuevo.PerformLayout();
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage TabLista;
        private TabPage TabNuevo;
        private Label label1;
        private TabPage TabEditar;
        private Button BuscarButton;
        private TextBox BuscarTextBox;
        private Button NuevoListaButton;
        private DataGridView CategoriasDGV;
        private TextBox NombreNuevoTextBox;
        private Label label2;
        private Label label3;
        private Button GuardarNuevoButton;
        private Button VolverNuevoButton;
        private ComboBox MedidaNuevoCmbBox;
        private Button GuardarEditarButton;
        private Button VolverEditarButton;
        private ComboBox MedidaEditarCmbBox;
        private Label label4;
        private TextBox NombreEditarTextBox;
        private Label label5;
        private ComboBox HabilitadoCmbBox;
        private Label label6;
    }
}