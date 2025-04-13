using System;
using System.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name) //4
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) //5
        {
            if (Students.Count < 5)
                throw new InvalidOperationException("Ranked grading requires at least 5 students.");

            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            var sortedGrades = Students
                .Select(s => s.AverageGrade)
                .OrderByDescending(g => g)
                .ToList();

            if (averageGrade >= sortedGrades[threshold - 1])
                return 'A';
            else if (averageGrade >= sortedGrades[(threshold * 2) - 1])
                return 'B';
            else if (averageGrade >= sortedGrades[(threshold * 3) - 1])
                return 'C';
            else if (averageGrade >= sortedGrades[(threshold * 4) - 1])
                return 'D';
            else
                return 'F';
        }
    }
}
