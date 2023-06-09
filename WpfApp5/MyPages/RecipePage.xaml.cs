﻿using System;
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
        public IEnumerable<IngredientOfCookingSage> IngredientOfCookings
        {
            get { return (IEnumerable<IngredientOfCookingSage>)GetValue(IngredientOfCookingsProperty); }
            set { SetValue(IngredientOfCookingsProperty, value); }
        }

        public static readonly DependencyProperty IngredientOfCookingsProperty =
            DependencyProperty.Register("IngredientOfCookings", typeof(IEnumerable<IngredientOfCookingSage>), typeof(RecipePage));

        public IEnumerable<CookingStage> CookingStages
        {
            get { return (IEnumerable<CookingStage>)GetValue(CookingStagesProperty); }
            set { SetValue(CookingStagesProperty, value); }
        }

        public static readonly DependencyProperty CookingStagesProperty =
            DependencyProperty.Register("CookingStages", typeof(IEnumerable<CookingStage>), typeof(IngredientOfCookingSage));

        public Dish dish { get; set; }
        public RecipePage(Dish _dish)
        {
            IngredientOfCookings = BdConect.db.CookingStage.Where(x => x.DishId == _dish.Id).SelectMany(s => s.IngredientOfCookingSage).ToList();
            CookingStages = BdConect.db.CookingStage.Where(x => x.DishId == _dish.Id).ToList();
       
            dish = _dish;

        
            InitializeComponent();
        }


        private void AddIngredBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddCookStageBtn_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
