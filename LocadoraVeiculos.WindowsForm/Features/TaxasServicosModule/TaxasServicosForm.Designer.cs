
namespace LocadoraVeiculos.WindowsForm.Features.TaxasServicosModule
{
    partial class TaxasServicosForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.RBNdiaria = new System.Windows.Forms.RadioButton();
            this.RBNfixa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 133);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(137, 174);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 1;
            // 
            // RBNdiaria
            // 
            this.RBNdiaria.AutoSize = true;
            this.RBNdiaria.Location = new System.Drawing.Point(69, 39);
            this.RBNdiaria.Name = "RBNdiaria";
            this.RBNdiaria.Size = new System.Drawing.Size(101, 21);
            this.RBNdiaria.TabIndex = 2;
            this.RBNdiaria.TabStop = true;
            this.RBNdiaria.Text = "Taxa Diária";
            this.RBNdiaria.UseVisualStyleBackColor = true;
            // 
            // RBNfixa
            // 
            this.RBNfixa.AutoSize = true;
            this.RBNfixa.Location = new System.Drawing.Point(214, 39);
            this.RBNfixa.Name = "RBNfixa";
            this.RBNfixa.Size = new System.Drawing.Size(89, 21);
            this.RBNfixa.TabIndex = 3;
            this.RBNfixa.TabStop = true;
            this.RBNfixa.Text = "Taxa Fixa";
            this.RBNfixa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(147, 90);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 6;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(147, 238);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(119, 45);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // TaxasServicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 305);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBNfixa);
            this.Controls.Add(this.RBNdiaria);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Name = "TaxasServicosForm";
            this.Text = "TaxasServicosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton RBNdiaria;
        private System.Windows.Forms.RadioButton RBNfixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Button btnGravar;
    }
}