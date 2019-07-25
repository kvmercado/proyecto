using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Logica
{
    public class LogicaEntradasSalidas
    {
        BaseDeDatos bd = new BaseDeDatos();

        public string registrarEntradaSalida(Entrada_Salida p)
        {
            try
            {
                string sentencia = string.Format("insert into salidas_entradas(tipo,id_niño) values ('{0}','{1}')", p.tipo, p.niño.id);
                bd.ejecutar(sentencia);
                return p.tipo+" registrada Correctamente";
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
            string sentencia = "SELECT id,id_niño,(select nombre from niño where id=id_niño) as niño ,tipo as Movimiento, fecha FROM salidas_entradas";
            return bd.select(sentencia);
        }
        public DataTable cargarTablaPorEstudiante(string estudiante,string tipo)
        {
            string sentencia = "SELECT id,id_niño,(select nombre from niño where id=id_niño) as niño ,tipo as Movimiento, fecha FROM salidas_entradas where id_niño = '" + estudiante + "' and tipo='" + tipo + "'";
            return bd.select(sentencia);
        }

        public DataTable cargarTablaPorTipos(string tipo)
        {
            string sentencia = "SELECT id,id_niño,(select nombre from niño where id=id_niño) as niño ,tipo as Movimiento, fecha FROM salidas_entradas where tipo='" + tipo + "'";
            return bd.select(sentencia);
        }




    }
}
