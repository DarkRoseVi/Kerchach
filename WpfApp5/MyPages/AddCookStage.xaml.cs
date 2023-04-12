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
using System.Windows.Shapes;
using WpfApp5.Componens;
using WpfApp5.MyPages;

namespace WpfApp5.MyPages
{
    /// <summary>
    /// Логика взаимодействия для AddCookStage.xaml
    /// </summary>
    public partial class AddCookStage : Window
    {
        public CookingStage cookingStage { get; set; }
        public AddCookStage(CookingStage _cookingStage)
        {
            InitializeComponent();
            cookingStage = _cookingStage;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
