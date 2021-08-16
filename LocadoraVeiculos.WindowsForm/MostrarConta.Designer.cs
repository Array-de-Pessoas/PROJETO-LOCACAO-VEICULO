
namespace LocadoraVeiculos.WindowsForm
{
    partial class MostrarConta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagemConta1 = new System.Windows.Forms.PictureBox();
            this.ImagemBalao = new System.Windows.Forms.PictureBox();
            this.TxtNomeConta = new System.Windows.Forms.Label();
            this.LinkSairConta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBalao)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagemConta1
            // 
            this.ImagemConta1.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.imagem_conta;
            this.ImagemConta1.Location = new System.Drawing.Point(46, 13);
            this.ImagemConta1.Name = "ImagemConta1";
            this.ImagemConta1.Size = new System.Drawing.Size(67, 54);
            this.ImagemConta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemConta1.TabIndex = 1;
            this.ImagemConta1.TabStop = false;
            // 
            // ImagemBalao
            // 
            this.ImagemBalao.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Balão_de_login;
            this.ImagemBalao.Location = new System.Drawing.Point(3, 0);
            this.ImagemBalao.Name = "ImagemBalao";
            this.ImagemBalao.Size = new System.Drawing.Size(150, 153);
            this.ImagemBalao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemBalao.TabIndex = 0;
            this.ImagemBalao.TabStop = false;
            // 
            // TxtNomeConta
            // 
            this.TxtNomeConta.AutoSize = true;
            this.TxtNomeConta.BackColor = System.Drawing.Color.White;
            this.TxtNomeConta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNomeConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.TxtNomeConta.Location = new System.Drawing.Point(56, 70);
            this.TxtNomeConta.Name = "TxtNomeConta";
            this.TxtNomeConta.Size = new System.Drawing.Size(46, 17);
            this.TxtNomeConta.TabIndex = 2;
            this.TxtNomeConta.Text = "label1";
            // 
            // LinkSairConta
            // 
            this.LinkSairConta.AutoSize = true;
            this.LinkSairConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.LinkSairConta.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.LinkSairConta.Location = new System.Drawing.Point(56, 87);
            this.LinkSairConta.Name = "LinkSairConta";
            this.LinkSairConta.Size = new System.Drawing.Size(33, 17);
            this.LinkSairConta.TabIndex = 3;
            this.LinkSairConta.TabStop = true;
            this.LinkSairConta.Text = "Sair";
            // 
            // MostrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.LinkSairConta);
            this.Controls.Add(this.TxtNomeConta);
            this.Controls.Add(this.ImagemConta1);
            this.Controls.Add(this.ImagemBalao);
            this.Name = "MostrarConta";
            this.Size = new System.Drawing.Size(156, 191);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemConta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBalao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemBalao;
        private System.Windows.Forms.PictureBox ImagemConta1;
        private System.Windows.Forms.Label TxtNomeConta;
        private System.Windows.Forms.LinkLabel LinkSairConta;
    }
}
