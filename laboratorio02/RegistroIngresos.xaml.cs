using System;
using System.Windows;

namespace laboratorio02
{
    public partial class RegistroIngresos : Window
    {
        public RegistroIngresos()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            // Obtén los valores ingresados por el usuario
            string tipoDocumento = TipoDocumentoTextBox.Text;
            string numeroDocumento = NumeroDocumentoTextBox.Text;
            string placa = PlacaTextBox.Text;
            string turno = TurnoTextBox.Text;
            string nombreConductor = NombreConductorTextBox.Text;
            string nombreCliente = NombreClienteTextBox.Text;
            string fechaHora = FechaHoraTextBox.Text; // No se procesa como DateTime
            string pesoIngreso = PesoIngresoTextBox.Text;

            // Ahora puedes utilizar estos valores para hacer lo que necesites,
            // como guardarlos en una base de datos o realizar otras operaciones.

            // Ejemplo: Mostrar los valores en un MessageBox
            string mensaje = $"Tipo de Documento: {tipoDocumento}\n" +
                             $"Número de Documento: {numeroDocumento}\n" +
                             $"Placa: {placa}\n" +
                             $"Turno: {turno}\n" +
                             $"Nombre del Conductor: {nombreConductor}\n" +
                             $"Nombre del Cliente: {nombreCliente}\n" +
                             $"Fecha y Hora: {fechaHora}\n" +
                             $"Peso de Ingreso: {pesoIngreso}";
            MessageBox.Show(mensaje, "Registro Guardado");

            // Limpia los campos después de guardar
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TipoDocumentoTextBox.Clear();
            NumeroDocumentoTextBox.Clear();
            PlacaTextBox.Clear();
            TurnoTextBox.Clear();
            NombreConductorTextBox.Clear();
            NombreClienteTextBox.Clear();
            FechaHoraTextBox.Clear();
            PesoIngresoTextBox.Clear();
        }
    }
}
