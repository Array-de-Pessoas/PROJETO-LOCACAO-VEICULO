
namespace LocadoraVeiculos.WindowsForm.Features.CombustivelModule
{
    partial class TabelaCombustivelControl
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
            this.dataGridCombustivel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCombustivel)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCombustivel
            // 
            this.dataGridCombustivel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCombustivel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridCombustivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCombustivel.Location = new System.Drawing.Point(3, 3);
            this.dataGridCombustivel.Name = "dataGridCombustivel";
            this.dataGridCombustivel.RowHeadersWidth = 51;
            this.dataGridCombustivel.RowTemplate.Height = 24;
            this.dataGridCombustivel.Size = new System.Drawing.Size(722, 576);
            this.dataGridCombustivel.TabIndex = 0;
            // 
            // TabelaCombustivelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCombustivel);
            this.Name = "TabelaCombustivelControl";
            this.Size = new System.Drawing.Size(728, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCombustivel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCombustivel;
    }
}
