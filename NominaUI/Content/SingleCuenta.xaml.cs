using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleCuenta.xaml
    /// </summary>                                                
    public partial class SingleCuenta : UserControl
    {
        public Cuenta cuenta = new Cuenta();

        public SingleCuenta(Cuenta reg)
        {
            InitializeComponent();
            cuenta = reg;
            this.DataContext = cuenta;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleCuenta()
        {
                InitializeComponent();
                this.DataContext =  cuenta;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( cuenta);
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
                obj.Update( cuenta,  cuenta.IdCuenta);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdEmpleado.Text = "";
 txtSaldo.Text = "";
 txtSaldoNeto.Text = "";

        }
    }
}
