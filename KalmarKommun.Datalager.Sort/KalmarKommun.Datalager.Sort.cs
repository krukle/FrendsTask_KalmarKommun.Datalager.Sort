using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

#pragma warning disable 1591

namespace KalmarKommun.Datalager.Sort
{
    public static class Sort
    {
        /// <summary>
        /// Task for sorting a List of Dicitionaries, based on the values of a key from the Dictionaries.
        /// Documentation: https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort
        /// </summary>
        /// <param name="input">The List to sort, and which key's values to sort by</param>
        /// <param name="cancellationToken"></param>
        /// <returns> List<Dictionary<string, string>> </returns>
        public static List<Dictionary<string, string>> SortAscendingByParsedIntThenDescendingByText(Parameters input, CancellationToken cancellationToken)
        {
            return input.ListToSort
                    .OrderBy(x => Int32.Parse(Regex.Match(x[input.Key], @"\d+").Value))
                    .ThenByDescending(x => x[input.Key])
                    .ToList();
        }
    }
}
