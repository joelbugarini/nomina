using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleVacaciones.xaml
    /// </summary>                                                
    public partial class SingleVacaciones : UserControl
    {
        public Vacaciones vacaciones = new Vacaciones();

        public SingleVacaciones(Vacaciones reg)
        {
            InitializeComponent();
            vacaciones = reg;
            this.DataContext = vacaciones;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleVacaciones()
        {
                InitializeComponent();
                this.DataContext =  vacaciones;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( vacaciones);
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
                obj.Update( vacaciones,  vacaciones.IdVacaciones);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtInicio.Text = "";
 txtFin.Text = "";
 txtActiva.Text = "";

        }
    }
}
