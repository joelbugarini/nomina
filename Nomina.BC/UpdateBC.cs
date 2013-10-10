using Properties;
using Nomina.DAC;

namespace Nomina.BC
{
    public class UpdateBC
    {
        public string Update(Pagos obj, int idPagos)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idPagos) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Justificante obj, int idJustificante)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idJustificante) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Incidente obj, int idIncidente)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idIncidente) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Horario obj, int idHorario)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idHorario) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(EmpleadoHuella obj, int idEmpleadoHuella)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idEmpleadoHuella) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Empleado obj, int idEmpleado)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idEmpleado) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Cuenta obj, int idCuenta)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idCuenta) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(CapacitacionEmpleado obj, int idCapacitacionEmpleado)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idCapacitacionEmpleado) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Capacitacion obj, int idCapacitacion)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idCapacitacion) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Bono obj, int idBono)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idBono) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Vacaciones obj, int idVacaciones)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idVacaciones) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(TipoHuella obj, int idTipoHuella)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idTipoHuella) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }

        public string Update(Registro obj, int idRegistro)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idRegistro) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Permiso obj, int idPermiso)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idPermiso) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Update(Sueldo obj, int idSueldo)
        {

            UpdateDAC objDAC = new UpdateDAC();
            if (objDAC.UpdateRecord(obj, idSueldo) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }

    }
}