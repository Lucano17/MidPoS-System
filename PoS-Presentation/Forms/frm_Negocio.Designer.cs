namespace PoS_Presentation.Forms
{
    partial class frm_Negocio
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
            GuardarButton = new Button();
            VolverButton = new Button();
            label9 = new Label();
            CelularTextBox = new TextBox();
            LogoPictureBox = new PictureBox();
            BuscarButton = new Button();
            label8 = new Label();
            direccionTextBox = new TextBox();
            label7 = new Label();
            rutaImagenTextBox = new TextBox();
            label6 = new Label();
            DivisaTextBox = new TextBox();
            label5 = new Label();
            emailTextBox = new TextBox();
            rucLabel = new Label();
            rucTextBox = new TextBox();
            RazonSocialTextBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(37, 65);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 23;
            label4.Text = "Razón Social:";
            // 
            // GuardarButton
            // 
            GuardarButton.BackColor = Color.White;
            GuardarButton.Cursor = Cursors.Hand;
            GuardarButton.FlatStyle = FlatStyle.Flat;
            GuardarButton.ForeColor = Color.FromArgb(30, 90, 195);
            GuardarButton.Location = new Point(582, 354);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 27);
            GuardarButton.TabIndex = 20;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = false;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.BackColor = Color.White;
            VolverButton.Cursor = Cursors.Hand;
            VolverButton.FlatStyle = FlatStyle.Flat;
            VolverButton.Location = new Point(452, 354);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(94, 27);
            VolverButton.TabIndex = 19;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Location = new Point(37, 331);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 17;
            label9.Text = "Número de celular:";
            // 
            // CelularTextBox
            // 
            CelularTextBox.BackColor = Color.White;
            CelularTextBox.Location = new Point(37, 354);
            CelularTextBox.Name = "CelularTextBox";
            CelularTextBox.Size = new Size(270, 27);
            CelularTextBox.TabIndex = 18;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Location = new Point(406, 194);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(140, 140);
            LogoPictureBox.TabIndex = 16;
            LogoPictureBox.TabStop = false;
            LogoPictureBox.Click += LogoPictureBox_Click;
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.White;
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Location = new Point(582, 150);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 27);
            BuscarButton.TabIndex = 15;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Location = new Point(37, 264);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 13;
            label8.Text = "Dirección:";
            // 
            // direccionTextBox
            // 
            direccionTextBox.BackColor = Color.White;
            direccionTextBox.Location = new Point(37, 287);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(270, 27);
            direccionTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(406, 127);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 11;
            label7.Text = "Logo del negocio:";
            // 
            // rutaImagenTextBox
            // 
            rutaImagenTextBox.BackColor = Color.White;
            rutaImagenTextBox.Location = new Point(406, 150);
            rutaImagenTextBox.Name = "rutaImagenTextBox";
            rutaImagenTextBox.ReadOnly = true;
            rutaImagenTextBox.Size = new Size(170, 27);
            rutaImagenTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(406, 65);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 9;
            label6.Text = "Divisa:";
            // 
            // DivisaTextBox
            // 
            DivisaTextBox.BackColor = Color.White;
            DivisaTextBox.Location = new Point(406, 88);
            DivisaTextBox.Name = "DivisaTextBox";
            DivisaTextBox.Size = new Size(270, 27);
            DivisaTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(37, 194);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 7;
            label5.Text = "Correo electrónico:";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.Location = new Point(37, 217);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(270, 27);
            emailTextBox.TabIndex = 8;
            // 
            // rucLabel
            // 
            rucLabel.AutoSize = true;
            rucLabel.BackColor = Color.White;
            rucLabel.Location = new Point(37, 127);
            rucLabel.Name = "rucLabel";
            rucLabel.Size = new Size(40, 20);
            rucLabel.TabIndex = 5;
            rucLabel.Text = "RUC:";
            // 
            // rucTextBox
            // 
            rucTextBox.BackColor = Color.White;
            rucTextBox.Location = new Point(37, 150);
            rucTextBox.Name = "rucTextBox";
            rucTextBox.Size = new Size(270, 27);
            rucTextBox.TabIndex = 6;
            // 
            // RazonSocialTextBox
            // 
            RazonSocialTextBox.BackColor = Color.White;
            RazonSocialTextBox.Location = new Point(37, 88);
            RazonSocialTextBox.Name = "RazonSocialTextBox";
            RazonSocialTextBox.Size = new Size(270, 27);
            RazonSocialTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(185, 20);
            label2.TabIndex = 2;
            label2.Text = "Configuración del negocio";
            // 
            // frm_Negocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(label4);
            Controls.Add(GuardarButton);
            Controls.Add(VolverButton);
            Controls.Add(CelularTextBox);
            Controls.Add(label9);
            Controls.Add(LogoPictureBox);
            Controls.Add(BuscarButton);
            Controls.Add(direccionTextBox);
            Controls.Add(label8);
            Controls.Add(rutaImagenTextBox);
            Controls.Add(label7);
            Controls.Add(DivisaTextBox);
            Controls.Add(label6);
            Controls.Add(emailTextBox);
            Controls.Add(label5);
            Controls.Add(rucTextBox);
            Controls.Add(rucLabel);
            Controls.Add(RazonSocialTextBox);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Negocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Negocio";
            Load += frm_Negocio_Load;
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button GuardarButton;
        private Button VolverButton;
        private Label label9;
        private TextBox CelularTextBox;
        private PictureBox LogoPictureBox;
        private Button BuscarButton;
        private Label label8;
        private TextBox direccionTextBox;
        private Label label7;
        private TextBox rutaImagenTextBox;
        private Label label6;
        private TextBox DivisaTextBox;
        private Label label5;
        private TextBox emailTextBox;
        private Label rucLabel;
        private TextBox rucTextBox;
        private TextBox RazonSocialTextBox;
        private Label label2;
    }
}