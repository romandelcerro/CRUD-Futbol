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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Linq
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Buscador(object sender, RoutedEventArgs e)
        {
            Buscador buscador = new Buscador();
            buscador.Show();
            this.Close();
        }

        private void Button_Insertar(object sender, RoutedEventArgs e)
        {
            Insertar insertar = new Insertar();
            insertar.Show();
            this.Close();
        }

        private void Button_Actualizar(object sender, RoutedEventArgs e)
        {
            Actualizar actualizar = new Actualizar();
            actualizar.Show();
            this.Close();
        }

        private void Button_Borrar(object sender, RoutedEventArgs e)
        {
            Borrar borrar = new Borrar();
            borrar.Show();
            this.Close();
        }
    }
}
