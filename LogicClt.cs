using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsBetter
{
    class LogicClt:DadosUsuario
    {

        public LogicClt(string nome,
            TipoContrato tipoContrato,
            double alimentacao,
            double transporte,
            double planoSaude,
            double extra,
            double valorHoraClt)
            : base(nome, tipoContrato, alimentacao, transporte, planoSaude, extra);



        public static double SalarioTotal = HorasTrabalhadas * HoraClt;
        public double FGTS = SalarioTotal * 1.08;
        public double DescontoAlimentacao = SalarioTotal * 0.015;
        public double TercoFerias = SalarioTotal / 3;
        public double SalarioAnual = SalarioTotal * 11;

        public void CalculaOpcao(DadosUsuario dados)
        {

        }
        //public double INSS
        //{
        //    get
        //    {
        //        if (SalarioTotal <= 1100)
        //        {
        //            return SalarioTotal * 0.075;
        //        }
        //        else
        //        {

        //        }
        //        if (SalarioTotal > 1100.01 && SalarioTotal <= 2203.48)
        //        {
        //            return SalarioTotal * 0.09;
        //        }
        //        else
        //        {

        //        }
        //        if (SalarioTotal > 2203.49 && SalarioTotal <= 3305.22)
        //        {
        //            return SalarioTotal * 0.12;
        //        }
        //        else
        //        {

        //        }
        //        if (SalarioTotal > 3302.23 && SalarioTotal <= 6433.57)
        //        {
        //            return SalarioTotal * 0.14;
        //        }
        //        else
        //        {

        //        }
        //}
        //}
    }
}
