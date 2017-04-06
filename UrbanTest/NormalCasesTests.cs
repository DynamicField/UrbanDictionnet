using System;
using System.Linq;
using NUnit.Framework;
using UrbanDictionnet;
using System.Threading.Tasks;


namespace UrbanTest
{
    [TestFixture]
    public class NormalCasesTests
    {
        private UrbanClient Client { get; } = new UrbanClient();
        
        [Test]
        public async Task FindsRandomWord()
        {
            Assert.That(await Client.GetRandomWordAsync(), Is.Not.EqualTo(null));          
        }
        [Test]
        public async Task FindsRandomWords()
        {
            var randomWords = await Client.GetRandomWordsAsync();
            // be surrrrrrre that every definition data are not null
            var isCorrect = true;
            foreach (var item in randomWords)
            {
                if (item == null)
                {
                    isCorrect = false;
                    break;
                }
            }
            Assert.That(isCorrect, Is.True);
        }
        [Test]
        public async Task AutoCompletionWorks()
        {
            // get autocompletion for "ye"
            var result = await Client.GetAutocompletionFor("ye");
            // check if there is things in it
            Assert.That(result.Any(), Is.True);
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
        public async Task VoteSuceeds()
        {
            var randomWord = await Client.GetRandomWordAsync();
            var voteResult = await Client.VoteOnDefinition(randomWord.DefId, VoteDirection.Up);
            Assert.That(voteResult.Status, Is.EqualTo(VoteStatus.Saved).Or.EqualTo(VoteStatus.Duplicate)); // Can be duplicate, don't trust randomness :)
        }

        //--------------------------
        // Testing auto properties is useless. :D
        //--------------------------

        //[Test]
        //public async Task GettingVoteResults()
        //{
        //    var word = await Client.GetRandomWordAsync();
        //    var result = await Client.VoteOnDefinition(word.List[0].DefId, VoteDirection.Up);
        //    Assert.DoesNotThrow(() =>
        //    {
        //        // ReSharper disable UnusedVariable
        //        var up = result.Up;
        //        var down = result.Down;
        //    });
        //}

        //[Test]
        //public async Task GettingWordResults()
        //{
        //    // get a random word
        //    // try to get tags and sounds
        //    var result = await Client.GetRandomWordAsync();
        //    Assert.DoesNotThrow(() =>
        //    {               
        //        var tags = result.Tags;                
        //        var sounds = result.Sounds;
        //        var firstDef = result[0];
        //        // ReSharper restore UnusedVariable
        //    });
            
        //}

        //[Test]
        //public async Task GettingIdWordResults()
        //{
        //    // get a random word
        //    // try to get tags and sounds
        //    var result = await Client.GetWordAsync(55);
        //    Assert.DoesNotThrow(() =>
        //    {
        //        var tags = result.Tags;
        //        var firstDef = result.Definition;
        //        // ReSharper restore UnusedVariable
        //    });

        //}

        [Test]
        public void ToUpEmojiWorks()
        {
            Assert.That(VoteDirection.Up.ToEmoji(),Is.SameAs("👍"));
        }

        [Test]
        public void ToDownEmojiWorks()
        {
            Assert.That(VoteDirection.Down.ToEmoji(),Is.SameAs("👎"));
        }

        [Test]
        public async Task ToStringWorks()
        {
            var result = await Client.GetRandomWordAsync();
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Assert.DoesNotThrow(() => result.ToString());
        }
        [Test]
        public async Task PermalinkIsValid()
        {
            var r = await Client.GetRandomWordAsync();
            Assert.That(Uri.IsWellFormedUriString(r.Permalink, UriKind.Absolute), Is.True);
        }

        [Test]
        public async Task SettingWordIndexer()
        {
            var result = await Client.GetRandomWordAsync();
            Assert.DoesNotThrow(() =>
            {
                result = new DefinitionData();
            });
        }

        [Test]
        public async Task CanGetEnumeratorFromWords()
        {
            var result = await Client.GetRandomWordsAsync();
            Assert.DoesNotThrow(() =>
            {
                // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
                result.GetEnumerator();
            });
        }

        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private static bool CheckContent(WordDefine result)
        {
            
            var notNull = result.List.Any(); // There can still be no tags and sounds.
            if ((from item 
                 in result.List
                 from prop 
                 in item.GetType().GetProperties()
                 where prop.GetValue(item) == null && prop.Name != "CurrentVote"
                 select item).Any())
            {
                return false;
            }
            return notNull;
        }
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private static bool CheckContent(UniqueWordDefine result)
        {
            return result.GetType().GetProperties().All(item => item != null);
        }
        
    }
}
