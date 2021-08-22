using System;

namespace Quiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Questions questions = new Questions();
            User user = new User();

            while (user.Points < Questions.MAX_NUMBER_OF_POINTS)
            {
                string randomQuestion = questions.GetRandomQuestion();
                Console.WriteLine(randomQuestion);
                
                string answer = Console.ReadLine().ToLower();
                bool validAnswer = questions.IsAnswerValid(questions.QuestionId, answer);

                if (validAnswer)
                {
                    user.Points += 1;
                }
                
                Console.WriteLine("Answer is: "+validAnswer+". You have total of "+user.Points+" points");
            }
            
            Console.WriteLine("You have finished the quiz");
            Console.ReadLine();

        }
    }
}