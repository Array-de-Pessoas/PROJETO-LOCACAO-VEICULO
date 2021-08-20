
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
            this.OpcaoCadastroFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoCadastroVeiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.gRUPODEVEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEÍCULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcaoCadastroServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ImagemChave = new System.Windows.Forms.PictureBox();
            this.btnVizualizarConta = new System.Windows.Forms.Button();
            this.TxtCadastroSelecionado = new System.Windows.Forms.Label();
            this.ImagemLinha = new System.Windows.Forms.PictureBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ImagemLinha2 = new System.Windows.Forms.PictureBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.panelTelaContaRegistradas = new System.Windows.Forms.Panel();
            this.toolTipBtnAdicionar = new System.Windows.Forms.ToolTip(this.components);
            this.panelTabelas = new System.Windows.Forms.Panel();
            this.StripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha2)).BeginInit();
            this.panelTabelas.SuspendLayout();
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
            this.StripMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.StripMenu.Size = new System.Drawing.Size(165, 528);
            this.StripMenu.TabIndex = 0;
            this.StripMenu.Text = "menuStrip1";
            this.StripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StripMenu_ItemClicked);
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
            this.OpcaoCadastroFuncionarios,
            this.OpcaoCadastroClientes,
            this.OpcaoCadastroVeiculos,
            this.OpcaoCadastroServicos});
            this.OpcoesCadastros.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcoesCadastros.Name = "OpcoesCadastros";
            this.OpcoesCadastros.Size = new System.Drawing.Size(156, 22);
            this.OpcoesCadastros.Text = "CADASTROS";
            this.OpcoesCadastros.Click += new System.EventHandler(this.OpcoesCadastros_Click);
            // 
            // OpcaoCadastroFuncionarios
            // 
            this.OpcaoCadastroFuncionarios.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcaoCadastroFuncionarios.Name = "OpcaoCadastroFuncionarios";
            this.OpcaoCadastroFuncionarios.Size = new System.Drawing.Size(224, 26);
            this.OpcaoCadastroFuncionarios.Text = "FUNCIONÁRIOS";
            this.OpcaoCadastroFuncionarios.Click += new System.EventHandler(this.OpcaoCadastroFuncionarios_Click);
            // 
            // OpcaoCadastroClientes
            // 
            this.OpcaoCadastroClientes.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcaoCadastroClientes.Name = "OpcaoCadastroClientes";
            this.OpcaoCadastroClientes.Size = new System.Drawing.Size(224, 26);
            this.OpcaoCadastroClientes.Text = "CLIENTES";
            this.OpcaoCadastroClientes.Click += new System.EventHandler(this.OpcaoCadastroClientes_Click);
            // 
            // OpcaoCadastroVeiculos
            // 
            this.OpcaoCadastroVeiculos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gRUPODEVEÍCULOSToolStripMenuItem,
            this.vEÍCULOSToolStripMenuItem});
            this.OpcaoCadastroVeiculos.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcaoCadastroVeiculos.Name = "OpcaoCadastroVeiculos";
            this.OpcaoCadastroVeiculos.Size = new System.Drawing.Size(224, 26);
            this.OpcaoCadastroVeiculos.Text = "VEÍCULOS";
            this.OpcaoCadastroVeiculos.Click += new System.EventHandler(this.OpcaoCadastroVeiculos_Click);
            // 
            // gRUPODEVEÍCULOSToolStripMenuItem
            // 
            this.gRUPODEVEÍCULOSToolStripMenuItem.Name = "gRUPODEVEÍCULOSToolStripMenuItem";
            this.gRUPODEVEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.gRUPODEVEÍCULOSToolStripMenuItem.Text = "GRUPO DE VEÍCULOS";
            this.gRUPODEVEÍCULOSToolStripMenuItem.Click += new System.EventHandler(this.gRUPODEVEÍCULOSToolStripMenuItem_Click);
            // 
            // vEÍCULOSToolStripMenuItem
            // 
            this.vEÍCULOSToolStripMenuItem.Name = "vEÍCULOSToolStripMenuItem";
            this.vEÍCULOSToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.vEÍCULOSToolStripMenuItem.Text = "VEÍCULOS";
            this.vEÍCULOSToolStripMenuItem.Click += new System.EventHandler(this.vEÍCULOSToolStripMenuItem_Click);
            // 
            // OpcaoCadastroServicos
            // 
            this.OpcaoCadastroServicos.Font = new System.Drawing.Font("Bahnschrift Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcaoCadastroServicos.Name = "OpcaoCadastroServicos";
            this.OpcaoCadastroServicos.Size = new System.Drawing.Size(224, 26);
            this.OpcaoCadastroServicos.Text = "SERVIÇOS";
            this.OpcaoCadastroServicos.Click += new System.EventHandler(this.OpcaoCadastroServicos_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ImagemChave
            // 
            this.ImagemChave.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Chave;
            this.ImagemChave.Location = new System.Drawing.Point(207, 137);
            this.ImagemChave.Margin = new System.Windows.Forms.Padding(2);
            this.ImagemChave.Name = "ImagemChave";
            this.ImagemChave.Size = new System.Drawing.Size(206, 236);
            this.ImagemChave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemChave.TabIndex = 1;
            this.ImagemChave.TabStop = false;
            // 
            // btnVizualizarConta
            // 
            this.btnVizualizarConta.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.btnVizualizarConta.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.new_contato;
            this.btnVizualizarConta.Location = new System.Drawing.Point(54, 487);
            this.btnVizualizarConta.Margin = new System.Windows.Forms.Padding(2);
            this.btnVizualizarConta.Name = "btnVizualizarConta";
            this.btnVizualizarConta.Size = new System.Drawing.Size(52, 37);
            this.btnVizualizarConta.TabIndex = 2;
            this.btnVizualizarConta.UseVisualStyleBackColor = true;
            this.btnVizualizarConta.Click += new System.EventHandler(this.btnVizualizarConta_Click);
            // 
            // TxtCadastroSelecionado
            // 
            this.TxtCadastroSelecionado.AutoSize = true;
            this.TxtCadastroSelecionado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCadastroSelecionado.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadastroSelecionado.Location = new System.Drawing.Point(20, 140);
            this.TxtCadastroSelecionado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtCadastroSelecionado.Name = "TxtCadastroSelecionado";
            this.TxtCadastroSelecionado.Size = new System.Drawing.Size(59, 14);
            this.TxtCadastroSelecionado.TabIndex = 3;
            this.TxtCadastroSelecionado.Text = "CLIENTES";
            // 
            // ImagemLinha
            // 
            this.ImagemLinha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImagemLinha.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Linha_de_separação;
            this.ImagemLinha.Location = new System.Drawing.Point(34, 157);
            this.ImagemLinha.Margin = new System.Windows.Forms.Padding(2);
            this.ImagemLinha.Name = "ImagemLinha";
            this.ImagemLinha.Size = new System.Drawing.Size(104, 12);
            this.ImagemLinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLinha.TabIndex = 4;
            this.ImagemLinha.TabStop = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdicionar.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Novo_botão_adicionar;
            this.btnAdicionar.Location = new System.Drawing.Point(22, 174);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 37);
            this.btnAdicionar.TabIndex = 5;
            this.toolTipBtnAdicionar.SetToolTip(this.btnAdicionar, "Adicionar um novo");
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Novo_botão_editar;
            this.btnEditar.Location = new System.Drawing.Point(22, 215);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 37);
            this.btnEditar.TabIndex = 6;
            this.toolTipBtnAdicionar.SetToolTip(this.btnEditar, "Editar item selecionado");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluir.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Novo_botão_excluir;
            this.btnExcluir.Location = new System.Drawing.Point(22, 257);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(122, 37);
            this.btnExcluir.TabIndex = 7;
            this.toolTipBtnAdicionar.SetToolTip(this.btnExcluir, "Excluir item selecionado");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ImagemLinha2
            // 
            this.ImagemLinha2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImagemLinha2.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Linha_de_separação;
            this.ImagemLinha2.Location = new System.Drawing.Point(34, 298);
            this.ImagemLinha2.Margin = new System.Windows.Forms.Padding(2);
            this.ImagemLinha2.Name = "ImagemLinha2";
            this.ImagemLinha2.Size = new System.Drawing.Size(104, 12);
            this.ImagemLinha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemLinha2.TabIndex = 8;
            this.ImagemLinha2.TabStop = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltro.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Novo_botão_filtro;
            this.btnFiltro.Location = new System.Drawing.Point(22, 315);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(122, 37);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // panelTelaContaRegistradas
            // 
            this.panelTelaContaRegistradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTelaContaRegistradas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTelaContaRegistradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTelaContaRegistradas.Location = new System.Drawing.Point(22, 357);
            this.panelTelaContaRegistradas.Margin = new System.Windows.Forms.Padding(2);
            this.panelTelaContaRegistradas.Name = "panelTelaContaRegistradas";
            this.panelTelaContaRegistradas.Size = new System.Drawing.Size(122, 128);
            this.panelTelaContaRegistradas.TabIndex = 10;
            // 
            // panelTabelas
            // 
            this.panelTabelas.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.panelTabelas.Controls.Add(this.ImagemChave);
            this.panelTabelas.Location = new System.Drawing.Point(164, 0);
            this.panelTabelas.Margin = new System.Windows.Forms.Padding(2);
            this.panelTabelas.Name = "panelTabelas";
            this.panelTabelas.Size = new System.Drawing.Size(674, 530);
            this.panelTabelas.TabIndex = 11;
            // 
            // TelaPrincipalCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTabelas);
            this.Controls.Add(this.panelTelaContaRegistradas);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.ImagemLinha2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.ImagemLinha);
            this.Controls.Add(this.TxtCadastroSelecionado);
            this.Controls.Add(this.btnVizualizarConta);
            this.Controls.Add(this.StripMenu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPrincipalCadastros";
            this.Size = new System.Drawing.Size(830, 528);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemLinha2)).EndInit();
            this.panelTabelas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TxtMenu;
        private System.Windows.Forms.ToolStripMenuItem OpcoesCadastros;
        private System.Windows.Forms.ToolStripMenuItem OpcaoCadastroFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem OpcaoCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem OpcaoCadastroVeiculos;
        private System.Windows.Forms.ToolStripMenuItem OpcaoCadastroServicos;
        private System.Windows.Forms.PictureBox ImagemChave;
        private System.Windows.Forms.Button btnVizualizarConta;
        private System.Windows.Forms.Label TxtCadastroSelecionado;
        private System.Windows.Forms.PictureBox ImagemLinha;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox ImagemLinha2;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Panel panelTelaContaRegistradas;
        private System.Windows.Forms.ToolStripMenuItem gRUPODEVEÍCULOSToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipBtnAdicionar;
        private System.Windows.Forms.Panel panelTabelas;
        private System.Windows.Forms.ToolStripMenuItem vEÍCULOSToolStripMenuItem;
    }
}
