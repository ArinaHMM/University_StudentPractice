using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для HeadOfTheDepartmentPage.xaml
    /// </summary>
    public partial class HeadOfTheDepartmentPage : Page
    {
        public HeadOfTheDepartmentPage()
        {
            InitializeComponent();
            DepartmentsDataGrid.ItemsSource = App.db.Cathedra.ToList();
            DepartmentsDataGrid.DataContext = App.db.Cathedra.ToList();
            App.CountOfCathedras = App.db.Cathedra.Count();

        }

        public void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
       public void Refresh()
        {
           DepartmentsDataGrid.ItemsSource = App.db.Cathedra.ToList();
            DepartmentsDataGrid.DataContext = App.db.Cathedra.ToList();
        }

        private void AddDepartmentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDepartmentPage(DepartmentsDataGrid.SelectedItem as Cathedra));
        }

        private void EditDepartmentButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDepartmentPage(DepartmentsDataGrid.SelectedItem as Cathedra));
        }
    }
    
}
