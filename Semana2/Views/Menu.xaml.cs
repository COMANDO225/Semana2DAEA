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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void operacionesBtn_Click(object sender, RoutedEventArgs e)
        {
            Operaciones op = new();
            op.Show();
            this.Close();
        }

        private void mantenimientoBtn_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento man = new();
            man.Show();
            this.Close();
        }

        private void reportesBtn_Click(object sender, RoutedEventArgs e)
        {
            Reportes rep = new();
            rep.Show();
            this.Close();
        }

        private void cerrarSessionBtn_Click(object sender, RoutedEventArgs e)
        {
            Login login = new();
            login.Show();
            this.Close();
        }
    }
}
