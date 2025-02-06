using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    public class Answers
    {
        //ansewer 1(AnswerId) for true(AnswerText)
        
        public int AnswerId { get; set; } 
        public string AnswerText { get; set; }
        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        public override string ToString()
        {
            return $"{AnswerText}";
        }

    }
}
