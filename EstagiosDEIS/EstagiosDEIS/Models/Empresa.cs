using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{
    public class Empresa
    {
        static int incID = 1;

        public int IDEmpresa { get; set; } //Verificar a implementação de ID's em C#
        public String Nome { get; set; }


        public Empresa() {
            IDEmpresa = incID;
            incID++;
        }
    }
}