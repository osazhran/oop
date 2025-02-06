using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestion) : base(timeOfExam, numberOfQuestion)
        {
        }
       
        public override void ShowExam()
        {
            //9- Final Exam Shows the Questions, Answers and Grade.
            int score = 0;
           // BaseQuestion _baseQuestion;

            foreach (var question in baseQuestion)
            {
                question.ShowQuestion();
                Console.Write("Enter your answer: ");
                int userAnswer = int.Parse(Console.ReadLine());
                if (userAnswer == question.CorrectAnswer)
                    score += question.Mark;
            }
            Console.Clear();
            Console.WriteLine("The Exam Ques And Answers ");

           foreach (var q in baseQuestion)
            {
                Console.WriteLine($"Q).{q.Body} Answers) {string.Join(" , ", q.answers.Select(a => a.ToString()))} .       Mark is {q.Mark} ");
                Console.WriteLine($"The Right Answer is Number {q.CorrectAnswer}");
                Console.WriteLine("=============================================");

            }
            
            Console.WriteLine($"Your final score: {score}\n");
        }

        ///if choose 1 ->Show Functionalty For final
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
        ///3.show the Time User Take To finsh The Exam
    }

 }


