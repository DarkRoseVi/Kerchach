using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;
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
using System.Data.Entity;

namespace WpfApp5.MyPages
{
    /// <summary>
    /// Логика взаимодействия для RecipePage.xaml
    /// </summary>
    public partial class RecipePage : Page
    {
        public static Recipe instance { get; private set; }
        public IEnumerable<CookingStage> CookingStage
        {
            get { return (IEnumerable<CookingStage>)GetValue(CookingStageProperty); }
            set { SetValue(CookingStageProperty, value); }
        }

        public static readonly DependencyProperty CookingStageProperty =
            DependencyProperty.Register("CookingStage", typeof(IEnumerable<CookingStage>), typeof(Recipe));

        public IEnumerable<IngredientOfCookingSage> IngredientOfStage
        {
            get { return (IEnumerable<IngredientOfCookingSage>)GetValue(IngredientOfStageProperty); }
            set { SetValue(IngredientOfStageProperty, value); }
        }

        public static readonly DependencyProperty IngredientOfStageProperty =
            DependencyProperty.Register("IngredientOfStage", typeof(IEnumerable<IngredientOfCookingSage>), typeof(Recipe));

        public Dish DishObject
        {
            get { return (Dish)GetValue(DishesProperty); }
            set { SetValue(DishesProperty, value); }
        }
        public static readonly DependencyProperty DishesProperty =
         DependencyProperty.Register("DishObject", typeof(Dish), typeof(Recipe));

        public Dish dish { get; set; }
        public RecipePage(Dish _dish)
        {
            BdConect.db.IngredientOfCookingSage.Load();
            IngredientOfStage = BdConect.db.IngredientOfCookingSage.Local;
            CookingStage = _dish.CookingStage;
            DishObject = _dish;
          
            InitializeComponent();
            instance = this;
            dish = _dish;
        
           
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
