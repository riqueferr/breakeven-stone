using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Quantify { get; set; }
    public double TotalValue { get; set; }
    public DateTime OpentedIn { get; set; }
    public DateTime? ClosedOn { get; set; }
    
}