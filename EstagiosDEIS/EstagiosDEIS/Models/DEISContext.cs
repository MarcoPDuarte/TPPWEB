using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EstagiosDEIS.Models
{
    public class DEISContext : DbContext
    {

        public DEISContext() : base(){
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Professor> Professores { get; set; }
    }
}