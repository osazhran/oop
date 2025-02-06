using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
  public  abstract class BaseQuestion  /*ICloneable, IComparable<BaseQuestion>*/
    {

        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answers[] answers { get; set; }
        public int CorrectAnswer { get; set; }

        protected BaseQuestion(string header, string body, int mark, Answers[] _answers, int correctAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            answers = _answers;
            CorrectAnswer = correctAnswer;
        }

        public override string ToString()
        {
            return $"Q.{Body} {string.Join(" , ", answers.Select(a => a.ToString()))}\n";
        }

        public abstract void ShowQuestion();


    }
}
