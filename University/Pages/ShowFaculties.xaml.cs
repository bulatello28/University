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
    /// Логика взаимодействия для ShowFaculties.xaml
    /// </summary>
    public partial class ShowFaculties : Page
    {
        public List<Faculty> facs = App.Connection.Faculty.ToList();
        public ShowFaculties()
        {
            InitializeComponent();
            lvFacs.ItemsSource = facs;
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
