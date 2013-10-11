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
    public partial class ListJustificante : UserControl
    {
        private List<Justificante> Justificantes = new List<Justificante>();

        public ListJustificante()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Justificantes = obj.ReadJustificante();

            this.DataContext = Justificantes;

        }

        private void listJustificante_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Justificante register = listJustificante.SelectedValue as Justificante;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleJustificante(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadJustificante();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Justificantes
                        orderby element.IdJustificante
                        where (element.IdIncidente.ToString().Trim().ToLower().Contains(txtIdIncidenteBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdIncidente(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Justificantes
		    orderby element.IdIncidente
		    select element;

            this.DataContext = query;
        }private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Justificantes
		    orderby element.Descripcion
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
