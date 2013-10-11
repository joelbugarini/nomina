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
    public partial class ListPermiso : UserControl
    {
        private List<Permiso> Permisos = new List<Permiso>();

        public ListPermiso()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Permisos = obj.ReadPermiso();

            this.DataContext = Permisos;

        }

        private void listPermiso_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Permiso register = listPermiso.SelectedValue as Permiso;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SinglePermiso(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadPermiso();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Permisos
                        orderby element.IdLicencia
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Activo.ToString().Trim().ToLower().Contains(txtActivoBusqueda.Text.Trim().ToLower()) &&
                        element.HoraIn.ToString().Trim().ToLower().Contains(txtHoraInBusqueda.Text.Trim().ToLower()) &&
                        element.HoraOut.ToString().Trim().ToLower().Contains(txtHoraOutBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Permisos
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headActivo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Permisos
		    orderby element.Activo
		    select element;

            this.DataContext = query;
        }private void headHoraIn(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Permisos
		    orderby element.HoraIn
		    select element;

            this.DataContext = query;
        }private void headHoraOut(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Permisos
		    orderby element.HoraOut
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
