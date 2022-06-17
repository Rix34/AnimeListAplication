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
    /// Logika interakcji dla klasy Dropped.xaml
    /// </summary>
    public partial class Dropped : Page
    {
        public Dropped()
        {
            InitializeComponent();
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            var anim = from a in db.AnimeLists
                       select new
                       {
                           Title = a.AnimeData.Title,
                           Status = a.Status.Status1,
                           Note = a.Note.Note1,
                       };

            this.GridOfAnime.ItemsSource = anim.ToList();
        }
    }
}
