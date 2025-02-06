namespace C__Exam
{
    internal class Subject
    {
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam _exam { get; set; }

        public void CreateExam()
        {

            int examType;
            do
            {
                Console.Write("Plase Enter The Type Of Exam You Want To Create (1: Practical, 2: Final): ");
            } while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2));

            int time;
            do
            {
                Console.Write("Enter Exam Duration in Minutes: ");
            } while (!int.TryParse(Console.ReadLine(), out time));

            int numQuestions;

            do
            {
                Console.Write("Enter Number of Questions for this Exam: ");
            } while (!int.TryParse(Console.ReadLine(), out numQuestions));

            _exam = examType == 1 ? new PracticalExam(time, numQuestions) : new FinalExam(time, numQuestions);

            for (int i = 0; i < numQuestions; i++)
            {
                int questionType;
                while (true)
                {
                    Console.Write($"Enter The Type Of Q{i + 1} (1: MCQ, 2: TF): ");
                    if (int.TryParse(Console.ReadLine(), out questionType) && (questionType == 1 || questionType == 2))
                    {
                        break; // Exit the loop if the input is valid
                    }
                    Console.WriteLine("plase Enter 1 or 2 only");
                }


                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                int mark;
                while (true)
                {
                    Console.Write("Enter mark: ");
                    if (int.TryParse(Console.ReadLine(), out mark))
                    {
                        break; // If valid input is entered, exit the loop
                    }
                    Console.WriteLine("Plase Enter Vaild Number");
                }
                int NumOfAnswers=0;

                if (questionType == 1)
                {
                    bool isValid = false;
                    while (!isValid)
                    {
                        Console.Write("Enter Number Of Answers: ");
                        isValid = int.TryParse(Console.ReadLine(), out NumOfAnswers);
                        if (!isValid)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                }

                Answers[] answers;
                if (questionType == 1)
                {
                    answers = new Answers[NumOfAnswers];
                    for (int j = 0; j < answers.Length; j++)
                    {
                        Console.Write($"Enter Answer {j + 1}: ");
                        answers[j] = new Answers(j + 1, Console.ReadLine());

                    }
                }
                else // questionType == 2
                {
                    answers = new Answers[2];
                    answers[0] = new Answers(1, "True");   
                    answers[1] = new Answers(2, "False");  
                }
                int correctAnswer;
                do
                {
                    Console.Write("Enter Correct Answer Number: ");

                } while (!int.TryParse(Console.ReadLine(), out correctAnswer) || correctAnswer < 1 || correctAnswer > answers.Length);

                Console.Clear();
                string header = questionType == 2 ? "True | False Qusetion" : "Chosse on Amsewr Form this";
                BaseQuestion question = questionType == 2 ? new TFQuesion(header, body, mark, answers, correctAnswer) : new MCQQuestion(header, body, mark, answers, correctAnswer);
                _exam.baseQuestion.Add(question);



            }


            //public override string ToString()
            //{
            //    return $"Subject: {SubjectName}, Exam Time: {_exam.TimeOfExam} minutes, Number of Questions: {_exam.NumberOfQuestion}";
            //}

        }
    }
}






