using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Wallet
{
    [Key]
    public int Id { get; set; }
    public double Balance { get; set; }
    public List<Product> Products { get; set; }
}