using NUnit.Framework;
using System.Collections.Generic;

namespace KalmarKommun.Datalager.Sort.Tests
{
    [TestFixture]
    class TestClass
    {
        /// <summary>
        /// Tests class SortAscendingByParsedIntThenDescendingByText. 
        /// </summary>
        [Test]
        public void TestSortAscendingByParsedIntThenDescendingByText()
        {

            var input = new Parameters
            {
                ListToSort = new List<Dictionary<string, string>> {
                    new Dictionary<string, string> {
                        { "season", "autum-2023" },
                        { "month", "october" }
                    },
                    new Dictionary<string, string> {
                        { "season", "spring-2022" }
                    },
                    new Dictionary<string, string> {
                        { "season", "autum-2022" },
                        { "month", "november" }
                    },
                    new Dictionary<string, string> {
                        { "season", "spring-2023" }
                    }
                },
                Key = "season"
            };

            var SortedList = Sort.SortAscendingByParsedIntThenDescendingByText(input, new System.Threading.CancellationToken());

            Assert.That(SortedList, Is.EqualTo(new List<Dictionary<string, string>> {
                new Dictionary<string, string> {
                    { "season", "spring-2022" }
                },
                new Dictionary<string, string> {
                    { "season", "autum-2022" },
                    { "month", "november" }
                },
                new Dictionary<string, string> {
                    { "season", "spring-2023" }
                },
                new Dictionary<string, string> {
                    { "season", "autum-2023" },
                    { "month", "october" }
                }
            }));
        }
    }
}
