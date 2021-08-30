
namespace LocadoraVeiculos.WindowsForm
{
    partial class Dashboard
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
            this.lblLocacoesPendentes = new System.Windows.Forms.Label();
            this.lblCarrosDisponiveis = new System.Windows.Forms.Label();
            this.lblCarrosAlugados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLocacoesPendentes
            // 
            this.lblLocacoesPendentes.AutoSize = true;
            this.lblLocacoesPendentes.BackColor = System.Drawing.Color.Transparent;
            this.lblLocacoesPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLocacoesPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLocacoesPendentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLocacoesPendentes.Location = new System.Drawing.Point(95, 374);
            this.lblLocacoesPendentes.Name = "lblLocacoesPendentes";
            this.lblLocacoesPendentes.Size = new System.Drawing.Size(29, 31);
            this.lblLocacoesPendentes.TabIndex = 0;
            this.lblLocacoesPendentes.Text = "1";
            // 
            // lblCarrosDisponiveis
            // 
            this.lblCarrosDisponiveis.AutoSize = true;
            this.lblCarrosDisponiveis.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrosDisponiveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarrosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCarrosDisponiveis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarrosDisponiveis.Location = new System.Drawing.Point(317, 374);
            this.lblCarrosDisponiveis.Name = "lblCarrosDisponiveis";
            this.lblCarrosDisponiveis.Size = new System.Drawing.Size(29, 31);
            this.lblCarrosDisponiveis.TabIndex = 1;
            this.lblCarrosDisponiveis.Text = "1";
            // 
            // lblCarrosAlugados
            // 
            this.lblCarrosAlugados.AutoSize = true;
            this.lblCarrosAlugados.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrosAlugados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarrosAlugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCarrosAlugados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCarrosAlugados.Location = new System.Drawing.Point(542, 374);
            this.lblCarrosAlugados.Name = "lblCarrosAlugados";
            this.lblCarrosAlugados.Size = new System.Drawing.Size(29, 31);
            this.lblCarrosAlugados.TabIndex = 2;
            this.lblCarrosAlugados.Text = "1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.new_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblCarrosAlugados);
            this.Controls.Add(this.lblCarrosDisponiveis);
            this.Controls.Add(this.lblLocacoesPendentes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(902, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocacoesPendentes;
        private System.Windows.Forms.Label lblCarrosDisponiveis;
        private System.Windows.Forms.Label lblCarrosAlugados;
    }
}
