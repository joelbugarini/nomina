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
    public partial class ListCapacitacion : UserControl
    {
        private List<Capacitacion> Capacitacions = new List<Capacitacion>();

        public ListCapacitacion()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Capacitacions = obj.ReadCapacitacion();

            this.DataContext = Capacitacions;

        }

        private void listCapacitacion_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Capacitacion register = listCapacitacion.SelectedValue as Capacitacion;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleCapacitacion(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadCapacitacion();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Capacitacions
                        orderby element.IdCapacitacion
                        where (element.Nombre.ToString().Trim().ToLower().Contains(txtNombreBusqueda.Text.Trim().ToLower()) &&
                        element.Imparte.ToString().Trim().ToLower().Contains(txtImparteBusqueda.Text.Trim().ToLower()) &&
                        element.Fecha.ToString().Trim().ToLower().Contains(txtFechaBusqueda.Text.Trim().ToLower()) &&
                        element.Duracion.ToString().Trim().ToLower().Contains(txtDuracionBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headNombre(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Capacitacions
		    orderby element.Nombre
		    select element;

            this.DataContext = query;
        }private void headImparte(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Capacitacions
		    orderby element.Imparte
		    select element;

            this.DataContext = query;
        }private void headFecha(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Capacitacions
		    orderby element.Fecha
		    select element;

            this.DataContext = query;
        }private void headDuracion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Capacitacions
		    orderby element.Duracion
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
