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

namespace University_StudentPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorizate.xaml
    /// </summary>
    public partial class Authorizate : Page
    {
        public Authorizate()
        {
            InitializeComponent();
        }
        public void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string selectedRole = ((ComboBoxItem)RoleCmb.SelectedItem)?.Content.ToString();
            string password = PasswordAuth.Password;

            if (!string.IsNullOrEmpty(selectedRole) && !string.IsNullOrEmpty(password))
            {
                if (CheckCredentials(selectedRole, password))
                {
                    OpenAppropriatePage(selectedRole);
                }
                else
                {
                    MessageBox.Show("Неверные учетные данные");
                }
            }
            else
            {
                MessageBox.Show("Выберите роль и введите пароль");
            }
        }

        private bool CheckCredentials(string role, string password)
        {
            switch (role)
            {
                case "Учитель":
                    return password == "0000";
                case "Заведующий кафедры":
                    return password == "1111";
                case "Инженер":
                    return password == "2222";
                case "Гость":
                    return true;
                default:
                    return false;
            }
        }

        private void OpenAppropriatePage(string role)
        {
            switch (role)
            {
                case "Учитель":
                    OpenTeacherPage();
                    break;
                case "Заведующий кафедры":
                    OpenHeadPage();
                    break;
                case "Инженер":
                    OpenEngineerPage();
                    break;
                case "Гость":
                    OpenGuestPage();
                    break;
            }
        }

        public void OpenTeacherPage()
        {
            TeacherPage teacherPage = new TeacherPage();
            NavigationService.Navigate(teacherPage);
        }

        private void OpenHeadPage()
        {
            //OpenHeadPage openHeadPage = new OpenHeadPage();
            //NavigationService.Navigate(openHeadPage);
            //myNavigation()

        }

        private void OpenEngineerPage()
        {

            //MainFrame.Navigate(new TeacherPage());

        }

        private void OpenGuestPage()
        {

           // MainFrame.Navigate(new TeacherPage());


        }
    }
}
