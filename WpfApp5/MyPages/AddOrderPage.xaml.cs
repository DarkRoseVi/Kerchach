using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


        public ObservableCollection<Dish> diseslidt
        {
            get { return (ObservableCollection<Dish>)GetValue(diseslidtProperty); }
            set { SetValue(diseslidtProperty, value); }
        }
        public static readonly DependencyProperty diseslidtProperty =
            DependencyProperty.Register("diseslidt", typeof(ObservableCollection<Dish>), typeof(AddOrderPage));

        public Order orders { get; set; }

        public AddOrderPage(Order _orders)
        {
            orders = _orders;

            diseslidt  = new ObservableCollection<Dish>();

            InitializeComponent();
            Instance = this;
           
            ClientCb.ItemsSource = BdConect.db.Сlient.ToList();
            ClientCb.DisplayMemberPath = "LastName";
            EmployeeCb.ItemsSource = BdConect.db.Employees.ToList();
            EmployeeCb.DisplayMemberPath = "LastName";
        }
        
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            orders.Dish = diseslidt;
            BdConect.db.Order.Add(orders);
            BdConect.db.SaveChanges();
            
            MessageBox.Show("yes");
            Navidation.NextPage(new Nav("",new OrderPage()));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e) =>
            new DishOrderAdd(diseslidt, orders).ShowDialog();
    }
}
