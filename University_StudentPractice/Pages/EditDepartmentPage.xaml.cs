﻿using System;
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
            FacultyCb.ItemsSource = App.db.Faculty.ToList();
            FacultyCb.DisplayMemberPath = "Name";
        }

        public void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            if (FacultyCb.SelectedIndex != -1 && Nametb.Text.Length > 0)
            {
                string Abbreviation = "";
                foreach (string i in Nametb.Text.Split(' '))
                {
                    Abbreviation += i.Substring(0, 1);
                }
                App.db.Cathedra.Add(new Cathedra()
                {
                    Code = Abbreviation.Substring(0, 1).ToUpper() + Abbreviation.Substring(1, Abbreviation.Length - 1).ToLower(),
                    Name = Nametb.Text,
                    Faculty = (FacultyCb.SelectedItem as Faculty).Abbreviation
                });
                App.db.SaveChanges();
                MessageBox.Show("Все норм");
                NavigationService.GoBack();
               
            }
            else
            {
                MessageBox.Show("Неправильнно");
                
            }
        }
    }
}
