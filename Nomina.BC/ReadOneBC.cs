using Properties;
using System.Collections.Generic;
using Nomina.DAC;

namespace Nomina.BC
{
    public class ReadOneBC
    {
        public Pagos ReadOnePagos(int idPagos)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOnePagos(idPagos);
        }
        public Justificante ReadOneJustificante(int idJustificante)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneJustificante(idJustificante);
        }
        public Incidente ReadOneIncidente(int idIncidente)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneIncidente(idIncidente);
        }
        public Horario ReadOneHorario(int idHorario)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneHorario(idHorario);
        }
        public EmpleadoHuella ReadOneEmpleadoHuella(int idEmpleadoHuella)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneEmpleadoHuella(idEmpleadoHuella);
        }
        public Empleado ReadOneEmpleado(int idEmpleado)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneEmpleado(idEmpleado);
        }
        public Cuenta ReadOneCuenta(int idCuenta)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneCuenta(idCuenta);
        }
        public CapacitacionEmpleado ReadOneCapacitacionEmpleado(int idCapacitacionEmpleado)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneCapacitacionEmpleado(idCapacitacionEmpleado);
        }
        public Capacitacion ReadOneCapacitacion(int idCapacitacion)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneCapacitacion(idCapacitacion);
        }
        public Bono ReadOneBono(int idBono)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneBono(idBono);
        }
        public Vacaciones ReadOneVacaciones(int idVacaciones)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneVacaciones(idVacaciones);
        }
        public TipoHuella ReadOneTipoHuella(int idTipoHuella)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneTipoHuella(idTipoHuella);
        }

        public Registro ReadOneRegistro(int idRegistro)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneRegistro(idRegistro);
        }
        public Permiso ReadOnePermiso(int idPermiso)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOnePermiso(idPermiso);
        }
        public Sueldo ReadOneSueldo(int idSueldo)
        {

            ReadOneDAC objDAC = new ReadOneDAC();

            return objDAC.readOneSueldo(idSueldo);
        }
    }
}