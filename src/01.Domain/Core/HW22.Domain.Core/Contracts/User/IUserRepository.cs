using HW22.Domain.Core.Dtos.User;

namespace HW22.Domain.Core.Contracts.User
{
    public interface IUserRepository
    {
        Task<UserLoginDto> Login(string username, string password, CancellationToken cancellationToken);
        Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken);
    }
}
