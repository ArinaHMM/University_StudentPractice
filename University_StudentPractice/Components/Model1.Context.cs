﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace University_StudentPractice.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PracticeClasses222103Entities : DbContext
    {
        public PracticeClasses222103Entities()
            : base("name=PracticeClasses222103Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Cathedra> Cathedra { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Engineer> Engineer { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Exam_Student> Exam_Student { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<HeadOfTheDepartment> HeadOfTheDepartment { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
    }
}
