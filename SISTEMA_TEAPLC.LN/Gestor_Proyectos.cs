using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEMA_TEAPLC.AD;
using SISTEMA_TEAPLC.MODEL;
using System.Windows.Forms;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Proyectos
    {
        private Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Proyectos()
        {

        }

        public void MostrarProyectos( DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarProyectos;");
            ConexionBD.GetData(consulta, DGV);
        }

        public bool InsertarProyecto(Proyecto nuevoProyecto)
        {
            ConexionBD.AbrirConexion();
            bool seInsertoProyecto;
            string consulta = string.Format("EXEC InsertarProyectos '{0}','{1}','{2}','{3}';",
                nuevoProyecto.Id_Empresa, nuevoProyecto.Id_Encargado,
                nuevoProyecto.Nombre, nuevoProyecto.Descripcion);
            seInsertoProyecto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInsertoProyecto;
        }

        public bool EliminarProyectos(Proyecto proyecto)
        {
            ConexionBD.AbrirConexion();
            bool seEliminoProyecto;
            string consulta = string.Format("EXEC EliminarProyectos '{0}';",
                proyecto.Id_Proyecto);
            seEliminoProyecto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seEliminoProyecto;
        }

        public bool ModificarProyectos(Proyecto proyecto)
        {
            ConexionBD.AbrirConexion();
            bool seModificoProyecto;
            string consulta = string.Format("EXEC ModificarProyectos '{0}','{1}','{2}','{3}','{4}';",
                proyecto.Id_Proyecto, proyecto.Id_Empresa, proyecto.Id_Encargado,
                proyecto.Nombre, proyecto.Descripcion);
            seModificoProyecto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModificoProyecto;
        }
    }
}
