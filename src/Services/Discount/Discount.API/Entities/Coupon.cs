
namespace Discount.API.Entities
{
    public class Coupon
    {
        public Coupon(int id, string productName, string description, int amount)
        {
            Id = id;
            ProductName = productName;
            Description = description;
            Amount = amount;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}