using AnimeListApplication.Pages;
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

namespace AnimeListApplication
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            //var anim = from a in db.AnimeDatas
            //           select a;

            //this.GridOfAnime.ItemsSource = anim.ToList();
        }


        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Close();

        }

        private void MainToWatching(object sender, RoutedEventArgs e)
        {
            Main.Content = new Watching();
        }

        private void MainToWatched(object sender, RoutedEventArgs e)
        {
            Main.Content = new Completed();
        }

        private void MainToPlanToWatch(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlanToWatch();
        }

        private void MainToDropped(object sender, RoutedEventArgs e)
        {
            Main.Content = new Dropped();
        }

        private void MainToAnimeDataBase(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddAnimeToDataBase();
        }
    }
}
