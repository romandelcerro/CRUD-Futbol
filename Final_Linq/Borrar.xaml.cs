using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
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

namespace Final_Linq
{
    /// <summary>
    /// Lógica de interacción para Borrar.xaml
    /// </summary>
    public partial class Borrar : Window
    {

        DataClasses1DataContext dataContext;
        public Borrar()
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
            
            var ligasEsp = from liga in dataContext.Liga where liga.País == "España" select liga;

            foreach (var liga in ligasEsp)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbInglaterra_Click(object sender, RoutedEventArgs e)
        {
            cbLigas.Items.Clear();
           
            var ligasIng = from liga in dataContext.Liga where liga.País == "Inglaterra" select liga;

            foreach (var liga in ligasIng)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbItalia_Click(object sender, RoutedEventArgs e)
        {
            cbLigas.Items.Clear();
            
            var ligasIta = from liga in dataContext.Liga where liga.País == "Italia" select liga;

            foreach (var liga in ligasIta)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void cbLigas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            refrescaLv();

        }

        private void lvEquipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lvEquipos.SelectedItem != null)
            {
                Equipos equipo = (Equipos)lvEquipos.SelectedItem;

                dataContext.Equipos.DeleteOnSubmit(equipo);
                dataContext.SubmitChanges();
                refrescaLv();
            }
        }

        private void refrescaLv()
        {

            String liga = (String)cbLigas.SelectedItem;

            var listaEquipos = from equipos in dataContext.Equipos
                               where equipos.Liga == liga
                               select equipos;

            lvEquipos.ItemsSource = listaEquipos;
        }

        
    }
}
