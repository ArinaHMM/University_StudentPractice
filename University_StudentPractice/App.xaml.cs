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
using System.Windows.Controls;

namespace University_StudentPractice
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public static PracticeClasses222103Entities1 db = new PracticeClasses222103Entities1();
        public static int COuntOfExams;
        public static int CountOfEmployeers;
        
        public static object CurrentUser { get; internal set; }
    }
}
