using System;
using System.Windows;
using System.Windows.Controls;
using Properties;
using FirstFloor.ModernUI.Windows.Controls;
using Nomina.BC;
using System.Windows.Data;
using System.Collections.Generic;
using NominaUI.Content;

namespace Nomina.Content
{
    /// <summary>
    /// Interaction logic for SingleEmpleado.xaml
    /// </summary>                                                
    public partial class SingleEmpleado : UserControl
    {
        public Empleado empleado = new Empleado();
        public List<Sueldo> Sueldos { get; private set; }

        public SingleEmpleado()
        {

            
            empleado = Nomina.Content.ListEmpleado.EmpleadoSeleccionado;

            if (empleado != null)
            {
                InitializeComponent();
                Sueldos = new ReadBC().ReadSueldo();

                Binding binding = new Binding();
                binding.Source = Sueldos;

                txtFechaNac.DisplayDate = Convert.ToDateTime(empleado.FechaNac);
                txtFechaNac.Text = Convert.ToString(empleado.FechaNac);
                txtFechaAlta.DisplayDate = Convert.ToDateTime(empleado.FechaAlta);
                txtFechaAlta.Text = Convert.ToString(empleado.FechaAlta);
                txtFechaBaja.DisplayDate = Convert.ToDateTime(empleado.FechaBaja);
                txtFechaBaja.Text = Convert.ToString(empleado.FechaBaja);

                txtIdSueldo.DisplayMemberPath = "Nivel";
                txtIdSueldo.SelectedValuePath = "IdSueldo";
                txtIdSueldo.SetBinding(ComboBox.ItemsSourceProperty, binding);

                this.DataContext = empleado;

                btnActualizar.Visibility = Visibility.Visible;
                btnGuardar.Visibility = Visibility.Collapsed;
                Nomina.Content.ListEmpleado.EmpleadoSeleccionado = null;
            }
            else
            {
                InitializeComponent();

                Sueldos = new ReadBC().ReadSueldo();

                Binding binding = new Binding();
                binding.Source = Sueldos;

                txtIdSueldo.DisplayMemberPath = "Nivel";
                txtIdSueldo.SelectedValuePath = "IdSueldo";
                txtIdSueldo.SetBinding(ComboBox.ItemsSourceProperty, binding);
                this.DataContext = empleado;
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CreateBC obj = new CreateBC();
                obj.Create(empleado);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente\n" + ex.Message, "Error", MessageBoxButton.OK);
            }

            NuevoReg();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UpdateBC obj = new UpdateBC();
                obj.Update(empleado, empleado.IdEmpleado);
            }
            catch (Exception ex)
            {
                ModernDialog.ShowMessage("Hubo un problema al intentar guardar el registro, revisa que todos los campos esten llenados correctamente\n" + ex.Message, "Error", MessageBoxButton.OK);
            }
        }

        private void NuevoReg()
        {
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtEstado.Text = "";
            txtTurno.Text = "";
            txtDepartamento.Text = "";
            txtNoEmpleado.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtFechaNac.Text = "";
            txtEstadoCivil.Text = "";
            txtCorreo.Text = "";
            txtNacDomicilio.Text = "";
            txtSangre.Text = "";
            txtEducacion.Text = "";
            txtTituloProf.Text = "";
            txtFechaAlta.Text = "";
            txtFechaBaja.Text = "";
            txtBaja.Text = "";
            txtIdSueldo.Text = "";

        }
    }
}
