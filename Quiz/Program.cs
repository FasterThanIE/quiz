using System;

namespace Quiz
{
    class Quiz
    {
        static void Main(string[] args)
        {
            Questions questions = new Questions();
            
            Console.WriteLine(questions.GetRandomQuestion());
            Console.ReadLine();
            Console.WriteLine("S");
            Console.ReadLine();
        }
    }
}