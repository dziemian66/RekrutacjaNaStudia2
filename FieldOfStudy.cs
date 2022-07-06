using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class FieldOfStudy
    {
        public Dictionary<string, float> Multipliers = new Dictionary<string, float>();
        ListOfApplicants listOfApplicants = new ListOfApplicants();
        public string NameFieldOfStudy { get; set; }
        public string YearOfRecruitment { get; set; }
        public bool RecruitIsOpened { get; set; } = false;
        public uint NumberOfRecruitmentStudents { get; set; }

        public FieldOfStudy(string nameFieldOfStudy)
        {
            NameFieldOfStudy = nameFieldOfStudy;
            //Multipliers for every exams
            Multipliers.Add("MathBasic", 0.5f); 
            Multipliers.Add("MathExtended", 1.75f); 
            Multipliers.Add("ForeignLanguageBasic", 0.2f); 
            Multipliers.Add("ForeignLanguageExtended", 0.4f); 
            Multipliers.Add("PhysicsExtended", 1.5f); 
        }

        public void SumPointsForExams()
        {
            float sumPoints = 0;

            if (Multipliers.Count != listOfApplicants.applicants[listOfApplicants.applicants.Count - 1].ExamResults.Count)
            {
                Console.WriteLine("Different length of lists");
                return;
            }
            for (int i = 0; i < Multipliers.Count; i++)
            {
                sumPoints = sumPoints + Multipliers.ElementAt(i).Value * listOfApplicants.applicants[listOfApplicants.applicants.Count - 1].ExamResults.ElementAt(i).Value;
            }
            listOfApplicants.applicants[listOfApplicants.applicants.Count - 1].PointsSum = sumPoints;
        }

        public void OpenRecruiting()
        {
            uint value;

            if (RecruitIsOpened == false)
            {
                RecruitIsOpened = true;
            }
            else
            {
                Console.WriteLine("\nRecruiting is opened for this field of study. \nPress any key to continue...");
                Console.ReadKey();
                return;
            }

            Console.Write("\nYear of recruitment: ");
            YearOfRecruitment = Console.ReadLine();

            Console.Write("Maximum number of students for this field of study: ");
            UInt32.TryParse(Console.ReadLine(), out value);
            NumberOfRecruitmentStudents = value;
        }

        public void CloseRecruiting(ListOfStudents listOfStudents)
        {
            if (RecruitIsOpened == true)
            {
                RecruitIsOpened = false;
                listOfApplicants.RemoveApplicants(NumberOfRecruitmentStudents);
                listOfStudents.AddNewStudents(listOfApplicants.applicants);
                listOfApplicants.ClearList();
            }
            else
            {
                Console.WriteLine("\nRecruiting is closed for this field of study. \nPress any key to continue...");
                Console.ReadKey();
            }
        }
        public void CheckAddApplicant()
        {
            if (RecruitIsOpened)
            {
                listOfApplicants.AddApplicant(NameFieldOfStudy, YearOfRecruitment);
                SumPointsForExams();
            }
            else
            {
                Console.WriteLine("Recruiting is closed for this field of study. \nPress any key to continue...");
                Console.ReadKey();
            }
            
        }
    }
}
