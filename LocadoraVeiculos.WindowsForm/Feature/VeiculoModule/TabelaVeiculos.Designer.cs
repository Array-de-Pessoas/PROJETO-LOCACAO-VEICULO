
namespace LocadoraVeiculos.WindowsForm.Feature.VeiculoModule
{
    partial class TabelaVeiculos
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
            this.DataGridDeVeiculos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDeVeiculos
            // 
            this.DataGridDeVeiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.DataGridDeVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDeVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridDeVeiculos.Location = new System.Drawing.Point(0, 0);
            this.DataGridDeVeiculos.Name = "DataGridDeVeiculos";
            this.DataGridDeVeiculos.Size = new System.Drawing.Size(679, 458);
            this.DataGridDeVeiculos.TabIndex = 0;
            // 
            // TabelaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.DataGridDeVeiculos);
            this.Name = "TabelaVeiculos";
            this.Size = new System.Drawing.Size(679, 458);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDeVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridDeVeiculos;
    }
}
