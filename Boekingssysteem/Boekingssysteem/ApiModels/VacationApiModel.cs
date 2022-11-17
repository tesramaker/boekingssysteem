using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boekingssysteem.ApiModels
{
    public class VacationApiModel
    {
        //TODO: Fix questionmark
        //public int id { get; set; }
        public int hotelId { get; set; }
        public int outboundTrip { get; set; }
        public int returnTrip { get; set; }
        public int amountOfPeople { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public double extraBagageInKg { get; set; }
        public int userId { get; set; }

        public VacationApiModel(int hotelId, int outboundTrip, int returnTrip, int amountOfPeople, DateTime startDate, DateTime endDate, double extraBagageInKg, int userId)
        {
            this.hotelId = hotelId;
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
