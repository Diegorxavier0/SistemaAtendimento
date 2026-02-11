namespace SistemaAtendimento
{
    partial class FrmLogin
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
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11F);
            lblSenha.Location = new Point(72, 152);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(52, 20);
            lblSenha.TabIndex = 0;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 1;
            txtEmail.Text = "edson@email.com";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F);
            lblEmail.Location = new Point(72, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(128, 152);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(208, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "senha123";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(184, 200);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(88, 32);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 16);
            label1.Name = "label1";
            label1.Size = new Size(163, 37);
            label1.TabIndex = 5;
            label1.Text = "Bem Vindo";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 270);
            Controls.Add(label1);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label label1;
    }
}