using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HomeTask_1.StationClasses;

namespace HomeTask_1
{
    public class Check
    {
        public Fuel FuelToCheck { get; set; }
        public CafeItem ItemToList { get; set; }
        public List<CafeItem> ItemsToCheck { get; set; } = new List<CafeItem>();
        public double FuelVolume { get; set; }
        public double FuelSum { get; set; } = 0;
        public double CafeSum { get; set; } = 0;
        
        public Check()
        {
            FuelToCheck = new Fuel();
            ItemToList = new CafeItem();
        }

        public override string ToString()
        {
            return $"Печать чека:\n" +
                   $"Топливо: {FuelToCheck.Type} - {FuelToCheck.Price} - {FuelSum}\n" +
                   $"Кафе: {CafeSum}\n" +
                   $"Итого: {FuelSum+CafeSum}";
        }
    }
}
