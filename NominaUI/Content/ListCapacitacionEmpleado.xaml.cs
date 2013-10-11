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
    public partial class ListCapacitacionEmpleado : UserControl
    {
        private List<CapacitacionEmpleado> CapacitacionEmpleados = new List<CapacitacionEmpleado>();

        public ListCapacitacionEmpleado()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            CapacitacionEmpleados = obj.ReadCapacitacionEmpleado();

            this.DataContext = CapacitacionEmpleados;

        }

        private void listCapacitacionEmpleado_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CapacitacionEmpleado register = listCapacitacionEmpleado.SelectedValue as CapacitacionEmpleado;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleCapacitacionEmpleado(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadCapacitacionEmpleado();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in CapacitacionEmpleados
                        orderby element.IdCapacitacionEmpleado
                        where (element.IdCapacitacion.ToString().Trim().ToLower().Contains(txtIdCapacitacionBusqueda.Text.Trim().ToLower()) &&
                        element.IdEmpleado.ToString().Trim().ToLower().Contains(txtIdEmpleadoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headIdCapacitacion(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in CapacitacionEmpleados
		    orderby element.IdCapacitacion
		    select element;

            this.DataContext = query;
        }private void headIdEmpleado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in CapacitacionEmpleados
		    orderby element.IdEmpleado
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
