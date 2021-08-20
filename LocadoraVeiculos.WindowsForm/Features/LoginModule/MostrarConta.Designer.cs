
namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
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
            this.LinkConta = new System.Windows.Forms.LinkLabel();
            this.txtNomeConta = new System.Windows.Forms.Label();
            this.ImagemConta1 = new System.Windows.Forms.PictureBox();
            this.ImagemBalao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemConta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBalao)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkConta
            // 
            this.LinkConta.AutoSize = true;
            this.LinkConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.LinkConta.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.LinkConta.Location = new System.Drawing.Point(52, 87);
            this.LinkConta.Name = "LinkConta";
            this.LinkConta.Size = new System.Drawing.Size(47, 17);
            this.LinkConta.TabIndex = 3;
            this.LinkConta.TabStop = true;
            this.LinkConta.Text = "Entrar";
            this.LinkConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSairConta_LinkClicked);
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.AutoSize = true;
            this.txtNomeConta.BackColor = System.Drawing.Color.White;
            this.txtNomeConta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.txtNomeConta.Location = new System.Drawing.Point(40, 70);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(73, 17);
            this.txtNomeConta.TabIndex = 2;
            this.txtNomeConta.Text = "Faça login";
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
            this.Controls.Add(this.LinkConta);
            this.Controls.Add(this.txtNomeConta);
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
        private System.Windows.Forms.Label txtNomeConta;
        private System.Windows.Forms.LinkLabel LinkConta;
    }
}
