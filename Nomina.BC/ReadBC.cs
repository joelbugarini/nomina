using Properties;
using System.Collections.Generic;
using Nomina.DAC;

namespace Nomina.BC
{
    public class ReadBC
    {
        public List<Pagos> ReadPagos()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readPagos();
        }

        public List<Registro> ReadCustomQuery(string query)
        {
            ReadDAC objDAC = new ReadDAC();

            return objDAC.CustomRead(query);
        }

        public List<Justificante> ReadJustificante()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readJustificante();
        }
        public List<Incidente> ReadIncidente()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readIncidente();
        }
        public List<Horario> ReadHorario()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readHorario();
        }
        public List<EmpleadoHuella> ReadEmpleadoHuella()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEmpleadoHuella();
        }
        public List<Empleado> ReadEmpleado()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readEmpleado();
        }
        public List<Cuenta> ReadCuenta()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readCuenta();
        }
        public List<CapacitacionEmpleado> ReadCapacitacionEmpleado()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readCapacitacionEmpleado();
        }
        public List<Capacitacion> ReadCapacitacion()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readCapacitacion();
        }
        public List<Bono> ReadBono()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readBono();
        }
        public List<Vacaciones> ReadVacaciones()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readVacaciones();
        }
        public List<TipoHuella> ReadTipoHuella()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readTipoHuella();
        }

        public List<Registro> ReadRegistro()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readRegistro();
        }
        public List<Permiso> ReadPermiso()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readPermiso();
        }

        public List<Sueldo> ReadSueldo()
        {

            ReadDAC objDAC = new ReadDAC();

            return objDAC.readSueldo();
        }

    }
}