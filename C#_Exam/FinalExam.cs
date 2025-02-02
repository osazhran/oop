using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class FinalExam : BaseQuestion
    {
        public bool TrueOrFalse { get; set; }
        public FinalExam(string header, string body, int mark) : base(header, body, mark)
        {
        }
        

    }
   
}
