
namespace LocadoraVeiculos.WindowsForm
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusAplicacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.panelTelaPrincipal = new System.Windows.Forms.Panel();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.ImagemInicio = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panelTelaPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusAplicacao,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusAplicacao
            // 
            this.StatusAplicacao.Name = "StatusAplicacao";
            this.StatusAplicacao.Size = new System.Drawing.Size(39, 21);
            this.StatusAplicacao.Text = "Status";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Btn_Opções;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // panelTelaPrincipal
            // 
            this.panelTelaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTelaPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTelaPrincipal.Controls.Add(this.btnAcessar);
            this.panelTelaPrincipal.Controls.Add(this.ImagemInicio);
            this.panelTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelTelaPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTelaPrincipal.Name = "panelTelaPrincipal";
            this.panelTelaPrincipal.Size = new System.Drawing.Size(830, 526);
            this.panelTelaPrincipal.TabIndex = 1;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Only_the_color_blue;
            this.btnAcessar.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Imagem_Acessar;
            this.btnAcessar.Location = new System.Drawing.Point(479, 370);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(104, 42);
            this.btnAcessar.TabIndex = 1;
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // ImagemInicio
            // 
            this.ImagemInicio.Image = global::LocadoraVeiculos.WindowsForm.Properties.Resources.New_Screen;
            this.ImagemInicio.Location = new System.Drawing.Point(0, 0);
            this.ImagemInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImagemInicio.Name = "ImagemInicio";
            this.ImagemInicio.Size = new System.Drawing.Size(830, 526);
            this.ImagemInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagemInicio.TabIndex = 0;
            this.ImagemInicio.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(832, 556);
            this.Controls.Add(this.panelTelaPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(848, 595);
            this.MinimumSize = new System.Drawing.Size(848, 595);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora Veículos - Inicio";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelTelaPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusAplicacao;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Panel panelTelaPrincipal;
        private System.Windows.Forms.PictureBox ImagemInicio;
        private System.Windows.Forms.Button btnAcessar;
    }
}

