using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SinglePermiso.xaml
    /// </summary>                                                
    public partial class SinglePermiso : UserControl
    {
        public Permiso permiso = new Permiso();

        public SinglePermiso(Permiso reg)
        {
            InitializeComponent();
            permiso = reg;
            this.DataContext = permiso;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SinglePermiso()
        {
                InitializeComponent();
                this.DataContext =  permiso;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( permiso);
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
                obj.Update( permiso,  permiso.IdLicencia);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdEmpleado.Text = "";
 txtActivo.Text = "";
 txtHoraIn.Text = "";
 txtHoraOut.Text = "";

        }
    }
}
