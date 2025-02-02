using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class BaseQuestion
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public MCQ mCQ { get; set; }
        public Answers[] AnswerList {  get; set; }

        public BaseQuestion(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }


        public enum MCQ
        {
            A,
            B,
            C,
            d
        }   

    }
}
