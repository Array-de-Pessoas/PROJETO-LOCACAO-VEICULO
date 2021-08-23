
namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    partial class TabelaTaxasServicos
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
            this.dataGridTaxasServicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaxasServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTaxasServicos
            // 
            this.dataGridTaxasServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTaxasServicos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridTaxasServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaxasServicos.Location = new System.Drawing.Point(15, 3);
            this.dataGridTaxasServicos.Name = "dataGridTaxasServicos";
            this.dataGridTaxasServicos.RowHeadersWidth = 51;
            this.dataGridTaxasServicos.RowTemplate.Height = 24;
            this.dataGridTaxasServicos.Size = new System.Drawing.Size(760, 580);
            this.dataGridTaxasServicos.TabIndex = 0;
            // 
            // TabelaTaxasServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridTaxasServicos);
            this.Name = "TabelaTaxasServicos";
            this.Size = new System.Drawing.Size(763, 583);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaxasServicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTaxasServicos;
    }
}
