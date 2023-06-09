﻿using System;
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
using WpfApp5.MyPages;
using WpfApp5.Componens;

namespace WpfApp5.MyPages
{
    /// <summary>
    /// Логика взаимодействия для EsitClientPage.xaml
    /// </summary>
    public partial class EsitClientPage : Page
    {
        public Сlient client { get; set; }
        public EsitClientPage(Сlient _client)
        {
            client = _client;
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var ClientId = BdConect.db.Сlient.Where(x => x.Name == NameTb.Text.Trim() && x.Patronymic == PatronumekTb.Text.Trim() && x.LastName == LastNameTb.Text.Trim()).FirstOrDefault();
            if (ClientId == null)
            {
                BdConect.db.Сlient.Add(client);
                MessageBox.Show("yes");

            }
            BdConect.db.SaveChanges();
            Navidation.NextPage(new Nav("Сотрудники", new ClientPage()));
        }
    }
}
