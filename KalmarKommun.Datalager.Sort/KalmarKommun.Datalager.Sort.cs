using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.CSharp; // You can remove this if you don't need dynamic type in .NET Standard frends Tasks

#pragma warning disable 1591

namespace KalmarKommun.Datalager.Sort
{
    public static class Sort
    {
        /// <summary>
        /// Task for sorting a List of Dicitionaries, based on the values of a key from the Dictionaries.
        /// 
        /// <br></br>
        /// 
        /// Repository: https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort
        /// </summary>
        /// <param name="input">The List to sort, and which key's values to sort by</param>
        /// <param name="cancellationToken"></param>
        /// <returns>The sorted list.</returns>
        public static Result SortAscendingByParsedIntThenDescendingByText(Parameters input, CancellationToken cancellationToken)
        {
            return new Result {
                SortedList = input.ListToSort
                    .OrderBy(x => Int32.Parse(Regex.Match(x[input.Key], @"\d+").Value))
                    .ThenByDescending(x => x[input.Key])
                    .ToList()
            };
        }
    }
}
