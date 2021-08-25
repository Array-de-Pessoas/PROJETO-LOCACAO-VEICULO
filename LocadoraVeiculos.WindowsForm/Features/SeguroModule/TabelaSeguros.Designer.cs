
namespace LocadoraVeiculos.WindowsForm.Features.SeguroModule
{
    partial class TabelaSeguros
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
            this.dataGridSeguros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeguros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSeguros
            // 
            this.dataGridSeguros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSeguros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridSeguros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSeguros.Location = new System.Drawing.Point(3, 3);
            this.dataGridSeguros.Name = "dataGridSeguros";
            this.dataGridSeguros.RowHeadersWidth = 51;
            this.dataGridSeguros.RowTemplate.Height = 24;
            this.dataGridSeguros.Size = new System.Drawing.Size(822, 580);
            this.dataGridSeguros.TabIndex = 0;
            // 
            // TabelaSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridSeguros);
            this.Name = "TabelaSeguros";
            this.Size = new System.Drawing.Size(828, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeguros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSeguros;
    }
}
