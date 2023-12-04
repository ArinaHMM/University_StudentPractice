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
    /// Логика взаимодействия для EditDepartmentPage.xaml
    /// </summary>
    public partial class EditDepartmentPage : Page
    {
        Cathedra cathedra;

        Employee employee;

        public EditDepartmentPage(Cathedra _cathedra)
        {
            InitializeComponent();
            DataContext = _cathedra;
            cathedra = _cathedra;

        }

        public void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что cathedra не null
            if (cathedra == null)
            {
                cathedra = new Cathedra(); // Создаем новый объект Cathedra
            }

            // Присваиваем значения полям cathedra из элементов управления
            cathedra.Code = Codetb.Text; // Предполагаем, что у вас есть TextBox с именем Codetb
            cathedra.Name = Nametb.Text; // Предполагаем, что у вас есть TextBox с именем NameTb

            // Проверяем, что поля cathedra не null и не пусты
            if (!string.IsNullOrWhiteSpace(cathedra.Code))
            {
                    if (App.db.Cathedra.Contains(cathedra))
                    {
                        // Если объект cathedra уже находится в базе данных, он будет автоматически обновлен
                        App.db.SaveChanges();
                        MessageBox.Show("Кафедра успешно обновлена.");
                    }
                    else
                    {
                        // Если объект cathedra не находится в базе данных, он будет добавлен
                        App.db.Cathedra.Add(cathedra);
                        App.db.SaveChanges();
                        MessageBox.Show("Новая кафедра успешно добавлена.");
                    }

                    NavigationService.GoBack();
                
            }
            else
            {
                MessageBox.Show("Поле 'Code' не может быть пустым.");
            }
        }
    }
}