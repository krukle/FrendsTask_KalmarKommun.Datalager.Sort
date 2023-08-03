using NUnit.Framework;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
                ListToSort = JArray.FromObject(
                    new List<Dictionary<string, string>>{
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
                    }
                ),
                Key = JToken.FromObject("season")
            };

            var ret = Sort.SortAscendingByParsedIntThenDescendingByText(input, new System.Threading.CancellationToken());

            Assert.That(ret.SortedList, Is.EqualTo(JArray.FromObject(
                new List<Dictionary<string, string>> {
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
                })));
        }
    }
}
