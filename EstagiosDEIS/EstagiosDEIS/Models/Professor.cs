﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstagiosDEIS.Models
{
    public class Professor
    {
        public int NumeroProfessor { get; set; }
        public String Nome { get; set; }
        public Boolean ComissaoEstagio { get; set; }
        public List<Estagio> OrientadorEstagios { get; set; }
        public List<Estagio> EstagiosSubmetidos { get; set; }

        public Professor(){

        }
    }
}