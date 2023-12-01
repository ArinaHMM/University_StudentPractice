using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using University_StudentPractice.Components;

namespace University_StudentPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для EngineerPage.xaml
    /// </summary>
    public partial class EngineerPage : Page
    {
        public Employee employee;
        public EngineerPage()
        {


            InitializeComponent();
            EmployeesDataGrid.ItemsSource = App.db.Employee.ToList();
            EmployeesDataGrid.DataContext = App.db.Employee.ToList();
            var PoositionEmployees = App.db.Employee.Where(x => x.Position != "зав. кафедрой").ToList();
/*            PositionCb.ItemsSource = PoositionEmployees;
            PositionCb.DisplayMemberPath = "Position";*/
            var chiefEmployees = App.db.Employee.Where(e => e.Position == "зав. кафедрой").ToList();
            //ChiefCb.ItemsSource = chiefEmployees;
            //ChiefCb.DisplayMemberPath = "LastName";
            //CodsCb.ItemsSource = App.db.Employee.ToList();
            //CodsCb.DisplayMemberPath = "Code";
            App.CountOfEmployeers = App.db.Employee.Count();



        }
        StringBuilder Validator()
        {
            StringBuilder stringBuilder = new StringBuilder();
            //if (IdTb == null)
            //    stringBuilder.AppendLine("Напишите код");
            //if (LastNameTb == null)
            //    stringBuilder.AppendLine("Напишите фамилию");
            //if (PositionCb.SelectedIndex == -1)
            //    stringBuilder.AppendLine("Выберите должность");
            //if (SalaryTb == null)
            //    stringBuilder.AppendLine("Напишите зарплату");
            //if (ChiefCb.SelectedIndex == -1)
            //    stringBuilder.AppendLine("Выберите начальника");
            return stringBuilder;
        }
        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(new Employee()));

        }
            /*if (Validator().Length == 0)
            {
                App.db.Employee.Add(new Employee()
                {

                    id = int.Parse(IdTb.Text),
                    //App.db.Exam.Count() + 1,
                    Code = ((CodsCb.SelectedItem) as Employee).Code,
                    LastName = LastNameTb.Text,
                    Position = (PositionCb.SelectedItem as Employee).Position,
                    Salary = int.Parse(SalaryTb.Text),
                    Chief = ((ChiefCb.SelectedItem) as Employee).Chief



                });
                App.db.SaveChanges();
                MessageBox.Show("Успешно");
                App.COuntOfExams += 1;
                Refresh();
            }
            else
                MessageBox.Show(Validator().ToString());*/
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    


    void Refresh()
        {
            EmployeesDataGrid.ItemsSource = App.db.Employee.ToList();
            EmployeesDataGrid.DataContext = App.db.Employee.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(EmployeesDataGrid.SelectedItem as Employee));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //App.db.Employee.Remove(EmployeesDataGrid.SelectedItem as Employee);

            //App.db.SaveChanges();
            //Refresh();

            if (EmployeesDataGrid.SelectedItem is Employee employee)
            {
                foreach(var em in App.db.Teacher.ToList())
                {
                    if(em.Employee == EmployeesDataGrid.SelectedItem as Employee)
                        { 
                    App.db.Teacher.Remove(App.db.Teacher.Find(em.id));
                    App.db.SaveChanges();
                    }
                }
                foreach (var em in App.db.Engineer.ToList())
                {
                    if (em.Employee == EmployeesDataGrid.SelectedItem as Employee)
                    {
                        App.db.Engineer.Remove(App.db.Engineer.Find(em.id));
                        App.db.SaveChanges();
                    }

                }
                foreach (var em in App.db.HeadOfTheDepartment.ToList())
                {
                    if (em.Employee == EmployeesDataGrid.SelectedItem as Employee)
                    {
                        App.db.HeadOfTheDepartment.Remove(App.db.HeadOfTheDepartment.Find(em.id));
                        App.db.SaveChanges();
                    }
                }
                App.db.Employee.Remove(App.db.Employee.Find(employee.id));
                App.db.SaveChanges();
                    
            }
            MessageBox.Show("Удалено");
            Refresh();
        }
    }
}



