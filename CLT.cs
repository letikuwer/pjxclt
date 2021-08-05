using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsBetter
{
    public class CLT
    {


        public static double CalculosCltAnual(DadosUsuario dadosUsuario)
        {
            double FGTS = dadosUsuario.SalarioTotal;
            double descontoAlimentacao = dadosUsuario.SalarioTotal * 0.015;
            double tercoFerias = dadosUsuario.SalarioTotal / 3;
            double INSS = CalculaINSS(dadosUsuario.SalarioTotal);
            double IRPF = CalculaIRPF(dadosUsuario.SalarioTotal);

            var valorAnualLimpo = FGTS +
                tercoFerias +
                dadosUsuario.SalarioTotal * 12 +
                dadosUsuario.Alimentacao +
                dadosUsuario.Transporte +
                dadosUsuario.PlanoDeSaude -
                INSS -
                IRPF;
            return valorAnualLimpo;

        }




        private static double CalculaINSS(double salarioTotal)
        {
            if (salarioTotal <= 1100)
            {
                return salarioTotal * 0.075;
            }

            if (salarioTotal > 1100.01 && salarioTotal <= 2203.48)
            {
                return salarioTotal * 0.09;
            }

            if (salarioTotal > 2203.49 && salarioTotal <= 3305.22)
            {
                return salarioTotal * 0.12;
            }

            if (salarioTotal > 3302.23 && salarioTotal <= 6433.57)
            {
                return salarioTotal * 0.14;
            }
            return 0.0;
        }

        private static double CalculaIRPF (double salarioTotal)
        {
            if (salarioTotal >= 1903.98 && salarioTotal <= 2826.65)
            {
                return salarioTotal * 0.075;
            }

            if (salarioTotal >= 2826.66 && salarioTotal <= 3751.05)
            {
                return salarioTotal * 0.15;
            }

            if (salarioTotal >= 3751.06 && salarioTotal <= 4464.68)
            {
                return salarioTotal * 0.225;
            }

            if (salarioTotal >= 4464.69)
            {
                return salarioTotal * 0.275;
            }
            return 0.0;

        }




    }
}

