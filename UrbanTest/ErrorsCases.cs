using System;
using NUnit.Framework;
using UrbanDictionnet;
using UrbanDictionnet.Entities;
using UrbanDictionnet.Entities.Vote;

namespace UrbanTest
{
    [TestFixture]
    public class ErrorsCases
    {
        private UrbanClient Client { get; } = new UrbanClient();
        private Random Randomizer { get; } = new Random();
        [Test]
        public void NegativeDefIdThrows()
        {
            const int id = -1;
            Assert.ThrowsAsync<ArgumentException>(async () => await Client.GetWordAsync(id));
        }

        [Test]
        public void NonExistantWordThrows()
        {
            var chars = new char[30];
            for (var i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)Randomizer.Next(21,79);
            }
            var stringToTest = new string(chars);
            Assert.ThrowsAsync<WordNotFoundException>(async () => await Client.GetWordAsync(stringToTest));
        }

        [Test]
        public void NonExistantDefIdThrows()
        {
            Assert.ThrowsAsync<WordNotFoundException>(async () => await Client.GetWordAsync(int.MaxValue));
        }

        [Test]
        public void VoteOnNonExistantDefIdThrows()
        {
            Assert.ThrowsAsync<VoteException>(async () => await Client.VoteOnDefinition(int.MaxValue, VoteDirection.Up));
        }
    }
}
