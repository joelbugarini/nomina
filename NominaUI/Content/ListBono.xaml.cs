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
    public partial class ListBono : UserControl
    {
        private List<Bono> Bonos = new List<Bono>();

        public ListBono()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Bonos = obj.ReadBono();

            this.DataContext = Bonos;

        }

        private void listBono_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Bono register = listBono.SelectedValue as Bono;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleBono(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadBono();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Bonos
                        orderby element.IdBono
                        where (element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) &&
                        element.Clave.ToString().Trim().ToLower().Contains(txtClaveBusqueda.Text.Trim().ToLower()) &&
                        element.Monto.ToString().Trim().ToLower().Contains(txtMontoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Bonos
		    orderby element.Descripcion
		    select element;

            this.DataContext = query;
        }private void headClave(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Bonos
		    orderby element.Clave
		    select element;

            this.DataContext = query;
        }private void headMonto(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Bonos
		    orderby element.Monto
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
