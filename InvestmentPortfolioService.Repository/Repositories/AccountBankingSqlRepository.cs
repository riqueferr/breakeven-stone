using Domain.Contracts;

namespace InvestmentPortfolioService.Repository.Repositories;

public class AccountBankingSqlRepository : IAccountBankingRepository
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<AccountBanking>> GetAllAccountsBanking()
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking?> GetAccountBankingById(int? accountId)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> AddAccountBanking(AccountBanking account)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> UpdateAccountBanking(AccountBanking account)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> DeactivateAccountBanking(int id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }
}