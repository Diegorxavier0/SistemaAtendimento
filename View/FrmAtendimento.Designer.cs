namespace SistemaAtendimento.View
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            grbDadosCliente = new GroupBox();
            btnCancelar = new Button();
            imlIcones = new ImageList(components);
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExluir = new Button();
            btnFinalizarAtendimento = new Button();
            cbxNomeCliente = new ComboBox();
            lblDataAbertura = new Label();
            dtpAberturaAtendimento = new DateTimePicker();
            btnNovo = new Button();
            cbxSituacaoAtendimento = new ComboBox();
            txtObservacaoAtendimento = new TextBox();
            lblObservacoes = new Label();
            lblSituacaoAtendimento = new Label();
            lblNome = new Label();
            txtCodigoCliente = new TextBox();
            lblCodigo = new Label();
            lblAtendimento = new Label();
            txtCodigoAtendimento = new TextBox();
            grbEtapasAtendimento = new GroupBox();
            dgvEtapasAtendimento = new DataGridView();
            btnAdicionarEtapa = new Button();
            cbxEtapaAtendimento = new ComboBox();
            btnExcluirEtapa = new Button();
            txtEtapaObservacao = new TextBox();
            lblObservacoesAtendimento = new Label();
            lblEtapaAtendimento = new Label();
            btnPesquisarAtendimento = new Button();
            grbDadosCliente.SuspendLayout();
            grbEtapasAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(btnCancelar);
            grbDadosCliente.Controls.Add(btnEditar);
            grbDadosCliente.Controls.Add(btnSalvar);
            grbDadosCliente.Controls.Add(btnExluir);
            grbDadosCliente.Controls.Add(btnFinalizarAtendimento);
            grbDadosCliente.Controls.Add(cbxNomeCliente);
            grbDadosCliente.Controls.Add(lblDataAbertura);
            grbDadosCliente.Controls.Add(dtpAberturaAtendimento);
            grbDadosCliente.Controls.Add(btnNovo);
            grbDadosCliente.Controls.Add(cbxSituacaoAtendimento);
            grbDadosCliente.Controls.Add(txtObservacaoAtendimento);
            grbDadosCliente.Controls.Add(lblObservacoes);
            grbDadosCliente.Controls.Add(lblSituacaoAtendimento);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigoCliente);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(8, 56);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(776, 248);
            grbDadosCliente.TabIndex = 1;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11F);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(400, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 32);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
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
            imlIcones.Images.SetKeyName(4, "icone-salvar.png");
            imlIcones.Images.SetKeyName(5, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(6, "Finalizar.png");
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11F);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(112, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 32);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 11F);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(208, 184);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 32);
            btnSalvar.TabIndex = 22;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExluir
            // 
            btnExluir.Font = new Font("Segoe UI", 11F);
            btnExluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExluir.ImageIndex = 2;
            btnExluir.ImageList = imlIcones;
            btnExluir.Location = new Point(304, 184);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(88, 32);
            btnExluir.TabIndex = 21;
            btnExluir.Text = "Excluir";
            btnExluir.TextAlign = ContentAlignment.MiddleRight;
            btnExluir.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarAtendimento
            // 
            btnFinalizarAtendimento.Font = new Font("Segoe UI", 11F);
            btnFinalizarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarAtendimento.ImageIndex = 6;
            btnFinalizarAtendimento.ImageList = imlIcones;
            btnFinalizarAtendimento.Location = new Point(568, 184);
            btnFinalizarAtendimento.Name = "btnFinalizarAtendimento";
            btnFinalizarAtendimento.Size = new Size(192, 32);
            btnFinalizarAtendimento.TabIndex = 20;
            btnFinalizarAtendimento.Text = "Finalizar Atendimento";
            btnFinalizarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnFinalizarAtendimento.UseVisualStyleBackColor = true;
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(144, 40);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(344, 23);
            cbxNomeCliente.TabIndex = 17;
            cbxNomeCliente.SelectedIndexChanged += cbxNomeCliente_SelectedIndexChanged;
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(496, 24);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(80, 15);
            lblDataAbertura.TabIndex = 16;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // dtpAberturaAtendimento
            // 
            dtpAberturaAtendimento.Location = new Point(496, 40);
            dtpAberturaAtendimento.Name = "dtpAberturaAtendimento";
            dtpAberturaAtendimento.Size = new Size(264, 23);
            dtpAberturaAtendimento.TabIndex = 15;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 11F);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 184);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 32);
            btnNovo.TabIndex = 13;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(16, 96);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(288, 23);
            cbxSituacaoAtendimento.TabIndex = 11;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Location = new Point(320, 88);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.ReadOnly = true;
            txtObservacaoAtendimento.Size = new Size(440, 80);
            txtObservacaoAtendimento.TabIndex = 8;
            // 
            // lblObservacoes
            // 
            lblObservacoes.AutoSize = true;
            lblObservacoes.Location = new Point(320, 72);
            lblObservacoes.Name = "lblObservacoes";
            lblObservacoes.Size = new Size(74, 15);
            lblObservacoes.TabIndex = 7;
            lblObservacoes.Text = "Observações";
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(16, 72);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 3;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
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
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(16, 40);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(112, 23);
            txtCodigoCliente.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(16, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(69, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Cód.Cliente";
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtendimento.Location = new Point(464, 8);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(149, 30);
            lblAtendimento.TabIndex = 2;
            lblAtendimento.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Location = new Point(616, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.ReadOnly = true;
            txtCodigoAtendimento.Size = new Size(168, 23);
            txtCodigoAtendimento.TabIndex = 9;
            // 
            // grbEtapasAtendimento
            // 
            grbEtapasAtendimento.Controls.Add(dgvEtapasAtendimento);
            grbEtapasAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapasAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapasAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapasAtendimento.Controls.Add(txtEtapaObservacao);
            grbEtapasAtendimento.Controls.Add(lblObservacoesAtendimento);
            grbEtapasAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapasAtendimento.Location = new Point(8, 320);
            grbEtapasAtendimento.Name = "grbEtapasAtendimento";
            grbEtapasAtendimento.Size = new Size(776, 264);
            grbEtapasAtendimento.TabIndex = 10;
            grbEtapasAtendimento.TabStop = false;
            grbEtapasAtendimento.Text = "Etapas do Atendimento";
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(336, 40);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(432, 216);
            dgvEtapasAtendimento.TabIndex = 13;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI", 11F);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 3;
            btnAdicionarEtapa.ImageList = imlIcones;
            btnAdicionarEtapa.Location = new Point(16, 216);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(152, 32);
            btnAdicionarEtapa.TabIndex = 12;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(16, 48);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(304, 23);
            cbxEtapaAtendimento.TabIndex = 11;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Font = new Font("Segoe UI", 11F);
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 0;
            btnExcluirEtapa.ImageList = imlIcones;
            btnExcluirEtapa.Location = new Point(184, 216);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(136, 32);
            btnExcluirEtapa.TabIndex = 10;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.TextAlign = ContentAlignment.MiddleRight;
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // txtEtapaObservacao
            // 
            txtEtapaObservacao.Location = new Point(16, 112);
            txtEtapaObservacao.Multiline = true;
            txtEtapaObservacao.Name = "txtEtapaObservacao";
            txtEtapaObservacao.ReadOnly = true;
            txtEtapaObservacao.Size = new Size(304, 96);
            txtEtapaObservacao.TabIndex = 8;
            // 
            // lblObservacoesAtendimento
            // 
            lblObservacoesAtendimento.AutoSize = true;
            lblObservacoesAtendimento.Location = new Point(16, 96);
            lblObservacoesAtendimento.Name = "lblObservacoesAtendimento";
            lblObservacoesAtendimento.Size = new Size(74, 15);
            lblObservacoesAtendimento.TabIndex = 3;
            lblObservacoesAtendimento.Text = "Observacões";
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(16, 32);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 0;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.Font = new Font("Segoe UI", 11F);
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageIndex = 5;
            btnPesquisarAtendimento.ImageList = imlIcones;
            btnPesquisarAtendimento.Location = new Point(16, 16);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(200, 32);
            btnPesquisarAtendimento.TabIndex = 18;
            btnPesquisarAtendimento.Text = "Pesquisar Atendimento";
            btnPesquisarAtendimento.TextAlign = ContentAlignment.MiddleRight;
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            btnPesquisarAtendimento.Click += btnPesquisarAtendimento_Click;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 607);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(grbEtapasAtendimento);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(lblAtendimento);
            Controls.Add(grbDadosCliente);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            Load += FrmAtendimento_Load;
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            grbEtapasAtendimento.ResumeLayout(false);
            grbEtapasAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private Label lblObservacoes;
        private Label lblSituacaoAtendimento;
        private Label lblNome;
        private TextBox txtCodigoCliente;
        private Label lblCodigo;
        private TextBox txtObservacaoAtendimento;
        private Label lblAtendimento;
        private TextBox txtCodigoAtendimento;
        private ComboBox cbxSituacaoAtendimento;
        private GroupBox grbEtapasAtendimento;
        private ComboBox cbxEtapaAtendimento;
        private Button btnExcluirEtapa;
        private TextBox txtEtapaObservacao;
        private Label lblObservacoesAtendimento;
        private Label lblEtapaAtendimento;
        private Button btnNovo;
        private Button btnAdicionarEtapa;
        private DateTimePicker dtpAberturaAtendimento;
        private DataGridView dgvEtapasAtendimento;
        private ImageList imlIcones;
        private Label lblDataAbertura;
        private ComboBox cbxNomeCliente;
        private Button btnPesquisarAtendimento;
        private Button btnFinalizarAtendimento;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExluir;
    }
}