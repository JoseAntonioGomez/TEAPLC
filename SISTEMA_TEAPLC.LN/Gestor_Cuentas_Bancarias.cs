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
    public class Gestor_Cuentas_Bancarias
    {
        Conexion_BD ConexionBD = new Conexion_BD();

        public Gestor_Cuentas_Bancarias()
        {

        }

        public void ConsultarCuentas(Cuenta cuenta, DataGridView DGV)
        {
            string consulta = string.Format("EXEC ConsultarCuentas '{0}';",
                cuenta.Id_Colaborador);
            ConexionBD.GetData(consulta, DGV);
        }

        public bool InsertarCuenta(Cuenta nuevaCuenta)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format(
                "EXEC InsertarCuenta '{0}','{1}','{2}','{3}','{4}','{5}';",
                nuevaCuenta.Id_Colaborador, nuevaCuenta.Numero_Cuenta,
                nuevaCuenta.Numero_Cuenta_Cliente, nuevaCuenta.Id_Banco,
                nuevaCuenta.Id_Moneda, nuevaCuenta.Id_Tipo_Cuenta);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarCuenta(Cuenta cuenta)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format("EXEC EliminarCuenta '{0}';",
                cuenta.Id_Cuenta);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarCuenta(Cuenta cuenta)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format(
                "EXEC ModificarCuenta '{0}','{1}','{2}','{3}','{4}','{5}','{6}';",
                cuenta.Id_Cuenta, cuenta.Id_Colaborador, 
                cuenta.Numero_Cuenta, cuenta.Numero_Cuenta_Cliente, 
                cuenta.Id_Banco, cuenta.Id_Moneda, cuenta.Id_Tipo_Cuenta);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
        //--------------------------------------Banco--------------------------------------//
        public bool InsertarBanco(Banco nuevoBanco)
        {
            ConexionBD.AbrirConexion();
            bool seInserto;
            string consulta = string.Format(
                "Insert into Tabla_Bancos values ('{0}');",
                nuevoBanco.Nombre);
            seInserto = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seInserto;
        }

        public bool EliminarBanco(Banco banco)
        {
            ConexionBD.AbrirConexion();
            bool seElimino;
            string consulta = string.Format(
                "delete from Tabla_Bancos where Id_Banco = {0};",
                banco.Id_Banco);
            seElimino = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seElimino;
        }

        public bool ModificarBanco(Banco banco)
        {
            ConexionBD.AbrirConexion();
            bool seModifico;
            string consulta = string.Format(
                "update Tabla_Bancos set Nombre = '{0}' where Id_Banco = {1};",
                banco.Nombre, banco.Id_Banco);
            seModifico = ConexionBD.EjecutarConsulta(consulta);
            ConexionBD.CerrarConexion();
            return seModifico;
        }
    }
}
