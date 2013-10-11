using System;

namespace Properties
{
    public class Incidente
    {private int idFalta;

        public int IdFalta
        {
            get { return idFalta; }
            set { idFalta = value; }
        }
private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

    }
}
