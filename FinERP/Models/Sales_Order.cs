public class SalesOrder
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public required string CustomerName { get; set; }
    public required string ProductSKU { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal TaxRate { get; set; }
    public int TotalAmount { get; set; }
    public required string status { get; set; } 
}