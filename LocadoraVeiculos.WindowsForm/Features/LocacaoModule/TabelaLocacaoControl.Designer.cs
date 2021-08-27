
namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    partial class TabelaLocacaoControl
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
            this.dataGridLocacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLocacao
            // 
            this.dataGridLocacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLocacao.Location = new System.Drawing.Point(0, 0);
            this.dataGridLocacao.Name = "dataGridLocacao";
            this.dataGridLocacao.Size = new System.Drawing.Size(616, 508);
            this.dataGridLocacao.TabIndex = 0;
            // 
            // TabelaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridLocacao);
            this.Name = "TabelaLocacao";
            this.Size = new System.Drawing.Size(616, 508);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLocacao;
    }
}
