namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbDadosUsuario = new GroupBox();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblPerfil = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            grbListaUsuarios = new GroupBox();
            dgvListaUsuarios = new DataGridView();
            lblPesquisar = new Label();
            grbDadosUsuario.SuspendLayout();
            grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(txtEmail);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(lblEmail);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Location = new Point(8, 8);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(784, 152);
            grbDadosUsuario.TabIndex = 0;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // cbxPerfil
            // 
            cbxPerfil.Enabled = false;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "Usuário", "Administrador" });
            cbxPerfil.Location = new Point(248, 104);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(256, 23);
            cbxPerfil.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(8, 104);
            txtSenha.Name = "txtSenha";
            txtSenha.ReadOnly = true;
            txtSenha.Size = new Size(224, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(184, 48);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(224, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(432, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(344, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(184, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(432, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(248, 88);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Perfil";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(152, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 32);
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
            btnNovo.Location = new Point(16, 184);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(80, 40);
            btnNovo.TabIndex = 1;
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
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(400, 184);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(304, 184);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 40);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(208, 184);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 40);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(112, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 40);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(720, 192);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(56, 32);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(504, 200);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(208, 23);
            txtPesquisar.TabIndex = 6;
            // 
            // grbListaUsuarios
            // 
            grbListaUsuarios.Controls.Add(dgvListaUsuarios);
            grbListaUsuarios.Location = new Point(8, 256);
            grbListaUsuarios.Name = "grbListaUsuarios";
            grbListaUsuarios.Size = new Size(728, 172);
            grbListaUsuarios.TabIndex = 7;
            grbListaUsuarios.TabStop = false;
            grbListaUsuarios.Text = "Lista de Usuários";
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaUsuarios.Location = new Point(0, 16);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.Size = new Size(888, 150);
            dgvListaUsuarios.TabIndex = 0;
            dgvListaUsuarios.CellDoubleClick += dgvListaUsuarios_CellDoubleClick;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(504, 184);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 6;
            lblPesquisar.Text = "Pesquisar";
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(lblPesquisar);
            Controls.Add(grbListaUsuarios);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosUsuario);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            Load += FrmCadastroUsuario_Load;
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosUsuario;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private Label lblPerfil;
        private ComboBox cbxPerfil;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private GroupBox grbListaUsuarios;
        private DataGridView dgvListaUsuarios;
        private ImageList imlIcones;
        private Label lblPesquisar;
    }
}