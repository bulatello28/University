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
    /// Логика взаимодействия для AddDepartmentFaculty.xaml
    /// </summary>
    public partial class AddDepartmentFaculty : Page
    {
        public AddDepartmentFaculty()
        {
            InitializeComponent();
        }

        private void AddFacultyClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NameFaculty.Text != "" || DirectorName.Text != "" || SurnameDirector.Text != ""
                    || PatronymicDirector.Text != "" || PhoneFaculty.Text != "" || NumberBuilding.Text != "")
                {
                    if (PhoneFaculty.Text.Length == 11)
                    {
                        App.Connection.Faculty.Add(new Faculty
                        {
                            Name_Faculty = NameFaculty.Text,
                            Surname_Director = SurnameDirector.Text,
                            FName_Director = DirectorName.Text,
                            LName_Director = PatronymicDirector.Text,
                            Phone = PhoneFaculty.Text,
                            Number_Building = Convert.ToInt32(NumberBuilding.Text)
                        });
                        App.Connection.SaveChanges();
                        MessageBox.Show("Faculty is successfully added");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect phone number");
                    }
                }
                else
                {
                    MessageBox.Show("Not all fields are empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDataPage());
        }

        private void AddDepClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Room.Text != "" || PhoneDep.Text != "" || QtyTeach.Text != "" || IdFac.Text != ""
                    || SurMan.Text != "" || NameMan.Text != "" || LNameMan.Text != "" || DepName.Text != "" || PhoneDep.Text != "")
                {
                    if (PhoneDep.Text.Length == 11)
                    {
                        App.Connection.Department.Add(new Department
                        {
                            Number_Room = Convert.ToInt32(Room.Text),
                            Phone = PhoneDep.Text,
                            Quantity_Teachers = Convert.ToInt32(QtyTeach.Text),
                            id_Faculty = Convert.ToInt32(IdFac.Text),
                            Surname_Manager = SurMan.Text,
                            FName_Manager = NameMan.Text,
                            LName_Manager = LNameMan.Text,
                            Name = DepName.Text
                        });
                        App.Connection.SaveChanges();
                        MessageBox.Show("Department is successfully added");
                    }
                    else
                    {
                        MessageBox.Show("Inccorect phone number");
                    }
                }
                else 
                {
                    MessageBox.Show("Not all fields are empty");
                }
            }
            catch
            {
                MessageBox.Show("Invalid Faculty");
            }
        }
    }
}
