using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_1
{
    public class Fuel
    {
        public string Type { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
