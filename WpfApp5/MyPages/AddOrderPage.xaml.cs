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
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public static AddOrderPage Instance { get; private set; }


        public IEnumerable<Dish> diseslidt
        {
            get { return (IEnumerable<Dish>)GetValue(diseslidtProperty); }
            set { SetValue(diseslidtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for diseslidt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty diseslidtProperty =
            DependencyProperty.Register("diseslidt", typeof(IEnumerable<Dish>), typeof(AddOrderPage));


        public Order orders { get; set; }
        public AddOrderPage(Order _orders)
        {
            orders = _orders;
            diseslidt = BdConect.db.Dish.ToList();
            InitializeComponent();
            Instance = this;
           
            ClientCb.ItemsSource = BdConect.db.Сlient.ToList();
            ClientCb.DisplayMemberPath = "LastName";
            EmployeeCb.ItemsSource = BdConect.db.Employees.ToList();
            EmployeeCb.DisplayMemberPath = "LastName";
            UpdateIngridientList(orders);
        }
        public static void UpdateIngridientList(Order orders)
        {
            Instance.diseslidt = BdConect.db.OrderDish.Where(x => x.OrserId == orders.Id).Select(s => s.Dish).ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            BdConect.db.Order.Add(new Order
            {
               // ClientId = ClientCb
              // EmployeesId
             
            }
            ) ;
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)=>
         //   new AddIngredientProv(diseslidt, _orders).ShowDialog();
    }
}
