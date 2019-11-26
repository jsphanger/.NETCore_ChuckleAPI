using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChuckleWebAPI
{
    interface IJoke
    {
        public string ToString();
    }

    interface IJokeServer
    {
        public List<Joke> GetAllJokes();
        public Joke GetRandomJoke();
        public Joke GetJokeByID(int id);
    }

    public class Joke : IJoke
    {
        public int ID { get; set; }
        public string Body { get; set; }
        public string Punchline { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Body, Punchline);
        }
    }

    public class JokeServer : IJokeServer
    {
        private List<Joke> Jokes { get; set; }

        public JokeServer()
        {
            Jokes = new List<Joke>()
            {
                new Joke(){ ID = 1, Body = "What do you call a picture of a bookcase?", Punchline = "A shelfie" },
                new Joke(){ ID = 2, Body = "What did the parking lot say to the garage?", Punchline = "Be car-ful" },
                new Joke(){ ID = 3, Body = "What did the math book say to his doctor?", Punchline = "I'm full of problems" },
                new Joke(){ ID = 4, Body = "Why did the crazy train get in trouble?", Punchline = "He had loco-motives" },
                new Joke(){ ID = 5, Body = "What do packages & social media share?", Punchline = "A post-al system" },
                new Joke(){ ID = 6, Body = "What's clever and can fit in your hand?", Punchline = "A smartphone" }
            };
        }
        
        public List<Joke> GetAllJokes()
        {
            return Jokes;
        }

        public Joke GetRandomJoke()
        {
            var jokeNumber = new Random().Next(0, Jokes.Count - 1);
            return Jokes.ElementAt(jokeNumber);
        }

        public Joke GetJokeByID(int id)
        {
            return Jokes.Where(x => x.ID == id).FirstOrDefault();
        }

    }
}
