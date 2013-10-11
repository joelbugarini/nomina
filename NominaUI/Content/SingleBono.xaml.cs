using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleBono.xaml
    /// </summary>                                                
    public partial class SingleBono : UserControl
    {
        public Bono bono = new Bono();

        public SingleBono(Bono reg)
        {
            InitializeComponent();
            bono = reg;
            this.DataContext = bono;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleBono()
        {
                InitializeComponent();
                this.DataContext =  bono;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( bono);
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
                obj.Update( bono,  bono.IdBono);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtDescripcion.Text = "";
 txtClave.Text = "";
 txtMonto.Text = "";

        }
    }
}
