using System.Linq;
using NUnit.Framework;
using UrbanDictionnet;
using System.Threading.Tasks;
using UrbanDictionnet.Entities;
using UrbanDictionnet.Entities.Vote;

namespace UrbanTest
{
    [TestFixture]
    public class NormalCasesTests
    {
        private UrbanClient Client { get; } = new UrbanClient();
        
        [Test]
        public async Task FindsRandomWord()
        {
            var result = await Client.GetRandomWordAsync();
            var nothingIsNull = CheckContent(result);
            Assert.That(nothingIsNull, Is.True);
        }

        [Test]
        public async Task FindsTestWord()
        {
            var result = await Client.GetWordAsync("lol");
            var right = CheckContent(result);
            Assert.That(right, Is.True);
        }

        [Test]
        public async Task FindsDefId()
        {
            const int id = 10956207;
            var result = await Client.GetWordAsync(id);
            var good = CheckContent(result);
            Assert.That(good, Is.True);
        }

        [Test]
        public async Task VoteSucceds()
        {
            var randomWord = await Client.GetRandomWordAsync();
            var voteResult = await Client.VoteOnDefinition(randomWord.List[0].DefId, VoteDirection.Up);
            Assert.That(voteResult.Status, Is.EqualTo(VoteStatus.Saved).Or.EqualTo(VoteStatus.Duplicate)); // Can be duplicate, don't trust randomness :)
        }

        [Test]
        public async Task GettingVoteResults()
        {
            var word = await Client.GetRandomWordAsync();
            var result = await Client.VoteOnDefinition(word.List[0].DefId, VoteDirection.Up);
            Assert.DoesNotThrow(() =>
            {
                // ReSharper disable UnusedVariable
                var up = result.Up;
                var down = result.Down;
            });
        }

        [Test]
        public async Task GettingWordResults()
        {
            // get a random word
            // try to get tags and sounds
            var result = await Client.GetRandomWordAsync();
            Assert.DoesNotThrow(() =>
            {
                
                var tags = result.Tags;                
                var sounds = result.Sounds;
                // ReSharper restore UnusedVariable
            });
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private static bool CheckContent(WordDefine result)
        {
            var notNull = result.List.Any(); // There can still be no tags and sounds.
            if (result.List.Any(item => item.GetType().GetProperties().Any(prop => prop.GetValue(item) == null)))
            {
                return false;
            }
            return notNull;
        }
    }
}
