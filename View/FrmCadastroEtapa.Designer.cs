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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroEtapa));
            grbDadosEtapa = new GroupBox();
            lblSituacao = new Label();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            txtOrdem = new TextBox();
            txtNome = new TextBox();
            lblOrdem = new Label();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            grbListaEtapas = new GroupBox();
            dgvListaEtapas = new DataGridView();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            grbDadosEtapa.SuspendLayout();
            pnlSituacao.SuspendLayout();
            grbListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaEtapas).BeginInit();
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
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(336, 72);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 7;
            lblSituacao.Text = "Situação";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(336, 88);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(128, 32);
            pnlSituacao.TabIndex = 4;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(64, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 4;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 3;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(16, 88);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(304, 23);
            txtOrdem.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(144, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(616, 23);
            txtNome.TabIndex = 1;
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
            txtCodigo.TabIndex = 0;
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
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 10F);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 192);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 40);
            btnNovo.TabIndex = 5;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
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
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(280, 192);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 40);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(192, 192);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 40);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(104, 192);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 40);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // grbListaEtapas
            // 
            grbListaEtapas.Controls.Add(dgvListaEtapas);
            grbListaEtapas.Location = new Point(17, 265);
            grbListaEtapas.Name = "grbListaEtapas";
            grbListaEtapas.Size = new Size(775, 175);
            grbListaEtapas.TabIndex = 6;
            grbListaEtapas.TabStop = false;
            grbListaEtapas.Text = "Lista de Etapas";
            // 
            // dgvListaEtapas
            // 
            dgvListaEtapas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaEtapas.Location = new Point(-8, 16);
            dgvListaEtapas.Name = "dgvListaEtapas";
            dgvListaEtapas.Size = new Size(784, 161);
            dgvListaEtapas.TabIndex = 0;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(480, 184);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 8;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(480, 200);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(240, 23);
            txtPesquisar.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(728, 192);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(51, 40);
            btnPesquisar.TabIndex = 11;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(grbListaEtapas);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            Load += FrmCadastroEtapa_Load;
            grbDadosEtapa.ResumeLayout(false);
            grbDadosEtapa.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            grbListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaEtapas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private GroupBox grbListaEtapas;
        private DataGridView dgvListaEtapas;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private ImageList imlIcones;
    }
}