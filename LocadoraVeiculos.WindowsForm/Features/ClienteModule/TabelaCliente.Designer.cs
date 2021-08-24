
namespace LocadoraVeiculos.WindowsForm.Features.ClienteModule
{
    partial class TabelaCliente
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(3, 0);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.RowHeadersWidth = 51;
            this.dataGridCliente.RowTemplate.Height = 24;
            this.dataGridCliente.Size = new System.Drawing.Size(705, 578);
            this.dataGridCliente.TabIndex = 0;
            // 
            // TabelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridCliente);
            this.Name = "TabelaCliente";
            this.Size = new System.Drawing.Size(708, 578);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCliente;
    }
}
