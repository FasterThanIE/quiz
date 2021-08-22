using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Questions
    {
        public static int MAX_NUMBER_OF_POINTS = 10;
        
        public int QuestionId { get; set; }
        private List<int> AnsweredQuestion = new List<int>();
        
        private string[] questions = new string[]
        {
            "What is 2+2\nA: 4\nB: 5\nC: 12",
            "What is 2+3\nA: 4\nB: 5\nC: 12",
        };
        
        private string[] answers = new string[] {"a", "b"};

        public string GetRandomQuestion()
        {
            Random rnd = new Random();
            QuestionId = rnd.Next(questions.Length);
            AnsweredQuestion.Add(QuestionId);

            return questions[QuestionId];
        }

        public bool IsAnswerValid(int questionId, string answer)
        {
            return answers[questionId] == answer;
        }
    }
}