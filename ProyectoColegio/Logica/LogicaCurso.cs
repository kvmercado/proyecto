using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaCurso
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string guardar(Curso p)
        {
            try
            {
                string sentencia = string.Format("insert into curso(nombre,descripcion,fecha_inicio_clases,fecha_fin_clases,valor_mensualidad,cedula_profesor) values ('{0}','{1}','{2}','{3}','{4}','{5}')", p.nombre, p.descripcion, p.fecha_inicio_clases,p.fecha_fin_clases,p.valor_mensualidad,p.profesor.cedula);
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
            string sentencia = "select c.* ,p.nombre as nombre_profesor,p.telefono as telefono_profesor,p.direccion as direccion_profesor from curso c, profesor p where c.cedula_profesor=p.cedula";
            return bd.select(sentencia);
        }

        public List<Curso> Lista()
        {
            List<Curso> lista = new List<Curso>();
            string sentencia = "select * from curso";
            DataTable tabla = bd.select(sentencia);


            foreach (DataRow fila in tabla.Rows)
            {
                Curso p = new Curso();
                p.id = fila["id"].ToString();
                p.nombre = fila["nombre"].ToString();
                p.descripcion = fila["descripcion"].ToString();
                p.fecha_inicio_clases = DateTime.Parse(fila["fecha_inicio_clases"].ToString());
                p.fecha_fin_clases = DateTime.Parse(fila["fecha_fin_clases"].ToString());
                p.valor_mensualidad = Decimal.Parse(fila["valor_mensualidad"].ToString());
                LogicaProfesor claseProfe = new LogicaProfesor();
                p.profesor = claseProfe.buscar(fila["cedula_profesor"].ToString());
                lista.Add(p);
            }
            return lista;
        }
        
        public Curso buscarPorNombre(string nom)
        {
            foreach (Curso p in Lista())
            {
                if (p.nombre.Equals(nom))
                {
                    return p;
                }
            }
            return null;
        }
        public Curso buscar(string id)
        {
            foreach (Curso p in Lista())
            {
                if (p.id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }

        public string editar(Curso p)
        {
            try
            {
                string sentencia = string.Format("update curso set nombre='{1}',descripcion ='{2}',fecha_inicio_clases = '{3}',fecha_fin_clases = '{4}',valor_mensualidad = '{5}',cedula_profesor = '{6}' where id = '{0}'", p.id, p.nombre, p.descripcion, p.fecha_inicio_clases, p.fecha_fin_clases, p.valor_mensualidad,p.profesor.cedula);
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
                string sentencia = string.Format("delete from curso where id = '{0}'", id);
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
