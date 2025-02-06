using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Exam
{
   public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<BaseQuestion> baseQuestion { get; set; }

        protected Exam(int timeOfExam, int numberOfQuestion)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestion = numberOfQuestion;
            
         baseQuestion = new List<BaseQuestion>();
        }

        public abstract void ShowExam();
       

        //public void CreateExam(string ExamName, int Time)
        //{
            //    Console.WriteLine("Do You Want 1.Final Or 2.Practicl Exam ");
            //    if (int.Parse(Console.ReadLine()) == 1)
            //    {
            //        //implment function to ceate FinalExam
            //        FinalExam finalExam = new FinalExam();
            //        //1.Enforce User To Enter {Time} of Exam
            //        Console.WriteLine("Enter The Time Of Exam");
            //        int Timee = int.Parse(Console.ReadLine());
            //        finalExam.TimeOfExam = Timee;

            //        //2.Enforce User To Enter {NumberOfQuestion} of Exam
            //        Console.WriteLine("Enter The NumberOfQuestion Of Exam");
            //        int NumberOfQuestion = int.Parse(Console.ReadLine());
            //        finalExam.NumberOfQuestion = NumberOfQuestion;

            //        for (int i = 1; i <= NumberOfQuestion; i++)
            //        {
            //            //Enforce User To Enter {TypeOfQuestion} of {NumberOfQuestion} is {1.MCQ} or {2.TF}
            //            Console.WriteLine($"Enter The TypeOfQuestion of Qustion Number {i} if It ( 1 )MCQ or ( 2 )TF");
            //            int result = int.Parse(Console.ReadLine());

            //            ///{2.TF}
            //            if (result == 2)
            //            {
            //                ///1. Enforce User To Enter {BodyOfQusion Ques Itself}  {NumberOfQuestion} of Exam
            //                ///2. Enforce User To Enter {MarkOfQuesion} {NumberOfQuestion} of Exam
            //                ///3. Enforce User To Enter {AnseerOFQuesion} {NumberOfQuestion} //This Shoud Be 1 or 2
            //                Console.WriteLine($"Enter The BodyOfQusion of {i} ");
            //                finalExam.Body = Console.ReadLine();

            //                Console.WriteLine($"Enter The Mark Of Quesion of {i} ");
            //                finalExam.Mark = int.Parse(Console.ReadLine());

            //                Console.WriteLine($"Enter The AnseerOFQuesion of {i} ( 1 )True ( 2 )False");
            //                finalExam.RightAnsewer = int.Parse(Console.ReadLine());
            //                Console.WriteLine("=========================");

            //            }
            //            ///{1.MCQ}
            //            if (result == 1)
            //            {
            //                ///1. Enforce User To Enter {BodyOfQusion Ques Itself}  {NumberOfQuestion} of Exam
            //                ///2. Enforce User To Enter {MarkOfQuesion} {NumberOfQuestion} of Exam
            //                ///3. Enforce User To Enter {Choese1 and choes2 and choes3 } {NumberOfQuestion}
            //                ///4. Enforce User To Enter {AnseerOFQuesion} {NumberOfQuestion}// This Shoud Be 1 or 2 or 3
            //                Console.WriteLine($"Enter The BodyOfQusion of {i} ");
            //                finalExam.Body = Console.ReadLine();

            //                Console.WriteLine($"Enter The Mark Of Quesion of {i} ");
            //                finalExam.Mark = int.Parse(Console.ReadLine());

            //                Console.WriteLine($"Enter The Ansewrs Of Quesion of {i} ");
            //                finalExam.Ansewers = Console.ReadLine();
            //                finalExam.Ansewers = Console.ReadLine();
            //                finalExam.Ansewers = Console.ReadLine();

            //                Console.WriteLine($"Enter The AnseerOFQuesion of {i} ( 1 ) or ( 2 ) or ( 3 )");
            //                finalExam.RightAnsewer = int.Parse(Console.ReadLine());
            //                Console.WriteLine("=========================");


            //            }


            //        }




        //}

    //}

      

        
    }
    }
