using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook //3
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted) //7.4
        {
            Type = GradeBookType.Standard;
        }

    }
}
