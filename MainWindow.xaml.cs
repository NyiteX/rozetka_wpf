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

namespace rozetka_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            main_window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Ini_listBox();
        }

        private void Ini_listBox()
        {
            
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void menu_1_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_1.Foreground = Brushes.Tomato;
        }

        private void menu_1_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_1.Foreground = Brushes.Black;
        }

        private void menu_2_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_2.Foreground = Brushes.Tomato;
        }

        private void menu_2_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_2.Foreground = Brushes.Black;
        }

        private void menu_3_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_3.Foreground = Brushes.Tomato;
        }

        private void menu_3_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_3.Foreground = Brushes.Black;
        }

        private void menu_4_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_4.Foreground = Brushes.Tomato;
        }

        private void menu_4_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_4.Foreground = Brushes.Black;
        }

        private void menu_5_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_5.Foreground = Brushes.Tomato;
        }

        private void menu_5_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_5.Foreground = Brushes.Black;
        }

        private void menu_6_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_6.Foreground = Brushes.Tomato;
        }

        private void menu_6_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_6.Foreground = Brushes.Black;
        }

        private void menu_7_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_7.Foreground = Brushes.Tomato;
        }

        private void menu_7_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_7.Foreground = Brushes.Black;
        }

        private void menu_8_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_8.Foreground = Brushes.Tomato;
        }

        private void menu_8_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_8.Foreground = Brushes.Black;
        }

        private void menu_9_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_9.Foreground = Brushes.Tomato;
        }

        private void menu_9_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_9.Foreground = Brushes.Black;
        }

        private void menu_10_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_10.Foreground = Brushes.Tomato;
        }

        private void menu_10_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_10.Foreground = Brushes.Black;
        }

        private void menu_11_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_11.Foreground = Brushes.Tomato;
        }

        private void menu_11_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_11.Foreground = Brushes.Black;
        }

        private void menu_12_MouseEnter(object sender, MouseEventArgs e)
        {
            menu_12.Foreground = Brushes.Tomato;
        }

        private void menu_12_MouseLeave(object sender, MouseEventArgs e)
        {
            menu_12.Foreground = Brushes.Black;
        }

        private void ru_label_MouseEnter(object sender, MouseEventArgs e)
        {
            ru_label.Foreground = Brushes.Tomato;
        }

        private void ru_label_MouseLeave(object sender, MouseEventArgs e)
        {
            ru_label.Foreground = Brushes.White;
        }

        private void ua_label_MouseEnter(object sender, MouseEventArgs e)
        {
            ua_label.Foreground = Brushes.Tomato;
        }

        private void ua_label_MouseLeave(object sender, MouseEventArgs e)
        {
            ua_label.Foreground = Brushes.White;
        }
    }
}
