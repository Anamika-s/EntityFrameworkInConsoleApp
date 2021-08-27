using CodeFirstApproachDemo.Models;
using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeDbContext db = new EmployeeDbContext();
            // CRUD Operations
            // LINQ 

            // Get all Records
            var list = db.Emps.ToList();
            if(list.Count>0)
            {
                foreach (var temp in list)
                {
                    Console.WriteLine(temp.Id + " " + temp.Name);
                }
            }
            else
            {
                Console.WriteLine("No Records found");
            }

            // Inserting Record
            db.Emps.Add(new Emp() { Name = "Sagar", Dept = "HR", Salary = 90000 });
            db.SaveChanges();

            // For a Single record
            var emp = db.Emps.Where(x => x.Id == 1).FirstOrDefault();
            if(emp!=null)
            {
                Console.WriteLine(emp.Id + " " + emp.Name);
            }
            else
            {
                Console.WriteLine("No Record Found");
            }

            // Update Record

              emp = db.Emps.Where(x => x.Id == 1).FirstOrDefault();
            if (emp != null)
            {
                emp.Dept = "Accts";
                emp.Salary = 30000;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Record Found");
            }

            // Delete Record

            emp = db.Emps.Where(x => x.Id == 1).FirstOrDefault();
            if (emp != null)
            {
                db.Emps.Remove(emp);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No Record Found");
            }


        }
    }
}
