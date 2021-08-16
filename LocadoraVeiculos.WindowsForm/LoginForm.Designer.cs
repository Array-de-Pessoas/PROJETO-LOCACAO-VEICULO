
namespace LocadoraVeiculos.WindowsForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelTelaEntrada = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.panelTelaEntrada.Controls.Add(this.button1);
            this.panelTelaEntrada.Controls.Add(this.textBox2);
            this.panelTelaEntrada.Controls.Add(this.textBox1);
            this.panelTelaEntrada.Controls.Add(this.ImagemSenha);
            this.panelTelaEntrada.Controls.Add(this.ImagemUsuario);
            this.panelTelaEntrada.Controls.Add(this.ImagemEntrar);
            this.panelTelaEntrada.Controls.Add(this.BarraDeStatusLogin);
            this.panelTelaEntrada.Location = new System.Drawing.Point(0, -1);
            this.panelTelaEntrada.Name = "panelTelaEntrada";
            this.panelTelaEntrada.Size = new System.Drawing.Size(394, 392);
            this.panelTelaEntrada.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(141, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 204);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 35);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 35);
            this.textBox1.TabIndex = 4;
            // 
            // ImagemSenha
            // 
            this.ImagemSenha.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Senha;
            this.ImagemSenha.Location = new System.Drawing.Point(36, 201);
            this.ImagemSenha.Name = "ImagemSenha";
            this.ImagemSenha.Size = new System.Drawing.Size(99, 38);
            this.ImagemSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemSenha.TabIndex = 3;
            this.ImagemSenha.TabStop = false;
            // 
            // ImagemUsuario
            // 
            this.ImagemUsuario.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Usúario;
            this.ImagemUsuario.Location = new System.Drawing.Point(12, 149);
            this.ImagemUsuario.Name = "ImagemUsuario";
            this.ImagemUsuario.Size = new System.Drawing.Size(123, 46);
            this.ImagemUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemUsuario.TabIndex = 2;
            this.ImagemUsuario.TabStop = false;
            // 
            // ImagemEntrar
            // 
            this.ImagemEntrar.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Entrar;
            this.ImagemEntrar.Location = new System.Drawing.Point(117, 51);
            this.ImagemEntrar.Name = "ImagemEntrar";
            this.ImagemEntrar.Size = new System.Drawing.Size(174, 69);
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
            this.BarraDeStatusLogin.Size = new System.Drawing.Size(394, 26);
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
            this.ClientSize = new System.Drawing.Size(394, 391);
            this.Controls.Add(this.panelTelaEntrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}