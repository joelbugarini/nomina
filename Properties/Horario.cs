using System;

namespace Properties
{
    public class Horario
    {
        private int idHorario;

        public int IdHorario
        {
            get { return idHorario; }
            set { idHorario = value; }
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
        private DateTime horaInMed;

        public DateTime HoraInMed
        {
            get { return horaInMed; }
            set { horaInMed = value; }
        }
        private DateTime horaOutMed;

        public DateTime HoraOutMed
        {
            get { return horaOutMed; }
            set { horaOutMed = value; }
        }
        private bool lunes;

        public bool Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }
        private bool martes;

        public bool Martes
        {
            get { return martes; }
            set { martes = value; }
        }
        private bool miercoles;

        public bool Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }
        private bool jueves;

        public bool Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }
        private bool viernes;

        public bool Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }
        private bool sabado;

        public bool Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }
        private bool domingo;

        public bool Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }

    }
}
