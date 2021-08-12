
namespace LocadoraVeiculos.WindowsForm
{
    partial class TelaPrincipalCadastros
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
            this.components = new System.ComponentModel.Container();
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcoesCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVizualizarConta = new System.Windows.Forms.Button();
            this.TxtCadastroSelecionado = new System.Windows.Forms.Label();
            this.ImagemLinha = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.StripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StripMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TxtMenu,
            this.OpcoesCadastros});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(169, 647);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 4);
            // 
            // TxtMenu
            // 
            this.TxtMenu.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.new_menu;
            this.TxtMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TxtMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TxtMenu.Name = "TxtMenu";
            this.TxtMenu.Size = new System.Drawing.Size(156, 88);
            // 
            // OpcoesCadastros
            // 
            this.OpcoesCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONÁRIOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem,
            this.vEÍCULOSToolStripMenuItem,
            this.sERVIÇOSToolStripMenuItem});
            this.OpcoesCadastros.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcoesCadastros.Name = "OpcoesCadastros";
            this.OpcoesCadastros.Size = new System.Drawing.Size(156, 27);
            this.OpcoesCadastros.Text = "CADASTROS";
            // 
            // fUNCIONÁRIOSToolStripMenuItem
            // 
            this.fUNCIONÁRIOSToolStripMenuItem.Name = "fUNCIONÁRIOSToolStripMenuItem";
            this.fUNCIONÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.fUNCIONÁRIOSToolStripMenuItem.Text = "FUNCIONÁRIOS";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // vEÍCULOSToolStripMenuItem
            // 
            this.vEÍCULOSToolStripMenuItem.Name = "vEÍCULOSToolStripMenuItem";
            this.vEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.vEÍCULOSToolStripMenuItem.Text = "VEÍCULOS";
            // 
            // sERVIÇOSToolStripMenuItem
            // 
            this.sERVIÇOSToolStripMenuItem.Name = "sERVIÇOSToolStripMenuItem";
            this.sERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(225, 28);
            this.sERVIÇOSToolStripMenuItem.Text = "SERVIÇOS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Chave;
            this.pictureBox1.Location = new System.Drawing.Point(484, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnVizualizarConta
            // 
            this.btnVizualizarConta.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.btnVizualizarConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.new_contato;
            this.btnVizualizarConta.Location = new System.Drawing.Point(40, 596);
            this.btnVizualizarConta.Name = "btnVizualizarConta";
            this.btnVizualizarConta.Size = new System.Drawing.Size(91, 48);
            this.btnVizualizarConta.TabIndex = 2;
            this.btnVizualizarConta.UseVisualStyleBackColor = true;
            // 
            // TxtCadastroSelecionado
            // 
            this.TxtCadastroSelecionado.AutoSize = true;
            this.TxtCadastroSelecionado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCadastroSelecionado.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadastroSelecionado.Location = new System.Drawing.Point(46, 172);
            this.TxtCadastroSelecionado.Name = "TxtCadastroSelecionado";
            this.TxtCadastroSelecionado.Size = new System.Drawing.Size(76, 18);
            this.TxtCadastroSelecionado.TabIndex = 3;
            this.TxtCadastroSelecionado.Text = "CLIENTES";
            // 
            // ImagemLinha
            // 
            this.ImagemLinha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImagemLinha.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Linha_de_separação;
            this.ImagemLinha.Location = new System.Drawing.Point(22, 193);
            this.ImagemLinha.Name = "ImagemLinha";
            this.ImagemLinha.Size = new System.Drawing.Size(123, 15);
            this.ImagemLinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLinha.TabIndex = 4;
            this.ImagemLinha.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.Location = new System.Drawing.Point(3, 214);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(163, 45);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(3, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Linha_de_separação;
            this.pictureBox2.Location = new System.Drawing.Point(22, 367);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(3, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 45);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TelaPrincipalCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ImagemLinha);
            this.Controls.Add(this.TxtCadastroSelecionado);
            this.Controls.Add(this.btnVizualizarConta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StripMenu);
            this.Name = "TelaPrincipalCadastros";
            this.Size = new System.Drawing.Size(1107, 647);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TxtMenu;
        private System.Windows.Forms.ToolStripMenuItem OpcoesCadastros;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVizualizarConta;
        private System.Windows.Forms.Label TxtCadastroSelecionado;
        private System.Windows.Forms.PictureBox ImagemLinha;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
    }
}
