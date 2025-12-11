using HW22.Domain.Core.Dtos.User;

namespace HW22.Domain.Core.Contracts.Repository
{
    public interface IUserRepository
    {
        Task<UserLoginDto> Login(string username, string password, CancellationToken cancellationToken);
        Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken);
        Task<GetUserDto?> GetUserDetails(int userId, CancellationToken cancellationToken);
        Task<List<GetUserDto>> GetUsers(CancellationToken cancellationToken);
    }
}
