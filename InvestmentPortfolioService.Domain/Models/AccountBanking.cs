using System.ComponentModel.DataAnnotations;
using Domain.Models;
using Domain.Models.Enumerations;


public class AccountBanking
{
    [Key]
    public int Id { get; set; }
    public string Document { get; set; }
    public int Password { get; set; }
    public AccountBankingStatus Status { get; set; }
    public DateTime StartDateTime { get; set; }
    public Wallet Wallet { get; set; }
}