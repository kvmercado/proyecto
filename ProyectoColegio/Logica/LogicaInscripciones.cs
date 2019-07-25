using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaInscripciones
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string registrarInscripcion(Inscripcion p)
        {
            try
            {
                string sentencia = string.Format("insert into inscripcion(id_niño,id_curso) values ('{0}','{1}')", p.niño.id, p.curso.id);
                bd.ejecutar(sentencia);
                return "Inscripcion registrada Correctamente";
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
            string sentencia = "select * from inscripcion";
            return bd.select(sentencia);
        }

        public List<Inscripcion> Lista()
        {
            List<Inscripcion> lista = new List<Inscripcion>();
            string sentencia = "select * from inscripcion";
            DataTable tabla = bd.select(sentencia);


            foreach (DataRow fila in tabla.Rows)
            {
                LogicaNiño claseniño = new LogicaNiño();
                LogicaCurso clasecurso = new LogicaCurso();
                Inscripcion p = new Inscripcion();
                p.id = fila["id"].ToString();
                p.niño = claseniño.buscar(fila["id_niño"].ToString());
                p.curso = clasecurso.buscar(fila["id_curso"].ToString());
                p.fecha = DateTime.Parse(fila["fecha"].ToString());
                lista.Add(p);
            }
            return lista;
        }

        public Inscripcion buscar(string id)
        {
            foreach (Inscripcion p in Lista())
            {
                if (p.id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

        public string eliminar(string id)
        {
            try
            {
                string sentencia = string.Format("delete from inscripcion where id ='{0}'",id);
                bd.ejecutar(sentencia);
                return "Inscripcion cancelada Correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
    }
}
