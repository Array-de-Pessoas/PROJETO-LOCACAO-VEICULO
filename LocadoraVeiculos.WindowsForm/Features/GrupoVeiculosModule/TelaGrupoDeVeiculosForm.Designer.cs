
namespace LocadoraVeiculos.WindowsForm.Features.GrupoVeiculosModule
{
    partial class TelaGrupoDeVeiculosForm
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ImagemFusca = new System.Windows.Forms.PictureBox();
            this.TxtNomeGrupoVeiculos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemFusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(218, 235);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(61, 38);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltar.Location = new System.Drawing.Point(153, 235);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 38);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ImagemFusca
            // 
            this.ImagemFusca.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.ImagemFusca.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Fuquinha;
            this.ImagemFusca.Location = new System.Drawing.Point(108, 28);
            this.ImagemFusca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImagemFusca.Name = "ImagemFusca";
            this.ImagemFusca.Size = new System.Drawing.Size(98, 96);
            this.ImagemFusca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemFusca.TabIndex = 2;
            this.ImagemFusca.TabStop = false;
            // 
            // TxtNomeGrupoVeiculos
            // 
            this.TxtNomeGrupoVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeGrupoVeiculos.Location = new System.Drawing.Point(56, 154);
            this.TxtNomeGrupoVeiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNomeGrupoVeiculos.Multiline = true;
            this.TxtNomeGrupoVeiculos.Name = "TxtNomeGrupoVeiculos";
            this.TxtNomeGrupoVeiculos.Size = new System.Drawing.Size(197, 34);
            this.TxtNomeGrupoVeiculos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Opção_nome_do_grupo;
            this.pictureBox1.Location = new System.Drawing.Point(46, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TelaGrupoDeVeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Fundo_Tela_Cadastro_Grupo_de_Veiculos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNomeGrupoVeiculos);
            this.Controls.Add(this.ImagemFusca);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 344);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 344);
            this.Name = "TelaGrupoDeVeiculosForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de grupo de veículos";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemFusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox ImagemFusca;
        private System.Windows.Forms.TextBox TxtNomeGrupoVeiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}