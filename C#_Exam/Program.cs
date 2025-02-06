using System.Diagnostics;

namespace C__Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10,"Math");
            sub.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start Exam Y|N :");
            char input = char.Parse(Console.ReadLine());
            if (input == 'Y' || input == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub._exam.ShowExam();
                Console.WriteLine($"The Elapsed Time ={sw.Elapsed}");
            }

            /// Create a subject
            ///Subject subject = new Subject(1, "Programming");
            /// Create a final exam
            ///FinalExam finalExam = new FinalExam(120, 5);
            /// Add questions to the exam
            ///TFQuesion tfQuestion = new TFQuesion("TF1", "Is C# an object-oriented language?", 2);
            ///tfQuestion.CorrectAnswerId = 1;
            ///finalExam.AddQuestion(tfQuestion);
            ///MCQQuestion mcqQuestion = new MCQQuestion("MCQ1", "What is the capital of France?", 3);
            ///mcqQuestion.AddAnswer(new Answers(1, "Paris"));
            ///mcqQuestion.AddAnswer(new Answers(2, "London"));
            ///mcqQuestion.AddAnswer(new Answers(3, "Berlin"));
            ///mcqQuestion.CorrectAnswerId = 1;
            ///finalExam.AddQuestion(mcqQuestion);
            /// Assign the exam to the subject
            ///subject.CreateExam(finalExam);
            /// Show exam details
            ///Console.WriteLine(subject);
            ///finalExam.ShowExam();

        }
    }
}
