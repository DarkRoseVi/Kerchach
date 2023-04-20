﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public ObservableCollection<Order> orders
        {
            get { return (ObservableCollection<Order>)GetValue(ordersProperty); }
            set { SetValue(ordersProperty, value); }
        }

        public static readonly DependencyProperty ordersProperty =
            DependencyProperty.Register("orders", typeof(ObservableCollection<Order>), typeof(OrderPage));

        public OrderPage()
        {
            BdConect.db.Order.Load();
            orders = BdConect.db.Order.Local;

            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrderpage(new Order()));
        }
    }
}
