using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SISTEMA_TEAPLC.MODEL;
using System.Configuration;
using SISTEMA_TEAPLC.AD.Properties;

namespace SISTEMA_TEAPLC.AD
{
    public class Conexion_BD
    {
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataAdapter AdaptadorDeDatos;

        private static string ObtenerConnectionString()
        {
            return Settings.Default.TEAPLC_BDConnectionString;
        }

        public void AbrirConexion()
        {
            Conexion = new SqlConnection(ObtenerConnectionString());
            Conexion.Open();
        }

        public void CerrarConexion()
        {
            Conexion.Close();
        }

        public bool EjecutarConsulta(string consulta)
        {
            int filasAfectadas = 0;
            Comando = new SqlCommand();
            Comando = Conexion.CreateCommand();
            Comando.CommandText = consulta;
            Comando.CommandType = CommandType.Text;
            filasAfectadas = Comando.ExecuteNonQuery();
            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EjecutarConsultaDeInicioDeSesion(string consulta)
        {        
            Comando = new SqlCommand();
            SqlDataReader LectorDatos;
            Comando = Conexion.CreateCommand();
            Comando.CommandText = consulta;
            Comando.CommandType = CommandType.Text;
            LectorDatos = Comando.ExecuteReader();
            if (LectorDatos.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string EjecutarConsultaParaObtenerUnaColumna(string consulta)
        {
            string resultado = "";
            Comando = new SqlCommand();
            SqlDataReader LectorDatos;
            Comando = Conexion.CreateCommand();
            Comando.CommandText = consulta;
            Comando.CommandType = CommandType.Text;
            LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                resultado = LectorDatos[0].ToString();
            }
            return resultado;
        }

        public void GetData(string consulta, DataGridView DGV)
        {
            AbrirConexion();                
            AdaptadorDeDatos = new SqlDataAdapter(consulta, Conexion);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(AdaptadorDeDatos);                
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            AdaptadorDeDatos.Fill(table);
            DGV.DataSource = table;
            CerrarConexion();
        }

        public void EjecutarProcedimientoConsultarPlanilla(DataGridView DGV, DateTime fecha)
        {
            AbrirConexion();
            DataTable tabla = new DataTable();
            AdaptadorDeDatos = new SqlDataAdapter("ConsultarPlanilla", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;
            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Fecha"].Value = fecha.Date;
            AdaptadorDeDatos.Fill(tabla);
            DGV.DataSource = tabla;
            CerrarConexion();
        }

        public bool EjecutarProcedimientoInsertarPlanilla(Planilla planilla)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("InsertarPlanilla", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdColaborador", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdColaborador"].Value = planilla.Id_Colaborador;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@NumeroHoras", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@NumeroHoras"].Value = planilla.Numero_Horas;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@PrecioHoras", SqlDbType.Money);
            AdaptadorDeDatos.SelectCommand.Parameters["@PrecioHoras"].Value = planilla.Precio_Horas;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Fecha"].Value = planilla.Fecha.Date;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@MontoPrestamo", SqlDbType.Money);
            AdaptadorDeDatos.SelectCommand.Parameters["@MontoPrestamo"].Value = planilla.Prestamo;

            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EjecutarProcedimientoModificarPlanilla(Planilla planilla)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("ModificarPlanilla", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdPlanilla", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdPlanilla"].Value = planilla.Id_Planilla;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdColaborador", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdColaborador"].Value = planilla.Id_Colaborador;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@NumeroHoras", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@NumeroHoras"].Value = planilla.Numero_Horas;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@PrecioHoras", SqlDbType.Money);
            AdaptadorDeDatos.SelectCommand.Parameters["@PrecioHoras"].Value = planilla.Precio_Horas;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Fecha"].Value = planilla.Fecha.Date;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@MontoPrestamo", SqlDbType.Money);
            AdaptadorDeDatos.SelectCommand.Parameters["@MontoPrestamo"].Value = planilla.Prestamo;

            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool EjecutarProcedimientoEliminarPlanilla(Planilla planilla)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("EliminarPlanilla", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdPlanilla", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdPlanilla"].Value = planilla.Id_Planilla;

            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();
            
            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EjecutarProcedimientoConsultarActividadesPorColaborador(DataGridView DGV, Actividad actividad)
        {
            AbrirConexion();
            DataTable tabla = new DataTable();
            AdaptadorDeDatos = new SqlDataAdapter("ConsultarActividadesPorColaborador", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;
            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdColaborador", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdColaborador"].Value = actividad.Id_Colaborador;
            AdaptadorDeDatos.Fill(tabla);
            DGV.DataSource = tabla;
            CerrarConexion();
        }

        public bool EjecutarProcedimientoInsertarActividadColaborador(Actividad actividad)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("InsertarActividadColaborador", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdColaborador", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdColaborador"].Value = actividad.Id_Colaborador;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Inicio", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Inicio"].Value = actividad.Fecha_Inicio.Date;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Finalizo", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Finalizo"].Value = actividad.Fecha_Finaliza.Date;
            
            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EjecutarProcedimientoModificarActividadColaborador(Actividad actividad)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("ModificarActividadColaborador", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdActividad", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdActividad"].Value = actividad.Id_Actividad;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdColaborador", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdColaborador"].Value = actividad.Id_Colaborador;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Inicio", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Inicio"].Value = actividad.Fecha_Inicio.Date;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@Finalizo", SqlDbType.Date);
            AdaptadorDeDatos.SelectCommand.Parameters["@Finalizo"].Value = actividad.Fecha_Finaliza.Date;

            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool EjecutarProcedimientoEliminarActividadColaborador(Actividad actividad)
        {
            int filasAfectadas = 0;

            AdaptadorDeDatos = new SqlDataAdapter("EliminarActividadColaborador", Conexion);
            AdaptadorDeDatos.SelectCommand.CommandType = CommandType.StoredProcedure;

            AdaptadorDeDatos.SelectCommand.Parameters.Add("@IdActividad", SqlDbType.Int);
            AdaptadorDeDatos.SelectCommand.Parameters["@IdActividad"].Value = actividad.Id_Actividad;

            filasAfectadas = AdaptadorDeDatos.SelectCommand.ExecuteNonQuery();

            if (filasAfectadas > 0)
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
