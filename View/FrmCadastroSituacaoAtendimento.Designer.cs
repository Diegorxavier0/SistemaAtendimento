namespace SistemaAtendimento.View
{
    partial class FrmCadastroSituacaoAtendimento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroSituacaoAtendimento));
            grbDadosSituacaoAtendimento = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtNome = new TextBox();
            txtCor = new TextBox();
            txtCodigo = new TextBox();
            lblCor = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            grbListaSituacaoAtendimento = new GroupBox();
            dgvListaSituacaoAtendimento = new DataGridView();
            grbDadosSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaSituacaoAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacaoAtendimento).BeginInit();
            SuspendLayout();
            // 
            // grbDadosSituacaoAtendimento
            // 
            grbDadosSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(lblSituacao);
            grbDadosSituacaoAtendimento.Controls.Add(txtNome);
            grbDadosSituacaoAtendimento.Controls.Add(txtCor);
            grbDadosSituacaoAtendimento.Controls.Add(txtCodigo);
            grbDadosSituacaoAtendimento.Controls.Add(lblCor);
            grbDadosSituacaoAtendimento.Controls.Add(lblNome);
            grbDadosSituacaoAtendimento.Controls.Add(lblCodigo);
            grbDadosSituacaoAtendimento.Location = new Point(9, 9);
            grbDadosSituacaoAtendimento.Name = "grbDadosSituacaoAtendimento";
            grbDadosSituacaoAtendimento.Size = new Size(783, 151);
            grbDadosSituacaoAtendimento.TabIndex = 0;
            grbDadosSituacaoAtendimento.TabStop = false;
            grbDadosSituacaoAtendimento.Text = "Dados da Situação do Atendimento ";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Enabled = false;
            pnlSituacao.Location = new Point(272, 88);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(136, 32);
            pnlSituacao.TabIndex = 4;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(74, 7);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Checked = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(272, 72);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 6;
            lblSituacao.Text = "Situação";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 40);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(584, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCor
            // 
            txtCor.Location = new Point(8, 96);
            txtCor.Name = "txtCor";
            txtCor.ReadOnly = true;
            txtCor.Size = new Size(257, 23);
            txtCor.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(152, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(8, 80);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 2;
            lblCor.Text = "Cor";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(184, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 10F);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 176);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 40);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(104, 176);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 40);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(192, 176);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(280, 176);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 40);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(472, 184);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.ReadOnly = true;
            txtPesquisar.Size = new Size(208, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(696, 176);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(80, 40);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(472, 168);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 8;
            lblPesquisar.Text = "Pesquisar";
            // 
            // grbListaSituacaoAtendimento
            // 
            grbListaSituacaoAtendimento.Controls.Add(dgvListaSituacaoAtendimento);
            grbListaSituacaoAtendimento.Location = new Point(8, 248);
            grbListaSituacaoAtendimento.Name = "grbListaSituacaoAtendimento";
            grbListaSituacaoAtendimento.Size = new Size(784, 192);
            grbListaSituacaoAtendimento.TabIndex = 10;
            grbListaSituacaoAtendimento.TabStop = false;
            grbListaSituacaoAtendimento.Text = "Lista de Situação de Atendimento";
            // 
            // dgvListaSituacaoAtendimento
            // 
            dgvListaSituacaoAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaSituacaoAtendimento.Location = new Point(-8, 16);
            dgvListaSituacaoAtendimento.Name = "dgvListaSituacaoAtendimento";
            dgvListaSituacaoAtendimento.Size = new Size(840, 184);
            dgvListaSituacaoAtendimento.TabIndex = 0;
            dgvListaSituacaoAtendimento.CellDoubleClick += dgvListaSituacaoAtendimento_CellDoubleClick;
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaSituacaoAtendimento);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosSituacaoAtendimento);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastros de Situação de Atendimentos";
            Load += FrmCadastroSituacaoAtendimento_Load;
            grbDadosSituacaoAtendimento.ResumeLayout(false);
            grbDadosSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaSituacaoAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaSituacaoAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosSituacaoAtendimento;
        private TextBox txtNome;
        private TextBox txtCor;
        private TextBox txtCodigo;
        private Label lblCor;
        private Label lblNome;
        private Label lblCodigo;
        private Panel pnlSituacao;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private RadioButton rdbInativo;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private ImageList imlIcones;
        private GroupBox grbListaSituacaoAtendimento;
        private DataGridView dgvListaSituacaoAtendimento;
    }
}