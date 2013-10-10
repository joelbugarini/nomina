using Properties;
using Nomina.DAC;

namespace Nomina.BC
{
    public class DeleteBC
    {
        public string DeletePagos(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deletePagos(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteJustificante(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteJustificante(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteIncidente(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteIncidente(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteSueldo(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteSueldo(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteHorario(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteHorario(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteEmpleadoHuella(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteEmpleadoHuella(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteEmpleado(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteEmpleado(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteCuenta(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteCuenta(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteCapacitacionEmpleado(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteCapacitacionEmpleado(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteCapacitacion(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteCapacitacion(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteBono(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteBono(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteVacaciones(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteVacaciones(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeleteTipoHuella(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteTipoHuella(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }

        public string DeleteRegistro(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deleteRegistro(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }
        public string DeletePermiso(int id)
        {

            DeleteDAC objDAC = new DeleteDAC();
            if (objDAC.deletePermiso(id) == true)
                return "Registro eliminado con éxito.";
            else
                return "No se pudo eliminar el regitro.";
        }

    }
}