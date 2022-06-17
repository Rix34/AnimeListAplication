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
    /// Logika interakcji dla klasy Watching.xaml
    /// </summary>
    public partial class Watching : Page
    {
        public Watching()
        {
            InitializeComponent();

            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            var anim = from a in db.Animes
                       select new
                       {
                           User = a.LoginData.Nickname,
                           Title = a.AnimeList.AnimeData.Title,
                           Studio = a.AnimeList.AnimeData.StudioID,
                           Status = a.AnimeList.StatusID,
                           Note = a.AnimeList.NoteID,

                       };

            this.GridOfAnime.ItemsSource = anim.ToList();
        }


        //private void ADDADB(object sender, RoutedEventArgs e)
        //{
        //    AnimeDataBaseEntities db = new AnimeDataBaseEntities();

        //    Anime anims = new Anime()
        //    {
        //        Id = Int32.Parse(thxtTitle.Text),
        //        LogID = Int32.Parse(thxtStatus.Text),
        //        AnimeID = Int32.Parse(thxtNote.Text),
            
        //    };
        //    db.Animes.Add(anims);
        //    db.SaveChanges();

        //}
    }
}
