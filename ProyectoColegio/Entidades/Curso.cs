using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Curso
    {
        public string id;
        public string nombre;
        public string descripcion;
        public DateTime fecha_inicio_clases;
        public DateTime fecha_fin_clases;
        public decimal valor_mensualidad;
        public Profesor profesor;
    }
}

