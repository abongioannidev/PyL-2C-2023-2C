﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public int Stock {  get; set; }


        public override string ToString()
        {
            return $"{Nombre}, {Descripcion}";
        }
    }
}
