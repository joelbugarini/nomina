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
    public partial class ListEmpleadoHuella : UserControl
    {
        private List<EmpleadoHuella> EmpleadoHuellas = new List<EmpleadoHuella>();

        public ListEmpleadoHuella()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            EmpleadoHuellas = obj.ReadEmpleadoHuella();

            this.DataContext = EmpleadoHuellas;

        }

        private void listEmpleadoHuella_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EmpleadoHuella register = listEmpleadoHuella.SelectedValue as EmpleadoHuella;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleEmpleadoHuella(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadEmpleadoHuella();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in EmpleadoHuellas
                        orderby element.IdEmpleadoHuella
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.IdTipoHuella.ToString().Trim().ToLower().Contains(txtIdTipoHuellaBusqueda.Text.Trim().ToLower()) &&
                        element.Huella.ToString().Trim().ToLower().Contains(txtHuellaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in EmpleadoHuellas
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headIdTipoHuella(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in EmpleadoHuellas
		    orderby element.IdTipoHuella
		    select element;

            this.DataContext = query;
        }private void headHuella(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in EmpleadoHuellas
		    orderby element.Huella
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
