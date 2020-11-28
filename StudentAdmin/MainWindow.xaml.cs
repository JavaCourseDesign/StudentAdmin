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

namespace StudentAdmin
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

        private void StudentNavBtn_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("StudentAdminPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TeacherNavBtn_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("TeacherAdminPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void CourseNavBtn_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("CourseAdminPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
