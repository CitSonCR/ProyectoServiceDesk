﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Equipo(string nombreEquipo, string descripcion)
        {
            Nombre = nombreEquipo;
            Descripcion = descripcion;
        }
    }
}