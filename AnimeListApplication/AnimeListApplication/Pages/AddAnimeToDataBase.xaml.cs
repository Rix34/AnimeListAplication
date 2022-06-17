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
                           ID = a.Id,
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
                Id = Int32.Parse(thxtID.Text),
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
                           ID = a.Id,
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
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

          
            var a = from d in db.AnimeDatas
                    where d.Id == updatingAnimeID
                    select d;
            AnimeData obj = a.SingleOrDefault();
            if (obj != null)
            {
                db.AnimeDatas.Remove(obj);
                db.SaveChanges();
            }
             


        }
        private int updatingAnimeID = 0;
        private void GridOfAnime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (this.GridOfAnime.SelectedIndex >= 0)
            {
                if (this.GridOfAnime.SelectedItems.Count >= 0)
                {
                    if (this.GridOfAnime.SelectedItems.GetType() == typeof(AnimeDataBaseEntities))
                    {
                        AnimeData a = (AnimeData)this.GridOfAnime.SelectedItems[0];
                        this.thxtID.Text = a.Id.ToString();
                        this.thxtTitle.Text = a.Title;
                        this.thxtGenre.Text = a.GenreID.ToString();
                        this.thxtAired.Text = a.Aired.ToString();
                        this.thxtStudio.Text = a.Studio.ToString();
                        this.updatingAnimeID = a.Id;
                    }
                }
            }
        }

        private void UpdatButton(object sender, RoutedEventArgs e)
        {
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            var a = from d in db.AnimeDatas
                    where d.Id == updatingAnimeID
                    select d;
            AnimeData obj = a.SingleOrDefault();
           if (obj != null)
            {
                obj.Id = Int32.Parse(this.thxtID.Text);
                obj.Title = this.thxtTitle.Text;
                obj.GenreID = Int32.Parse(this.thxtGenre.Text);
                obj.Aired = DateTime.Parse(this.thxtAired.Text);
                obj.StudioID = Int32.Parse(this.thxtStudio.Text);
                db.SaveChanges();
            }
            

        }
    }
  }



