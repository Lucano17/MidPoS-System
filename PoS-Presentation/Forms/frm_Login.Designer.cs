namespace PoS_Presentation.Forms
{
    partial class frm_Login
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UsuarioTextBox = new TextBox();
            ClaveTextBox = new TextBox();
            OlvideClaveLinkLabel = new LinkLabel();
            IngresarButton = new Button();
            SalirButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(58, 49, 69);
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 307);
            label1.TabIndex = 0;
            label1.Text = "Demo MidPoS-System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, 9);
            label2.Name = "label2";
            label2.Size = new Size(215, 46);
            label2.TabIndex = 1;
            label2.Text = "Iniciar Sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 146);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            // 
            // UsuarioTextBox
            // 
            UsuarioTextBox.Location = new Point(298, 98);
            UsuarioTextBox.Name = "UsuarioTextBox";
            UsuarioTextBox.Size = new Size(215, 27);
            UsuarioTextBox.TabIndex = 4;
            // 
            // ClaveTextBox
            // 
            ClaveTextBox.Location = new Point(300, 169);
            ClaveTextBox.Name = "ClaveTextBox";
            ClaveTextBox.PasswordChar = '*';
            ClaveTextBox.Size = new Size(213, 27);
            ClaveTextBox.TabIndex = 5;
            // 
            // OlvideClaveLinkLabel
            // 
            OlvideClaveLinkLabel.AutoSize = true;
            OlvideClaveLinkLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OlvideClaveLinkLabel.Location = new Point(382, 209);
            OlvideClaveLinkLabel.Name = "OlvideClaveLinkLabel";
            OlvideClaveLinkLabel.Size = new Size(131, 17);
            OlvideClaveLinkLabel.TabIndex = 6;
            OlvideClaveLinkLabel.TabStop = true;
            OlvideClaveLinkLabel.Text = "Olvidé mi contraseña";
            OlvideClaveLinkLabel.LinkClicked += OlvideClaveLinkLabel_LinkClicked;
            // 
            // IngresarButton
            // 
            IngresarButton.BackColor = Color.White;
            IngresarButton.Location = new Point(419, 257);
            IngresarButton.Name = "IngresarButton";
            IngresarButton.Size = new Size(94, 29);
            IngresarButton.TabIndex = 7;
            IngresarButton.Text = "Ingresar";
            IngresarButton.UseVisualStyleBackColor = false;
            IngresarButton.Click += IngresarButton_Click;
            // 
            // SalirButton
            // 
            SalirButton.BackColor = Color.White;
            SalirButton.ForeColor = Color.Red;
            SalirButton.Location = new Point(300, 257);
            SalirButton.Name = "SalirButton";
            SalirButton.Size = new Size(94, 29);
            SalirButton.TabIndex = 8;
            SalirButton.Text = "Salir";
            SalirButton.UseVisualStyleBackColor = false;
            SalirButton.Click += SalirButton_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 307);
            Controls.Add(SalirButton);
            Controls.Add(IngresarButton);
            Controls.Add(OlvideClaveLinkLabel);
            Controls.Add(ClaveTextBox);
            Controls.Add(UsuarioTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Login";
            Load += frm_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UsuarioTextBox;
        private TextBox ClaveTextBox;
        private LinkLabel OlvideClaveLinkLabel;
        private Button IngresarButton;
        private Button SalirButton;
    }
}