using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaProfesor
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string guardar(Profesor p)
        {
            try
            {
                string sentencia = string.Format("insert into profesor values ('{0}','{1}','{2}','{3}')", p.cedula, p.nombre, p.direccion, p.telefono);
                bd.ejecutar(sentencia);
                return "Guardado Correctamente";
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
            string sentencia = "select * from profesor";
            return bd.select(sentencia);
        }

        public List<Profesor> Lista()
        {
            List<Profesor> lista = new List<Profesor>();
            string sentencia = "select * from profesor";
            DataTable tabla = bd.select(sentencia);


            foreach (DataRow fila in tabla.Rows)
            {
                Profesor p = new Profesor();
                p.cedula = fila["cedula"].ToString();
                p.nombre = fila["nombre"].ToString();
                p.direccion = fila["direccion"].ToString();
                p.telefono = fila["telefono"].ToString();
              
                lista.Add(p);
            }
            
            return lista;
        }

        public Profesor buscar(string cedula)
        {
            foreach (Profesor p in Lista())
            {
                if (p.cedula.Equals(cedula))
                {
                    return p;
                }
            }
            return null;
        }

        public Profesor buscarPorNombre(string nombre)
        {
            foreach (Profesor p in Lista())
            {
                if (p.nombre.Equals(nombre))
                {
                    return p;
                }
            }
            return null;
        }

        public string editar(Profesor p)
        {
            try
            {
                string sentencia = string.Format("update profesor set cedula ='{0}', nombre='{1}',direccion ='{2}',telefono = '{3}' where cedula = '{0}'", p.cedula, p.nombre, p.direccion, p.telefono);
                bd.ejecutar(sentencia);
                return "Editado Correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
        public Boolean eliminar(string cedula)
        {
            try
            {
                string sentencia = string.Format("delete from profesor where cedula = '{0}'", cedula);
                bd.ejecutar(sentencia);
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
    }
}
