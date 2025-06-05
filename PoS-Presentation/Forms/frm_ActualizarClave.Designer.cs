namespace PoS_Presentation.Forms
{
    partial class frm_ActualizarClave
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
            ClaveTextBox = new TextBox();
            RepetirClaveTextBox = new TextBox();
            ValidacionLabel = new Label();
            GuardarButton = new Button();
            VolverButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Repetir contraseña:";
            // 
            // ClaveTextBox
            // 
            ClaveTextBox.Location = new Point(12, 32);
            ClaveTextBox.Name = "ClaveTextBox";
            ClaveTextBox.PasswordChar = '*';
            ClaveTextBox.Size = new Size(242, 27);
            ClaveTextBox.TabIndex = 2;
            // 
            // RepetirClaveTextBox
            // 
            RepetirClaveTextBox.Location = new Point(12, 95);
            RepetirClaveTextBox.Name = "RepetirClaveTextBox";
            RepetirClaveTextBox.PasswordChar = '*';
            RepetirClaveTextBox.Size = new Size(242, 27);
            RepetirClaveTextBox.TabIndex = 3;
            // 
            // ValidacionLabel
            // 
            ValidacionLabel.AutoSize = true;
            ValidacionLabel.ForeColor = Color.Red;
            ValidacionLabel.Location = new Point(12, 125);
            ValidacionLabel.Name = "ValidacionLabel";
            ValidacionLabel.Size = new Size(201, 20);
            ValidacionLabel.TabIndex = 6;
            ValidacionLabel.Text = "Las contraseñas no coinciden";
            // 
            // GuardarButton
            // 
            GuardarButton.BackColor = Color.White;
            GuardarButton.ForeColor = Color.Blue;
            GuardarButton.Location = new Point(160, 157);
            GuardarButton.Name = "GuardarButton";
            GuardarButton.Size = new Size(94, 29);
            GuardarButton.TabIndex = 8;
            GuardarButton.Text = "Guardar";
            GuardarButton.UseVisualStyleBackColor = false;
            GuardarButton.Click += GuardarButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.BackColor = Color.White;
            VolverButton.Location = new Point(12, 157);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(94, 29);
            VolverButton.TabIndex = 9;
            VolverButton.Text = "Volver";
            VolverButton.UseVisualStyleBackColor = false;
            VolverButton.Click += VolverButton_Click;
            // 
            // frm_ActualizarClave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 193);
            Controls.Add(VolverButton);
            Controls.Add(GuardarButton);
            Controls.Add(ValidacionLabel);
            Controls.Add(RepetirClaveTextBox);
            Controls.Add(ClaveTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(284, 240);
            MinimizeBox = false;
            MinimumSize = new Size(284, 240);
            Name = "frm_ActualizarClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar";
            Load += frm_ActualizarClave_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox ClaveTextBox;
        private TextBox RepetirClaveTextBox;
        private Label ValidacionLabel;
        private Button GuardarButton;
        private Button VolverButton;
    }
}