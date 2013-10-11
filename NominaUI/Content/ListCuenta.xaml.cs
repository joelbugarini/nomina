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
    public partial class ListCuenta : UserControl
    {
        private List<Cuenta> Cuentas = new List<Cuenta>();

        public ListCuenta()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Cuentas = obj.ReadCuenta();

            this.DataContext = Cuentas;

        }

        private void listCuenta_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Cuenta register = listCuenta.SelectedValue as Cuenta;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleCuenta(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadCuenta();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Cuentas
                        orderby element.IdCuenta
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Saldo.ToString().Trim().ToLower().Contains(txtSaldoBusqueda.Text.Trim().ToLower()) &&
                        element.SaldoNeto.ToString().Trim().ToLower().Contains(txtSaldoNetoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Cuentas
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headSaldo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Cuentas
		    orderby element.Saldo
		    select element;

            this.DataContext = query;
        }private void headSaldoNeto(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Cuentas
		    orderby element.SaldoNeto
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
