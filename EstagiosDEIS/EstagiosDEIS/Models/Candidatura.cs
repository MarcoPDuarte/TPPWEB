using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{   
    public enum Estado
    {
        Aceite,
        EsperaResultado,
        PrecisaEntrevista,
        Rejeitado
    }

    public class Candidatura
    {
        public Ramo ramo { get; set; }
        public Estado estado { get; set; }
        public String LocalPreferencia { get; set; }
        public String NomeOrientador { get; set; }
        public int NumeroOrientador { get; set; }
        public DateTime DataDeCandidatura { get; set; } 

    }
}