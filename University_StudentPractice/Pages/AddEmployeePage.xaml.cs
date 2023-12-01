using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public Employee employee;
        public HeadOfTheDepartment headOfTheDepartment;

        public AddEmployeePage()
        {

            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("выаа");
        }
        //    var PoositionEmployees = App.db.Employee.Where(x => x.Position != "зав. кафедрой").ToList();
        //    PositionCb.ItemsSource = PoositionEmployees;
        //    PositionCb.DisplayMemberPath = "Position"; 
        //    var chiefEmployees = App.db.Employee.Where(e => e.Position == "зав. кафедрой").ToList();
        //    ChiefCb.ItemsSource = chiefEmployees;
        //    ChiefCb.DisplayMemberPath = "LastName";
        //    CodsCb.ItemsSource = App.db.Employee.ToList();
        //    CodsCb.DisplayMemberPath = "Code";
        //    App.CountOfEmployeers = App.db.Employee.Count();



        //}
        //StringBuilder Validator()
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    if (CodeTb == null)
        //        stringBuilder.AppendLine("Напишите код");
        //    if (LastNameTb == null)
        //        stringBuilder.AppendLine("Напишите фамилию");
        //    if (PositionCb.SelectedIndex == -1)
        //        stringBuilder.AppendLine("Выберите должность");
        //    if (SalaryTb == null)
        //        stringBuilder.AppendLine("Напишите зарплату");
        //    if (ChiefCb.SelectedIndex == -1)
        //        stringBuilder.AppendLine("Выберите начальника");
        //    return stringBuilder;
        //}
        //private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //if (Validator().Length == 0)
        //    //{
        //        App.db.Employee.Add(new Employee()
        //        {
        //            id = employee.id,
        //            Code = employee.Code,
        //            LastName = employee.LastName,
        //            Position = employee.Position,
        //            Salary = employee.Salary,
        //            Chief = employee.Chief


        //        });
        //        App.db.SaveChanges();
        //        MessageBox.Show("Успешно");



        //    }

        //}


        //void Refresh()
        //{
        //    engineerPage.EmployeesDataGrid.ItemsSource = App.db.Employee.ToList();
        //    engineerPage.EmployeesDataGrid.DataContext = App.db.Employee.ToList();
        //}




    }
}
    

