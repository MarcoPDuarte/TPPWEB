using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        
        public int NumeroAluno { get; set; }
        public String NomeAluno { get; set; }
        public Estagio Estagio { get; set; }
        public Candidatura Candidatura { get; set; }

        public Aluno(int numero, String nome)
        {
            this.NumeroAluno = numero;
            this.NomeAluno = nome;
        }
    }
}