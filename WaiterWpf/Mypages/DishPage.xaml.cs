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
using WaiterWpf.Components;
using WaiterWpf.Mypages; 

namespace WaiterWpf.Mypages
{
    /// <summary>
    /// Логика взаимодействия для DishPage.xaml
    /// </summary>
    public partial class DishPage : Page
    {
        kersachViEntities _context = new kersachViEntities();
        public DishPage()
        {
            InitializeComponent();
            LViewDishes.ItemsSource = BdConect.db.Dish.ToList();
            List<Category> cated = BdConect.db.Category.ToList();
            cated.Insert(0, new Category { Title = "Все" });
            CategorylCb.ItemsSource = cated;
            CategorylCb.SelectedIndex = 0;
            List<DegreeSharpness> degreg = BdConect.db.DegreeSharpness.ToList();
            degreg.Insert(0, new DegreeSharpness { Title = "Все" });
            DegreeSharpnesslCb.ItemsSource = degreg;
            DegreeSharpnesslCb.SelectedIndex = 0;
        }
        private void Refrese()
        {
            //IEnumerable<Dish> listdis = _context.Dish.ToList();


            //if (CategorylCb.SelectedIndex != 0)
            //{
            //    Category selecrcategory = (Category)CategorylCb.SelectedItem;
            //    listdis = listdis.Where(x => x.CategoryId == selecrcategory.Id).ToList();
            //}

            //if (DegreeSharpnesslCb.SelectedIndex != 0)
            //{
            //    DegreeSharpness selectdegree = (DegreeSharpness)DegreeSharpnesslCb.SelectedItem;
            //    listdis = listdis.Where(x => x.DegreeSharpnessId == selectdegree.Id).ToList();
            //}
            //LViewDishes.ItemsSource = listdis;

        }

        private void PoisTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refrese();

        }

        private void DegreeSharpnesslCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refrese();
        }

        private void CategorylCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refrese();
        }
    }
}
