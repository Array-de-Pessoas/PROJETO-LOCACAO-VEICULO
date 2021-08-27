
namespace LocadoraVeiculos.WindowsForm.Features.LocacaoModule
{
    partial class TelaLocacaoForm
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
            this.cbTaxa = new System.Windows.Forms.ComboBox();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dtLocacao = new System.Windows.Forms.DateTimePicker();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbSeguro = new System.Windows.Forms.ComboBox();
            this.cbPlano = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTaxa
            // 
            this.cbTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaxa.FormattingEnabled = true;
            this.cbTaxa.Location = new System.Drawing.Point(209, 189);
            this.cbTaxa.Name = "cbTaxa";
            this.cbTaxa.Size = new System.Drawing.Size(228, 28);
            this.cbTaxa.TabIndex = 54;
            this.cbTaxa.SelectedIndexChanged += new System.EventHandler(this.cbTaxa_SelectedIndexChanged);
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(209, 155);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(228, 28);
            this.cbVeiculo.TabIndex = 53;
            this.cbVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbVeiculo_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(209, 121);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(228, 28);
            this.cbCliente.TabIndex = 52;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(346, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 43);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(239, 427);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(101, 43);
            this.btnGravar.TabIndex = 50;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // dtDevolucao
            // 
            this.dtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDevolucao.Location = new System.Drawing.Point(209, 326);
            this.dtDevolucao.Name = "dtDevolucao";
            this.dtDevolucao.Size = new System.Drawing.Size(159, 29);
            this.dtDevolucao.TabIndex = 49;
            this.dtDevolucao.ValueChanged += new System.EventHandler(this.dtDevolucao_ValueChanged);
            // 
            // dtLocacao
            // 
            this.dtLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtLocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLocacao.Location = new System.Drawing.Point(209, 291);
            this.dtLocacao.Name = "dtLocacao";
            this.dtLocacao.Size = new System.Drawing.Size(159, 29);
            this.dtLocacao.TabIndex = 48;
            this.dtLocacao.ValueChanged += new System.EventHandler(this.dtLocacao_ValueChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(209, 361);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(228, 27);
            this.txtPreco.TabIndex = 47;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(184, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(133, 27);
            this.txtId.TabIndex = 46;
            // 
            // cbSeguro
            // 
            this.cbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeguro.FormattingEnabled = true;
            this.cbSeguro.Location = new System.Drawing.Point(209, 223);
            this.cbSeguro.Name = "cbSeguro";
            this.cbSeguro.Size = new System.Drawing.Size(228, 28);
            this.cbSeguro.TabIndex = 55;
            this.cbSeguro.SelectedIndexChanged += new System.EventHandler(this.cbSeguro_SelectedIndexChanged);
            // 
            // cbPlano
            // 
            this.cbPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "Diário",
            "Controlado",
            "Livre"});
            this.cbPlano.Location = new System.Drawing.Point(209, 257);
            this.cbPlano.Name = "cbPlano";
            this.cbPlano.Size = new System.Drawing.Size(228, 28);
            this.cbPlano.TabIndex = 56;
            this.cbPlano.SelectedIndexChanged += new System.EventHandler(this.cbPlano_SelectedIndexChanged);
            // 
            // TelaLocacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LocadoraVeiculos.WindowsForm.Properties.Resources.Cadastro_de_combustivel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 515);
            this.Controls.Add(this.cbPlano);
            this.Controls.Add(this.cbSeguro);
            this.Controls.Add(this.cbTaxa);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtDevolucao);
            this.Controls.Add(this.dtLocacao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtId);
            this.Name = "TelaLocacaoForm";
            this.Text = "TelaLocacaoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTaxa;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtDevolucao;
        private System.Windows.Forms.DateTimePicker dtLocacao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbSeguro;
        private System.Windows.Forms.ComboBox cbPlano;
    }
}