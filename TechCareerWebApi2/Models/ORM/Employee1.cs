using System.ComponentModel.DataAnnotations;

namespace TechCareerWebApi2.Models.ORM
{
    public class Employee1
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? City { get; set; }
        public DateTime AddDate { get; set; }
    }
}
