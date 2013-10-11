using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleTipoHuella.xaml
    /// </summary>                                                
    public partial class SingleTipoHuella : UserControl
    {
        public TipoHuella tipoHuella = new TipoHuella();

        public SingleTipoHuella(TipoHuella reg)
        {
            InitializeComponent();
            tipoHuella = reg;
            this.DataContext = tipoHuella;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleTipoHuella()
        {
                InitializeComponent();
                this.DataContext =  tipoHuella;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( tipoHuella);
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
                obj.Update( tipoHuella,  tipoHuella.IdTipoHuella);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtClave.Text = "";
 txtDescripcion.Text = "";

        }
    }
}
