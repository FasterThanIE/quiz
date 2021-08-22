using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Questions
    {
        private int QuestionId { get; set; }
        private List<int> AnsweredQuestion = new List<int>();
        
        public string GetRandomQuestion()
        {
            string[] questions = new string[]
            {
                "What is 2+2",
                "What is 2+3",
            };

            Random rnd = new Random();
            QuestionId = rnd.Next(questions.Length);
            AnsweredQuestion.Add(QuestionId);

            Console.WriteLine(QuestionId);
                
            return questions[QuestionId];
        }
    }
}