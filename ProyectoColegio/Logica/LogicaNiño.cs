using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaNiño
    {
        BaseDeDatos bd = new BaseDeDatos();

        public DataTable cargarTabla()
        {
            string sentencia = "select * from niño";
            return bd.select(sentencia);
        }

        public List<Niño> Lista()
        {
            List<Niño> lista = new List<Niño>();
            string sentencia = "select * from niño";
            DataTable tabla = bd.select(sentencia);


            foreach (DataRow fila in tabla.Rows)
            {
                Niño p = new Niño();
                p.id = fila["id"].ToString();
                p.nombre = fila["nombre"].ToString();
                p.edad = fila["edad"].ToString();
                p.sexo = fila["sexo"].ToString();
                p.id_acudiente = fila["id_acudiente"].ToString();
                p.nombre_acudiente = fila["nombre_acudiente"].ToString();
                p.telefono_acudiente = fila["telefono_acudiente"].ToString();
                p.direccion_acudiente = fila["direccion_acudiente"].ToString();
                lista.Add(p);
            }
            return lista;
        }

        public string guardar(Niño p)
        {
            try
            {
                string sentencia = string.Format("insert into niño values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", p.id, p.nombre, p.edad, p.sexo, p.id_acudiente, p.nombre_acudiente, p.telefono_acudiente, p.direccion_acudiente);
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

      

        public Niño buscar(string id)
        {
            foreach (Niño p in Lista())
            {
                if (p.id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

        public string editar(Niño p)
        {
            try
            {
                string sentencia = string.Format("update niño set id ='{0}', nombre='{1}',edad ='{2}',sexo = '{3}',id_acudiente ='{4}',nombre_acudiente = '{5}',telefono_acudiente = '{6}',direccion_acudiente= '{7}' where id = '{0}'", p.id, p.nombre, p.edad, p.sexo, p.id_acudiente, p.nombre_acudiente, p.telefono_acudiente, p.direccion_acudiente);
                bd.ejecutar(sentencia);
                return "Editado Correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
        }
        public Boolean eliminar(string id)
        {
            try
            {
                string sentencia = string.Format("delete from niño where id = '{0}'", id);
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
