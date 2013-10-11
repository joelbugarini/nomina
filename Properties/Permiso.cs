using System;

namespace Properties
{
    public class Permiso
    {private int idLicencia;

        public int IdLicencia
        {
            get { return idLicencia; }
            set { idLicencia = value; }
        }
private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
private DateTime horaIn;

        public DateTime HoraIn
        {
            get { return horaIn; }
            set { horaIn = value; }
        }
private DateTime horaOut;

        public DateTime HoraOut
        {
            get { return horaOut; }
            set { horaOut = value; }
        }

    }
}
