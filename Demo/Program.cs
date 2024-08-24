using Demo.Context;
using Demo.Entities;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD
            //CompanyG04dbcontext dbcontext = new CompanyG04dbcontext();

            //            Emploee e01 = new Emploee() {EmpName="mohamed", Adress="asdasdas",Age=23,Email="mohamed@gmail.com",password="sadasdasd",Salary=50000 };

            //            Emploee e02 = new Emploee() { EmpName = "ahmed", Adress = "asdasdas", Age = 23, Email = "ahmed@gmail.com", password = "sadasdasd", Salary = 50000 };
            //            #region Insert

            //            //Console.WriteLine(dbcontext.Entry(e01).State);
            //            //dbcontext.Add(e01);
            //            //dbcontext.Add(e02);
            //            //Console.WriteLine(dbcontext.Entry(e01).State);
            //            //dbcontext.SaveChanges();
            //            //Console.WriteLine(dbcontext.Entry(e01).State); 
            //            #endregion


            //            #region select
            //            //Console.WriteLine();
            //            //var empl1 = (from p in dbcontext.Emploeyes
            //            //            where p.Id == 1
            //            //            select p).FirstOrDefault();
            //            //Console.WriteLine(dbcontext.Entry(e01).State);
            //            //Console.WriteLine(empl1.EmpName);
            //            //Console.WriteLine(dbcontext.Entry(e01).State); 
            //            #endregion

            //            #region Update


            //            //var empl1 = (from p in dbcontext.Emploeyes
            //            //             where p.Id == 1
            //            //             select p).FirstOrDefault();
            //            //Console.WriteLine(dbcontext.Entry(empl1).State);

            //            //empl1.EmpName = "aaaaaaaaa";
            //            //Console.WriteLine(dbcontext.Entry(empl1).State);
            //            //dbcontext.SaveChanges(); 
            //            #endregion

            //            #region Delete
            //            //            Console.WriteLine();
            //            //            var empl1 = (from p in dbcontext.Emploeyes
            //            //                         where p.Id == 1
            //            //                         select p).FirstOrDefault();
            //            //            Console.WriteLine(dbcontext.Entry(e01).State);

            //            //dbcontext.Remove(empl1);
            //            //            Console.WriteLine(dbcontext.Entry(e01).State);

            //            //            dbcontext.SaveChanges();
            //            //            Console.WriteLine(dbcontext.Entry(e01).State); 
            //            #endregion 
            #endregion

            #region Inhertance


            //InheratanceDbContext dbContext2 = new InheratanceDbContext();

            //PartialTimeEmployee emploee1 = new PartialTimeEmployee() { FullName = "asdasd", HourRate = 300, CountOfRate = 232, };
            //FullTimeEmployee emploee2 = new FullTimeEmployee() { FullName = "asdasd", Salary = 300, Hirdate = DateOnly.FromDateTime(DateTime.Now) };


            //dbContext2.Add(emploee1);
            //dbContext2.Add(emploee2);
            //dbContext2.SaveChanges();

            //var fulltimeemploees=from p in dbContext2.FullTimeEmployees
            //                     select p;

            //foreach(var p  in fulltimeemploees)
            //    Console.WriteLine($"{p.FullName}"); 
            #endregion


        }



    }
}
