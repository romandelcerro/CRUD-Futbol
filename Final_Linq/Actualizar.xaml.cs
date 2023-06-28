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
    /// Lógica de interacción para Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {
        DataClasses1DataContext dataContext;

        public Actualizar()
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
            tbNombre.Text = "";
            tbEstadio.Text = "";
            tbValor.Text = "";
            tbEstadio.Text = "";
            tbJugadores.Text = "";
            tbLiga.Text = "";

            cbLigas.Items.Clear();
            
            var ligasEsp = from liga in dataContext.Liga where liga.País == "España" select liga;

            foreach (var liga in ligasEsp)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbInglaterra_Click(object sender, RoutedEventArgs e)
        {
            tbNombre.Text = "";
            tbEstadio.Text = "";
            tbValor.Text = "";
            tbEstadio.Text = "";
            tbJugadores.Text = "";
            tbLiga.Text = "";

            cbLigas.Items.Clear();
            
            var ligasIng = from liga in dataContext.Liga where liga.País == "Inglaterra" select liga;

            foreach (var liga in ligasIng)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void rbItalia_Click(object sender, RoutedEventArgs e)
        {
            tbNombre.Text = "";
            tbEstadio.Text = "";
            tbValor.Text = "";
            tbEstadio.Text = "";
            tbJugadores.Text = "";
            tbLiga.Text = "";

            cbLigas.Items.Clear();
            
            var ligasIta = from liga in dataContext.Liga where liga.País == "Italia" select liga;

            foreach (var liga in ligasIta)
            {
                cbLigas.Items.Add(liga.Nombre);
            }
        }

        private void cbLigas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            tbNombre.Text = "";
            tbEstadio.Text = "";
            tbValor.Text = "";
            tbEstadio.Text = "";
            tbJugadores.Text = "";
            tbLiga.Text = "";

            String liga = (String)cbLigas.SelectedItem;

            var listaEquipos = from equipos in dataContext.Equipos
                               where equipos.Liga == liga
                               select equipos;

            lvEquipos.ItemsSource = listaEquipos;

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
                    tbNombre.Text = equipo.Nombre;
                    tbEstadio.Text = equipo.Estadio;
                    tbValor.Text = equipo.Valor_Equipo.ToString();
                    tbJugadores.Text = equipo.Num_Jugadores.ToString();
                    tbLiga.Text = equipo.Liga;

                }

                

            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

            Equipos idEquipo = (Equipos)lvEquipos.SelectedItem;
            var listaEquipos = from equipos in dataContext.Equipos
                               where equipos.Id == idEquipo.Id
                               select equipos;

            foreach (var equipo in listaEquipos)
            {
                equipo.Nombre = tbNombre.Text;
                equipo.Estadio = tbEstadio.Text;
                equipo.Num_Jugadores = int.Parse(tbJugadores.Text);
                equipo.Liga = tbLiga.Text;
                equipo.Valor_Equipo = long.Parse(tbValor.Text);
                dataContext.SubmitChanges();

            }
        }
    }
}
