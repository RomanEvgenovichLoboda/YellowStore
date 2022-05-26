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
        int _id = 0;
        List<ProductControl> mobiles;
        public MainWindow()
        {
            InitializeComponent();
            mobiles = new List<ProductControl>();
            mobiles.Add(new ProductControl() { id = _id++ });
            mobiles.Add(new ProductControl() { id = _id++ });
            mobiles.Add(new ProductControl() { id = _id++ });


        }
        private void click_Add(object send,RoutedEventArgs e)
        {
            ListProd.RowDefinitions.Clear();
            ListProd.Children.Clear();
            int col = 0;
            int row = 0;

            mobiles.Add(new ProductControl() { id = _id++ }); ;
            foreach (var item in mobiles)
            {
                if (col == 0) { ListProd.RowDefinitions.Add(new RowDefinition()); }
                Grid.SetColumn(item, col);
                Grid.SetRow(item, row);
                
                ListProd.Children.Add(item); 
                col++;
                if(col >= 4)
                {
                    row++;
                    col = 0;
                }
            }
        }
        private void click_Remove(object send, RoutedEventArgs e)
        {
            
        }
    }
}
