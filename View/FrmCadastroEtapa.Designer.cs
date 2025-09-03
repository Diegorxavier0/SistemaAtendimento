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
            SuspendLayout();
            // 
            // grbDadosEtapa
            // 
            grbDadosEtapa.Location = new Point(16, 8);
            grbDadosEtapa.Name = "grbDadosEtapa";
            grbDadosEtapa.Size = new Size(776, 148);
            grbDadosEtapa.TabIndex = 0;
            grbDadosEtapa.TabStop = false;
            grbDadosEtapa.Text = "Dados da Etapa";
            // 
            // FrmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbDadosEtapa);
            Name = "FrmCadastroEtapa";
            Text = "Cadastro de Etapas";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDadosEtapa;
    }
}