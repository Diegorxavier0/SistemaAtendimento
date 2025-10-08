namespace SistemaAtendimento.View
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            dgvConsultaAtendimento = new DataGridView();
            txtFiltro = new TextBox();
            btnPesquisar = new Button();
            imlIcones = new ImageList(components);
            cbxFiltro = new ComboBox();
            grbFiltro = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            grbFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(16, 72);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(624, 312);
            dgvConsultaAtendimento.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(176, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(336, 23);
            txtFiltro.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Font = new Font("Segoe UI", 10F);
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(528, 24);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(104, 32);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome do Cliente", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(8, 24);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(160, 23);
            cbxFiltro.TabIndex = 4;
            // 
            // grbFiltro
            // 
            grbFiltro.Controls.Add(cbxFiltro);
            grbFiltro.Controls.Add(dgvConsultaAtendimento);
            grbFiltro.Controls.Add(btnPesquisar);
            grbFiltro.Controls.Add(txtFiltro);
            grbFiltro.Location = new Point(8, 16);
            grbFiltro.Name = "grbFiltro";
            grbFiltro.Size = new Size(648, 392);
            grbFiltro.TabIndex = 6;
            grbFiltro.TabStop = false;
            grbFiltro.Text = "Filtrar por :";
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 415);
            Controls.Add(grbFiltro);
            Name = "FrmConsultaAtendimento";
            Text = "Consultas de Atendimentos";
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            grbFiltro.ResumeLayout(false);
            grbFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private TextBox txtFiltro;
        private Button btnPesquisar;
        private ComboBox cbxFiltro;
        private Label lblFiltrar;
        private ImageList imlIcones;
        private GroupBox grbFiltro;
    }
}