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
        /// The list of dictionaries to sort.
        /// </summary>
        [DisplayFormat(DataFormatString = "Expression")]
        [DefaultValue(null)]
        public List<Dictionary<string, string>> ListToSort { get; set; }

        /// <summary>
        /// Key of which value in dictionaries to sort list by.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("")]
        public string Key { get; set; }
    }
}
