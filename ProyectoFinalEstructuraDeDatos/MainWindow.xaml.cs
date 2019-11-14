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

namespace ProyectoFinalEstructuraDeDatos
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
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(rdSeries.IsChecked == true)
            {
                grdCine.Children.Add(new Series());
                lbl_Pelicula.Visibility = Visibility.Hidden;
                lbl_Serie.Visibility = Visibility.Hidden;
                lbl_Tipo.Visibility = Visibility.Hidden;
                Stackpanel.Visibility = Visibility.Hidden;
                btn_Cancelar.Visibility = Visibility.Visible;
                btn_Guardar.Visibility = Visibility.Visible;
            }
            else if(rdPeliculas.IsChecked == true)
            {
                grdCine.Children.Add(new Peliculas());
                lbl_Pelicula.Visibility = Visibility.Hidden;
                lbl_Serie.Visibility = Visibility.Hidden;
                lbl_Tipo.Visibility = Visibility.Hidden;
                Stackpanel.Visibility = Visibility.Hidden;
                btn_Cancelar.Visibility = Visibility.Visible;
                btn_Guardar.Visibility = Visibility.Visible;
            }
        }

        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            grdCine.Children.Clear();
            lbl_Pelicula.Visibility = Visibility.Visible;
            lbl_Serie.Visibility = Visibility.Visible;
            lbl_Tipo.Visibility = Visibility.Visible;
            Stackpanel.Visibility = Visibility.Visible;
            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Guardar.Visibility = Visibility.Hidden;
        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            grdCine.Children.Clear();
            lbl_Pelicula.Visibility = Visibility.Visible;
            lbl_Serie.Visibility = Visibility.Visible;
            lbl_Tipo.Visibility = Visibility.Visible;
            Stackpanel.Visibility = Visibility.Visible;
            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Guardar.Visibility = Visibility.Hidden;
        }
    }
}
