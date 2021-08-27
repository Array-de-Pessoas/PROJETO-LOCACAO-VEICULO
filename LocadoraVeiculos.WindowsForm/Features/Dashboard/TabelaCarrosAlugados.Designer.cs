
namespace LocadoraVeiculos.WindowsForm.Features.Dashboard
{
    partial class TabelaCarrosAlugados
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
            this.dataGridCarrosAlugados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrosAlugados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarrosAlugados
            // 
            this.dataGridCarrosAlugados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.dataGridCarrosAlugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrosAlugados.Location = new System.Drawing.Point(0, 0);
            this.dataGridCarrosAlugados.Name = "dataGridCarrosAlugados";
            this.dataGridCarrosAlugados.RowHeadersWidth = 51;
            this.dataGridCarrosAlugados.RowTemplate.Height = 24;
            this.dataGridCarrosAlugados.Size = new System.Drawing.Size(852, 684);
            this.dataGridCarrosAlugados.TabIndex = 0;
            // 
            // TabelaCarrosAlugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(75)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.dataGridCarrosAlugados);
            this.Name = "TabelaCarrosAlugados";
            this.Size = new System.Drawing.Size(852, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrosAlugados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCarrosAlugados;
    }
}
