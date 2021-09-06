
namespace LocadoraVeiculos.WindowsForm.Features.CupomModule
{
    partial class TabelaCupom
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
            this.dataGridCupom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupom)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCupom
            // 
            this.dataGridCupom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCupom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridCupom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCupom.Location = new System.Drawing.Point(3, 3);
            this.dataGridCupom.Name = "dataGridCupom";
            this.dataGridCupom.RowHeadersWidth = 51;
            this.dataGridCupom.RowTemplate.Height = 24;
            this.dataGridCupom.Size = new System.Drawing.Size(747, 608);
            this.dataGridCupom.TabIndex = 0;
            // 
            // TabelaCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCupom);
            this.Name = "TabelaCupom";
            this.Size = new System.Drawing.Size(753, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCupom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCupom;
    }
}
