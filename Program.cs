using System;
using System.Linq;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Adding a new student
                var student = new Student { Name = "John Doe", Age = 20 };
                context.Students.Add(student);
                context.SaveChanges();

                // Querying the database
                var query = context.Students.Where(s => s.Name == "John Doe");
                // Displaying the results
                foreach (var stud in query)
                {
                    Console.WriteLine($"Student: {stud.Name}, Age: {stud.Age}");
                }

                // Updating the student
                var student = context.Students.First(s => s.Name == "John Doe");
                student.Age = 23;
                context.SaveChanges();

                // Deleting the student
                var student = context.Students.First(s => s.Name == "John Doe");
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}