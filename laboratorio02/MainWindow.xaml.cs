using System;
using System.Windows;
using System.Windows.Controls;

namespace laboratorio02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Verificar el usuario y la contraseña (personaliza esta lógica según tus necesidades)
            if (username == "diego" && password == "123")
            {
                // Usuario y contraseña correctos, realiza la lógica de inicio de sesión aquí
                // Puedes abrir una nueva ventana o realizar cualquier acción deseada
                ventana1 ventana1 = new ventana1();
                this.Close();
                ventana1.Show();
            }
            else
            {
                // Usuario o contraseña incorrectos, muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
