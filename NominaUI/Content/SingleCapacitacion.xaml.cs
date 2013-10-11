using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleCapacitacion.xaml
    /// </summary>                                                
    public partial class SingleCapacitacion : UserControl
    {
        public Capacitacion capacitacion = new Capacitacion();

        public SingleCapacitacion(Capacitacion reg)
        {
            InitializeComponent();
            capacitacion = reg;
            this.DataContext = capacitacion;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleCapacitacion()
        {
                InitializeComponent();
                this.DataContext =  capacitacion;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create( capacitacion);
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
                obj.Update( capacitacion,  capacitacion.IdCapacitacion);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtNombre.Text = "";
 txtImparte.Text = "";
 txtFecha.Text = "";
 txtDuracion.Text = "";

        }
    }
}
