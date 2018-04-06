using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_TEAPLC.MODEL;
using SISTEMA_TEAPLC.AD;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Prestamos
    {
        Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Prestamos()
        {

        }
        public void ConsultarPrestamos(Prestamo prestamo, DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarPrestamos '{0}','{1}';",
                prestamo.Id_Colaborador, prestamo.Id_Estado);
            ConexionBD.GetData(consulta,DGV);

        }

        public void ConsultarTodosLosPrestamos(Prestamo prestamo, DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarTodoLosPrestamos '{0}';",
                prestamo.Id_Colaborador);
            ConexionBD.GetData(consulta, DGV);

        }

        public bool CancelarUnPrestamo(Prestamo prestamo)
        {
            ConexionBD.AbrirConexion();
            bool seCancelo;
            string consulta = string.Format("EXEC CancelarUnPrestamo '{0}','{1}';",
                prestamo.Id_Prestamo, prestamo.MontoPendiente);
            seCancelo = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seCancelo;
        }

        public string CancelarTodosLosPrestamosPorColaborador(Prestamo prestamo)
        {
            ConexionBD.AbrirConexion();
            string seCancelo;
            string consulta = string.Format("EXEC CancelarTodosLosPrestamosPorColaborador '{0}';",
                prestamo.Id_Colaborador);
            seCancelo = ConexionBD.EjecutarConsultaParaObtenerUnaColumna(consulta);
            ConexionBD.CerrarConexion();
            return seCancelo;
        }


        public bool InsertarPrestamos(Prestamo nuevaPrestamo)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format("EXEC InsertarPrestamo '{0}','{1}','{2}';",
                nuevaPrestamo.Id_Colaborador, nuevaPrestamo.Descripcion,
                nuevaPrestamo.Monto);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarPrestamos(Prestamo prestamo)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format("EXEC EliminarPrestamo '{0}';",
                prestamo.Id_Prestamo);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarPrestamos(Prestamo prestamo)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format("EXEC ModificarPrestamo '{0}','{1}','{2}','{3}';",
                prestamo.Id_Prestamo, prestamo.Id_Colaborador,
                prestamo.Descripcion, prestamo.Monto);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }




    }
}
