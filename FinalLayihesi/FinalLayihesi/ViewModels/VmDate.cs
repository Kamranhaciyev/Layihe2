using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalLayihesi.ViewModels
{
    public class VmDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Count { get; set; }

        public enum Monthes
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
