
namespace LocadoraVeiculos.WindowsForm
{
    partial class TabelaGrupoVeiculos
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
            this.dataGridGrupoVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupoVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGrupoVeiculos
            // 
            this.dataGridGrupoVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGrupoVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridGrupoVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrupoVeiculos.Location = new System.Drawing.Point(0, 3);
            this.dataGridGrupoVeiculos.Name = "dataGridGrupoVeiculos";
            this.dataGridGrupoVeiculos.RowHeadersWidth = 51;
            this.dataGridGrupoVeiculos.RowTemplate.Height = 24;
            this.dataGridGrupoVeiculos.Size = new System.Drawing.Size(895, 643);
            this.dataGridGrupoVeiculos.TabIndex = 0;
            // 
            // TabelaGrupoVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridGrupoVeiculos);
            this.Name = "TabelaGrupoVeiculos";
            this.Size = new System.Drawing.Size(885, 649);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupoVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGrupoVeiculos;
    }
}
