using System;

namespace Properties
{
    public class Empleado
    {
        public Empleado()
        {
            Nombre = "";
            ApellidoPaterno = "";
            ApellidoMaterno = "";
            Estado = false;
            Turno = "";
            Departamento = "";
            NoEmpleado = "";
            Domicilio = "";
            Telefono = "";
            EstadoCivil = "";
            Correo = "";
            NacDomicilio = "";
            Sangre = "";
            Educacion = "";
            TituloProf = false;
            Baja = false;
            IdSueldo = 0;

        }

        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellidoPaterno;

        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
            set { apellidoPaterno = value; }
        }
        private string apellidoMaterno;

        public string ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }
        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private string noEmpleado;

        public string NoEmpleado
        {
            get { return noEmpleado; }
            set { noEmpleado = value; }
        }
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private DateTime? fechaNac;

        public DateTime? FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }
        private string estadoCivil;

        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private string nacDomicilio;

        public string NacDomicilio
        {
            get { return nacDomicilio; }
            set { nacDomicilio = value; }
        }
        private string sangre;

        public string Sangre
        {
            get { return sangre; }
            set { sangre = value; }
        }
        private string educacion;

        public string Educacion
        {
            get { return educacion; }
            set { educacion = value; }
        }
        private bool tituloProf;

        public bool TituloProf
        {
            get { return tituloProf; }
            set { tituloProf = value; }
        }
        private DateTime? fechaAlta;

        public DateTime? FechaAlta
        {
            get { return fechaAlta; }
            set { fechaAlta = value; }
        }
        private DateTime? fechaBaja;

        public DateTime? FechaBaja
        {
            get { return fechaBaja; }
            set { fechaBaja = value; }
        }
        private bool baja;

        public bool Baja
        {
            get { return baja; }
            set { baja = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private int idSueldo;

        public int IdSueldo
        {
            get { return idSueldo; }
            set { idSueldo = value; }
        }
        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}
