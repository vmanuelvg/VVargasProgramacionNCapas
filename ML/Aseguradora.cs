﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Aseguradora
    {
        public int IdAseguradora { get; set; }
        public string Nombre { get; set; }
        public string FechaCreacion { get; set; }
        public string FechaModificacion { get; set; }
        public ML.Usuario Usuario { get; set; }
    }
}
