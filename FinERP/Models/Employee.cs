using System.ComponentModel.DataAnnotations;
namespace FinERP.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Department { get; set; }
        public required string Role { get; set; }
        public DateTime HireDate { get; set; }
        public int SalaryUSD { get; set; }
        public required string Region { get; set; }
        public required string Employment_Status { get; set; }
        public int Manager_ID { get; set; }
    }
}