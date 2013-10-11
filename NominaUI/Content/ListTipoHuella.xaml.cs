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
    public partial class ListTipoHuella : UserControl
    {
        private List<TipoHuella> TipoHuellas = new List<TipoHuella>();

        public ListTipoHuella()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            TipoHuellas = obj.ReadTipoHuella();

            this.DataContext = TipoHuellas;

        }

        private void listTipoHuella_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TipoHuella register = listTipoHuella.SelectedValue as TipoHuella;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleTipoHuella(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadTipoHuella();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in TipoHuellas
                        orderby element.IdTipoHuella
                        where (element.Clave.ToString().Trim().ToLower().Contains(txtClaveBusqueda.Text.Trim().ToLower()) &&
                        element.Descripcion.ToString().Trim().ToLower().Contains(txtDescripcionBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headClave(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in TipoHuellas
		    orderby element.Clave
		    select element;

            this.DataContext = query;
        }private void headDescripcion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in TipoHuellas
		    orderby element.Descripcion
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
