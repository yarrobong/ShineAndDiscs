using ShineAndDiscs.Models;
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


namespace ShineAndDiscs.View
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        Core db = new Core();
        public ProductPage()
        {
            InitializeComponent();
            ProductListView.ItemsSource = db.context.Product.ToList();
        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            Product item = ProductListView.SelectedItem as Product;
            if (item == null)
            {
                this.NavigationService.Navigate(new UpdateProductPage());
            }
            else
            {
                this.NavigationService.Navigate(new UpdateProductPage(item));
            }
        }
    }
}
