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
    public partial class ListSueldo : UserControl
    {
        private List<Sueldo> Sueldos = new List<Sueldo>();

        public ListSueldo()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Sueldos = obj.ReadSueldo();

            this.DataContext = Sueldos;

        }

        private void listSueldo_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Sueldo register = listSueldo.SelectedValue as Sueldo;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleSueldo(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadSueldo();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Sueldos
                        orderby element.IdSueldo
                        where (element.Nivel.ToString().Trim().ToLower().Contains(txtNivelBusqueda.Text.Trim().ToLower()) &&
                        element.SueldoMin.ToString().Trim().ToLower().Contains(txtSueldoMinBusqueda.Text.Trim().ToLower()) &&
                        element.SueldoMax.ToString().Trim().ToLower().Contains(txtSueldoMaxBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headNivel(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Sueldos
		    orderby element.Nivel
		    select element;

            this.DataContext = query;
        }private void headSueldoMin(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Sueldos
		    orderby element.SueldoMin
		    select element;

            this.DataContext = query;
        }private void headSueldoMax(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Sueldos
		    orderby element.SueldoMax
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
