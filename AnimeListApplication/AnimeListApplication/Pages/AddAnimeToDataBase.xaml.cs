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

namespace AnimeListApplication.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy AddAnimeToDataBase.xaml
    /// </summary>
    public partial class AddAnimeToDataBase : Page
    {
        public AddAnimeToDataBase()
        {
            InitializeComponent();

            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            var anim = from a in db.AnimeDatas
                       select new
                       {
                           Image = a.Image,
                           Title = a.Title,
                           Genre = a.Genre.Genre1,
                           Aired = a.Aired,
                           Studio = a.Studio.Studio1,
                       };

            this.GridOfAnime.ItemsSource = anim.ToList();
        }



        private void ADDADB(object sender, RoutedEventArgs e)
        {
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            AnimeData animeData = new AnimeData()
            {
                Title = thxtTitle.Text,
                GenreID = Int32.Parse(thxtGenre.Text),
                Aired = DateTime.Parse(thxtAired.Text),
                StudioID = Int32.Parse(thxtStudio.Text),
            };
            db.AnimeDatas.Add(animeData);
            db.SaveChanges();

        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();
            var anim = from a in db.AnimeDatas
                       select new
                       {
                           Image = a.Image,
                           Title = a.Title,
                           Genre = a.Genre.Genre1,
                           Aired = a.Aired,
                           Studio = a.Studio.Studio1,
                       };
            this.GridOfAnime.ItemsSource = anim.ToList();
        }

        private void DTAFDB(object sender, RoutedEventArgs e)
        {

        }
    }


}
