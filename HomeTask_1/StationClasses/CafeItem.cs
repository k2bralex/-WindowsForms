using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_1.StationClasses
{
    public class CafeItem
    {
        public string Type { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Price.ToString();
        }
    }
}
