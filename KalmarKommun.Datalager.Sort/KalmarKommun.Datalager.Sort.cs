﻿using System;
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
        /// 
        /// Documentation: https://github.com/krukle/FrendsTask_KalmarKommun.Datalager.Sort
        /// 
        /// </summary>
        /// <param name="input">The List to sort, and which key's values to sort by</param>
        /// <param name="cancellationToken"></param>
        /// <returns>The sorted list of dictionaries.</returns>
        public static Result SortAscendingByParsedIntThenDescendingByText(Parameters input, CancellationToken cancellationToken)
        {
            return new Result
            {
                SortedList = input.ListToSort
                    .OrderBy(x => Int32.Parse(Regex.Match(x[input.Key.ToString()].ToString(), @"\d+").Value))
                    .ThenByDescending(x => x[input.Key.ToString()])
                    .ToList()
            };
        }
    }
}
