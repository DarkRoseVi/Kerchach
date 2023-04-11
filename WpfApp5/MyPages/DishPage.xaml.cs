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
using WpfApp5.Componens;
using WpfApp5.MyPages;

namespace WpfApp5.MyPages
{
    /// <summary>
    /// Логика взаимодействия для DishPage.xaml
    /// </summary>
    public partial class DishPage : Page
    {
        CookEntities _context = new CookEntities();
        public DishPage()
        {
            InitializeComponent();
            Refrese();

        }
        private void Refrese() 
        {
            List<Dish> listdis = _context.Dish.ToList();
            LViewDishes.ItemsSource = listdis;
        }

        private void LViewDishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navidation.NextPage(new Nav("Рецепт", new RecipePage(LViewDishes.SelectedItem as Dish)));
        }
    }
}
