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

namespace WpfApp6
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Film> films = new ObservableCollection<Film>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this.GetFilms();
        }

        public ObservableCollection<Film> GetFilms()
        {
            return films;
        }

        private void DodajFilm(object sender, RoutedEventArgs e)
        {
            films.Add(new Film());
        }

        public void EdytujFilm(object sender, RoutedEventArgs e)
        {
            ListBox lista = (ListBox)this.FindName("Film");
            Film film = (Film)lista.SelectedItem;
            new OknoEdycji(film).Show();
        }
    }

    public class Film
    {
        public Film()
        {
            tytuł = "";
            reżyser = "";
            studio = "";
            nośnik = "";
            dataWydania = DateTime.Parse("01.01.2001");
        }

        public string tytuł { get; set; }
        public string reżyser { get; set; }
        public string studio { get; set; }
        public string nośnik { get; set; }
        public DateTime dataWydania { get; set; }
    }
}
