
namespace LocadoraVeiculos.WindowsForm.Features.ParceiroModule
{
    partial class TabelaParceiro
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
            this.dataGridParceiro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridParceiro
            // 
            this.dataGridParceiro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridParceiro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridParceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParceiro.Location = new System.Drawing.Point(3, 3);
            this.dataGridParceiro.Name = "dataGridParceiro";
            this.dataGridParceiro.RowHeadersWidth = 51;
            this.dataGridParceiro.RowTemplate.Height = 24;
            this.dataGridParceiro.Size = new System.Drawing.Size(683, 587);
            this.dataGridParceiro.TabIndex = 0;
            // 
            // TabelaParceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridParceiro);
            this.Name = "TabelaParceiro";
            this.Size = new System.Drawing.Size(686, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParceiro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridParceiro;
    }
}
