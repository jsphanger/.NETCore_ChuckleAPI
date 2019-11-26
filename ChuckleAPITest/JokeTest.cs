using ChuckleWebAPI;
using System;
using Xunit;

namespace ChuckleAPITest
{
    public class JokeTest
    {
        private JokeServer server { get; set; }

        public JokeTest(){
            server = new JokeServer();
        }

        [Fact]
        public void JokeServer_AllJokes()
        {
            var jokes = server.GetAllJokes();
            
            Assert.True(jokes.Count > 0);
        }

        [Fact]
        public void JokeServer_RandomJoke()
        {
            var joke = server.GetRandomJoke();

            Assert.NotNull(joke);
        }

        [Fact]
        public void JokeServer_JokeByID()
        {
            var id = 3;
            var joke = server.GetJokeByID(id);

            Assert.Equal(id, joke.ID);
        }
    }
}
