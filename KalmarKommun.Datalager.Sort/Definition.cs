#pragma warning disable 1591

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KalmarKommun.Datalager.Sort
{
    /// <summary>
    /// Parameters class contains parameters that are required.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// The list to sort.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue(null)]
        public List<Dictionary<string, string>> ListToSort { get; set; }

        /// <summary>
        /// Key of which value to sort by.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("")]
        public string Key { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// Contains SortedList which is ListToSort, sorted by the provided Key.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public List<Dictionary<string, string>> SortedList;
    }
}
