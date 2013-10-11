using System;

namespace Properties
{
    public class Vacaciones
    {private int idVacaciones;

        public int IdVacaciones
        {
            get { return idVacaciones; }
            set { idVacaciones = value; }
        }
private DateTime inicio;

        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
private DateTime fin;

        public DateTime Fin
        {
            get { return fin; }
            set { fin = value; }
        }
private bool activa;

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }

    }
}
