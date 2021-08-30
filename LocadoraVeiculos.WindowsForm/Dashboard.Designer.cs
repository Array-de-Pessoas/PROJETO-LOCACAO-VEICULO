
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
            this.btnCarrosAlugados = new System.Windows.Forms.Label();
            this.btnCarrosDisponiveis = new System.Windows.Forms.Label();
            this.btnLocacoesPendentes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarrosAlugados
            // 
            this.btnCarrosAlugados.AutoSize = true;
            this.btnCarrosAlugados.BackColor = System.Drawing.Color.Transparent;
            this.btnCarrosAlugados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrosAlugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCarrosAlugados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarrosAlugados.Location = new System.Drawing.Point(541, 376);
            this.btnCarrosAlugados.Name = "btnCarrosAlugados";
            this.btnCarrosAlugados.Size = new System.Drawing.Size(29, 31);
            this.btnCarrosAlugados.TabIndex = 21;
            this.btnCarrosAlugados.Text = "0";
            // 
            // btnCarrosDisponiveis
            // 
            this.btnCarrosDisponiveis.AutoSize = true;
            this.btnCarrosDisponiveis.BackColor = System.Drawing.Color.Transparent;
            this.btnCarrosDisponiveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCarrosDisponiveis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCarrosDisponiveis.Location = new System.Drawing.Point(317, 376);
            this.btnCarrosDisponiveis.Name = "btnCarrosDisponiveis";
            this.btnCarrosDisponiveis.Size = new System.Drawing.Size(29, 31);
            this.btnCarrosDisponiveis.TabIndex = 22;
            this.btnCarrosDisponiveis.Text = "0";
            // 
            // btnLocacoesPendentes
            // 
            this.btnLocacoesPendentes.AutoSize = true;
            this.btnLocacoesPendentes.BackColor = System.Drawing.Color.Transparent;
            this.btnLocacoesPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocacoesPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnLocacoesPendentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLocacoesPendentes.Location = new System.Drawing.Point(97, 376);
            this.btnLocacoesPendentes.Name = "btnLocacoesPendentes";
            this.btnLocacoesPendentes.Size = new System.Drawing.Size(29, 31);
            this.btnLocacoesPendentes.TabIndex = 23;
            this.btnLocacoesPendentes.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.new_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnLocacoesPendentes);
            this.Controls.Add(this.btnCarrosDisponiveis);
            this.Controls.Add(this.btnCarrosAlugados);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(902, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCarrosAlugados;
        private System.Windows.Forms.Label btnCarrosDisponiveis;
        private System.Windows.Forms.Label btnLocacoesPendentes;
    }
}
