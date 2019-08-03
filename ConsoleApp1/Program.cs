using System;
using System.Configuration;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = ConfigurationManager.AppSettings["MyKey"];
            //Console.WriteLine(result);
            using (MyDbContext ctx=new MyDbContext())
            {
                Person p1 = new Person();
                p1.Age = 5;
                p1.Name = "rupeng";
                p1.Gender = true;

                ctx.Persons.Add(p1);
                ctx.SaveChanges();
            }
            Console.ReadKey();
        }
    }
}
