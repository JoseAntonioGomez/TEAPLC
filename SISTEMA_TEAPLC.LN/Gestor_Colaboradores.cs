using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_TEAPLC.AD;
using SISTEMA_TEAPLC.MODEL;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Colaboradores
    {
        Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Colaboradores()
        {

        }
        public void MostrarColaboradores(string colaborador,DataGridView DGV)
        {
            string consulta = string.Format("EXEC BuscarColaborador '{0}%';",colaborador);
            ConexionBD.GetData(consulta, DGV);
            
        }

        public bool InsertarColaborador(Colaborador nuevoColaborador)
        {
            ConexionBD.AbrirConexion();
            bool seInsertoColaborador;
            string consulta = string.Format("EXEC InsertarColaborador '{0}','{1}','{2}','{3}','{4}';",
                nuevoColaborador.Nombre, nuevoColaborador.Cedula,nuevoColaborador.Telefono,
                nuevoColaborador.Correo,nuevoColaborador.Direccion);
            seInsertoColaborador = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInsertoColaborador;
        }

        public bool EliminarColaborador(Colaborador colaborador)
        {
            ConexionBD.AbrirConexion();
            bool seEliminoColaborador;
            string consulta = string.Format("EXEC EliminarColaborador '{0}';",
                colaborador.Id_Colaborador);
            seEliminoColaborador = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seEliminoColaborador;
        }

        public bool ModificarColaborador(Colaborador colaborador)
        {
            ConexionBD.AbrirConexion();
            bool seModificoColaborador;
            string consulta = string.Format("EXEC ModificarColaborador '{0}','{1}','{2}','{3}','{4}','{5}';",
                colaborador.Id_Colaborador, colaborador.Nombre, colaborador.Cedula, colaborador.Telefono,
                colaborador.Correo, colaborador.Direccion);
            seModificoColaborador = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModificoColaborador;
        }

    }
}
