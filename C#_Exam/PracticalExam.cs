using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestion) : base(timeOfExam, numberOfQuestion)
        {
        }

        public override void ShowExam()
        {

            foreach (var question in baseQuestion)
            {
                question.ShowQuestion();
                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                Console.WriteLine($"Correct answer: {question.CorrectAnswer}\n");
                Console.WriteLine("==================================");

            }
            ///if choose 2 ->Show Functionalty for Practical
            ///for (int i = 1; i < NumberOfQuestion; i++)
            ///{
            ///    Console.WriteLine($"Q{i}  {Body} ");
            ///    Console.WriteLine($"Answer{i}  {Ansewers} ");
            ///    Console.WriteLine("Enter yor Chooes ");
            ///    int ansewer = int.Parse(Console.ReadLine());
            ///}
            ///5.for(i<NumberOfQuesion.lenth)
            ///1.Show {NumberOfQuestion} and Its Answers and put==========
            ///2.Enforse User To Enter The Answer 1 or 2 and  put==========
            ///6.after Finsh loop 
            ///1.Show {NumberOfQuestion} and {MyAnswer}
            ///2.calculet my {Grade} and Show It
        }

    }
}