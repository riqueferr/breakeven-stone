using Domain.Models;

namespace Domain.Contracts;

public interface IAccountBankingRepository : IDisposable
{
    Task<IEnumerable<AccountBanking>> GetAllAccountsBanking();
    Task<AccountBanking?> GetAccountBankingById(int? accountId);
    Task<AccountBanking> AddAccountBanking(AccountBanking account);
    Task<AccountBanking> UpdateAccountBanking(AccountBanking account);
    Task<AccountBanking> DeactivateAccountBanking(int id);
    Task Save(); 
}