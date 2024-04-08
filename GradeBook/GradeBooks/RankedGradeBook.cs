using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighed) : base(name, isWeighed)
        {
            Name = name;
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int gradesBelowAVGGiven = 0;
            for (int i = 0; i < Students.Count; i++)
            {
                if (averageGrade > Students[i].AverageGrade) gradesBelowAVGGiven++;
            }
            double avgGradeTopPercent = gradesBelowAVGGiven / Students.Count * 100;

            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40)
                return 'C';
            else if (averageGrade >= 20)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5) 
            Console.WriteLine("Ranked grading requires at least 5 students.");
            else
            base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {   
            if(Students.Count < 5)
            Console.WriteLine("Ranked grading requires at least 5 students.");
            else
            base.CalculateStudentStatistics(name);
        }
    }
}
