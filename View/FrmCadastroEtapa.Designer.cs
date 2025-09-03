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
            txtNome = new TextBox();
            lblOrdem = new Label();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtOrdem = new TextBox();
            pnlSituacao = new Panel();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            lblSituacao = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            grbDadosEtapa.SuspendLayout();
            pnlSituacao.SuspendLayout();
            SuspendLayout();
            // 
            // grbDadosEtapa
            // 
            grbDadosEtapa.Controls.Add(lblSituacao);
            grbDadosEtapa.Controls.Add(pnlSituacao);
            grbDadosEtapa.Controls.Add(txtOrdem);
            grbDadosEtapa.Controls.Add(txtNome);
            grbDadosEtapa.Controls.Add(lblOrdem);
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
            // txtNome
            // 
            txtNome.Location = new Point(144, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(616, 23);
            txtNome.TabIndex = 4;
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(16, 72);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 3;
            lblOrdem.Text = "Ordem";
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
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(112, 23);
            txtCodigo.TabIndex = 1;
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
            // txtOrdem
            // 
            txtOrdem.Location = new Point(16, 88);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(304, 23);
            txtOrdem.TabIndex = 5;
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(336, 88);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(128, 32);
            pnlSituacao.TabIndex = 6;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(64, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(336, 72);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 7;
            lblSituacao.Text = "Situação";
            // 
            // button1
            // 
            button1.Location = new Point(16, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(368, 192);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(280, 192);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(192, 192);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(104, 192);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grbDadosEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            grbDadosEtapa.ResumeLayout(false);
            grbDadosEtapa.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDadosEtapa;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblOrdem;
        private Label lblNome;
        private TextBox txtNome;
        private Panel pnlSituacao;
        private TextBox txtOrdem;
        private Label lblSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}