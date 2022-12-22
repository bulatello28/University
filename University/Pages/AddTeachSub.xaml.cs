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
    /// Логика взаимодействия для AddTeachSub.xaml
    /// </summary>
    public partial class AddTeachSub : Page
    {
        public AddTeachSub()
        {
            InitializeComponent();
        }

        private void AddTeacherClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Surname.Text != "" || TeacherName.Text != "" || LName.Text != "" || StartWork.Text != "" || Birthday.Text != ""
                    || Exp.Text != "" || Post.Text != "" || Sex.Text != "" || City.Text != "")
                {
                    App.Connection.Teacher.Add(new Teacher
                    {
                        Surname = Surname.Text,
                        First_Name = TeacherName.Text,
                        Last_Name = LName.Text,
                        Date_Start_Work = (DateTime)StartWork.SelectedDate,
                        Birthday = (DateTime)Birthday.SelectedDate,
                        Experience = Convert.ToDecimal(Exp.Text),
                        id_Post = Convert.ToInt32(Post.Text),
                        id_City = Convert.ToInt32(City.Text),
                        id_Sex = Convert.ToInt32(Sex.Text)

                    });
                    App.Connection.SaveChanges();
                    MessageBox.Show("Teacher is successfully added");
                }
                else
                {
                    MessageBox.Show("Not all fields are empty");
                }
            }
            catch
            {
                MessageBox.Show("Please, check the input data");
                return;
            }
        }

        private void AddSubClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NameSub.Text != "" || QtyHrs.Text != "" || IdTeacher.Text != "")
                {
                    App.Connection.Subject.Add(new Subject
                    {
                        Name = NameSub.Text,
                        Quantity_Hours = Convert.ToInt32(QtyHrs.Text),
                        id_Teacher = Convert.ToInt32(IdTeacher.Text)
                    });
                    App.Connection.SaveChanges();
                    MessageBox.Show("Subject is successfully added");
                }
                else
                {
                    MessageBox.Show("Not all fields are empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDataPage());
        }
    }
}
