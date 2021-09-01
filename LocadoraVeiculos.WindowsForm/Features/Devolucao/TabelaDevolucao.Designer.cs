
namespace LocadoraVeiculos.WindowsForm.Features.Devolucao
{
    partial class TabelaDevolucao
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
            this.dataGridDevolucao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDevolucao
            // 
            this.dataGridDevolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDevolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevolucao.Location = new System.Drawing.Point(3, 0);
            this.dataGridDevolucao.Name = "dataGridDevolucao";
            this.dataGridDevolucao.RowHeadersWidth = 51;
            this.dataGridDevolucao.RowTemplate.Height = 24;
            this.dataGridDevolucao.Size = new System.Drawing.Size(672, 592);
            this.dataGridDevolucao.TabIndex = 0;
            // 
            // TabelaDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridDevolucao);
            this.Name = "TabelaDevolucao";
            this.Size = new System.Drawing.Size(675, 592);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDevolucao;
    }
}
