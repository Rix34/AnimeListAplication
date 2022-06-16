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
                       select a;

            this.GridOfAnime.ItemsSource = anim.ToList();
        }

   
    }


}
