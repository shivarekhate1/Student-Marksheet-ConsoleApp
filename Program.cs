using System;

namespace ITP1030
{
    class Program
    {
        
        abstract class Marksheet
        {
            public abstract void PrintHeader();
            public abstract void PrintStudentDetails();
            public abstract void PrintSubjectMarks();
            public abstract void PrintResult();
        }

       
        class Student1 : Marksheet
        {
            public override void PrintHeader()
            {
                Console.WriteLine("|-----------------------------------------------------------------------------|");
                Console.WriteLine("|                         *     ITPRENEUR       *                             |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
            }

            public override void PrintStudentDetails()
            {
                Console.WriteLine("|                       Name      :   Shiva Balkrushna Rekhate                |");
                Console.WriteLine("|                       Roll No   :   1                                       |");
                Console.WriteLine("|      Education Qualification   :   Mechanical Engineering (BE)              |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
            }

            public override void PrintSubjectMarks()
            {
                Console.WriteLine("| Subject                 | Marks                                            |");
                Console.WriteLine("|-------------------------|--------------------------------------------------|");
                Console.WriteLine("| C#                      | 80                                               |");
                Console.WriteLine("| ASP.NET                 | 70                                               |");
                Console.WriteLine("| MVC                     | 89                                               |");
                Console.WriteLine("| MS-SQL Server           | 76                                               |");
                Console.WriteLine("| UI                      | 90                                               |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
            }

            public override void PrintResult()
            {
                Console.WriteLine("| Total Marks             : 500                                              |");
                Console.WriteLine("| Obtained Marks          : 467                                              |");
                Console.WriteLine("| Percentage              : 90%                                              |");
                Console.WriteLine("|-----------------------------------------------------------------------------|");
            }
        }

        static void Main(string[] args)
        {
           
            Marksheet student = new Student1();
            student.PrintHeader();
            student.PrintStudentDetails();
            student.PrintSubjectMarks();
            student.PrintResult();

            Console.ReadLine(); 
        }
    }
}
