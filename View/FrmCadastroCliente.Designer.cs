namespace SistemaAtendimento
{
    partial class FrmCadastroCliente
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
            grbDadosCliente = new GroupBox();
            lblSituacao = new Label();
            pnlSituacao = new Panel();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            cbxEstado = new ComboBox();
            lblEstado = new Label();
            txtCidade = new TextBox();
            lblCidade = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            lblCep = new Label();
            txtCpfCnpj = new TextBox();
            lblCpfCnpj = new Label();
            pnlTipoPessoa = new Panel();
            rdbJuridico = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblEmail = new Label();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            lblPesquisar = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgvClientes = new DataGridView();
            txtBairro = new TextBox();
            grbDadosCliente.SuspendLayout();
            pnlSituacao.SuspendLayout();
            pnlTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(lblSituacao);
            grbDadosCliente.Controls.Add(pnlSituacao);
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(lblEndereco);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(lblCep);
            grbDadosCliente.Controls.Add(txtCpfCnpj);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(pnlTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(lblTelefone);
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblEmail);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(8, 8);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(776, 288);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados Do Cliente";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(160, 240);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 26;
            lblSituacao.Text = "Situação";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Location = new Point(160, 248);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(152, 32);
            pnlSituacao.TabIndex = 14;
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
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" });
            cbxEstado.Location = new Point(8, 256);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(144, 23);
            cbxEstado.TabIndex = 13;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(8, 240);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(504, 200);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(264, 23);
            txtCidade.TabIndex = 12;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(504, 184);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 22;
            lblCidade.Text = "Cidade";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(200, 200);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(288, 23);
            txtComplemento.TabIndex = 11;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(200, 184);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 21;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(8, 184);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 20;
            lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(608, 128);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 19;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(608, 144);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(160, 23);
            txtNumero.TabIndex = 9;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(200, 128);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 17;
            lblEndereco.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(200, 144);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(392, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(8, 144);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(176, 23);
            txtCep.TabIndex = 7;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(8, 128);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(568, 88);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(200, 23);
            txtCpfCnpj.TabIndex = 6;
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(568, 72);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 12;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // pnlTipoPessoa
            // 
            pnlTipoPessoa.Controls.Add(rdbJuridico);
            pnlTipoPessoa.Controls.Add(rdbFisica);
            pnlTipoPessoa.Location = new Point(416, 88);
            pnlTipoPessoa.Name = "pnlTipoPessoa";
            pnlTipoPessoa.Size = new Size(136, 24);
            pnlTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridico
            // 
            rdbJuridico.AutoSize = true;
            rdbJuridico.Location = new Point(64, 0);
            rdbJuridico.Name = "rdbJuridico";
            rdbJuridico.Size = new Size(66, 19);
            rdbJuridico.TabIndex = 1;
            rdbJuridico.TabStop = true;
            rdbJuridico.Text = "Júridico";
            rdbJuridico.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(8, 0);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(416, 72);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(72, 15);
            lblTipoPessoa.TabIndex = 10;
            lblTipoPessoa.Text = "Tipo Pessoa ";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(200, 88);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(200, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(200, 72);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(8, 88);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(176, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(8, 72);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(464, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(152, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(296, 23);
            txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(464, 24);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(152, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(128, 23);
            txtCodigo.TabIndex = 0;
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
            btnNovo.Location = new Point(16, 320);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 32);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(104, 320);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 32);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(192, 320);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 32);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(368, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 32);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(280, 320);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 32);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(472, 304);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 27;
            lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(472, 320);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(240, 23);
            txtPesquisar.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(720, 312);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(72, 32);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvClientes);
            grbListaClientes.Location = new Point(8, 368);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(776, 144);
            grbListaClientes.TabIndex = 29;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(-8, 16);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(832, 150);
            dgvClientes.TabIndex = 0;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(8, 200);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(176, 23);
            txtBairro.TabIndex = 10;
            // 
            // FrmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroCliente";
            Text = "Cadastro de Clientes";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            pnlTipoPessoa.ResumeLayout(false);
            pnlTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblEmail;
        private Label lblNome;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtCelular;
        private Label lblCelular;
        private Panel pnlTipoPessoa;
        private Label lblTipoPessoa;
        private RadioButton rdbJuridico;
        private RadioButton rdbFisica;
        private TextBox txtCep;
        private Label lblCep;
        private TextBox txtCpfCnpj;
        private Label lblCpfCnpj;
        private TextBox txtCidade;
        private Label lblCidade;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblEstado;
        private ComboBox cbxEstado;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Panel pnlSituacao;
        private Label lblSituacao;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Label lblPesquisar;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgvClientes;
        private TextBox txtBairro;
    }
}