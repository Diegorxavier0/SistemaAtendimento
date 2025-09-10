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
            grbDadosSituacaoAtendimento = new GroupBox();
            SuspendLayout();
            // 
            // grbDadosSituacaoAtendimento
            // 
            grbDadosSituacaoAtendimento.Location = new Point(9, 9);
            grbDadosSituacaoAtendimento.Name = "grbDadosSituacaoAtendimento";
            grbDadosSituacaoAtendimento.Size = new Size(783, 100);
            grbDadosSituacaoAtendimento.TabIndex = 0;
            grbDadosSituacaoAtendimento.TabStop = false;
            grbDadosSituacaoAtendimento.Text = "Dados da Situação do Atendimento ";
            // 
            // FrmCadastroSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbDadosSituacaoAtendimento);
            Name = "FrmCadastroSituacaoAtendimento";
            Text = "Cadastros de Situação de Atendimentos";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDadosSituacaoAtendimento;
    }
}