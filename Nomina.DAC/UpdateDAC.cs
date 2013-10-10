using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace Nomina.DAC
{
    public class UpdateDAC
    {
        DBInfo Info = new DBInfo();
        public bool UpdateRecord(Pagos obj, int idPagos)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pagos_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdPago", idPagos);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Monto", obj.Monto);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
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
        public bool UpdateRecord(Justificante obj, int idJustificante)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Justificante_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdJustificante", idJustificante);
            cmd.Parameters.AddWithValue("@IdIncidente", obj.IdIncidente);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
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
        public bool UpdateRecord(Incidente obj, int idIncidente)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Incidente_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFalta", idIncidente);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Tipo", obj.Tipo);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
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
        public bool UpdateRecord(Horario obj, int idHorario)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Horario_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdHorario", idHorario);
            cmd.Parameters.AddWithValue("@HoraIn", obj.HoraIn);
            cmd.Parameters.AddWithValue("@HoraOut", obj.HoraOut);
            cmd.Parameters.AddWithValue("@HoraInMed", obj.HoraInMed);
            cmd.Parameters.AddWithValue("@HoraOutMed", obj.HoraOutMed);
            cmd.Parameters.AddWithValue("@Lunes", obj.Lunes);
            cmd.Parameters.AddWithValue("@Martes", obj.Martes);
            cmd.Parameters.AddWithValue("@Miercoles", obj.Miercoles);
            cmd.Parameters.AddWithValue("@Jueves", obj.Jueves);
            cmd.Parameters.AddWithValue("@Viernes", obj.Viernes);
            cmd.Parameters.AddWithValue("@Sabado", obj.Sabado);
            cmd.Parameters.AddWithValue("@Domingo", obj.Domingo);
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
        public bool UpdateRecord(EmpleadoHuella obj, int idEmpleadoHuella)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_EmpleadoHuella_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleadoHuella", idEmpleadoHuella);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@IdTipoHuella", obj.IdTipoHuella);
            cmd.Parameters.AddWithValue("@Huella", obj.Huella);
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
        public bool UpdateRecord(Empleado obj, int idEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", obj.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", obj.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Turno", obj.Turno);
            cmd.Parameters.AddWithValue("@Departamento", obj.Departamento);
            cmd.Parameters.AddWithValue("@NoEmpleado", obj.NoEmpleado);
            cmd.Parameters.AddWithValue("@Domicilio", obj.Domicilio);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("@FechaNac", Utils.NullDate(obj.FechaNac.ToString()));
            cmd.Parameters.AddWithValue("@EstadoCivil", obj.EstadoCivil);
            cmd.Parameters.AddWithValue("@Correo", obj.Correo);
            cmd.Parameters.AddWithValue("@NacDomicilio", obj.NacDomicilio);
            cmd.Parameters.AddWithValue("@Sangre", obj.Sangre);
            cmd.Parameters.AddWithValue("@Educacion", obj.Educacion);
            cmd.Parameters.AddWithValue("@TituloProf", obj.TituloProf);
            cmd.Parameters.AddWithValue("@FechaAlta", Utils.NullDate(obj.FechaAlta.ToString()));
            cmd.Parameters.AddWithValue("@FechaBaja", Utils.NullDate(obj.FechaBaja.ToString()));
            cmd.Parameters.AddWithValue("@Baja", obj.Baja);
            cmd.Parameters.AddWithValue("@Categoria", obj.Categoria);
            cmd.Parameters.AddWithValue("@IdSueldo", obj.IdSueldo);
            cmd.Parameters.AddWithValue("@Salario", obj.Salario);
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
        public bool UpdateRecord(Cuenta obj, int idCuenta)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Cuenta_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCuenta", idCuenta);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Saldo", obj.Saldo);
            cmd.Parameters.AddWithValue("@SaldoNeto", obj.SaldoNeto);
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
        public bool UpdateRecord(CapacitacionEmpleado obj, int idCapacitacionEmpleado)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_CapacitacionEmpleado_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCapacitacionEmpleado", idCapacitacionEmpleado);
            cmd.Parameters.AddWithValue("@IdCapacitacion", obj.IdCapacitacion);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
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
        public bool UpdateRecord(Capacitacion obj, int idCapacitacion)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Capacitacion_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCapacitacion", idCapacitacion);
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@Imparte", obj.Imparte);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
            cmd.Parameters.AddWithValue("@Duracion", obj.Duracion);
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
        public bool UpdateRecord(Bono obj, int idBono)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Bono_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdBono", idBono);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
            cmd.Parameters.AddWithValue("@Clave", obj.Clave);
            cmd.Parameters.AddWithValue("@Monto", obj.Monto);
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
        public bool UpdateRecord(Vacaciones obj, int idVacaciones)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Vacaciones_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdVacaciones", idVacaciones);
            cmd.Parameters.AddWithValue("@Inicio", obj.Inicio);
            cmd.Parameters.AddWithValue("@Fin", obj.Fin);
            cmd.Parameters.AddWithValue("@Activa", obj.Activa);
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
        public bool UpdateRecord(TipoHuella obj, int idTipoHuella)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_TipoHuella_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdTipoHuella", idTipoHuella);
            cmd.Parameters.AddWithValue("@Clave", obj.Clave);
            cmd.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
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

        public bool UpdateRecord(Registro obj, int idRegistro)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Registro_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdRegistro", idRegistro);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Fecha", obj.Fecha);
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
        public bool UpdateRecord(Permiso obj, int idPermiso)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Permiso_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdLicencia", idPermiso);
            cmd.Parameters.AddWithValue("@IdEmpleado", obj.IdEmpleado);
            cmd.Parameters.AddWithValue("@Activo", obj.Activo);
            cmd.Parameters.AddWithValue("@HoraIn", obj.HoraIn);
            cmd.Parameters.AddWithValue("@HoraOut", obj.HoraOut);
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
        public bool UpdateRecord(Sueldo obj, int idSueldo)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Sueldo_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdSueldo", idSueldo);
            cmd.Parameters.AddWithValue("@Nivel", obj.Nivel);
            cmd.Parameters.AddWithValue("@SueldoMin", obj.SueldoMin);
            cmd.Parameters.AddWithValue("@SueldoMax", obj.SueldoMax);
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
            