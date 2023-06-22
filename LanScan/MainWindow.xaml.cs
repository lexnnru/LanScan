using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace LanScan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void newfature()
        {
             string  faatures;
        }
        public void newfature2()
        {
            string faatures2 = "wedfwedf";
            int i = faatures2.Length;
        }
        public void newfature4()
        {
            string faatures4 = "wedfwedf";
            int i = faatures4.Length;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { int id=0;

            do
            {
                tb.Text = tb.Text + id.ToString();
                id++;
                Thread.Sleep(100);
                MessageBox.Show("da");
///koment add
///второй
///третий
            }
            while (id <= 5);


         
        }
    }
}
