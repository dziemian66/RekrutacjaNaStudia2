using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }
        public string FieldOfStudy { get; set; }
        public string YearOfRecruitment { get; set; }
        public uint ApplicationNumber { get; set; }
        public uint StudentId { get; set; }
        public float PointsSum { get; set; }

        public Dictionary<string, float> ExamResults = new Dictionary<string, float>();

        public Student(string nameFieldOfStudy, string yearOfRecruitment)
        {
            uint value = 0;
            Console.WriteLine("\nComplete the application:");
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Surname: ");
            Surname = Console.ReadLine();

            Console.Write("PESEL: ");
            Pesel = Console.ReadLine();

            Console.Write("Basic Math exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            ExamResults.Add("Basic Math Exam", value);

            Console.Write("Extended Math exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);  
            ExamResults.Add("Extended Math exam", value);

            Console.Write("Basic Foreign Language exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            ExamResults.Add("Basic Foreign Language exam", value);

            Console.Write("Extended Foreign Language exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            ExamResults.Add("Extended Foreign Language exam", value);

            Console.Write("Extended Physics exam result: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            ExamResults.Add("Extended Physics exam", value);

            FieldOfStudy = nameFieldOfStudy;
            YearOfRecruitment = yearOfRecruitment;
        }




   
    }
}
