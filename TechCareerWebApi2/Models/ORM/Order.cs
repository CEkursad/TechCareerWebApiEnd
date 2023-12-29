namespace TechCareerWebApi2.Models.ORM
{
    public class Order
    {
        public int ID { get; set; }
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }

        public List<User> Users { get; set; }
    }
}
