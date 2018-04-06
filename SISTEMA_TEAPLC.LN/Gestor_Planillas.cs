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
    public class Gestor_Planillas
    {
        private Conexion_BD ConexionBD = new Conexion_BD();

        public Gestor_Planillas()
        {

        }

        public void ConsultarPlanilla(Planilla planilla,DataGridView DGV)
        {
            ConexionBD.EjecutarProcedimientoConsultarPlanilla(DGV,planilla.Fecha);
        }

        public bool InsertarPlanilla(Planilla nuevaPlanilla)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            seInserto = ConexionBD.EjecutarProcedimientoInsertarPlanilla(nuevaPlanilla);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarPlanilla(Planilla planilla)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            seElimino = ConexionBD.EjecutarProcedimientoEliminarPlanilla(planilla);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarPlanilla(Planilla planilla)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            seModifico = ConexionBD.EjecutarProcedimientoModificarPlanilla(planilla);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
    }
}
