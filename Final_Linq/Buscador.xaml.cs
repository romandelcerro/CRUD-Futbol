using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Configuration;

namespace Final_Linq
{
    /// <summary>
    /// Lógica de interacción para Buscador.xaml
    /// </summary>
    /// 

    public partial class Buscador : Window
    {
        DataClasses1DataContext dataContext;

        public Buscador()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["Final_Linq.Properties.Settings.FutbolConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(miConexion);
            
            var ligasEsp = from liga in dataContext.Liga where liga.País == "España" select liga;

            foreach (var liga in ligasEsp)
            {
                cbLigas.Items.Add(liga.Nombre);
            }

            

        }

        private void Button_Home(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            home.Show();
            this.Close();
        }


        public void rbEspaña_Click(object sender, RoutedEventArgs e)
        {
            cbLigas.Items.Clear();
            Uri resourceUri = new Uri("/Imágenes/balon.png", UriKind.Relative);
            imgEscudo.Source = new BitmapImage(resourceUri);
            var ligasEsp = from liga in dataContext.Liga where liga.País == "España" select liga;

            foreach (var liga in ligasEsp)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbInglaterra_Click(object sender, RoutedEventArgs e)
        {
            cbLigas.Items.Clear();
            Uri resourceUri = new Uri("/Imágenes/balon.png", UriKind.Relative);
            imgEscudo.Source = new BitmapImage(resourceUri);
            var ligasIng = from liga in dataContext.Liga where liga.País == "Inglaterra" select liga;

            foreach (var liga in ligasIng)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbItalia_Click(object sender, RoutedEventArgs e)
        {
            cbLigas.Items.Clear();
            Uri resourceUri = new Uri("/Imágenes/balon.png", UriKind.Relative);
            imgEscudo.Source = new BitmapImage(resourceUri);
            var ligasIta = from liga in dataContext.Liga where liga.País == "Italia" select liga;

            foreach (var liga in ligasIta)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void cbLigas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Uri resourceUri = new Uri("/Imágenes/balon.png", UriKind.Relative);
            imgEscudo.Source = new BitmapImage(resourceUri);

            String liga = (String)cbLigas.SelectedItem;

            var listaEquipos = from equipos in dataContext.Equipos
                            where equipos.Liga == liga
                            select equipos;

            lvEquipos.ItemsSource= listaEquipos;

        }

        private void lvEquipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvEquipos.SelectedItem != null)
            {
                Equipos idEquipo = (Equipos)lvEquipos.SelectedItem;
                var listaEquipos = from equipos in dataContext.Equipos
                                where equipos.Id == idEquipo.Id
                                select equipos;

                foreach (var equipo in listaEquipos)
                {
                    Uri resourceUri = new Uri(equipo.Escudo, UriKind.Relative);
                    imgEscudo.Source = new BitmapImage(resourceUri);
                }
                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Equipos> lv = new List<Equipos>();

            foreach(Equipos equipo in lvEquipos.Items)
            {
                lv.Add(equipo);
            }

            var ordenarValor = from equipos in lv
                               orderby equipos.Valor_Equipo
                               select equipos;

            lvEquipos.ItemsSource = ordenarValor;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Equipos> lv = new List<Equipos>();

            foreach (Equipos equipo in lvEquipos.Items)
            {
                lv.Add(equipo);
            }

            var ordenarValor = from equipos in lv
                               orderby equipos.Num_Jugadores
                               select equipos;

            lvEquipos.ItemsSource = ordenarValor;
        }
    }
}
