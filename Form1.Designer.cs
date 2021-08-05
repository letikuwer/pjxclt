
namespace WhatsBetter
{
    partial class WhatsBetter
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.better = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lbl__valorHora = new System.Windows.Forms.Label();
            this.lblAlimentacao = new System.Windows.Forms.Label();
            this.txtAlimentacao = new System.Windows.Forms.TextBox();
            this.lblPlanoDeSaude = new System.Windows.Forms.Label();
            this.txtPlanoSaude = new System.Windows.Forms.TextBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblTotalAnual = new System.Windows.Forms.Label();
            this.lblTotalMensal = new System.Windows.Forms.Label();
            this.txtTotalMensal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxValor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // better
            // 
            this.better.AutoSize = true;
            this.better.BackColor = System.Drawing.Color.Transparent;
            this.better.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.better.ForeColor = System.Drawing.Color.White;
            this.better.Location = new System.Drawing.Point(195, 23);
            this.better.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.better.Name = "better";
            this.better.Size = new System.Drawing.Size(449, 28);
            this.better.TabIndex = 2;
            this.better.Text = "Insira seus dados de contratação CLT";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 96);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(785, 38);
            this.txtNome.TabIndex = 3;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(53, 159);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(379, 38);
            this.txtSalario.TabIndex = 4;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKeyPressed);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(57, 75);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lbl__valorHora
            // 
            this.lbl__valorHora.AutoSize = true;
            this.lbl__valorHora.Location = new System.Drawing.Point(57, 142);
            this.lbl__valorHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl__valorHora.Name = "lbl__valorHora";
            this.lbl__valorHora.Size = new System.Drawing.Size(126, 17);
            this.lbl__valorHora.TabIndex = 8;
            this.lbl__valorHora.Text = "Salário Bruto Total";
            // 
            // lblAlimentacao
            // 
            this.lblAlimentacao.AutoSize = true;
            this.lblAlimentacao.Location = new System.Drawing.Point(445, 142);
            this.lblAlimentacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlimentacao.Name = "lblAlimentacao";
            this.lblAlimentacao.Size = new System.Drawing.Size(129, 17);
            this.lblAlimentacao.TabIndex = 10;
            this.lblAlimentacao.Text = "Auxílio Alimentação";
            // 
            // txtAlimentacao
            // 
            this.txtAlimentacao.Location = new System.Drawing.Point(441, 159);
            this.txtAlimentacao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlimentacao.Multiline = true;
            this.txtAlimentacao.Name = "txtAlimentacao";
            this.txtAlimentacao.Size = new System.Drawing.Size(399, 38);
            this.txtAlimentacao.TabIndex = 9;
            this.txtAlimentacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAuxilioAlimentacao);
            // 
            // lblPlanoDeSaude
            // 
            this.lblPlanoDeSaude.AutoSize = true;
            this.lblPlanoDeSaude.Location = new System.Drawing.Point(57, 201);
            this.lblPlanoDeSaude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanoDeSaude.Name = "lblPlanoDeSaude";
            this.lblPlanoDeSaude.Size = new System.Drawing.Size(109, 17);
            this.lblPlanoDeSaude.TabIndex = 12;
            this.lblPlanoDeSaude.Text = "Plano de Saúde";
            // 
            // txtPlanoSaude
            // 
            this.txtPlanoSaude.Location = new System.Drawing.Point(53, 218);
            this.txtPlanoSaude.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanoSaude.Multiline = true;
            this.txtPlanoSaude.Name = "txtPlanoSaude";
            this.txtPlanoSaude.Size = new System.Drawing.Size(379, 38);
            this.txtPlanoSaude.TabIndex = 11;
            this.txtPlanoSaude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlanoDeSaude);
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.Location = new System.Drawing.Point(445, 201);
            this.lblTransporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(122, 17);
            this.lblTransporte.TabIndex = 14;
            this.lblTransporte.Text = "Auxílio Transporte";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(441, 218);
            this.txtTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtTransporte.Multiline = true;
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(399, 38);
            this.txtTransporte.TabIndex = 13;
            this.txtTransporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAuxilioTransporte);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(57, 262);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(77, 17);
            this.lblExtra.TabIndex = 16;
            this.lblExtra.Text = "Valor Extra";
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(53, 282);
            this.txtExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(785, 38);
            this.txtExtra.TabIndex = 15;
            this.txtExtra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorExtra);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(297, 329);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(273, 57);
            this.btnCalcular.TabIndex = 17;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(53, 474);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(169, 22);
            this.txtResultado.TabIndex = 18;
            // 
            // lblTotalAnual
            // 
            this.lblTotalAnual.AutoEllipsis = true;
            this.lblTotalAnual.AutoSize = true;
            this.lblTotalAnual.Location = new System.Drawing.Point(57, 455);
            this.lblTotalAnual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAnual.Name = "lblTotalAnual";
            this.lblTotalAnual.Size = new System.Drawing.Size(122, 17);
            this.lblTotalAnual.TabIndex = 19;
            this.lblTotalAnual.Text = "Total Anual Limpo";
            // 
            // lblTotalMensal
            // 
            this.lblTotalMensal.AutoEllipsis = true;
            this.lblTotalMensal.AutoSize = true;
            this.lblTotalMensal.Location = new System.Drawing.Point(265, 455);
            this.lblTotalMensal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMensal.Name = "lblTotalMensal";
            this.lblTotalMensal.Size = new System.Drawing.Size(131, 17);
            this.lblTotalMensal.TabIndex = 21;
            this.lblTotalMensal.Text = "Total Mensal Limpo";
            // 
            // txtTotalMensal
            // 
            this.txtTotalMensal.Location = new System.Drawing.Point(261, 474);
            this.txtTotalMensal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalMensal.Name = "txtTotalMensal";
            this.txtTotalMensal.ReadOnly = true;
            this.txtTotalMensal.Size = new System.Drawing.Size(169, 22);
            this.txtTotalMensal.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.better);
            this.panel1.Location = new System.Drawing.Point(-20, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(916, 73);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 561);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Você deve ganhar no mínimo ";
            // 
            // txtbxValor
            // 
            this.txtbxValor.Location = new System.Drawing.Point(53, 580);
            this.txtbxValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbxValor.Name = "txtbxValor";
            this.txtbxValor.ReadOnly = true;
            this.txtbxValor.Size = new System.Drawing.Size(337, 22);
            this.txtbxValor.TabIndex = 23;
            
            // 
            // WhatsBetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxValor);
            this.Controls.Add(this.lblTotalMensal);
            this.Controls.Add(this.txtTotalMensal);
            this.Controls.Add(this.lblTotalAnual);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.lblPlanoDeSaude);
            this.Controls.Add(this.txtPlanoSaude);
            this.Controls.Add(this.lblAlimentacao);
            this.Controls.Add(this.txtAlimentacao);
            this.Controls.Add(this.lbl__valorHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WhatsBetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhatsBetter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label better;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lbl__valorHora;
        private System.Windows.Forms.Label lblAlimentacao;
        private System.Windows.Forms.TextBox txtAlimentacao;
        private System.Windows.Forms.Label lblPlanoDeSaude;
        private System.Windows.Forms.TextBox txtPlanoSaude;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTotalAnual;
        private System.Windows.Forms.Label lblTotalMensal;
        private System.Windows.Forms.TextBox txtTotalMensal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxValor;
    }
}

