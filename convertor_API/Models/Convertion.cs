using System;
using System.Collections.Generic;

#nullable disable

namespace convertor_API.Models
{
    public partial class Convertion
    {
        public int ConvetionId { get; set; }
        public string AmountConverted { get; set; }
        public string CurrencyFrom { get; set; }
        public string CurrencyFromRate { get; set; }
        public string CurrencyTo { get; set; }
        public string CurrencyToRate { get; set; }
        public string UserAgent { get; set; }
    }
}
