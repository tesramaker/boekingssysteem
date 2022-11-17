using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    internal class HotelApiModel
    {
        public int? id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double xCoord { get; set; }
        public double yCoord { get; set; }
    }
}
