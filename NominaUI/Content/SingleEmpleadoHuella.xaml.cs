using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleEmpleadoHuella.xaml
    /// </summary>                                                
    public partial class SingleEmpleadoHuella : UserControl
    {
        public EmpleadoHuella empleadoHuella = new EmpleadoHuella();

        public SingleEmpleadoHuella(EmpleadoHuella reg)
        {
            InitializeComponent();
            empleadoHuella = reg;
            this.DataContext = empleadoHuella;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleEmpleadoHuella()
        {
                InitializeComponent();
                this.DataContext =  empleadoHuella;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( empleadoHuella);
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
                obj.Update( empleadoHuella,  empleadoHuella.IdEmpleadoHuella);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdEmpleado.Text = "";
 txtIdTipoHuella.Text = "";
 txtHuella.Text = "";

        }
    }
}
