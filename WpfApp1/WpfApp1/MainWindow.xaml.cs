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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void Button_Manu1_Click(object sender, RoutedEventArgs e)
        {
            int text1 = int.Parse(TxtBox1.Text);
            int text2 = int.Parse(TxtBox2.Text);
            int text3 = int.Parse(TxtBox3.Text);
            int text4 = text1 - text2;
            int text5 = text3 / text4;
            TxtBox4.Text = text5.ToString();
         
        }


    }
}
