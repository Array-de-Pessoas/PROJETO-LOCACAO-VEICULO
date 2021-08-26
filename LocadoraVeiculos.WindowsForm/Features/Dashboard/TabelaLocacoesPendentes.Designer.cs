
namespace LocadoraVeiculos.WindowsForm.Features.Dashboard
{
    partial class TabelaLocacoesPendentes
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
            this.dataGridLocacoesPendentes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacoesPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLocacoesPendentes
            // 
            this.dataGridLocacoesPendentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridLocacoesPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLocacoesPendentes.Location = new System.Drawing.Point(3, 3);
            this.dataGridLocacoesPendentes.Name = "dataGridLocacoesPendentes";
            this.dataGridLocacoesPendentes.RowHeadersWidth = 51;
            this.dataGridLocacoesPendentes.RowTemplate.Height = 24;
            this.dataGridLocacoesPendentes.Size = new System.Drawing.Size(868, 610);
            this.dataGridLocacoesPendentes.TabIndex = 0;
            // 
            // TabelaLocacoesPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridLocacoesPendentes);
            this.Name = "TabelaLocacoesPendentes";
            this.Size = new System.Drawing.Size(874, 616);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLocacoesPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLocacoesPendentes;
    }
}
