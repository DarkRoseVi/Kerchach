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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
   
        public ClientPage()
        {

            InitializeComponent();
            ClientLW.ItemsSource = BdConect.db.Сlient.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Navidation.NextPage(new Nav("Добавление клиента", new EsitClientPage(new Сlient())));
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            var n = (sender as Button).DataContext as Сlient;
            Navidation.NextPage(new Nav("Добавление клиента", new EsitClientPage(n)));

        }
    }
}
