using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{
    public enum Ramo {
        DesenvolvimentodeAplicações,
        SistemasdeInformação,
        RedeseAdministraçãodeSistemas
    }

    public enum EstadoEstagio {
        PorComeçar,
        ADecorrer,
        Terminado
    }

    public class Estagio
    {
        public Aluno Estagiario { get; set; }
        public int NumEstagio { get; set; }
        public Ramo RamoAluno { get; set; }
        public String Enquadramento { get; set; }
        public String Objetivos { get; set; }
        public String CondicoesAcesso { get; set; }
        public String LocalEstagio { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumOrientador { get; set; }
        public String NomeOrientador { get; set; }
        public String SubmetidoPor { get; set; }
        public float NotaAluno { get; set; }
        public float NotaEmpresa { get; set; }
        public DateTime DataDefesa { get; set; }

        public Estagio() {
        }


    }
}