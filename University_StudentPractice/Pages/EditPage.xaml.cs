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
using University_StudentPractice;
using University_StudentPractice.Components;
using University_StudentPractice.Pages;

namespace University_StudentPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        Employee employee;

        public EditPage(Employee _employee)
        {
            InitializeComponent();
            DataContext = _employee;
            employee = _employee;
            CodeCb.ItemsSource = App.db.Cathedra.ToList();
            PositionCb.ItemsSource = App.db.PositionT.ToList();
            var chiefEmployees = App.db.Employee.Where(e => e.Position == "зав. кафедрой").ToList();
            ChiefCb.ItemsSource = chiefEmployees;

        }

        public void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (employee.id  >=0)
                App.db.Employee.Add(employee);
            App.db.SaveChanges();
            MessageBox.Show("Готово");

            NavigationService.GoBack();
        }

    }
}
