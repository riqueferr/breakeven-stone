namespace InvestmentPortfolioService.Api.Contracts.v1.Requests;

public class CreateAccountBankingCommand
{
    public string Document { get; set; }
    public string Password { get; set; }

}