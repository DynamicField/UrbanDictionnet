using System;
using System.Linq;
using System.Threading.Tasks;
using UrbanDictionnet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UrbanUnitTests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public async Task FindsRandomWord()
        {
            var client = new UrbanClient();
            var result = await client.GetRandomWordAsync();
            var notNull = result.List.Any(); // There can still be no tags and sounds.
            var nothingIsNull = notNull;
            foreach (var item in result.List)
            {
                if (item.GetType().GetProperties().Any(prop => prop.GetValue(item) == null))
                {
                    nothingIsNull = true;
                }
            }
            Assert.IsTrue(nothingIsNull);
        }
    }
}
