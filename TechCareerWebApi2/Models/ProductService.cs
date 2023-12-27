namespace TechCareerWebApi2.Models
{
    public class ProductService
    {
        public static List<Product> GetList()
        {
            var productValue = new List<Product>();
            productValue.Add(new Product("Masa", 1, "100"));
            productValue.Add(new Product("Sandalye", 2, "200"));
            productValue.Add(new Product("Mouse", 3, "300"));

            return productValue;
        }
    }
}
