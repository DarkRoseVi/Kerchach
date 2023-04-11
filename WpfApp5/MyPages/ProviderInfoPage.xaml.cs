using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ProviderInfoPage.xaml
    /// </summary>
    public partial class ProviderInfoPage : Page
    {
      
  public ObservableCollection<Ingredient> ingrediebt
        {
            get { return (ObservableCollection<Ingredient>)GetValue(ingrediebtProperty); }
            set { SetValue(ingrediebtProperty, value); }
        }

        public static readonly DependencyProperty ingrediebtProperty =
            DependencyProperty.Register("ingrediebt", typeof(ObservableCollection<Ingredient>), typeof(ObservableCollection<Ingredient>));



        public Provider proviser { get; set; }
        public ProviderInfoPage(Provider _provider)
        {
            proviser = _provider;
            BdConect.db.Ingredient.Load();
            ingrediebt = BdConect.db.Ingredient.Local;
            InitializeComponent();
           ProductLw.ItemsSource = BdConect.db.Landing.Where(x => x.ProviderId == proviser.Id).ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var ProviderId = BdConect.db.Provider.Where(x => x.Title == NameTb.Text.Trim()).FirstOrDefault();
            if (ProviderId == null)
            {
                BdConect.db.Provider.Add(proviser);
                MessageBox.Show("Yes");
            }
            BdConect.db.SaveChanges();
            Navidation.NextPage(new Nav("", new ProviderPage()));

        }
    }
}
