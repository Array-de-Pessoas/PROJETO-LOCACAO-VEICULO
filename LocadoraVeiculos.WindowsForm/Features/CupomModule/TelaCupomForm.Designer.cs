
namespace LocadoraVeiculos.WindowsForm.Features.CupomModule
{
    partial class TelaCupomForm
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorMinimo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.CmbParceiro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeVencimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(381, 487);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(114, 55);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(261, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 55);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(219, 172);
            this.txtTipo.Multiline = true;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(186, 32);
            this.txtTipo.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(219, 219);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(186, 32);
            this.txtValor.TabIndex = 3;
            // 
            // txtValorMinimo
            // 
            this.txtValorMinimo.Location = new System.Drawing.Point(219, 266);
            this.txtValorMinimo.Multiline = true;
            this.txtValorMinimo.Name = "txtValorMinimo";
            this.txtValorMinimo.Size = new System.Drawing.Size(186, 32);
            this.txtValorMinimo.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(219, 410);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(186, 32);
            this.txtQuantidade.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(219, 57);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 32);
            this.txtId.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(219, 121);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 32);
            this.txtCodigo.TabIndex = 9;
            // 
            // CmbParceiro
            // 
            this.CmbParceiro.FormattingEnabled = true;
            this.CmbParceiro.Items.AddRange(new object[] {
            "Lucas",
            "Pedro"});
            this.CmbParceiro.Location = new System.Drawing.Point(219, 319);
            this.CmbParceiro.Name = "CmbParceiro";
            this.CmbParceiro.Size = new System.Drawing.Size(186, 24);
            this.CmbParceiro.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "TIPO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "VALOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "VALOR MÍNIMO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "PARCEIRO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "DIA VENCIMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "QUANTIDADE";
            // 
            // dateTimeVencimento
            // 
            this.dateTimeVencimento.Location = new System.Drawing.Point(237, 371);
            this.dateTimeVencimento.Name = "dateTimeVencimento";
            this.dateTimeVencimento.Size = new System.Drawing.Size(200, 22);
            this.dateTimeVencimento.TabIndex = 18;
            // 
            // TelaCupomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Cadastro_de_combustivel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 574);
            this.Controls.Add(this.dateTimeVencimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbParceiro);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorMinimo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Name = "TelaCupomForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cupom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox CmbParceiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeVencimento;
    }
}