using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text;

namespace DAL.Data
{

    public class ScechualDbContext: DbContext
    {
        private readonly string _connectionString;

        protected readonly IConfiguration Configuration;
        public DbSet<ResultTbl> ResultTbl { get; set; }
        public DbSet<Grade> grade { get; set; }
        public DbSet<Hour> hour { get; set; }
        public DbSet<Absences> absences { get; set; }
        public DbSet<Constrains> constrains { get; set; }
        public DbSet<Cycle> cycle { get; set; }
        public DbSet<Day> day { get; set; }
        public DbSet<DraftTable> draftTable { get; set; }
        public DbSet<Lesson> lesson { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<TeacherLessons> teacherLessonss { get; set; }
        public DbSet<Teacher> teacher { get; set; }
        public DbSet<SubjectForCycle> subjectForCycle { get; set; }
        public DbSet<Subject> subject { get; set; }


        public ScechualDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public ScechualDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    // connect to sql server with connection string from app settings




        //    options.UseSqlServer(Configuration.GetConnectionString("Data Source=DESKTOP-4S3RFK3\\MSSQLSERVER02;Initial Catalog=projectsofi;Integrated Security=True ;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=DESKTOP-4S3RFK3\\MSSQLSERVER02;Initial Catalog=projectsofi;Integrated Security=True ;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            }
        }


        //options.UseSqlServer(Configuration.GetConnectionString("ProjectSofiDbConnectionString"));


    }
}
