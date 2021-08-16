
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
            this.LinkSairConta = new System.Windows.Forms.LinkLabel();
            this.TxtNomeConta = new System.Windows.Forms.Label();
            this.ImagemConta1 = new System.Windows.Forms.PictureBox();
            this.ImagemBalao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBalao)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkSairConta
            // 
            this.LinkSairConta.AutoSize = true;
            this.LinkSairConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.LinkSairConta.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.LinkSairConta.Location = new System.Drawing.Point(52, 87);
            this.LinkSairConta.Name = "LinkSairConta";
            this.LinkSairConta.Size = new System.Drawing.Size(47, 17);
            this.LinkSairConta.TabIndex = 3;
            this.LinkSairConta.TabStop = true;
            this.LinkSairConta.Text = "Entrar";
            this.LinkSairConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSairConta_LinkClicked);
            // 
            // TxtNomeConta
            // 
            this.TxtNomeConta.AutoSize = true;
            this.TxtNomeConta.BackColor = System.Drawing.Color.White;
            this.TxtNomeConta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNomeConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.TxtNomeConta.Location = new System.Drawing.Point(40, 70);
            this.TxtNomeConta.Name = "TxtNomeConta";
            this.TxtNomeConta.Size = new System.Drawing.Size(73, 17);
            this.TxtNomeConta.TabIndex = 2;
            this.TxtNomeConta.Text = "Faça login";
            // 
            // ImagemConta1
            // 
            this.ImagemConta1.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.ImagemConta1.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Sem_conta;
            this.ImagemConta1.Location = new System.Drawing.Point(41, 7);
            this.ImagemConta1.Name = "ImagemConta1";
            this.ImagemConta1.Size = new System.Drawing.Size(72, 60);
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
