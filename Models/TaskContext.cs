using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mission6GroupAssignment.Models
{
    public class TaskContext : DbContext
    {
        //Constructor
        public TaskContext (DbContextOptions<TaskContext> options) : base (options)
        {

        }
        public DbSet<TaskResponse> TResponses { get; set; }
        public DbSet<Category> Categories { get; set; }



        //Seed data

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Home" },
                new Category { CategoryId = 2, CategoryName = "School" },
                new Category { CategoryId = 3, CategoryName = "Work" },
                new Category { CategoryId = 4, CategoryName = "Church" }

                );
            mb.Entity<TaskResponse>().HasData(
     new TaskResponse
     {
         TaskId = 1,
         Task = "Hospital",
         CategoryId = 1,
         DueDate = "2/22/22",
         Quadrant = 1,
         Completed = true,
     },
     new TaskResponse
     {
         TaskId = 2,
         Task = "Exercise",
         CategoryId = 1,
         DueDate = "2/22/22",
         Quadrant = 2,
         Completed = true,
     },
     new TaskResponse
     {
         TaskId = 3,
         Task = "Phone Call",
         CategoryId = 3,
         DueDate = "2/2/22",
         Quadrant = 3,
         Completed = false,
     },
      new TaskResponse
      {
          TaskId = 4,
          Task = "Busy Work",
          CategoryId = 3,
          DueDate = "2/5/22",
          Quadrant = 4,
          Completed = true,
      }
      );
        }
    }
}



