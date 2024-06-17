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
using System.Windows.Shapes;

namespace Eduard.Minin.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для СhatWindow.xaml
    /// </summary>
    public partial class СhatWindow : Window
    {
        public СhatWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationWindow navigationWindow = new NavigationWindow();
            navigationWindow.Show();
            this.Close();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            HikingWindow hikingWindow = new HikingWindow();
            hikingWindow.Show();
            this.Close();
        }
    }
}
