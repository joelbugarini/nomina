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
    public partial class ListVacaciones : UserControl
    {
        private List<Vacaciones> Vacacioness = new List<Vacaciones>();

        public ListVacaciones()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Vacacioness = obj.ReadVacaciones();

            this.DataContext = Vacacioness;

        }

        private void listVacaciones_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Vacaciones register = listVacaciones.SelectedValue as Vacaciones;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleVacaciones(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadVacaciones();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Vacacioness
                        orderby element.IdVacaciones
                        where (element.Inicio.ToString().Trim().ToLower().Contains(txtInicioBusqueda.Text.Trim().ToLower()) &&
                        element.Fin.ToString().Trim().ToLower().Contains(txtFinBusqueda.Text.Trim().ToLower()) &&
                        element.Activa.ToString().Trim().ToLower().Contains(txtActivaBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headInicio(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Vacacioness
		    orderby element.Inicio
		    select element;

            this.DataContext = query;
        }private void headFin(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Vacacioness
		    orderby element.Fin
		    select element;

            this.DataContext = query;
        }private void headActiva(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Vacacioness
		    orderby element.Activa
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
