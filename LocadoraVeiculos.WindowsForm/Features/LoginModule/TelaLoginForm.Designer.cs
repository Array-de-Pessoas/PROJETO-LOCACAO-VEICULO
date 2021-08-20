
namespace LocadoraVeiculos.WindowsForm.Features.LoginModule
{
    partial class TelaLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginForm));
            this.panelTelaEntrada = new System.Windows.Forms.Panel();
            this.linkCriarLogin = new System.Windows.Forms.LinkLabel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.ImagemSenha = new System.Windows.Forms.PictureBox();
            this.ImagemUsuario = new System.Windows.Forms.PictureBox();
            this.ImagemEntrar = new System.Windows.Forms.PictureBox();
            this.BarraDeStatusLogin = new System.Windows.Forms.StatusStrip();
            this.StatusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTelaEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemEntrar)).BeginInit();
            this.BarraDeStatusLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTelaEntrada
            // 
            this.panelTelaEntrada.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.panelTelaEntrada.Controls.Add(this.linkCriarLogin);
            this.panelTelaEntrada.Controls.Add(this.btnConfirmar);
            this.panelTelaEntrada.Controls.Add(this.txtSenha);
            this.panelTelaEntrada.Controls.Add(this.txtUsuario);
            this.panelTelaEntrada.Controls.Add(this.ImagemSenha);
            this.panelTelaEntrada.Controls.Add(this.ImagemUsuario);
            this.panelTelaEntrada.Controls.Add(this.ImagemEntrar);
            this.panelTelaEntrada.Controls.Add(this.BarraDeStatusLogin);
            this.panelTelaEntrada.Location = new System.Drawing.Point(0, -1);
            this.panelTelaEntrada.Name = "panelTelaEntrada";
            this.panelTelaEntrada.Size = new System.Drawing.Size(442, 392);
            this.panelTelaEntrada.TabIndex = 0;
            // 
            // linkCriarLogin
            // 
            this.linkCriarLogin.AutoSize = true;
            this.linkCriarLogin.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.linkCriarLogin.LinkColor = System.Drawing.Color.White;
            this.linkCriarLogin.Location = new System.Drawing.Point(160, 226);
            this.linkCriarLogin.Name = "linkCriarLogin";
            this.linkCriarLogin.Size = new System.Drawing.Size(194, 17);
            this.linkCriarLogin.TabIndex = 7;
            this.linkCriarLogin.TabStop = true;
            this.linkCriarLogin.Text = "Não tem um login? crie agora";
            this.linkCriarLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCriarLogin_LinkClicked);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.Location = new System.Drawing.Point(163, 271);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(109, 46);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(163, 188);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(227, 35);
            this.txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(163, 144);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 35);
            this.txtUsuario.TabIndex = 4;
            // 
            // ImagemSenha
            // 
            this.ImagemSenha.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Senha;
            this.ImagemSenha.Location = new System.Drawing.Point(58, 185);
            this.ImagemSenha.Name = "ImagemSenha";
            this.ImagemSenha.Size = new System.Drawing.Size(99, 38);
            this.ImagemSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemSenha.TabIndex = 3;
            this.ImagemSenha.TabStop = false;
            // 
            // ImagemUsuario
            // 
            this.ImagemUsuario.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Usúario;
            this.ImagemUsuario.Location = new System.Drawing.Point(34, 133);
            this.ImagemUsuario.Name = "ImagemUsuario";
            this.ImagemUsuario.Size = new System.Drawing.Size(123, 46);
            this.ImagemUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemUsuario.TabIndex = 2;
            this.ImagemUsuario.TabStop = false;
            // 
            // ImagemEntrar
            // 
            this.ImagemEntrar.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Entrar;
            this.ImagemEntrar.Location = new System.Drawing.Point(116, 57);
            this.ImagemEntrar.Name = "ImagemEntrar";
            this.ImagemEntrar.Size = new System.Drawing.Size(205, 69);
            this.ImagemEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemEntrar.TabIndex = 1;
            this.ImagemEntrar.TabStop = false;
            // 
            // BarraDeStatusLogin
            // 
            this.BarraDeStatusLogin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraDeStatusLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLogin});
            this.BarraDeStatusLogin.Location = new System.Drawing.Point(0, 366);
            this.BarraDeStatusLogin.Name = "BarraDeStatusLogin";
            this.BarraDeStatusLogin.Size = new System.Drawing.Size(442, 26);
            this.BarraDeStatusLogin.TabIndex = 0;
            this.BarraDeStatusLogin.Text = "statusStrip1";
            // 
            // StatusLogin
            // 
            this.StatusLogin.Name = "StatusLogin";
            this.StatusLogin.Size = new System.Drawing.Size(86, 20);
            this.StatusLogin.Text = "StatusLogin";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 391);
            this.Controls.Add(this.panelTelaEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Acesso";
            this.panelTelaEntrada.ResumeLayout(false);
            this.panelTelaEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemEntrar)).EndInit();
            this.BarraDeStatusLogin.ResumeLayout(false);
            this.BarraDeStatusLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTelaEntrada;
        private System.Windows.Forms.PictureBox ImagemEntrar;
        private System.Windows.Forms.StatusStrip BarraDeStatusLogin;
        private System.Windows.Forms.ToolStripStatusLabel StatusLogin;
        private System.Windows.Forms.PictureBox ImagemUsuario;
        private System.Windows.Forms.PictureBox ImagemSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel linkCriarLogin;
    }
}