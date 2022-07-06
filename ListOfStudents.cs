using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class ListOfStudents
    {
        public const uint MIN_STUDENT_ID = 100000; //Minimum number for student ID
        private static uint StudentId = MIN_STUDENT_ID;

        List<Student> students = new List<Student>();

        public void AddNewStudents(List<Student> listOfApplicants)
        {
            foreach (var newstudet in listOfApplicants)
            {
                newstudet.StudentId = StudentId;
                students.Add(newstudet);
                StudentId++;
            }
        }

        public void FindStudent()
        {
            Console.WriteLine("\nProvide your PESEL:");
            var pesel = Console.ReadLine();
            foreach(var student in students)
            {
                if(student.Pesel == pesel)
                {
                    Console.WriteLine($"Congratulations {student.Name} {student.Surname}!\nYou are {student.FieldOfStudy} student!" +
                                         $"\nYour student ID number is: {student.StudentId}");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Unfortunately, you aren't on list of students.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }




}
