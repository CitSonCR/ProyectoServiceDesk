﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoServiceDesk.Controlador
{
    class ClsTarea
    {
        public int TareaId { get; set; }
        public string Nombre { get; set; }
        public string Prioridad { get; set; }
        public int TiempoHoras { get; set; }
        public int Dificultad { get; set; }
        public int UsuarioAtiende { get; set; }

        public ClsTarea(int tareaId, string nombre, string prioridad, int tiempoHoras, int dificultad, int usuarioAtiende)
        {
            TareaId = tareaId;
            Nombre = nombre;
            Prioridad = prioridad;
            TiempoHoras = tiempoHoras;
            Dificultad = dificultad;
            UsuarioAtiende = usuarioAtiende;
        }
    }
}
