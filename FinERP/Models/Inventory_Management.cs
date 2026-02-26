public class InventoryManagement
{
    public int Id { get; set; } 
    public required string ProductName { get; set; }
    public int WarehouseID { get; set; }
    public required string ShelfLocation { get; set; }
    public int QtyOnHand { get; set; }
    public int ReorderPoint { get; set; }
    public int LeadTimeDays { get; set; }    
    public int UnitCost { get; set; }
    public DateTime LastAuditDate { get; set; }    
} 