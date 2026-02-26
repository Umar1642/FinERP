public class Employee
{
    public int Id { get; set; } 
    public required string Name { get; set; }
    public required string Department { get; set; }
    public required string Role { get; set; }
    public DateTime HireDate { get; set; }
    public int SalaryUSD { get; set; }
    public required string Region { get; set; }
    public bool Employment_Status { get; set; }
    public int Manager_ID { get; set; }
}