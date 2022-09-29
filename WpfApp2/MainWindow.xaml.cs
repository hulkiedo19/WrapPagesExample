using Microsoft.EntityFrameworkCore;
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
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Product> Page = null;
        private static int page_size = 4;
        private static int page_number = 0;
        private static int page_max = 1;

        public MainWindow()
        {
            InitializeComponent();

            // prepares
            int element_count = new Test1Context().Products.Count();
            page_max = (element_count / page_size) + ((element_count % page_size) > 0 ? 1 : 0);

            // setting page
            int position = page_number * page_size;

            Page = new Test1Context().Products
                .Include(p => p.ProductType)
                .Skip(position)
                .Take(page_size)
                .ToList();

            LV1.ItemsSource = Page;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (page_number <= 0)
                return;

            page_number--;

            int position = page_number * page_size;

            Page = new Test1Context().Products
                .Include(p => p.ProductType)
                .Skip(position)
                .Take(page_size)
                .ToList();

            LV1.ItemsSource = Page;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (page_number >= page_max - 1)
                return;

            page_number++;

            int position = page_number * page_size;

            Page = new Test1Context().Products
                .Include(p => p.ProductType)
                .Skip(position)
                .Take(page_size)
                .ToList();

            LV1.ItemsSource = Page;
        }
    }
}
