using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaMensualidades
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string registrarmensualidad(Mensualidad p)
        {
            try
            {
                string sentencia = string.Format("insert into mensualidad(id_inscripcion,estado,valor_pagado,deuda) values ('{0}','{1}','{2}','{3}')", p.inscrpcion.id, p.estado, p.valor_pagado, (p.inscrpcion.curso.valor_mensualidad-p.valor_pagado));
                bd.ejecutar(sentencia);
                return "Mensualidad registrada Correctamente";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
                throw;
            }
        }

        //-----------------------------------------------------------------------------------

        public DataTable cargarTabla()
        {
            string sentencia = "SELECT n.nombre as niño, n.id as N_documento_niño, n.nombre_acudiente as acudiente, c.nombre as curso,p.nombre as profesor_encargado, m.valor_pagado as valor_pagado, m.deuda as deuda,m.estado as estado, i.fecha as fecha_inscripcion,m.fecha as fecha_de_pago FROM mensualidad m, niño n,profesor p,curso c, inscripcion i where m.id_inscripcion=i.id and i.id_curso=c.id and i.id_niño=n.id and c.cedula_profesor=p.cedula ";
            return bd.select(sentencia);
        }
        public DataTable cargarTablaPorEstudiante(string estudiante)
        {
            string sentencia = "SELECT n.nombre as niño, n.id as N_documento_niño, n.nombre_acudiente as acudiente, c.nombre as curso,p.nombre as profesor_encargado, m.valor_pagado as valor_pagado, m.deuda as deuda,m.estado as estado, i.fecha as fecha_inscripcion,m.fecha as fecha_de_pago FROM mensualidad m, niño n,profesor p,curso c, inscripcion i where m.id_inscripcion=i.id and i.id_curso=c.id and i.id_niño=n.id and c.cedula_profesor=p.cedula and n.id = '" + estudiante+"'";
            return bd.select(sentencia);
        }

        public List<Mensualidad> Lista()
        {
            List<Mensualidad> lista = new List<Mensualidad>();
            string sentencia = "select * from mensualidad";
            DataTable tabla = bd.select(sentencia);


            foreach (DataRow fila in tabla.Rows)
            {
                LogicaInscripciones claseinscripcion = new LogicaInscripciones();

                Mensualidad m = new Mensualidad();
                m.inscrpcion = claseinscripcion.buscar(fila["id_inscripcion"].ToString());
                m.estado = fila["estado"].ToString();
                m.valor_pagado = Decimal.Parse(fila["valor_pagado"].ToString());
                m.deuda = Decimal.Parse(fila["deuda"].ToString());
                lista.Add(m);
            }
            return lista;
        }

        public Mensualidad buscar(string id)
        {
            foreach (Mensualidad p in Lista())
            {
                if (p.id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

     
    }
}
