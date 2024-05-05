using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OmniMarket.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public string Value_Text
        {
            get
            {
                return Value.ToString("C2");
            }
        }
    }
}