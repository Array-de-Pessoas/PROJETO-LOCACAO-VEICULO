
namespace LocadoraVeiculos.WindowsForm.Features.Dashboard
{
    partial class TabelaCarrosDisponiveis
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
            this.dataGridCarrosDisponiveis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrosDisponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarrosDisponiveis
            // 
            this.dataGridCarrosDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCarrosDisponiveis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridCarrosDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrosDisponiveis.Location = new System.Drawing.Point(0, 0);
            this.dataGridCarrosDisponiveis.Name = "dataGridCarrosDisponiveis";
            this.dataGridCarrosDisponiveis.RowHeadersWidth = 51;
            this.dataGridCarrosDisponiveis.RowTemplate.Height = 24;
            this.dataGridCarrosDisponiveis.Size = new System.Drawing.Size(798, 579);
            this.dataGridCarrosDisponiveis.TabIndex = 0;
            // 
            // TabelaCarrosDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.dataGridCarrosDisponiveis);
            this.Name = "TabelaCarrosDisponiveis";
            this.Size = new System.Drawing.Size(798, 579);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrosDisponiveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCarrosDisponiveis;
    }
}
