using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    public class VacationApiModel
    {
        public int? id { get; set; }
        public int hotel { get; set; }
        public int outboundTrip { get; set; }
        public int returnTrip { get; set; }
        public int amountOfPeople { get; set; }
        public DateTime startDate;
        public DateTime endDate;
        public double extraBagageInKg { get; set; }
        public int userId { get; set; }

        public VacationApiModel(int hotel, int outboundTrip, int returnTrip, int amountOfPeople, DateTime startDate, DateTime endDate, double extraBagageInKg, int userId)
        {
            this.hotel = hotel;
            this.outboundTrip = outboundTrip;
            this.returnTrip = returnTrip;
            this.amountOfPeople = amountOfPeople;
            this.startDate = startDate;
            this.endDate = endDate;
            this.extraBagageInKg = extraBagageInKg;
            this.userId = userId;
        }
    }
}
