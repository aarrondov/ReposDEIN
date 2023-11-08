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

namespace Estilos_de_Aritz_A
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            Close();
            w.Show();
        }

        private void WindowSearch(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            Close();
            w1.Show();
        }

        private void Error(object sender, RoutedEventArgs e)
        {
            //WindowError ventanaError = new WindowError();
        }
    }
}
