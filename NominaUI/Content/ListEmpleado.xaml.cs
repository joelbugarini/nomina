using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;
using Properties;

namespace Nomina.Content
{

    public partial class ListEmpleado : UserControl
    {
        public static Empleado EmpleadoSeleccionado { get; set; }
        private List<Empleado> Empleados = new List<Empleado>();

        public ListEmpleado()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Empleados = obj.ReadEmpleado();

            this.DataContext = Empleados;
        }

        private void listEmpleado_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Empleado register = listEmpleado.SelectedValue as Empleado;
            EmpleadoSeleccionado = register;
            new NominaUI.Content.SingleNominaEmpleado().Show();



            /* new ModernDialog
             {
                 Title = "Modificar",
                 Content = new SingleEmpleado(register)
             }.ShowDialog();*/
        }

        public void Update()
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadEmpleado();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.IdEmpleado
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.ApellidoPaterno.ToString().Trim().ToLower().Contains(txtApellidoPaternoBusqueda.Text.Trim().ToLower()) &&
                        element.ApellidoMaterno.ToString().Trim().ToLower().Contains(txtApellidoMaternoBusqueda.Text.Trim().ToLower()) &&
                        element.Departamento.ToString().Trim().ToLower().Contains(txtDepartamentoBusqueda.Text.Trim().ToLower()) &&
                        element.NoEmpleado.ToString().Trim().ToLower().Contains(txtNoEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Domicilio.ToString().Trim().ToLower().Contains(txtDomicilioBusqueda.Text.Trim().ToLower()) &&
                        element.Telefono.ToString().Trim().ToLower().Contains(txtTelefonoBusqueda.Text.Trim().ToLower()) &&
                        element.EstadoCivil.ToString().Trim().ToLower().Contains(txtEstadoCivilBusqueda.Text.Trim().ToLower()) &&
                        element.Correo.ToString().Trim().ToLower().Contains(txtCorreoBusqueda.Text.Trim().ToLower()) &&
                        element.NacDomicilio.ToString().Trim().ToLower().Contains(txtNacDomicilioBusqueda.Text.Trim().ToLower()) &&
                        element.Sangre.ToString().Trim().ToLower().Contains(txtSangreBusqueda.Text.Trim().ToLower()) &&
                        element.Educacion.ToString().Trim().ToLower().Contains(txtEducacionBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;
        }
        private void headNombre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Nombre
                        select element;

            this.DataContext = query;
        }
        private void headApellidoPaterno(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.ApellidoPaterno
                        select element;

            this.DataContext = query;
        }
        private void headApellidoMaterno(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.ApellidoMaterno
                        select element;

            this.DataContext = query;
        }

        private void headDepartamento(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Departamento
                        select element;

            this.DataContext = query;
        }
        private void headNoEmpleado(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.NoEmpleado
                        select element;

            this.DataContext = query;
        }
        private void headDomicilio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Domicilio
                        select element;

            this.DataContext = query;
        }
        private void headTelefono(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Telefono
                        select element;

            this.DataContext = query;
        }
        private void headFechaNac(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.FechaNac
                        select element;

            this.DataContext = query;
        }
        private void headEstadoCivil(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.EstadoCivil
                        select element;

            this.DataContext = query;
        }
        private void headCorreo(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Correo
                        select element;

            this.DataContext = query;
        }
        private void headNacDomicilio(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.NacDomicilio
                        select element;

            this.DataContext = query;
        }
        private void headSangre(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Sangre
                        select element;

            this.DataContext = query;
        }
        private void headEducacion(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.Educacion
                        select element;

            this.DataContext = query;
        }
        private void headTituloProf(object sender, MouseButtonEventArgs e)
        {
            var query = from element in Empleados
                        orderby element.TituloProf
                        select element;

            this.DataContext = query;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
