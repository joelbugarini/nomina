using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleCapacitacionEmpleado.xaml
    /// </summary>                                                
    public partial class SingleCapacitacionEmpleado : UserControl
    {
        public CapacitacionEmpleado capacitacionEmpleado = new CapacitacionEmpleado();

        public SingleCapacitacionEmpleado(CapacitacionEmpleado reg)
        {
            InitializeComponent();
            capacitacionEmpleado = reg;
            this.DataContext = capacitacionEmpleado;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleCapacitacionEmpleado()
        {
                InitializeComponent();
                this.DataContext =  capacitacionEmpleado;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( capacitacionEmpleado);
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
                obj.Update( capacitacionEmpleado,  capacitacionEmpleado.IdCapacitacionEmpleado);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtIdCapacitacion.Text = "";
 txtIdEmpleado.Text = "";

        }
    }
}
