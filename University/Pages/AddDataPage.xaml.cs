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

namespace University.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddDataPage.xaml
    /// </summary>
    public partial class AddDataPage : Page
    {
        public AddDataPage()
        {
            InitializeComponent();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void AddDepFacClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDepartmentFaculty());
        }

        private void AddTeachSub(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTeachSub());
        }
    }
}
