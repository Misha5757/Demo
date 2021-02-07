using System;
using System.Collections.Generic;
using System.Data;
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
using Warehouse.Views.DateBase.Contexs;

namespace Warehouse.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Warehouse_Display.xaml
    /// </summary>
    public partial class Warehouse_Display : Page
    {
        

        public Warehouse_Display()
        {
            InitializeComponent();
        }

        private void Display_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Display.ItemsSource = ClassBD.db.warehouse.ToList();
    


                }


        private void CliclOff_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Display.ItemsSource = ClassBD.db.warehouse.Where(item => item.ID.ToString().Contains(Search.Text) || item.TitleID.ToString().Contains (Search.Text) || item.Titel.Product_Name.Contains (Search.Text)).ToList();
        }
    }
}
