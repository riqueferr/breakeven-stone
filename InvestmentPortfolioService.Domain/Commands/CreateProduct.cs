namespace InvestmentPortfolioService.Api.Contracts.v1.Requests;

public class CreateProduct
{
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int Quantify { get; set; }
    public double TotalValue { get; set; }
}