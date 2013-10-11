using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleSueldo.xaml
    /// </summary>                                                
    public partial class SingleSueldo : UserControl
    {
        public Sueldo sueldo = new Sueldo();

        public SingleSueldo(Sueldo reg)
        {
            InitializeComponent();
            sueldo = reg;
            this.DataContext = sueldo;

            btnActualizar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Collapsed;
        }

        public SingleSueldo()
        {
                InitializeComponent();
                this.DataContext =  sueldo;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                CreateBC obj = new CreateBC();
                obj.Create( sueldo);
           /* }
            catch(Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
            */
            NuevoReg();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateBC obj = new UpdateBC();
                obj.Update( sueldo,  sueldo.IdSueldo);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente", "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg() {
 txtNivel.Text = "";
 txtSueldoMin.Text = "";
 txtSueldoMax.Text = "";

        }
    }
}
