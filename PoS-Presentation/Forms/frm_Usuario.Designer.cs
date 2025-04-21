namespace PoS_Presentation.Forms
{
    partial class frm_Usuario
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
            tabControlMain = new TabControl();
            TabLista = new TabPage();
            UsuariosDGV = new DataGridView();
            BuscarButton = new Button();
            BuscarTextBox = new TextBox();
            NuevoListaButton = new Button();
            TabNuevo = new TabPage();
            NombreUsuarioNuevoTextBox = new TextBox();
            label9 = new Label();
            CorreoNuevoTextBox = new TextBox();
            label8 = new Label();
            ApellidoNuevoTextBox = new TextBox();
            label7 = new Label();
            GuardarNuevoButton = new Button();
            VolverNuevoButton = new Button();
            RolNuevoCmbBox = new ComboBox();
            label3 = new Label();
            NombreNuevoTextBox = new TextBox();
            label2 = new Label();
            TabEditar = new TabPage();
            HabilitadoCmbBox = new ComboBox();
            label12 = new Label();
            NombreUsuarioEditarTextBox = new TextBox();
            label4 = new Label();
            CorreoEditarTextBox = new TextBox();
            label5 = new Label();
            ApellidoEditarTextBox = new TextBox();
            label6 = new Label();
            GuardarEditarButton = new Button();
            VolverEditarButton = new Button();
            RolEditarCmbBox = new ComboBox();
            label10 = new Label();
            NombreEditarTextBox = new TextBox();
            label11 = new Label();
            tabControlMain.SuspendLayout();
            TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsuariosDGV).BeginInit();
            TabNuevo.SuspendLayout();
            TabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Usuarios";
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
            // TabLista
            // 
            TabLista.Controls.Add(UsuariosDGV);
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
            // UsuariosDGV
            // 
            UsuariosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsuariosDGV.Location = new Point(20, 53);
            UsuariosDGV.Name = "UsuariosDGV";
            UsuariosDGV.RowHeadersWidth = 51;
            UsuariosDGV.Size = new Size(691, 257);
            UsuariosDGV.TabIndex = 3;
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
            TabNuevo.Controls.Add(NombreUsuarioNuevoTextBox);
            TabNuevo.Controls.Add(label9);
            TabNuevo.Controls.Add(CorreoNuevoTextBox);
            TabNuevo.Controls.Add(label8);
            TabNuevo.Controls.Add(ApellidoNuevoTextBox);
            TabNuevo.Controls.Add(label7);
            TabNuevo.Controls.Add(GuardarNuevoButton);
            TabNuevo.Controls.Add(VolverNuevoButton);
            TabNuevo.Controls.Add(RolNuevoCmbBox);
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
            // NombreUsuarioNuevoTextBox
            // 
            NombreUsuarioNuevoTextBox.Location = new Point(439, 108);
            NombreUsuarioNuevoTextBox.Name = "NombreUsuarioNuevoTextBox";
            NombreUsuarioNuevoTextBox.Size = new Size(270, 27);
            NombreUsuarioNuevoTextBox.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 88);
            label9.Name = "label9";
            label9.Size = new Size(140, 20);
            label9.TabIndex = 10;
            label9.Text = "Nombre de usuario:";
            // 
            // CorreoNuevoTextBox
            // 
            CorreoNuevoTextBox.Location = new Point(439, 47);
            CorreoNuevoTextBox.Name = "CorreoNuevoTextBox";
            CorreoNuevoTextBox.Size = new Size(270, 27);
            CorreoNuevoTextBox.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(442, 27);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 8;
            label8.Text = "Correo:";
            // 
            // ApellidoNuevoTextBox
            // 
            ApellidoNuevoTextBox.Location = new Point(24, 170);
            ApellidoNuevoTextBox.Name = "ApellidoNuevoTextBox";
            ApellidoNuevoTextBox.Size = new Size(270, 27);
            ApellidoNuevoTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 150);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Apellido";
            // 
            // GuardarNuevoButton
            // 
            GuardarNuevoButton.BackColor = Color.White;
            GuardarNuevoButton.Cursor = Cursors.Hand;
            GuardarNuevoButton.FlatStyle = FlatStyle.Flat;
            GuardarNuevoButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarNuevoButton.Location = new Point(417, 246);
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
            VolverNuevoButton.Location = new Point(241, 246);
            VolverNuevoButton.Name = "VolverNuevoButton";
            VolverNuevoButton.Size = new Size(94, 27);
            VolverNuevoButton.TabIndex = 4;
            VolverNuevoButton.Text = "Volver";
            VolverNuevoButton.UseVisualStyleBackColor = false;
            VolverNuevoButton.Click += VolverNuevoButton_Click;
            // 
            // RolNuevoCmbBox
            // 
            RolNuevoCmbBox.Cursor = Cursors.Hand;
            RolNuevoCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RolNuevoCmbBox.FormattingEnabled = true;
            RolNuevoCmbBox.Location = new Point(24, 47);
            RolNuevoCmbBox.Name = "RolNuevoCmbBox";
            RolNuevoCmbBox.Size = new Size(270, 28);
            RolNuevoCmbBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 27);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Medida:";
            // 
            // NombreNuevoTextBox
            // 
            NombreNuevoTextBox.Location = new Point(24, 108);
            NombreNuevoTextBox.Name = "NombreNuevoTextBox";
            NombreNuevoTextBox.Size = new Size(270, 27);
            NombreNuevoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(HabilitadoCmbBox);
            TabEditar.Controls.Add(label12);
            TabEditar.Controls.Add(NombreUsuarioEditarTextBox);
            TabEditar.Controls.Add(label4);
            TabEditar.Controls.Add(CorreoEditarTextBox);
            TabEditar.Controls.Add(label5);
            TabEditar.Controls.Add(ApellidoEditarTextBox);
            TabEditar.Controls.Add(label6);
            TabEditar.Controls.Add(GuardarEditarButton);
            TabEditar.Controls.Add(VolverEditarButton);
            TabEditar.Controls.Add(RolEditarCmbBox);
            TabEditar.Controls.Add(label10);
            TabEditar.Controls.Add(NombreEditarTextBox);
            TabEditar.Controls.Add(label11);
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
            HabilitadoCmbBox.Location = new Point(439, 170);
            HabilitadoCmbBox.Name = "HabilitadoCmbBox";
            HabilitadoCmbBox.Size = new Size(270, 28);
            HabilitadoCmbBox.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(442, 150);
            label12.Name = "label12";
            label12.Size = new Size(83, 20);
            label12.TabIndex = 24;
            label12.Text = "Habilitado:";
            // 
            // NombreUsuarioEditarTextBox
            // 
            NombreUsuarioEditarTextBox.Location = new Point(439, 108);
            NombreUsuarioEditarTextBox.Name = "NombreUsuarioEditarTextBox";
            NombreUsuarioEditarTextBox.Size = new Size(270, 27);
            NombreUsuarioEditarTextBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 88);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 22;
            label4.Text = "Nombre de usuario:";
            // 
            // CorreoEditarTextBox
            // 
            CorreoEditarTextBox.Location = new Point(439, 47);
            CorreoEditarTextBox.Name = "CorreoEditarTextBox";
            CorreoEditarTextBox.Size = new Size(270, 27);
            CorreoEditarTextBox.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 27);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 20;
            label5.Text = "Correo:";
            // 
            // ApellidoEditarTextBox
            // 
            ApellidoEditarTextBox.Location = new Point(24, 170);
            ApellidoEditarTextBox.Name = "ApellidoEditarTextBox";
            ApellidoEditarTextBox.Size = new Size(270, 27);
            ApellidoEditarTextBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 150);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 18;
            label6.Text = "Apellido";
            // 
            // GuardarEditarButton
            // 
            GuardarEditarButton.BackColor = Color.White;
            GuardarEditarButton.Cursor = Cursors.Hand;
            GuardarEditarButton.FlatStyle = FlatStyle.Flat;
            GuardarEditarButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarEditarButton.Location = new Point(417, 246);
            GuardarEditarButton.Name = "GuardarEditarButton";
            GuardarEditarButton.Size = new Size(94, 27);
            GuardarEditarButton.TabIndex = 17;
            GuardarEditarButton.Text = "Guardar";
            GuardarEditarButton.UseVisualStyleBackColor = false;
            // 
            // VolverEditarButton
            // 
            VolverEditarButton.BackColor = Color.White;
            VolverEditarButton.Cursor = Cursors.Hand;
            VolverEditarButton.FlatStyle = FlatStyle.Flat;
            VolverEditarButton.Location = new Point(241, 246);
            VolverEditarButton.Name = "VolverEditarButton";
            VolverEditarButton.Size = new Size(94, 27);
            VolverEditarButton.TabIndex = 16;
            VolverEditarButton.Text = "Volver";
            VolverEditarButton.UseVisualStyleBackColor = false;
            // 
            // RolEditarCmbBox
            // 
            RolEditarCmbBox.Cursor = Cursors.Hand;
            RolEditarCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RolEditarCmbBox.FormattingEnabled = true;
            RolEditarCmbBox.Location = new Point(24, 47);
            RolEditarCmbBox.Name = "RolEditarCmbBox";
            RolEditarCmbBox.Size = new Size(270, 28);
            RolEditarCmbBox.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 27);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 14;
            label10.Text = "Rol:";
            // 
            // NombreEditarTextBox
            // 
            NombreEditarTextBox.Location = new Point(24, 108);
            NombreEditarTextBox.Name = "NombreEditarTextBox";
            NombreEditarTextBox.Size = new Size(270, 27);
            NombreEditarTextBox.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 88);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 12;
            label11.Text = "Nombre:";
            // 
            // frm_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Usuario";
            Load += frm_Usuario_Load;
            tabControlMain.ResumeLayout(false);
            TabLista.ResumeLayout(false);
            TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsuariosDGV).EndInit();
            TabNuevo.ResumeLayout(false);
            TabNuevo.PerformLayout();
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControlMain;
        private TabPage TabLista;
        private DataGridView UsuariosDGV;
        private Button BuscarButton;
        private TextBox BuscarTextBox;
        private Button NuevoListaButton;
        private TabPage TabNuevo;
        private Button GuardarNuevoButton;
        private Button VolverNuevoButton;
        private ComboBox RolNuevoCmbBox;
        private Label label3;
        private TextBox NombreNuevoTextBox;
        private Label label2;
        private TabPage TabEditar;
        private TextBox ApellidoNuevoTextBox;
        private Label label7;
        private TextBox CorreoNuevoTextBox;
        private Label label8;
        private TextBox NombreUsuarioNuevoTextBox;
        private Label label9;
        private TextBox NombreUsuarioEditarTextBox;
        private Label label4;
        private TextBox CorreoEditarTextBox;
        private Label label5;
        private TextBox ApellidoEditarTextBox;
        private Label label6;
        private Button GuardarEditarButton;
        private Button VolverEditarButton;
        private ComboBox RolEditarCmbBox;
        private Label label10;
        private TextBox NombreEditarTextBox;
        private Label label11;
        private ComboBox HabilitadoCmbBox;
        private Label label12;
    }
}