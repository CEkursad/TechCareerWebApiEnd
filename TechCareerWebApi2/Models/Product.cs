namespace TechCareerWebApi2.Models
{
    public class Product
    {
        public Product(string name, int id, string unitPrice)
        {
            this.Name = name;
            this.Id = id;
            this.UnitPrice = unitPrice;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string UnitPrice { get; set; }
        public Category Category { get; set; }
    }
}
