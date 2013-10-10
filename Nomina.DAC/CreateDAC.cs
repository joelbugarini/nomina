using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace Nomina.DAC
{
    public class CreateDAC
    {
        DBInfo Info = new DBInfo();
        public bool CreateRecord(Pagos obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Pagos_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Justificante obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Justificante_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Incidente obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Incidente_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Horario obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Horario_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(EmpleadoHuella obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_EmpleadoHuella_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Empleado obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Empleado_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", obj.ApellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", obj.ApellidoMaterno);
            cmd.Parameters.AddWithValue("@Estado", obj.Estado);
            cmd.Parameters.AddWithValue("@Turno", obj.Turno);
            cmd.Parameters.AddWithValue("@Departamento", obj.Departamento);
            cmd.Parameters.AddWithValue("@NoEmpleado", obj.NoEmpleado);
            cmd.Parameters.AddWithValue("@Domicilio", obj.Domicilio);
            cmd.Parameters.AddWithValue("@Telefono", obj.Telefono);
            cmd.Parameters.AddWithValue("@FechaNac", obj.FechaNac);
            cmd.Parameters.AddWithValue("@EstadoCivil", obj.EstadoCivil);
            cmd.Parameters.AddWithValue("@Correo", obj.Correo);
            cmd.Parameters.AddWithValue("@NacDomicilio", obj.NacDomicilio);
            cmd.Parameters.AddWithValue("@Sangre", obj.Sangre);
            cmd.Parameters.AddWithValue("@Educacion", obj.Educacion);
            cmd.Parameters.AddWithValue("@TituloProf", obj.TituloProf);
            cmd.Parameters.AddWithValue("@FechaAlta", obj.FechaAlta);
            cmd.Parameters.AddWithValue("@FechaBaja", obj.FechaBaja);
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
        public bool CreateRecord(Cuenta obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Cuenta_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(CapacitacionEmpleado obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_CapacitacionEmpleado_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Capacitacion obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Capacitacion_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Bono obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Bono_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Vacaciones obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Vacaciones_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(TipoHuella obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_TipoHuella_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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

        public bool CreateRecord(Registro obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Registro_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
        public bool CreateRecord(Permiso obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Permiso_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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


        public bool CreateRecord(Sueldo obj)
        {
            SqlConnection con = new SqlConnection(Info.sqlSet());
            SqlCommand cmd = new SqlCommand("SP_Sueldo_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
