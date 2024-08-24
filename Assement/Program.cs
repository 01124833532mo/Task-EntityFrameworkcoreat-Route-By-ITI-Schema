using Assement.Context;
using Assement.Entities;

namespace Assement
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region CRUD
            //using ITIdbContext dbcontext = new ITIdbContext();


            //Department department = new Department()
            //{
            //    Name = "cs",
            //    Ins_ID = 1,
                
            //};
            //Student student = new Student()
            //{
            //    Fname = "mohamed",
            //    Lname = "ahmed",
            //    Adress = "asdasdas",
            //    Age = 14,
            //    Dept_id = 10
            //};
            //Instructor instractor = new Instructor()
            //{
            //    Name = "mohamed",
            //    Adress = "asdasdas",
            //    Salary = 14,
            //    Dept_ID = 10,
            //};

            //Topic topic1 = new Topic() { Name = "assddas" };

            //Course course1 = new Course() { Name = "ahmed", Description = "aaaaaaaaaaa", Top_ID = 4 };

            //Student_Cours student_Cours1 = new Student_Cours() { Cours_ID = 4, Stud_ID = 4, Grade = 5 };
            //Console.WriteLine(dbcontext.Entry(student_Cours1).State);

            ////dbcontext.Add(department);
            ////dbcontext.Add(student);
            ////dbcontext.Add(instractor);
            ////dbcontext.Add(topic1);
            ////dbcontext.Add(course1);
            //dbcontext.Add(student_Cours1);
            ////Console.WriteLine(dbcontext.Entry(topic1).State);
            ////Console.WriteLine(dbcontext.Entry(course1).State);

            ////Console.WriteLine(dbcontext.Entry(student_Cours1).State);
            //Console.WriteLine(dbcontext.Entry(student_Cours1).State);


            //dbcontext.SaveChanges();


            ////var department1 = (from p in dbcontext.Department
            ////                   select p).FirstOrDefault();

            ////var strude1 = (from p in dbcontext.Students
            ////               select p).FirstOrDefault();
            ////var instactor1 = (from p in dbcontext.Department
            ////                  select p).FirstOrDefault();

            ////Console.WriteLine(department1?.Name ?? "not found");


            ////department1.Name = "mohamed hamdi";

            ////strude1.Fname = "donia";

            ////instactor1.Name = "ahmed";

            ////dbcontext.SaveChanges();




            ////dbcontext.Remove(department1);
            ////dbcontext.Remove(strude1);
            ////dbcontext.Remove(instactor1);

            ////dbcontext.SaveChanges();
            #endregion




        }
    }
}
