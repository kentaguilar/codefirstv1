using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstEF.Core;
using CodeFirstEF.Models;
using System.Configuration;

namespace CodeFirstEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("Starting {0}", ConfigurationManager.AppSettings["AppName"]));


            using (var appContextMain = new AppContextMain())
            {
                appContextMain.Students.Add(new Student
                {
                    Id = 2,
                    Name = "Angel Locsin",
                    Status = "Active"
                });

                appContextMain.SaveChanges();
            }


            Console.WriteLine("Completed");
            Console.ReadKey();
        }
    }
}
