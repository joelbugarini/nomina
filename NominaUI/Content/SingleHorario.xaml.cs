using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleHorario.xaml
    /// </summary>                                                
    public partial class SingleHorario : UserControl
    {
        public Horario horario = new Horario();

        public SingleHorario(Horario reg)
        {
            InitializeComponent();
            horario = reg;
            this.DataContext = horario;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleHorario()
        {
                InitializeComponent();
                this.DataContext =  horario;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( horario);
            }
            catch(Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }

            NuevoReg();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateBC obj = new UpdateBC();
                obj.Update( horario,  horario.IdHorario);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtHoraIn.Text = "";
 txtHoraOut.Text = "";
 txtHoraInMed.Text = "";
 txtHoraOutMed.Text = "";
 txtLunes.Text = "";
 txtMartes.Text = "";
 txtMiercoles.Text = "";
 txtJueves.Text = "";
 txtViernes.Text = "";
 txtSabado.Text = "";
 txtDomingo.Text = "";

        }
    }
}
