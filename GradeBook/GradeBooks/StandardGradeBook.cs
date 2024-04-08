using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighed) : base(name, isWeighed)
        {
            Name = name;
            Type = Enums.GradeBookType.Standard;
        }
    }
}
