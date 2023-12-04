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
            OrderCb.ItemsSource = App.db.Faculty.ToList();
            OrderCb.DisplayMemberPath = "Name";
            Refresh();
        }


        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDepartmentPage(DepartmentsDataGrid.SelectedItem as Cathedra));

        }

        void Refresh()
        {
            DepartmentsDataGrid.ItemsSource = null;
            IEnumerable<Cathedra> cathedras = App.db.Cathedra.ToList();
            if (OrderCb.SelectedIndex != -1)
            {
                cathedras = cathedras.Where(x => x.Faculty == (OrderCb.SelectedItem as Faculty).Abbreviation);
            }
            DepartmentsDataGrid.ItemsSource = cathedras;
            
        }
        private void OrderCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void ByTheBaseBtn_Click(object sender, RoutedEventArgs e)
        {
            OrderCb.SelectedIndex = -1;
            Refresh();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorizate());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}


        