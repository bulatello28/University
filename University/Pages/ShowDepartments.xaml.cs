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
using University.AdoApp;

namespace University.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShowDepartments.xaml
    /// </summary>
    public partial class ShowDepartments : Page
    {
        public List<Department> deps = App.Connection.Department.ToList();
        public ShowDepartments()
        {
            InitializeComponent();
            lvDeps.ItemsSource = deps;
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
