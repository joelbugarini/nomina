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
    public partial class ListRegistro : UserControl
    {
        private List<Registro> Registros = new List<Registro>();

        public ListRegistro()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Registros = obj.ReadCustomQuery("SELECT TOP 2000 * FROM Registro ORDER BY IdRegistro DESC");

            this.DataContext = Registros;

        }

        private void listRegistro_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Registro register = listRegistro.SelectedValue as Registro;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleRegistro(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadRegistro();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Registros
                        orderby element.IdRegistro
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Estado.ToString().Trim().ToLower().Contains(txtEstadoBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Registros
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headEstado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Registros
		    orderby element.Estado
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Registros
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
