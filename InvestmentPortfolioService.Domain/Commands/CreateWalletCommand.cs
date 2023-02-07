using Domain.Models;

namespace Domain.Commands;

public class CreateWalletCommand
{
    public int Id { get; set; }
    public double Balance { get; set; }
    public List<Product>? Products { get; set; } 
}