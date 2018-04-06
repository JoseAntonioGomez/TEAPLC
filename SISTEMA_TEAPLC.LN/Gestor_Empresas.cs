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
    public class Gestor_Empresas
    {
        private Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Empresas()
        {

        }

        public void MostrarEmpresas(DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarEmpresas;");
            ConexionBD.GetData(consulta, DGV);
        }

        public bool InsertarEmpresas(Empresa nuevaEmpresa)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format("EXEC InsertarEmpresas '{0}','{1}','{2}','{3}';",
                nuevaEmpresa.Nombre, nuevaEmpresa.Telefono,
                nuevaEmpresa.Correo, nuevaEmpresa.Direccion);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarEmpresas(Empresa empresa)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format("EXEC EliminarEmpresas '{0}';",
                empresa.Id_Empresa);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarEmpresas(Empresa empresa)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format("EXEC ModificarEmpresas '{0}','{1}','{2}','{3}','{4}';",
                empresa.Id_Empresa, empresa.Nombre, 
                empresa.Telefono, empresa.Correo, empresa.Direccion);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
    }
}
