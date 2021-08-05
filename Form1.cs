using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsBetter
{
    public partial class WhatsBetter : Form
    {
        public WhatsBetter()
        {
            InitializeComponent();
            
        }

        public static void Moeda (ref TextBox txt)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            var nome = this.txtNome.Text;
            
                         
                if (double.TryParse(this.txtSalario.Text, out var valor))
                {
                    if (double.TryParse(this.txtAlimentacao.Text, out var valorAlimentacao))
                    {
                        if(double.TryParse(this.txtPlanoSaude.Text,out var valorPlano))
                        {
                            if(double.TryParse(this.txtTransporte.Text, out var valorTransporte))
                            {
                                if (double.TryParse(this.txtExtra.Text, out var valorExtra))
                                {

                                    DadosUsuario dadosUsuario = new DadosUsuario(nome, valorAlimentacao, valorTransporte, valorPlano, valorExtra, valor);
                                    double retornoCalculo = CLT.CalculosCltAnual(dadosUsuario);
                                    this.txtResultado.Text = retornoCalculo.ToString("C");

                                    double retornoCalculoMensal = (CLT.CalculosCltAnual(dadosUsuario)/12);
                                    this.txtTotalMensal.Text = retornoCalculoMensal.ToString("C");

                                    double retornoTotalPJ = ((retornoCalculoMensal)*1.12);
                                    this.txtbxValor.Text = retornoTotalPJ.ToString("C");
                            }   
                            }
                        }
                    }
                                     
                }
        }

        private void TxtKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void TxtAuxilioAlimentacao(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void TxtAuxilioTransporte(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void TxtPlanoDeSaude(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        private void TxtValorExtra(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                return;
            }
            e.Handled = true;
        }

        
    }
}
  

    

