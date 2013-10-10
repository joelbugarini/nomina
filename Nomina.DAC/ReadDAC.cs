using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Properties;
using System.Data;
using System.Data.SqlClient;

namespace Nomina.DAC
{
    public class ReadDAC
    {
        DBInfo Info = new DBInfo();

        public List<Registro> CustomRead(string query)
        {
            List<Registro> registroList = new List<Registro>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Registro tmp = new Registro();

                        tmp.IdRegistro = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdRegistro;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Estado = (reader.GetValue(2) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(2)) : tmp.Estado;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        registroList.Add(tmp);
                    }
                }

                con.Close();
            }

            return registroList;
        }

        public List<Pagos> readPagos()
        {
            List<Pagos> pagosList = new List<Pagos>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Pagos_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Pagos tmp = new Pagos();

                        tmp.IdPago = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdPago;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Monto = (reader.GetValue(2) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(2)) : tmp.Monto;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        pagosList.Add(tmp);
                    }
                }

                con.Close();
            }

            return pagosList;
        }
        public List<Justificante> readJustificante()
        {
            List<Justificante> justificanteList = new List<Justificante>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Justificante_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Justificante tmp = new Justificante();

                        tmp.IdJustificante = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdJustificante;
                        tmp.IdIncidente = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdIncidente;
                        tmp.Descripcion = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Descripcion;

                        justificanteList.Add(tmp);
                    }
                }

                con.Close();
            }

            return justificanteList;
        }
        public List<Incidente> readIncidente()
        {
            List<Incidente> incidenteList = new List<Incidente>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Incidente_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Incidente tmp = new Incidente();

                        tmp.IdFalta = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdFalta;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Tipo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Tipo;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        incidenteList.Add(tmp);
                    }
                }

                con.Close();
            }

            return incidenteList;
        }
        public List<Horario> readHorario()
        {
            List<Horario> horarioList = new List<Horario>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Horario_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Horario tmp = new Horario();

                        tmp.IdHorario = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdHorario;
                        tmp.HoraIn = (reader.GetValue(1) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(1)) : tmp.HoraIn;
                        tmp.HoraOut = (reader.GetValue(2) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(2)) : tmp.HoraOut;
                        tmp.HoraInMed = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.HoraInMed;
                        tmp.HoraOutMed = (reader.GetValue(4) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(4)) : tmp.HoraOutMed;
                        tmp.Lunes = (reader.GetValue(5) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(5)) : tmp.Lunes;
                        tmp.Martes = (reader.GetValue(6) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(6)) : tmp.Martes;
                        tmp.Miercoles = (reader.GetValue(7) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(7)) : tmp.Miercoles;
                        tmp.Jueves = (reader.GetValue(8) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(8)) : tmp.Jueves;
                        tmp.Viernes = (reader.GetValue(9) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(9)) : tmp.Viernes;
                        tmp.Sabado = (reader.GetValue(10) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(10)) : tmp.Sabado;
                        tmp.Domingo = (reader.GetValue(11) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(11)) : tmp.Domingo;

                        horarioList.Add(tmp);
                    }
                }

                con.Close();
            }

            return horarioList;
        }
        public List<EmpleadoHuella> readEmpleadoHuella()
        {
            List<EmpleadoHuella> empleadoHuellaList = new List<EmpleadoHuella>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_EmpleadoHuella_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        EmpleadoHuella tmp = new EmpleadoHuella();

                        tmp.IdEmpleadoHuella = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEmpleadoHuella;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.IdTipoHuella = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdTipoHuella;
                        tmp.Huella = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.Huella;

                        empleadoHuellaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return empleadoHuellaList;
        }
        public List<Empleado> readEmpleado()
        {
            List<Empleado> empleadoList = new List<Empleado>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Empleado_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Empleado tmp = new Empleado();

                        tmp.IdEmpleado = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdEmpleado;
                        tmp.Nombre = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nombre;
                        tmp.ApellidoPaterno = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.ApellidoPaterno;
                        tmp.ApellidoMaterno = (reader.GetValue(3) != DBNull.Value) ? Convert.ToString(reader.GetValue(3)) : tmp.ApellidoMaterno;
                        tmp.Estado = (reader.GetValue(4) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(4)) : tmp.Estado;
                        tmp.Turno = (reader.GetValue(5) != DBNull.Value) ? Convert.ToString(reader.GetValue(5)) : tmp.Turno;
                        tmp.Departamento = (reader.GetValue(6) != DBNull.Value) ? Convert.ToString(reader.GetValue(6)) : tmp.Departamento;
                        tmp.NoEmpleado = (reader.GetValue(7) != DBNull.Value) ? Convert.ToString(reader.GetValue(7)) : tmp.NoEmpleado;
                        tmp.Domicilio = (reader.GetValue(8) != DBNull.Value) ? Convert.ToString(reader.GetValue(8)) : tmp.Domicilio;
                        tmp.Telefono = (reader.GetValue(9) != DBNull.Value) ? Convert.ToString(reader.GetValue(9)) : tmp.Telefono;
                        tmp.FechaNac = (reader.GetValue(10) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(10)) : tmp.FechaNac;
                        tmp.EstadoCivil = (reader.GetValue(11) != DBNull.Value) ? Convert.ToString(reader.GetValue(11)) : tmp.EstadoCivil;
                        tmp.Correo = (reader.GetValue(12) != DBNull.Value) ? Convert.ToString(reader.GetValue(12)) : tmp.Correo;
                        tmp.NacDomicilio = (reader.GetValue(13) != DBNull.Value) ? Convert.ToString(reader.GetValue(13)) : tmp.NacDomicilio;
                        tmp.Sangre = (reader.GetValue(14) != DBNull.Value) ? Convert.ToString(reader.GetValue(14)) : tmp.Sangre;
                        tmp.Educacion = (reader.GetValue(15) != DBNull.Value) ? Convert.ToString(reader.GetValue(15)) : tmp.Educacion;
                        tmp.TituloProf = (reader.GetValue(16) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(16)) : tmp.TituloProf;
                        tmp.FechaAlta = (reader.GetValue(17) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(17)) : tmp.FechaAlta;
                        tmp.FechaBaja = (reader.GetValue(18) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(18)) : tmp.FechaBaja;
                        tmp.Baja = (reader.GetValue(19) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(19)) : tmp.Baja;
                        tmp.Categoria = (reader.GetValue(20) != DBNull.Value) ? Convert.ToString(reader.GetValue(20)) : tmp.Categoria;
                        tmp.IdSueldo = (reader.GetValue(21) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(21)) : tmp.IdSueldo;
                        tmp.Salario = (reader.GetValue(22) != DBNull.Value) ? Convert.ToDouble(reader.GetValue(22)) : tmp.Salario;

                        empleadoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return empleadoList;
        }
        public List<Cuenta> readCuenta()
        {
            List<Cuenta> cuentaList = new List<Cuenta>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Cuenta_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Cuenta tmp = new Cuenta();

                        tmp.IdCuenta = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdCuenta;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Saldo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(2)) : tmp.Saldo;
                        tmp.SaldoNeto = (reader.GetValue(3) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(3)) : tmp.SaldoNeto;

                        cuentaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return cuentaList;
        }
        public List<CapacitacionEmpleado> readCapacitacionEmpleado()
        {
            List<CapacitacionEmpleado> capacitacionEmpleadoList = new List<CapacitacionEmpleado>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_CapacitacionEmpleado_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        CapacitacionEmpleado tmp = new CapacitacionEmpleado();

                        tmp.IdCapacitacionEmpleado = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdCapacitacionEmpleado;
                        tmp.IdCapacitacion = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdCapacitacion;
                        tmp.IdEmpleado = (reader.GetValue(2) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(2)) : tmp.IdEmpleado;

                        capacitacionEmpleadoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return capacitacionEmpleadoList;
        }
        public List<Capacitacion> readCapacitacion()
        {
            List<Capacitacion> capacitacionList = new List<Capacitacion>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Capacitacion_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Capacitacion tmp = new Capacitacion();

                        tmp.IdCapacitacion = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdCapacitacion;
                        tmp.Nombre = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nombre;
                        tmp.Imparte = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Imparte;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;
                        tmp.Duracion = (reader.GetValue(4) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(4)) : tmp.Duracion;

                        capacitacionList.Add(tmp);
                    }
                }

                con.Close();
            }

            return capacitacionList;
        }
        public List<Bono> readBono()
        {
            List<Bono> bonoList = new List<Bono>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Bono_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Bono tmp = new Bono();

                        tmp.IdBono = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdBono;
                        tmp.Descripcion = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Descripcion;
                        tmp.Clave = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Clave;
                        tmp.Monto = (reader.GetValue(3) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(3)) : tmp.Monto;

                        bonoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return bonoList;
        }
        public List<Vacaciones> readVacaciones()
        {
            List<Vacaciones> vacacionesList = new List<Vacaciones>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Vacaciones_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Vacaciones tmp = new Vacaciones();

                        tmp.IdVacaciones = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdVacaciones;
                        tmp.Inicio = (reader.GetValue(1) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(1)) : tmp.Inicio;
                        tmp.Fin = (reader.GetValue(2) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(2)) : tmp.Fin;
                        tmp.Activa = (reader.GetValue(3) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(3)) : tmp.Activa;

                        vacacionesList.Add(tmp);
                    }
                }

                con.Close();
            }

            return vacacionesList;
        }
        public List<TipoHuella> readTipoHuella()
        {
            List<TipoHuella> tipoHuellaList = new List<TipoHuella>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_TipoHuella_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        TipoHuella tmp = new TipoHuella();

                        tmp.IdTipoHuella = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdTipoHuella;
                        tmp.Clave = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Clave;
                        tmp.Descripcion = (reader.GetValue(2) != DBNull.Value) ? Convert.ToString(reader.GetValue(2)) : tmp.Descripcion;

                        tipoHuellaList.Add(tmp);
                    }
                }

                con.Close();
            }

            return tipoHuellaList;
        }

        public List<Registro> readRegistro()
        {
            List<Registro> registroList = new List<Registro>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Registro_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Registro tmp = new Registro();

                        tmp.IdRegistro = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdRegistro;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Estado = (reader.GetValue(2) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(2)) : tmp.Estado;
                        tmp.Fecha = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.Fecha;

                        registroList.Add(tmp);
                    }
                }

                con.Close();
            }

            return registroList;
        }
        public List<Permiso> readPermiso()
        {
            List<Permiso> permisoList = new List<Permiso>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Permiso_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Permiso tmp = new Permiso();

                        tmp.IdLicencia = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdLicencia;
                        tmp.IdEmpleado = (reader.GetValue(1) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(1)) : tmp.IdEmpleado;
                        tmp.Activo = (reader.GetValue(2) != DBNull.Value) ? Convert.ToBoolean(reader.GetValue(2)) : tmp.Activo;
                        tmp.HoraIn = (reader.GetValue(3) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(3)) : tmp.HoraIn;
                        tmp.HoraOut = (reader.GetValue(4) != DBNull.Value) ? Convert.ToDateTime(reader.GetValue(4)) : tmp.HoraOut;

                        permisoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return permisoList;
        }

        public List<Sueldo> readSueldo()
        {
            List<Sueldo> sueldoList = new List<Sueldo>();

            using (SqlConnection con = new SqlConnection(Info.sqlSet()))
            {
                SqlCommand cmd = new SqlCommand("SP_Sueldo_SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Loop through each record.
                    while (reader.Read())
                    {
                        Sueldo tmp = new Sueldo();

                        tmp.IdSueldo = (reader.GetValue(0) != DBNull.Value) ? Convert.ToInt32(reader.GetValue(0)) : tmp.IdSueldo;
                        tmp.Nivel = (reader.GetValue(1) != DBNull.Value) ? Convert.ToString(reader.GetValue(1)) : tmp.Nivel;
                        tmp.SueldoMin = (reader.GetValue(2) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(2)) : tmp.SueldoMin;
                        tmp.SueldoMax = (reader.GetValue(3) != DBNull.Value) ? Convert.ToSingle(reader.GetValue(3)) : tmp.SueldoMax;

                        sueldoList.Add(tmp);
                    }
                }

                con.Close();
            }

            return sueldoList;
        }
    }
}
