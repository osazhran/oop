using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class MCQQuestion : BaseQuestion
    {
        public MCQQuestion(string header, string body, int mark, Answers[] _answers, int correctAnswerId) : base(header, body, mark, _answers, correctAnswerId)
        {
          

        }
        public override void ShowQuestion()
        {
            Console.WriteLine($"MCQ){Header}\n Q.{Body}");
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {answers[i].AnswerText}");
            }
        }
    }
}
