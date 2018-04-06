using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_TEAPLC.AD;
using SISTEMA_TEAPLC.MODEL;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Trabajos
    {
        Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Trabajos()
        {

        }

        public void MostrarTrabajosProyectos(Trabajo trabajoProyecto, DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarTrabajosProyecto '{0}';", trabajoProyecto.Id_Proyecto);
            ConexionBD.GetData(consulta, DGV);

        }

        public string ObtenerMontoTotalPorProyecto(Trabajo trabajoProyecto)
        {
            string consulta = string.Format("select SUM(Monto_Total) from Tabla_Trabajos where Id_Proyecto ='{0}';",
                trabajoProyecto.Id_Proyecto);
            string montoTotal = "";
            ConexionBD.AbrirConexion();
            montoTotal = ConexionBD.EjecutarConsultaParaObtenerUnaColumna(consulta);
            ConexionBD.CerrarConexion();
            return montoTotal;
        }

        public string ObtenerIdEncargado(Trabajo trabajoProyecto)
        {
            string consulta = string.Format("select Id_Encargado from Tabla_Proyectos where Id_Proyecto ='{0}';",
                trabajoProyecto.Id_Proyecto);
            string idEncagado = "";
            ConexionBD.AbrirConexion();
            idEncagado = ConexionBD.EjecutarConsultaParaObtenerUnaColumna(consulta);
            ConexionBD.CerrarConexion();
            return idEncagado;
        }

        public bool InsertarTrabajo(Trabajo nuevoTrabajo)
        {
            ConexionBD.AbrirConexion();
            bool seInsertoTrabajo;
            string consulta = string.Format(
                "EXEC InsertarTrabajo '{0}','{1}','{2}','{3}','{4}';",
                nuevoTrabajo.Id_Proyecto, nuevoTrabajo.Tipo_Trabajo,
                nuevoTrabajo.Id_Tipo_Forro, nuevoTrabajo.Area,
                nuevoTrabajo.Precio);
            seInsertoTrabajo = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInsertoTrabajo;
        }

        public bool EliminarTrabajos(Trabajo trabajo)
        {
            ConexionBD.AbrirConexion();
            bool seEliminoTrabajo;
            string consulta = string.Format("EXEC EliminarTrabajo '{0}';",
                trabajo.Id_Trabajo);
            seEliminoTrabajo = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seEliminoTrabajo;
        }

        public bool ModificarTrabajos(Trabajo trabajo)
        {
            ConexionBD.AbrirConexion();
            bool seModificoTrabajo;
            string consulta = string.Format(
                "EXEC ModificarTrabajo '{0}','{1}','{2}','{3}','{4}','{5}';",
                trabajo.Id_Trabajo, trabajo.Id_Proyecto, trabajo.Tipo_Trabajo, trabajo.Id_Tipo_Forro,
                trabajo.Area, trabajo.Precio);
            seModificoTrabajo = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModificoTrabajo;
        }
//--------------------------------------Tipo de Trabajos--------------------------------------//
        public bool InsertarTipoTrabajo(Tipo_Trabajo nuevoTipoTrabajo)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format(
                "Insert into Tabla_Tipos_Trabajos values ('{0}');",
                nuevoTipoTrabajo.Descripcion);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarTipoTrabajos(Tipo_Trabajo tipoTrabajo)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format(
                "delete from Tabla_Tipos_Trabajos where Id_Tipo_Trabajo = {0};",
                tipoTrabajo.Id_Tipo_Trabajo);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarTipoTrabajos(Tipo_Trabajo tipoTrabajo)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format(
                "update Tabla_Tipos_Trabajos set Descripcion = '{0}' where Id_Tipo_Trabajo = {1};",
                tipoTrabajo.Descripcion,tipoTrabajo.Id_Tipo_Trabajo);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
        //--------------------------------------Tipo de Forro--------------------------------------//
        public bool InsertarTipoForro(Tipo_Forro nuevoTipoForro)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format(
                "Insert into Tabla_Tipos_Forros values ('{0}');",
                nuevoTipoForro.Descripcion);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarTipoForros(Tipo_Forro tipoForro)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format(
                "delete from Tabla_Tipos_Forros where Id_Tipo_Forro = {0};",
                tipoForro.Id_Tipo_Forro);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarTipoForro(Tipo_Forro tipoForro)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format(
                "update Tabla_Tipos_Forros set Descripcion = '{0}' where Id_Tipo_Forro = {1};",
                tipoForro.Descripcion, tipoForro.Id_Tipo_Forro);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
    }
}
