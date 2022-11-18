namespace Boekingssysteem.ApiModels
{
    internal class RoomApiModel
    {
        public int id { get; set; }
        public int hotelId { get; set; }
        public int roomNumber { get; set; }
        public int amountOfPeople { get; set; }
        public decimal price { get; set; }
        public DateTime reservedFrom { get; set; }
        public DateTime reservedTill { get; set; }
        public int typeOfRoom { get; set; }
    }
}