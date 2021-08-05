using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsBetter
{
    public enum TipoContrato
    {
        
        Mensalista,
        Horista,
        
    }

    public class DadosUsuario
    {
        public string Nome { get; } 
        //public TipoContrato Contrato { get; }
        public double Alimentacao { get; }
        public double Transporte { get; }
        public double PlanoDeSaude { get; }
        public double Extra { get; }

        public double SalarioTotal { get; }

        public DadosUsuario(string nome, double alimentacao, double transporte, double planoSaude, double extra,double salarioTotal)
        {
            Nome = nome;
            
            Alimentacao = alimentacao;
            Transporte = transporte;
            PlanoDeSaude = planoSaude;
            Extra = extra;
            SalarioTotal = salarioTotal;

        }
    }


    //public class HoristaClt : DadosUsuario
    //{
    //    public HoristaClt(string nome, 
    //        TipoContrato tipoContrato, 
    //        double alimentacao, 
    //        double transporte, 
    //        double planoSaude, 
    //        double extra, 
    //        double valorHoraClt)
    //        :base(nome, tipoContrato, alimentacao, transporte, planoSaude, extra)
    //    {
    //        ValorHoraClt = valorHoraClt;
    //    }

    //    public double ValorHoraClt { get; }
    //}

    //public class MensalistaClt : DadosUsuario
    //{
    //    public MensalistaClt(string nome,
    //        TipoContrato tipoContrato,
    //        double alimentacao,
    //        double transporte,
    //        double planoSaude,
    //        double extra,
    //        double valorMensalClt)
    //        : base(nome, tipoContrato, alimentacao, transporte, planoSaude, extra)
    //    {
    //        ValorMensalClt = valorMensalClt;
    //    }

    //    public double ValorMensalClt { get; }
    //}


}
