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
        string tmpTB = "";
        public MainWindow()
        {
            InitializeComponent();

            main_window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Ini_listBox();
            borderItem.Visibility = Visibility.Hidden;
        }

        private void Ini_listBox()
        {
            
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
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

        private void poisk_textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            poisk_textBox.Text = tmpTB;
        }
        private void poisk_textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            tmpTB = poisk_textBox.Text;
            if(tmpTB.Length == 0 )
            poisk_textBox.Text = "Я шукаю...";
        }

        private void catalog_btn_Click(object sender, RoutedEventArgs e)
        {
            if(borderItem.Visibility== Visibility.Hidden)
            borderItem.Visibility = Visibility.Visible;
            else borderItem.Visibility = Visibility.Hidden;
        }

        private void borderItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!panel_menu2.IsMouseOver)
            {
                borderItem.Visibility = Visibility.Hidden;
            }
        }
    }
}
