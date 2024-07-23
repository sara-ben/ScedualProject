using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProjectSofiDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TeacherLessons> TeacherLessonss { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectForCycle> SubjectForCycles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ResultTbl> Results { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<DraftTable> DraftTables { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Cycle> Cycles { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Constrains> Constrainss { get; set; }
        public DbSet<Absences> Absencess { get; set; }





        public ProjectSofiDBContext(DbContextOptions<ProjectSofiDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<TeacherLessons>().ToTable("TeacherLessons");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<SubjectForCycle>().ToTable("SubjectForCycle");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<ResultTbl>().ToTable("Result");
            modelBuilder.Entity<Lesson>().ToTable("Lesson");
            modelBuilder.Entity<Hour>().ToTable("Hour");
            modelBuilder.Entity<DraftTable>().ToTable("DraftTable");
            modelBuilder.Entity<Day>().ToTable("Day");
            modelBuilder.Entity<Cycle>().ToTable("Cycle");
            modelBuilder.Entity<Grade>().ToTable("Grade"); 
            modelBuilder.Entity<Constrains>().ToTable("Constrains");
            modelBuilder.Entity<Absences>().ToTable("Absences");


        }
    }
}

