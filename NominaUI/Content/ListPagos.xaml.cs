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
    public partial class ListPagos : UserControl
    {
        private List<Pagos> Pagoss = new List<Pagos>();

        public ListPagos()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Pagoss = obj.ReadPagos();

            this.DataContext = Pagoss;

        }

        private void listPagos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Pagos register = listPagos.SelectedValue as Pagos;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SinglePagos(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadPagos();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Pagoss
                        orderby element.IdPago
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Monto.ToString().Trim().ToLower().Contains(txtMontoBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pagoss
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headMonto(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pagoss
		    orderby element.Monto
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Pagoss
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
