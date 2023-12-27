using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareerWebApi2.Context;
using TechCareerWebApi2.Models.ORM;

namespace TechCareerWebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee1Controller : ControllerBase
    {
        private readonly TechCareerDbContext1 _context;

        public Employee1Controller()
        {
            _context = new TechCareerDbContext1();
        }

        [HttpGet]
        public IActionResult Get()
        {
            //databasedeki blogları getir
            var employee = _context.Employees1.ToList();
            return Ok(employee);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //disaridan gelen id ile blogu bul
            //find metodu primary keye göre arama yapar
            //var blog = _context.Blogs.Find(id);

            //firstordefault metodu icerisine yazdığımız sorguya göre arama yapar
            var employee = _context.Employees1.FirstOrDefault(x => x.Id == id);

            //blog yoksa 404 döndür
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Create(Employee1 employee)
        {

            _context.Employees1.Add(employee);
            _context.SaveChanges();

            return StatusCode(201, employee);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee1 updatedEmployee)
        {

            var existingEmployee = _context.Employees1.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return NotFound();
            }

            // Sadece belirli alanları güncelle
            existingEmployee.FirstName = string.IsNullOrWhiteSpace(updatedEmployee.FirstName) ? existingEmployee.FirstName : updatedEmployee.FirstName;
            existingEmployee.LastName = string.IsNullOrWhiteSpace(updatedEmployee.LastName) ? existingEmployee.LastName : updatedEmployee.LastName;
            existingEmployee.Address = string.IsNullOrWhiteSpace(updatedEmployee.Address) ? existingEmployee.Address : updatedEmployee.Address;
            existingEmployee.City = string.IsNullOrWhiteSpace(updatedEmployee.City) ? existingEmployee.City : updatedEmployee.City;

            // BirthDate için özel kontrol
            if (updatedEmployee.BirthDate.Year >= 1900)
            {
                existingEmployee.BirthDate = updatedEmployee.BirthDate;
            }
            else
            {
                return BadRequest(ModelState);
            }

            if (updatedEmployee.AddDate.Year >= 1900)
            {
                existingEmployee.AddDate = updatedEmployee.AddDate;
            }
            else
            {
                return BadRequest(ModelState);
            }


            // Eğer istemci tarafından gönderilen verilerle bir hata oluşursa
            if (!TryValidateModel(existingEmployee))
            {
                return BadRequest(ModelState);
            }

            _context.SaveChanges();

            return Ok(existingEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //disaridan gelen id ile blogu bul
            var employee = _context.Employees1.FirstOrDefault(x => x.Id == id);

            //blog yoksa 404 döndür
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees1.Remove(employee);
            _context.SaveChanges();

            return Ok(employee);
        }
    }
}
