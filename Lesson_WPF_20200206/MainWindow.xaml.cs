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

namespace Lesson_WPF_20200206
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //for (int i = 0; i < 5; i++)
            //{
            //    Border border = new Border();
            //    border.Margin = new Thickness(10);
            //    border.BorderThickness = new Thickness(2);
            //    border.BorderBrush = new SolidColorBrush(Colors.Black);
            //    border.Width = 100;
            //    border.Height = 100;

            //    WrapPanelTest.Children.Add(border);
            //}




        }

       // private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //     foreach(Border item in WrapPanelTest.Children)
        //    {
        //        item.BorderBrush = new SolidColorBrush(Colors.Red);
        //    }
}
    }

