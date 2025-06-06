namespace PoS_Presentation.Forms
{
    partial class Layout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Layout));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            SesionLink = new LinkLabel();
            RolLabel = new Label();
            UsuarioLabel = new Label();
            panel2 = new Panel();
            msMenu = new MenuStrip();
            VentasMN = new ToolStripMenuItem();
            NuevoSM = new ToolStripMenuItem();
            HistorialSM = new ToolStripMenuItem();
            InventarioMN = new ToolStripMenuItem();
            ProductosSM = new ToolStripMenuItem();
            CategoriasSM = new ToolStripMenuItem();
            ReportesMN = new ToolStripMenuItem();
            VentasSM = new ToolStripMenuItem();
            UsuariosMN = new ToolStripMenuItem();
            ConfiguracionMN = new ToolStripMenuItem();
            PanelMain = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            msMenu.SuspendLayout();
            PanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 49, 69);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SesionLink);
            panel1.Controls.Add(RolLabel);
            panel1.Controls.Add(UsuarioLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(917, 91);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(155, 11);
            label1.Name = "label1";
            label1.Size = new Size(461, 54);
            label1.TabIndex = 3;
            label1.Text = "Demo Sistema de Ventas";
            // 
            // SesionLink
            // 
            SesionLink.ActiveLinkColor = Color.White;
            SesionLink.AutoSize = true;
            SesionLink.LinkColor = Color.White;
            SesionLink.Location = new Point(810, 68);
            SesionLink.Name = "SesionLink";
            SesionLink.Size = new Size(96, 20);
            SesionLink.TabIndex = 2;
            SesionLink.TabStop = true;
            SesionLink.Text = "Cerrar Sesión";
            SesionLink.VisitedLinkColor = Color.White;
            SesionLink.LinkClicked += SesionLink_LinkClicked;
            // 
            // RolLabel
            // 
            RolLabel.ForeColor = Color.White;
            RolLabel.Location = new Point(691, 38);
            RolLabel.Name = "RolLabel";
            RolLabel.RightToLeft = RightToLeft.Yes;
            RolLabel.Size = new Size(215, 20);
            RolLabel.TabIndex = 1;
            RolLabel.Text = "Rol";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.ForeColor = Color.White;
            UsuarioLabel.Location = new Point(690, 9);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.RightToLeft = RightToLeft.Yes;
            UsuarioLabel.Size = new Size(215, 20);
            UsuarioLabel.TabIndex = 0;
            UsuarioLabel.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(58, 49, 69);
            panel2.Controls.Add(msMenu);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 399);
            panel2.TabIndex = 1;
            // 
            // msMenu
            // 
            msMenu.BackColor = Color.FromArgb(58, 49, 69);
            msMenu.ImageScalingSize = new Size(20, 20);
            msMenu.Items.AddRange(new ToolStripItem[] { VentasMN, InventarioMN, ReportesMN, UsuariosMN, ConfiguracionMN });
            msMenu.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.Size = new Size(155, 256);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // VentasMN
            // 
            VentasMN.AutoSize = false;
            VentasMN.BackColor = Color.FromArgb(58, 49, 69);
            VentasMN.DropDownItems.AddRange(new ToolStripItem[] { NuevoSM, HistorialSM });
            VentasMN.ForeColor = Color.White;
            VentasMN.Name = "VentasMN";
            VentasMN.Size = new Size(148, 50);
            VentasMN.Tag = "ventas";
            VentasMN.Text = "Ventas >";
            // 
            // NuevoSM
            // 
            NuevoSM.AutoSize = false;
            NuevoSM.BackColor = Color.FromArgb(58, 49, 69);
            NuevoSM.ForeColor = Color.White;
            NuevoSM.Name = "NuevoSM";
            NuevoSM.Padding = new Padding(0, 2, 0, 2);
            NuevoSM.Size = new Size(224, 30);
            NuevoSM.Tag = "nuevo";
            NuevoSM.Text = "Nuevo";
            NuevoSM.Click += NuevoSM_Click;
            // 
            // HistorialSM
            // 
            HistorialSM.AutoSize = false;
            HistorialSM.BackColor = Color.FromArgb(58, 49, 69);
            HistorialSM.ForeColor = Color.White;
            HistorialSM.Name = "HistorialSM";
            HistorialSM.Padding = new Padding(0, 2, 0, 2);
            HistorialSM.Size = new Size(224, 30);
            HistorialSM.Tag = "historial";
            HistorialSM.Text = "Historial";
            HistorialSM.Click += HistorialSM_Click;
            // 
            // InventarioMN
            // 
            InventarioMN.AutoSize = false;
            InventarioMN.BackColor = Color.FromArgb(58, 49, 69);
            InventarioMN.DropDownItems.AddRange(new ToolStripItem[] { ProductosSM, CategoriasSM });
            InventarioMN.ForeColor = Color.White;
            InventarioMN.Name = "InventarioMN";
            InventarioMN.Size = new Size(148, 50);
            InventarioMN.Tag = "inventario";
            InventarioMN.Text = "Inventario >";
            // 
            // ProductosSM
            // 
            ProductosSM.AutoSize = false;
            ProductosSM.BackColor = Color.FromArgb(58, 49, 69);
            ProductosSM.ForeColor = Color.White;
            ProductosSM.Name = "ProductosSM";
            ProductosSM.Padding = new Padding(0, 2, 0, 2);
            ProductosSM.Size = new Size(224, 28);
            ProductosSM.Tag = "productos";
            ProductosSM.Text = "Productos";
            ProductosSM.Click += ProductosSM_Click;
            // 
            // CategoriasSM
            // 
            CategoriasSM.AutoSize = false;
            CategoriasSM.BackColor = Color.FromArgb(58, 49, 69);
            CategoriasSM.ForeColor = Color.White;
            CategoriasSM.Name = "CategoriasSM";
            CategoriasSM.Padding = new Padding(0, 2, 0, 2);
            CategoriasSM.Size = new Size(224, 28);
            CategoriasSM.Tag = "categorías";
            CategoriasSM.Text = "Categorías";
            CategoriasSM.Click += CategoriasSM_Click;
            // 
            // ReportesMN
            // 
            ReportesMN.AutoSize = false;
            ReportesMN.BackColor = Color.FromArgb(58, 49, 69);
            ReportesMN.DropDownItems.AddRange(new ToolStripItem[] { VentasSM });
            ReportesMN.ForeColor = Color.White;
            ReportesMN.Name = "ReportesMN";
            ReportesMN.Size = new Size(148, 50);
            ReportesMN.Tag = "reportes";
            ReportesMN.Text = "Reportes >";
            // 
            // VentasSM
            // 
            VentasSM.AutoSize = false;
            VentasSM.BackColor = Color.FromArgb(58, 49, 69);
            VentasSM.ForeColor = Color.White;
            VentasSM.Name = "VentasSM";
            VentasSM.Padding = new Padding(0, 2, 0, 2);
            VentasSM.Size = new Size(224, 30);
            VentasSM.Tag = "ventas";
            VentasSM.Text = "Ventas";
            VentasSM.Click += VentasSM_Click;
            // 
            // UsuariosMN
            // 
            UsuariosMN.AutoSize = false;
            UsuariosMN.BackColor = Color.FromArgb(58, 49, 69);
            UsuariosMN.ForeColor = Color.White;
            UsuariosMN.Name = "UsuariosMN";
            UsuariosMN.Size = new Size(148, 50);
            UsuariosMN.Tag = "usuarios";
            UsuariosMN.Text = "Usuarios";
            UsuariosMN.Click += UsuariosMN_Click;
            // 
            // ConfiguracionMN
            // 
            ConfiguracionMN.AutoSize = false;
            ConfiguracionMN.BackColor = Color.FromArgb(58, 49, 69);
            ConfiguracionMN.ForeColor = Color.White;
            ConfiguracionMN.Name = "ConfiguracionMN";
            ConfiguracionMN.Size = new Size(148, 50);
            ConfiguracionMN.Tag = "configuración";
            ConfiguracionMN.Text = "Configuración";
            ConfiguracionMN.Click += ConfiguracionMN_Click;
            // 
            // PanelMain
            // 
            PanelMain.Controls.Add(label2);
            PanelMain.Dock = DockStyle.Fill;
            PanelMain.Location = new Point(155, 91);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(762, 399);
            PanelMain.TabIndex = 2;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(762, 399);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Layout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 490);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MainMenuStrip = msMenu;
            MaximizeBox = false;
            MaximumSize = new Size(935, 537);
            MinimumSize = new Size(935, 537);
            Name = "Layout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Layout";
            Load += Layout_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            PanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private MenuStrip msMenu;
        private Panel PanelMain;
        private ToolStripMenuItem VentasMN;
        private ToolStripMenuItem InventarioMN;
        private ToolStripMenuItem ReportesMN;
        private ToolStripMenuItem UsuariosMN;
        private ToolStripMenuItem ConfiguracionMN;
        private ToolStripMenuItem NuevoSM;
        private ToolStripMenuItem HistorialSM;
        private ToolStripMenuItem ProductosSM;
        private ToolStripMenuItem CategoriasSM;
        private ToolStripMenuItem VentasSM;
        private Label RolLabel;
        private Label UsuarioLabel;
        private LinkLabel SesionLink;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}