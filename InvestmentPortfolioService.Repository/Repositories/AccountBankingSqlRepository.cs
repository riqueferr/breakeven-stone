using Domain.Contracts;

namespace InvestmentPortfolioService.Repository.Repositories;

public class AccountBankingSqlRepository : IAccountBankingRepository
{
    
    
    public Task<IEnumerable<AccountBanking>> GetAllAccounts()
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

    public Task<AccountBanking?> GetAccountById(int? accountId)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> AddAccount(AccountBanking account)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> UpdateAccount(AccountBanking account)
    {
        throw new NotImplementedException();
    }

    public Task<AccountBanking> DeactivateAccount(int id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}