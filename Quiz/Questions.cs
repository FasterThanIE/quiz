using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Questions
    {
        public static int MAX_NUMBER_OF_POINTS = 10;
        
        private int QuestionId { get; set; }
        private List<int> AnsweredQuestion = new List<int>();

        public string GetRandomQuestion()
        {
            string[] questions = new string[]
            {
                "What is 2+2\nA: 4\nB: 5\nC: 12",
                "What is 2+3",
            };

            Random rnd = new Random();
            QuestionId = rnd.Next(questions.Length);
            AnsweredQuestion.Add(QuestionId);

            Console.WriteLine(QuestionId);
                
            return questions[QuestionId];
        }

        private bool IsAnswerValid(int questionId, int answerId)
        {
            string[] answers = new string[] {"a", "b"};
            
            // TODO: Add logic
            return true;
        }
    }
}