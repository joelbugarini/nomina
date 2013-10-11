using System;

namespace Properties
{
    public class Sueldo
    {
        private int idSueldo;

        public int IdSueldo
        {
            get { return idSueldo; }
            set { idSueldo = value; }
        }
        private string nivel;

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        private float sueldoMin;

        public float SueldoMin
        {
            get { return sueldoMin; }
            set { sueldoMin = value; }
        }
        private float sueldoMax;

        public float SueldoMax
        {
            get { return sueldoMax; }
            set { sueldoMax = value; }
        }

    }
}
