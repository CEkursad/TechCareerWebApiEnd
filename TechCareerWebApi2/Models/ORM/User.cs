namespace TechCareerWebApi2.Models.ORM
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public List<Order> Orders { get; set; }
    }
}
