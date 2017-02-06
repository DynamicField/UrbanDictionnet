using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrbanDictionnet;
using System.Threading.Tasks;

namespace UrbanTest
{
    [TestClass]
    public class UnitTest1
    {        
        private UrbanClient Client { get; set; }

        [TestInitialize]
        public void Init()
        {
            Client = new UrbanClient();
        }
        
        [TestMethod]      
        public async Task FindsRandomWord()
        {            
            var result = await Client.GetRandomWordAsync();
            var nothingIsNull = CheckContent(result);
            Assert.IsTrue(nothingIsNull);
            
        }

        [TestMethod]
        public async Task FindsTestWord()
        {
            var result = await Client.GetWordAsync("lol");
            var right = CheckContent(result);
            Assert.IsTrue(right);
        }

        [TestMethod]
        public async Task FindsDefId()
        {
            var id = 10956207;
            var result = await Client.GetWordAsync(id);
            var good = CheckContent(result);
            Assert.IsTrue(good);
        }

        private static bool CheckContent(UrbanDictionnet.Entities.WordDefine result)
        {
            var notNull = result.List.Any(); // There can still be no tags and sounds.
            foreach (var item in result.List)
            {
                if (item.GetType().GetProperties().Any(prop => prop.GetValue(item) == null))
                {
                    return false;
                }
            }
            return notNull;
        }
        }
    }
