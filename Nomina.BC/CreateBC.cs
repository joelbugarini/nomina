using Properties;
using Nomina.DAC;

namespace Nomina.BC
{
    public class CreateBC
    {
        public string Create(Pagos obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Justificante obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Incidente obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Horario obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(EmpleadoHuella obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Empleado obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Cuenta obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(CapacitacionEmpleado obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Sueldo obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Capacitacion obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Bono obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Vacaciones obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(TipoHuella obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }

        public string Create(Registro obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }
        public string Create(Permiso obj)
        {

            CreateDAC objDAC = new CreateDAC();
            if (objDAC.CreateRecord(obj) == true)
                return "Registro almacenado con éxito.";
            else
                return "No se pudo almacenar el regitro.";
        }

    }
}