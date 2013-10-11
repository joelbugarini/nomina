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
    public partial class ListIncidente : UserControl
    {
        private List<Incidente> Incidentes = new List<Incidente>();

        public ListIncidente()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Incidentes = obj.ReadIncidente();

            this.DataContext = Incidentes;

        }

        private void listIncidente_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Incidente register = listIncidente.SelectedValue as Incidente;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleIncidente(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadIncidente();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Incidentes
                        orderby element.IdFalta
                        where (element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) &&
                        element.Tipo.ToString().Trim().ToLower().Contains(txtTipoBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Incidentes
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void headTipo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Incidentes
		    orderby element.Tipo
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Incidentes
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
