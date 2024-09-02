using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Program1.Day22
{

    class Student
    {
        public int StudentId { get; set; }   
        public string StudentName { get; set; }
        public string StudentCourse { get; set; }

    }

    internal class LinqDemoClass
    {

        public static void Main(string[] args)
        {

            // Step 1: Specify or the data source
            ArrayList arrlist = new ArrayList();

            arrlist.Add(new Student { StudentId = 1,StudentName = "Kevin", StudentCourse = "C#" });
            arrlist.Add(new Student { StudentId = 2, StudentName = "Clavin", StudentCourse = "Java" });
            arrlist.Add(new Student { StudentId = 3, StudentName = "Alvin", StudentCourse = "Python" });

            //Step 2: Create the query
            var query = from Student myobj in arrlist
                            //where myobj.StudentCourse == "Java"
                            //orderby myobj.StudentName
                        where myobj.StudentName.Length == 5
                        select myobj;

            //Step 3: Execute the query 
            Console.WriteLine("Student details are ");

           foreach(var item in query)
            {
                Console.WriteLine(" {0} \t {1} \t {2}", item.StudentId, item.StudentName, item.StudentCourse);
            }
            Console.ReadKey();
        }

    }
}

