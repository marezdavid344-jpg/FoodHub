namespace FoodHub.Models
{
    public class Restuarnt
    {
        public int ID { get; set;}
        public string Name { get; set;}
        public string Cuisine { get; set;}
        public double Rating { get; set;}
        public decimal DeliveryFee {  get; set;}
        public int DeliveryMinutes { get; set; }
        public bool IsOpen { get; set; }
    }
}
