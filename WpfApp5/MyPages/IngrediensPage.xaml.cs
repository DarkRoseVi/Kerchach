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
    /// Логика взаимодействия для IngrediensPage.xaml
    /// </summary>
    public partial class IngrediensPage : Page
    {
        public IngrediensPage()
        {
            InitializeComponent();
            IngredientLW.ItemsSource = BdConect.db.Ingredient.ToList();
        }

        private void DeletBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var ing = (sender as Button).DataContext as Ingredient;
            Navidation.NextPage(new Nav("Редактирование", new EsitIngredientpage(ing)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Navidation.NextPage(new Nav("Добавление", new EsitIngredientpage(new Ingredient())));
        }
    }
}
