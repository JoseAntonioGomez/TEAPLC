using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEMA_TEAPLC.AD;
using SISTEMA_TEAPLC.MODEL;

namespace SISTEMA_TEAPLC.LN
{
    public class Gestor_Usuarios
    {
        Conexion_BD ConexionBD = new Conexion_BD();
        public Gestor_Usuarios()
        {

        }

        public bool ActualizarUsuario(Usuario nuevoUsuario, Usuario viejoUsuario)
        {
            bool seActualizoUsuario;
            ConexionBD.AbrirConexion();
            string consulta = string.Format(
                "EXEC ModificarUsuario '{0}','{1}','{2}','{3}';",
                viejoUsuario.Nombre_Usuario, viejoUsuario.Password,
                nuevoUsuario.Nombre_Usuario, nuevoUsuario.Password);
            seActualizoUsuario = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seActualizoUsuario;
        }

        public bool IniciarSesion(Usuario usuario)
        {
            ConexionBD.AbrirConexion();
            string consulta = string.Format(
                "EXEC IniciarSesionUsuario '{0}','{1}';",
                usuario.Nombre_Usuario, usuario.Password);
            bool existeCuenta;
            existeCuenta = ConexionBD.EjecutarConsultaDeInicioDeSesion(consulta);
            ConexionBD.CerrarConexion();
            if (existeCuenta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
