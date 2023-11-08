using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace DataBinding_de_AritzA
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Empleado> empleados = new ObservableCollection<Empleado>();
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = empleados;
        }

        private void AgregarEmpleadoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Nombre.Text == "Nombre" || Apellidos.Text == "Apellidos" || Email.Text == "E-mail" || Telefono.Text == "Teléfono")
            {
                MessageBox.Show("Completa los campos obligatorios.");
            }else
            {
                Empleado nuevoEmpleado = new Empleado
                {
                    Nombre = Nombre.Text,
                    Apellidos = Apellidos.Text,
                    Email = Email.Text,
                    Telefono = Telefono.Text
                };

                empleados.Add(nuevoEmpleado);
                Nombre.Text = "Nombre";
                Apellidos.Text = "Apellidos";
                Email.Text = "E-mail";
                Telefono.Text = "Teléfono";
            }
        }

        private void AbrirImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg|Todos los archivos|*.*"; // Filtro de archivos de imagen
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string filename = openFileDialog.FileName;
                    BitmapImage bitmap = new BitmapImage(new Uri(filename));
                    Imagen.Source = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void Text_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Nombre" || textBox.Text == "Apellidos" || textBox.Text == "E-mail" || textBox.Text == "Teléfono")
                {
                    textBox.Text = "";
                }
            }
        }

        private void Text_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text)){
                    if (textBox.Name == "Nombre")
                    {
                        textBox.Text = "Nombre";
                    }
                    else if (textBox.Name == "Apellidos")
                    {
                        textBox.Text = "Apellidos";
                    }
                    else if (textBox.Name == "Email")
                    {
                        textBox.Text = "E-mail";
                    }
                    else if (textBox.Name == "Telefono")
                    {
                        textBox.Text = "Teléfono";
                    }
                }
            }
        }
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }

}
