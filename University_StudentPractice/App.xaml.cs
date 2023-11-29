using University_StudentPractice.Components;
using University_StudentPractice.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;

namespace University_StudentPractice
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public static PracticeClasses222103Entities db = new PracticeClasses222103Entities();
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
