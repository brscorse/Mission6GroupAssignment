// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6GroupAssignment.Models;

namespace Mission6GroupAssignment.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220208050133_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission6GroupAssignment.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission6GroupAssignment.Models.TaskResponse", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TResponses");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryId = 1,
                            Completed = true,
                            DueDate = "2/22/22",
                            Quadrant = 1,
                            Task = "Hospital"
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryId = 1,
                            Completed = true,
                            DueDate = "2/22/22",
                            Quadrant = 2,
                            Task = "Excersise"
                        },
                        new
                        {
                            TaskId = 3,
                            CategoryId = 3,
                            Completed = false,
                            DueDate = "2/2/22",
                            Quadrant = 3,
                            Task = "Phone Call"
                        },
                        new
                        {
                            TaskId = 4,
                            CategoryId = 3,
                            Completed = true,
                            DueDate = "2/5/22",
                            Quadrant = 4,
                            Task = "Busy Work"
                        });
                });

            modelBuilder.Entity("Mission6GroupAssignment.Models.TaskResponse", b =>
                {
                    b.HasOne("Mission6GroupAssignment.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
