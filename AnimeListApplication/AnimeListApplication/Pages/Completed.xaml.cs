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
    /// Logika interakcji dla klasy Completed.xaml
    /// </summary>
    public partial class Completed : Page
    {
        public Completed()
        {
            InitializeComponent();
            AnimeDataBaseEntities db = new AnimeDataBaseEntities();

            var anim = from a in db.Users
                       select new
                       {
                           FirstName = a.FirstName,
                           Status = a.SecondName,
                           Login = a.LoginData.Nickname,
                           Password = a.LoginData.Password,
                       };

            this.GridOfAnime.ItemsSource = anim.ToList();
        }
    }
}
