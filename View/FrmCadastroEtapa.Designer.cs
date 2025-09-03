namespace SistemaAtendimento.View
{
    partial class FrmCadastroEtapa
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
            grbDadosEtapa = new GroupBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            grbDadosEtapa.SuspendLayout();
            SuspendLayout();
            // 
            // grbDadosEtapa
            // 
            grbDadosEtapa.Controls.Add(txtNome);
            grbDadosEtapa.Controls.Add(label3);
            grbDadosEtapa.Controls.Add(lblNome);
            grbDadosEtapa.Controls.Add(txtCodigo);
            grbDadosEtapa.Controls.Add(lblCodigo);
            grbDadosEtapa.Location = new Point(16, 8);
            grbDadosEtapa.Name = "grbDadosEtapa";
            grbDadosEtapa.Size = new Size(776, 148);
            grbDadosEtapa.TabIndex = 0;
            grbDadosEtapa.TabStop = false;
            grbDadosEtapa.Text = "Dados da Etapa";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(112, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(144, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 88);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(144, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(616, 23);
            txtNome.TabIndex = 4;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbDadosEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            grbDadosEtapa.ResumeLayout(false);
            grbDadosEtapa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDadosEtapa;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label label3;
        private Label lblNome;
        private TextBox txtNome;
    }
}