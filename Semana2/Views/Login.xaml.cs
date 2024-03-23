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

namespace Semana2.Views
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = emailText.Text;
            string password = passwordText.Password;

            if (email == "anderson@gmail.com" || email == "anderson.almeyda@gmail.com" &&  password == "123456")
            {
                MessageBox.Show("Inciaste alarako mano");
                Menu menumasna = new();
                menumasna.Show();
                this.Close();
            } else
            {
                errorEmail.Text = "Correo o password incorrrectos";
                errorPass.Text = "Correo o password incorrectos";
                MessageBox.Show("Vete a otra carrera");
            }
        }
    }
}
