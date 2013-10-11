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
    public partial class ListHorario : UserControl
    {
        private List<Horario> Horarios = new List<Horario>();

        public ListHorario()
        {
            InitializeComponent();

            ReadBC obj = new ReadBC();
            Horarios = obj.ReadHorario();

            this.DataContext = Horarios;

        }

        private void listHorario_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Horario register = listHorario.SelectedValue as Horario;
            new ModernDialog
            {
                Title = "Modificar",
                Content = new SingleHorario(register)
            }.ShowDialog();
        }

        public void Update() 
        {
            ReadBC obj = new ReadBC();
            this.DataContext = obj.ReadHorario();
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = from element in Horarios
                        orderby element.IdHorario
                        where (element.HoraIn.ToString().Trim().ToLower().Contains(txtHoraInBusqueda.Text.Trim().ToLower()) &&
                        element.HoraOut.ToString().Trim().ToLower().Contains(txtHoraOutBusqueda.Text.Trim().ToLower()) &&
                        element.HoraInMed.ToString().Trim().ToLower().Contains(txtHoraInMedBusqueda.Text.Trim().ToLower()) &&
                        element.HoraOutMed.ToString().Trim().ToLower().Contains(txtHoraOutMedBusqueda.Text.Trim().ToLower()) &&
                        element.Lunes.ToString().Trim().ToLower().Contains(txtLunesBusqueda.Text.Trim().ToLower()) &&
                        element.Martes.ToString().Trim().ToLower().Contains(txtMartesBusqueda.Text.Trim().ToLower()) &&
                        element.Miercoles.ToString().Trim().ToLower().Contains(txtMiercolesBusqueda.Text.Trim().ToLower()) &&
                        element.Jueves.ToString().Trim().ToLower().Contains(txtJuevesBusqueda.Text.Trim().ToLower()) &&
                        element.Viernes.ToString().Trim().ToLower().Contains(txtViernesBusqueda.Text.Trim().ToLower()) &&
                        element.Sabado.ToString().Trim().ToLower().Contains(txtSabadoBusqueda.Text.Trim().ToLower()) &&
                        element.Domingo.ToString().Trim().ToLower().Contains(txtDomingoBusqueda.Text.Trim().ToLower()) 
                         )
                        select element;

            this.DataContext = query;       
        }
private void headHoraIn(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.HoraIn
		    select element;

            this.DataContext = query;
        }private void headHoraOut(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.HoraOut
		    select element;

            this.DataContext = query;
        }private void headHoraInMed(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.HoraInMed
		    select element;

            this.DataContext = query;
        }private void headHoraOutMed(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.HoraOutMed
		    select element;

            this.DataContext = query;
        }private void headLunes(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Lunes
		    select element;

            this.DataContext = query;
        }private void headMartes(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Martes
		    select element;

            this.DataContext = query;
        }private void headMiercoles(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Miercoles
		    select element;

            this.DataContext = query;
        }private void headJueves(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Jueves
		    select element;

            this.DataContext = query;
        }private void headViernes(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Viernes
		    select element;

            this.DataContext = query;
        }private void headSabado(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Sabado
		    select element;

            this.DataContext = query;
        }private void headDomingo(object sender, MouseButtonEventArgs e)
        {
             var query =  from element in Horarios
		    orderby element.Domingo
		    select element;

            this.DataContext = query;
        }private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
