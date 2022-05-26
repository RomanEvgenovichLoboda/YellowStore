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
using YellowStore.Controls;

namespace YellowStore
{ 
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string text { get; set; }
        int _id = 0;
        List<ProductControl> mobiles;
        public MainWindow()
        {
            InitializeComponent();
            mobiles = new List<ProductControl>();
            mobiles.Add(new ProductControl("black"));
            mobiles.Add(new ProductControl("red"));
            mobiles.Add(new ProductControl("white"));
            this.DataContext = this;

        }
        void ShowProd()
        {
            ListProd.RowDefinitions.Clear();
            ListProd.Children.Clear();
            int col = 0;
            int row = 0;
            foreach (var item in mobiles)
            {
                if (col == 0) { ListProd.RowDefinitions.Add(new RowDefinition()); }
                Grid.SetColumn(item, col);
                Grid.SetRow(item, row);
                ListProd.Children.Add(item);
                col++;
                if (col >= 4)
                {
                    row++;
                    col = 0;
                }
            }
        }
        private void click_Add(object send,RoutedEventArgs e)
        {
            mobiles.Add(new ProductControl(text));
            ShowProd();
        }
        private void click_Remove(object send, RoutedEventArgs e)
        {
            ProductControl deletebal = null;
            foreach (var item in mobiles)
            {
                if (item.color.ToLower() == text.ToLower()) { deletebal = item; }
            }

            if (deletebal != null) { mobiles.Remove(deletebal); }
            ShowProd();
        }
    }
}
