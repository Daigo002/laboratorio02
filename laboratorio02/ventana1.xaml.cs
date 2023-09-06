using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laboratorio02
{
    /// <summary>
    /// Lógica de interacción para ventana1.xaml
    /// </summary>
    public partial class ventana1 : Window
    {
        public ventana1()
        {
            InitializeComponent();
        }
        private void IngresosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana de registros de ingresos
            RegistroIngresos registroIngresos = new RegistroIngresos();
            registroIngresos.ShowDialog();
        }
        private void MantenimientoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Crear una instancia de la nueva ventana de Mantenimiento
            Mantenimiento mantenimientoWindow = new Mantenimiento();

            // Mostrar la nueva ventana
            mantenimientoWindow.Show();

            // Opcionalmente, cierra la ventana actual si deseas
            this.Close();
        }
        private void ReporteItem_Click(object sender, RoutedEventArgs e)
        {
            // Crear una instancia de la nueva ventana de Mantenimiento
            Reportes reportesWindow = new Reportes();

            // Mostrar la nueva ventana
            reportesWindow.Show();

            // Opcionalmente, cierra la ventana actual si deseas
            this.Close();
        }


    }
}
