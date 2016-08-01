using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.Content
{
    public class BlogInit : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {

            //Answers to question init
            List<Answer> answers = new List<Answer>
            {
                new Answer {ID = 1, Text="1" },
                new Answer {ID = 2, Text="2" },
                new Answer {ID = 3, Text="3" },
                new Answer {ID = 4, Text="4" },
                new Answer {ID = 5, Text="5" }

            };
            context.Answers.AddRange(answers);
            context.SaveChanges();


            //Questions init
            List<Question> questions = new List<Question>
            {
                new Question {ID = 1, Text = "How would you rate this blog?", PossibleAnswer = answers, SelectedAnswer = 0 },  
            };

            context.Questions.AddRange(questions);
            context.SaveChanges();

            //Account init
            List<Account> Accounts = new List<Account>
            {
                new Account { ID = 1, Name = "Yevgeniy", Age = 19, Gender = "Male", Telephone = "0939142271", Notification = "SMS", Password = "123", Date = DateTime.Now, Email = "13heavyweather@gmail.com" },
                new Account { ID = 2, Name = "Maria", Age = 19, Gender = "Female", Telephone = "0954534534", Notification = "Facebook", Password = "312", Date = DateTime.Now.AddDays(-1), Email = "CoolGuy@rambler.ru" },
                new Account { ID = 3, Name = "Natasha", Age = 44, Gender = "Female", Telephone = "0675746778", Notification = "Telephone", Password = "gtrhy", Date = DateTime.Now.AddHours(-5), Email = "Hello@mail.ru" }
            };
            context.Accounts.AddRange(Accounts);
            context.SaveChanges();

            //Tags init
            Tag tag1 = new Tag { ID = 1, Text = "Football" };
            Tag tag2 = new Tag { ID = 2, Text = "Art" };
            Tag tag3 = new Tag { ID = 3, Text = "Photo" };

            context.Tags.Add(tag1);
            context.Tags.Add(tag2);
            context.Tags.Add(tag3);


            //Posts init
            List<Post> Posts = new List<Post>
            {
                new Post {ID = 1, Author = "Yevgeniy", Text = "This site is awesome", Title = "New blog", Date = DateTime.Now.AddDays(-3), Tags = new List<Tag>() { tag1 }  },
                new Post {ID = 2, Author = "Maria", Text = "I like my sister", Title = "My sister", Date = DateTime.Now.AddDays(-2), Tags = new List<Tag>() { tag2 } },
                new Post {ID = 3, Author = "Natasha", Text = "Can't stand those haters", Title = "Haters gonna hate", Date = DateTime.Now.AddDays(-1), Tags = new List<Tag>() { tag3, tag1 } }
            };

            context.Posts.AddRange(Posts);
            context.SaveChanges();


            //Revews init
            List<Review> Reviews = new List<Review>
            {
                new Review {ID = 1, Author = "Yevgeniy", Text = "Will download this soon.", Date = DateTime.Now.AddHours(-12) },
                new Review {ID = 2, Author = "Maria", Text = "Going to enjoy my workout in 5 minutes", Date = DateTime.Now.AddHours(-8) }
            };

            context.Reviews.AddRange(Reviews);
            context.SaveChanges();
        }
    }
}
