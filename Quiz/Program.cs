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
                Console.WriteLine();
            }

        }
    }
}