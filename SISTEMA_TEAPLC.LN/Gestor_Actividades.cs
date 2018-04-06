using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEMA_TEAPLC.MODEL;
using SISTEMA_TEAPLC.AD;
using System.Windows.Forms;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Actividades
    {
        private Conexion_BD ConexionBD = new Conexion_BD();

        public Gestor_Actividades()
        {

        }

        public void ConsultarActividadesPorColaborador(Actividad actividad, DataGridView DGV)
        {
            ConexionBD.EjecutarProcedimientoConsultarActividadesPorColaborador(DGV, actividad);
        }

        public bool InsertarActividadColaborador(Actividad nuevaActividad)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            seInserto = ConexionBD.EjecutarProcedimientoInsertarActividadColaborador(nuevaActividad);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarActividadColaborador(Actividad actividad)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            seElimino = ConexionBD.EjecutarProcedimientoEliminarActividadColaborador(actividad);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarActividadColaborador(Actividad actividad)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            seModifico = ConexionBD.EjecutarProcedimientoModificarActividadColaborador(actividad);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
    }
}
