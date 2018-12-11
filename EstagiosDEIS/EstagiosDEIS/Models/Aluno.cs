using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{
    public class Aluno
    {
        public int NumeroAluno { get; set; }
        public String NomeAluno { get; set; }
        public Estagio estagio { get; set; }
        public Candidatura candidatura { get; set; }

        public Aluno(int numero, String nome)
        {
            this.NumeroAluno = numero;
            this.NomeAluno = nome;
        }
    }
}