using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekrutacjaNaStudia
{
    public class ListOfApplicants
    {
        public List<Student> applicants;
        public ListOfApplicants()
        {
            applicants = new List<Student>();
        }

        public void AddApplicant(string nameFieldOfStudy, string yearOfRecruitment)
        {
            Student student = new Student(nameFieldOfStudy, yearOfRecruitment);
            applicants.Add(student);
        }

        public void RemoveApplicants(uint numberOfRecruitmentStudents)
        {
            uint deleteStudent;

            if (numberOfRecruitmentStudents < (uint)applicants.Count)
            {
                deleteStudent = (uint)applicants.Count - numberOfRecruitmentStudents; //Number of students to delete        
            }
            else
            {
                deleteStudent = 0;
            }
            for (int i = 0; i < deleteStudent; i++)
            {                            
                if (applicants.Count == 0)
                {
                    return; // Breaking the loop when number of applicants is 0
                }

                float minPointsSum = applicants[0].PointsSum;
                int applicantToDelete = 0;

                for (int j = 0; j < applicants.Count; j++)
                {
                    if (minPointsSum > applicants[j].PointsSum)
                    {
                        minPointsSum = applicants[j].PointsSum;
                        applicantToDelete = j;
                    }
                }
                applicants.RemoveAt(applicantToDelete);
            }
        }
        public void ClearList()
        {
            applicants.Clear();
        }
    }
}
