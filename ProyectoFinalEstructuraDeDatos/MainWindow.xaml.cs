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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProyectoFinalEstructuraDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Collección de Datos
        ObservableCollection<Datos> listaDatos = new ObservableCollection<Datos>();

        // Colección de Películas
        ObservableCollection<Peliculas> peliculas = new ObservableCollection<Peliculas>();

        // Colección de Series
        ObservableCollection<Series> series = new ObservableCollection<Series>();

        public MainWindow()
        {
            InitializeComponent();

            Peliculas pelicula1 = new Peliculas("Pelicula" ,"Wuu", 2006, "Acción", "adsfadfasfdr", 2);
            Series serie1 = new Series("Serie", "Wuu2", 2002, "Comedia", "adsfadfasfdr", 2, 10, "Alexia");

            listaDatos.Add(pelicula1);
            listaDatos.Add(serie1);

            lista.ItemsSource = listaDatos;
        }

        // Add New
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rdSeries.IsChecked == true)
            {
                hideFields();

                lblNuevo.Visibility = Visibility.Visible;
                txtTitle.Visibility = Visibility.Visible;
                txtTitle2.Visibility = Visibility.Visible;
                txtYear.Visibility = Visibility.Visible;
                txtYear2.Visibility = Visibility.Visible;
                txtSeasons.Visibility = Visibility.Visible;
                txtSeasons2.Visibility = Visibility.Visible;
                txtRating.Visibility = Visibility.Visible;
                txtRating2.Visibility = Visibility.Visible;
                txtProductor.Visibility = Visibility.Visible;
                txtProductor2.Visibility = Visibility.Visible;
                txtDescription.Visibility = Visibility.Visible;
                txtDescription2.Visibility = Visibility.Visible;
                cmbGenre.Visibility = Visibility.Visible;
                cmbGenre2.Visibility = Visibility.Visible;

                txtTitle.Text = "";
                txtYear.Text = "";
                txtSeasons.Text = "";
                txtRating.Text = "";
                txtProductor.Text = "";
                txtDescription.Text = "";
                cmbGenre.SelectedIndex = -1;

                btn_Cancelar.Visibility = Visibility.Visible;
                btn_Guardar.Visibility = Visibility.Visible;
            }
            else if(rdPeliculas.IsChecked == true)
            {
                hideFields();

                lblNuevo.Visibility = Visibility.Visible;
                lblTitulo.Visibility = Visibility.Visible;
                lblTitulo2.Visibility = Visibility.Visible;
                lblAño.Visibility = Visibility.Visible;
                lblAño2.Visibility = Visibility.Visible;
                lblDescripcion.Visibility = Visibility.Visible;
                lblDescripcion2.Visibility = Visibility.Visible;
                lblRating.Visibility = Visibility.Visible;
                lblRating2.Visibility = Visibility.Visible;
                cmbGenero.Visibility = Visibility.Visible;
                cmbGenero2.Visibility = Visibility.Visible;

                lblTitulo.Text = "";
                lblAño.Text = "";
                lblTitulo.Text = "";
                lblRating.Text = "";
                lblDescripcion.Text = "";
                cmbGenero.SelectedIndex = -1;

                btn_Cancelar.Visibility = Visibility.Visible;
                btn_Guardar.Visibility = Visibility.Visible;
            }
        }

        // Save
        private void btn_Guardar_Click(object sender, RoutedEventArgs e)
        {
            if(Int32.Parse(lblRating.Text) > 5 || Int32.Parse(txtRating.Text) > 5 || Int32.Parse(lblRating.Text) < 0 || Int32.Parse(txtRating.Text) < 0)
            {
                lblErrorRating.Visibility = Visibility.Visible;
            }
            else if (rdSeries.IsChecked == true)
            {
                Series serie = new Series(
                        "Serie",
                        txtTitle.Text,
                        Int32.Parse(txtYear.Text),
                        cmbGenre.SelectedIndex.ToString(),
                        txtDescription.Text,
                        Int32.Parse(txtRating.Text),
                        Int32.Parse(txtSeasons.Text),
                        txtProductor.Text
                        );

                listaDatos.Add(serie);
                lista.ItemsSource = listaDatos;
                
                hideFields();

                btnNuevo.Visibility = Visibility.Visible;
                lbl_Pelicula.Visibility = Visibility.Visible;
                lbl_Serie.Visibility = Visibility.Visible;
                lbl_Tipo.Visibility = Visibility.Visible;
                Stackpanel.Visibility = Visibility.Visible;
            }
            else if (rdPeliculas.IsChecked == true)
            {
                Peliculas pelicula = new Peliculas(
                       "Pelicula",
                       lblTitulo.Text,
                       Int32.Parse(lblAño.Text),
                       cmbGenero.SelectedIndex.ToString(),
                       lblDescripcion.Text,
                       Int32.Parse(lblRating.Text)
                       );

                listaDatos.Add(pelicula);
                lista.ItemsSource = listaDatos;

                hideFields();

                btnNuevo.Visibility = Visibility.Visible;
                lbl_Pelicula.Visibility = Visibility.Visible;
                lbl_Serie.Visibility = Visibility.Visible;
                lbl_Tipo.Visibility = Visibility.Visible;
                Stackpanel.Visibility = Visibility.Visible;
            }
        }

        // Cancel
        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            hideFields();

            btnNuevo.Visibility = Visibility.Visible;
            lbl_Pelicula.Visibility = Visibility.Visible;
            lbl_Serie.Visibility = Visibility.Visible;
            lbl_Tipo.Visibility = Visibility.Visible;
            Stackpanel.Visibility = Visibility.Visible;
        }

        // Hide 
        private void hideFields()
        {
            lblNuevo.Visibility = Visibility.Hidden;
            lblTitulo.Visibility = Visibility.Hidden;
            lblTitulo2.Visibility = Visibility.Hidden;
            lblAño.Visibility = Visibility.Hidden;
            lblAño2.Visibility = Visibility.Hidden;
            lblDescripcion.Visibility = Visibility.Hidden;
            lblDescripcion2.Visibility = Visibility.Hidden;
            lblRating.Visibility = Visibility.Hidden;
            lblRating2.Visibility = Visibility.Hidden;
            cmbGenero.Visibility = Visibility.Hidden;
            cmbGenero2.Visibility = Visibility.Hidden;


            lblNuevo.Visibility = Visibility.Hidden;
            txtYear.Visibility = Visibility.Hidden;
            txtYear2.Visibility = Visibility.Hidden;
            txtTitle.Visibility = Visibility.Hidden;
            txtTitle2.Visibility = Visibility.Hidden;
            txtSeasons.Visibility = Visibility.Hidden;
            txtSeasons2.Visibility = Visibility.Hidden;
            txtRating.Visibility = Visibility.Hidden;
            txtRating2.Visibility = Visibility.Hidden;
            txtProductor.Visibility = Visibility.Hidden;
            txtProductor2.Visibility = Visibility.Hidden;
            txtDescription.Visibility = Visibility.Hidden;
            txtDescription2.Visibility = Visibility.Hidden;
            cmbGenre.Visibility = Visibility.Hidden;
            cmbGenre2.Visibility = Visibility.Hidden;

            btn_Cancelar.Visibility = Visibility.Hidden;
            btn_Guardar.Visibility = Visibility.Hidden;
            btn_Editar.Visibility = Visibility.Hidden;
            lblErrorRating.Visibility = Visibility.Hidden;
            grdCine.Children.Clear();
        }

        // List Selection
        private void lista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            hideFields();
            btn_Cancelar.Visibility = Visibility.Visible;
            btn_Editar.Visibility = Visibility.Visible;

            if (listaDatos[lista.SelectedIndex].Formato == "Pelicula")
            {
                grdCine.Children.Add(new VisualizacionPeliculas());

                ((VisualizacionPeliculas)(grdCine.Children[0])).txtTitle.Text = listaDatos[lista.SelectedIndex].Titulo;
                ((VisualizacionPeliculas)(grdCine.Children[0])).txtYear.Text = listaDatos[lista.SelectedIndex].Año.ToString();
                ((VisualizacionPeliculas)(grdCine.Children[0])).txtRating.Text = listaDatos[lista.SelectedIndex].Rating.ToString();
                ((VisualizacionPeliculas)(grdCine.Children[0])).txtDescription.Text = listaDatos[lista.SelectedIndex].Descripcion;
                ((VisualizacionPeliculas)(grdCine.Children[0])).cmbGenre.SelectedIndex = Int32.Parse(listaDatos[lista.SelectedIndex].Genero.ToString());
            }
            else if (listaDatos[lista.SelectedIndex].Formato == "Serie")
            {
                grdCine.Children.Add(new VisualizacionSeries());

                ((VisualizacionSeries)(grdCine.Children[0])).txtTitle.Text = listaDatos[lista.SelectedIndex].Titulo;
                ((VisualizacionSeries)(grdCine.Children[0])).txtYear.Text = listaDatos[lista.SelectedIndex].Año.ToString();
                ((VisualizacionSeries)(grdCine.Children[0])).txtRating.Text = listaDatos[lista.SelectedIndex].Rating.ToString();
                ((VisualizacionSeries)(grdCine.Children[0])).txtDescription.Text = listaDatos[lista.SelectedIndex].Descripcion;
                ((VisualizacionSeries)(grdCine.Children[0])).cmbGenre.SelectedIndex = Int32.Parse(listaDatos[lista.SelectedIndex].Genero.ToString());
                ((VisualizacionSeries)(grdCine.Children[0])).txtProductor.Text = listaDatos[lista.SelectedIndex].Productor;
                ((VisualizacionSeries)(grdCine.Children[0])).txtSeasons.Text = listaDatos[lista.SelectedIndex].Temporadas.ToString();
            }
        }

        // Edit Movie/Series !!!
        private void btn_Editar_Click(object sender, RoutedEventArgs e)
        {
            if (listaDatos[lista.SelectedIndex].Formato == "Serie")
            {
                listaDatos[lista.SelectedIndex].Titulo = ((VisualizacionSeries)(grdCine.Children[0])).txtTitle.Text;
                listaDatos[lista.SelectedIndex].Año = Int32.Parse(((VisualizacionSeries)(grdCine.Children[0])).txtYear.Text);
                listaDatos[lista.SelectedIndex].Rating = Int32.Parse(((VisualizacionSeries)(grdCine.Children[0])).txtRating.Text);
                listaDatos[lista.SelectedIndex].Descripcion = ((VisualizacionSeries)(grdCine.Children[0])).txtDescription.Text;
                listaDatos[lista.SelectedIndex].Genero = ((VisualizacionSeries)(grdCine.Children[0])).cmbGenre.SelectedIndex.ToString();
                listaDatos[lista.SelectedIndex].Productor = ((VisualizacionSeries)(grdCine.Children[0])).txtProductor.Text;
                listaDatos[lista.SelectedIndex].Temporadas = Int32.Parse(((VisualizacionSeries)(grdCine.Children[0])).txtSeasons.Text);
                lista.Items.Refresh();
                
            }
            else if (listaDatos[lista.SelectedIndex].Formato == "Pelicula")
            {
                listaDatos[lista.SelectedIndex].Titulo = ((VisualizacionPeliculas)(grdCine.Children[0])).txtTitle.Text;
                listaDatos[lista.SelectedIndex].Año = Int32.Parse(((VisualizacionPeliculas)(grdCine.Children[0])).txtYear.Text);
                listaDatos[lista.SelectedIndex].Rating = Int32.Parse(((VisualizacionPeliculas)(grdCine.Children[0])).txtRating.Text);
                listaDatos[lista.SelectedIndex].Descripcion = ((VisualizacionPeliculas)(grdCine.Children[0])).txtDescription.Text;
                listaDatos[lista.SelectedIndex].Genero = ((VisualizacionPeliculas)(grdCine.Children[0])).cmbGenre.SelectedIndex.ToString();
                lista.Items.Refresh();
            }
            hideFields();
        }
        
        /// Sorting Methods

        // Order A-Z
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lista.Items.SortDescriptions.Clear();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lista.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Titulo", ListSortDirection.Ascending));
        }

        // Order Year Asc
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lista.Items.SortDescriptions.Clear();
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < listaDatos.Count - 1; i++)
                {
                    if (listaDatos[i].Año > listaDatos[i + 1].Año)
                    {
                        var temp = listaDatos[i];
                        listaDatos[i] = listaDatos[i + 1];
                        listaDatos[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change);
        }

        // Order Z-A
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lista.Items.SortDescriptions.Clear();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lista.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Titulo", ListSortDirection.Descending));
        }

        // Order Year Desc
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lista.Items.SortDescriptions.Clear();
            bool change = false;
            do
            {
                change = false;
                for (int i = 0; i < listaDatos.Count - 1; i++)
                {
                    if (listaDatos[i].Año < listaDatos[i + 1].Año)
                    {
                        var temp = listaDatos[i];
                        listaDatos[i] = listaDatos[i + 1];
                        listaDatos[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change);
        }
    }
}
