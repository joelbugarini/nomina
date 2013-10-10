using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace Nomina.DAC
{
    public class DeleteDAC
    {
        DBInfo Info = new DBInfo();
        public bool deletePagos(int idPagos)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pagos_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPago", idPagos);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteJustificante(int idJustificante)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Justificante_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdJustificante", idJustificante);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteIncidente(int idIncidente)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Incidente_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFalta", idIncidente);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteHorario(int idHorario)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Horario_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdHorario", idHorario);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteEmpleadoHuella(int idEmpleadoHuella)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_EmpleadoHuella_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleadoHuella", idEmpleadoHuella);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteEmpleado(int idEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteCuenta(int idCuenta)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Cuenta_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteCapacitacionEmpleado(int idCapacitacionEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_CapacitacionEmpleado_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCapacitacionEmpleado", idCapacitacionEmpleado);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteCapacitacion(int idCapacitacion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Capacitacion_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCapacitacion", idCapacitacion);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteBono(int idBono)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Bono_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdBono", idBono);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteVacaciones(int idVacaciones)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Vacaciones_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdVacaciones", idVacaciones);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteTipoHuella(int idTipoHuella)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_TipoHuella_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdTipoHuella", idTipoHuella);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteSueldo(int idSueldo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Sueldo_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSueldo", idSueldo);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deleteRegistro(int idRegistro)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Registro_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRegistro", idRegistro);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
        public bool deletePermiso(int idPermiso)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Permiso_DeleteRow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdLicencia", idPermiso);
            con.Open();

            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
