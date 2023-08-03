#pragma warning disable 1591

using Newtonsoft.Json.Linq;
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
        /// The list of dictionaries to sort.
        /// </summary>
        [DisplayFormat(DataFormatString = "Expression")]
        [DefaultValue(null)]
        public JArray ListToSort { get; set; }

        /// <summary>
        /// Key of which value in dictionaries to sort list by.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("")]
        public JToken Key { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// Contains SortedList which is ListToSort, sorted by the provided Key.
        /// </summary>
        [DisplayFormat(DataFormatString = "Expression")]
        public JArray SortedList;
    }
}
