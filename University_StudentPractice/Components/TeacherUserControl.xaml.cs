﻿using System;
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

namespace University_StudentPractice.Components
{
    /// <summary>
    /// Логика взаимодействия для TeacherUserControl.xaml
    /// </summary>
    public partial class TeacherUserControl : UserControl
    {
        private Student student;
        private Exam exam;
        public TeacherUserControl()
        {
            InitializeComponent();

        }
    }
}

//        private void AddStudentToExam_Click(object sender, RoutedEventArgs e)
//        {
//            Student selectedStudent = (Student)StudentsComboBox.SelectedItem;
//            Exam selectedExam = (Exam)ExamsListBox.SelectedItem;

//            if (selectedStudent != null && selectedExam != null)
//            {
//                // Ваш код для добавления студента к экзамену
//                App.db.Exam_Student.Add(new Exam_Student { id_exam = selectedExam.id_exam, id_student = selectedStudent.RegNumber });
//                App.db.SaveChanges();

//                // После этого обновите список экзаменов, чтобы отобразить изменения
                
//            }
//            else
//            {
//                MessageBox.Show("Выберите студента и экзамен для добавления");
//            }
//        }

//        private void GradeStudent_Click(object sender, RoutedEventArgs e)
//        {
//            Student selectedStudent = (Student)StudentsForGradingComboBox.SelectedItem;
//            Exam selectedExam = (Exam)ExamsListBox.SelectedItem;
//            string grade = GradeTextBox.Text;

//            if (selectedStudent != null && selectedExam != null && !string.IsNullOrEmpty(grade))
//            {
//                // Ваш код для оценивания студента за экзамен
//                var examStudent = App.db.Exam_Student.FirstOrDefault(es => es.id_exam == selectedExam.id_exam && es.id_student == selectedStudent.RegNumber);

//                if (examStudent != null)
//                {
//                    // Оценивание студента за экзамен
//                    examStudent.Assessment = grade;
//                    examStudent.Student = selectedStudent;
//                    App.db.SaveChanges();
//                }

//                // После этого обновите список экзаменов, чтобы отобразить изменения
                
//            }
//            else
//            {
//                MessageBox.Show("Выберите студента, экзамен и введите оценку");
//            }
//        }

//        private void ExamsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            List<Exam> exams = App.db.Exam.ToList();
//        }

//        //private void StudentsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        //{

//        //}
//    }
//}
