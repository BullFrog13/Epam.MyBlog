using System.Collections.Generic;

namespace DAL
{
    public class Question
    {
        public static int TotalAnswers;

        public int ID { get; set; }

        public string Text { get; set; }

        public int SelectedAnswer { get; set; }

        public ICollection<Answer> PossibleAnswer { get; set; }
    }
}