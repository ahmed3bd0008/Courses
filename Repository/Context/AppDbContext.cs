using Microsoft.EntityFrameworkCore;
using Core.Entity;
using Core.Entity.Course;
using Repository.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Core.Entity.User;
using System;

namespace Repository.Context
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,string>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseLevel> CourseLevels { get; set; }
        public DbSet< Language> Language { get; set; }
        public DbSet< Currency> Currency { get; set; }
        public DbSet< CourseCategory> CourseCategories { get; set; }
        public DbSet< CourseStatus> CourseStatuses { get; set; }
        public DbSet< CourseType> CourseTypes { get; set; }
        public DbSet< Instructor> Instructors { get; set; }
        public DbSet< Skill> Skills { get; set; }
        public DbSet< Module> Modules { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Countery> Counteries { get; set; }
        override  public DbSet<AppUser> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //impotant for identity 
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration( new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ModuleConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
            modelBuilder.ApplyConfiguration(new CounteryConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
       
    }
}