//using System;
//using System.Collections.Generic;
//using System.Text;
//using DAL.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;


//namespace BLL
//{
//    public class DataContext: DbContext
//    {
//        protected readonly IConfiguration Configuration;

//        public DataContext(DbContextOptions options) : base(options)
//        {
//        }
//        public DataContext(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        protected override void OnConfiguring(DbContextOptionsBuilder options)
//        {
//            // connect to sql server with connection string from app settings
//            options.UseSqlServer(Configuration.GetConnectionString("ProjectSofiDbConnectionString"));
//        }

//        public DbSet<Grade> Grades { get; set; }
//    }
//}
