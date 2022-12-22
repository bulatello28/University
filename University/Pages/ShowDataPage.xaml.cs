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
    /// Логика взаимодействия для ShowDataPage.xaml
    /// </summary>
    public partial class ShowDataPage : Page
    {
        public ShowDataPage()
        {
            InitializeComponent();
        }

        private void ShowTeachersClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowTeachers());
        }

        private void ShowFac(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowFaculties());
        }

        private void ShowDeps(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowDepartments());
        }
    }
}
