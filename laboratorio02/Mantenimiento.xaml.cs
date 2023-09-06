using System.Windows;
using System.Windows.Controls;

namespace laboratorio02
{
    public partial class Mantenimiento : Window
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void RegistrarConductoresButton_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el contenedor de registro de conductores y ocultar el de lista de conductores
            RegistroConductoresContainer.Visibility = Visibility.Visible;
            ListaConductoresContainer.Visibility = Visibility.Collapsed;
        }

        private void ListarConductoresButton_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar el contenedor de lista de conductores y ocultar el de registro de conductores
            ListaConductoresContainer.Visibility = Visibility.Visible;
            RegistroConductoresContainer.Visibility = Visibility.Collapsed;

            // Puedes agregar aquí la lógica para cargar y mostrar la lista de conductores en el ListView
        }

        private void GuardarConductorButton_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar la lógica para guardar el conductor en tu base de datos o en otro almacenamiento
            // Puedes obtener los valores de los TextBox como NombreConductorRegistroTextBox.Text, LicenciaTextBox.Text, etc.

            // Después de guardar, puedes mostrar un mensaje de confirmación o limpiar los campos del formulario
            MessageBox.Show("Conductor registrado con éxito.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
            LimpiarCamposRegistroConductores();
        }

        private void LimpiarCamposRegistroConductores()
        {
            NombreConductorRegistroTextBox.Clear();
            LicenciaTextBox.Clear();
            TransporteTextBox.Clear();
            // Limpia otros campos si es necesario
        }
        private void VolverAVentana1Button_Click(object sender, RoutedEventArgs e)
        {
            ventana1 ventana1 = new ventana1(); // Crea una nueva instancia de Ventana1
            ventana1.Show(); // Muestra la Ventana1
            Close(); // Cierra la ventana actual (Mantenimiento)
        }

    }
}
