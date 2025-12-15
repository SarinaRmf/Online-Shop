using HW22.Domain.Core.Contracts.Repository;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos.User;
using HW22.framework;

namespace HW22.Domain.Services
{
    public class UserService(IUserRepository _repo) : IUserService
    {
        public async Task<List<GetUserDto>> GetUsers(CancellationToken cancellationToken)
        {
            return await _repo.GetUsers(cancellationToken);
        }

        public async Task<GetUserDto> GetUserDetails(int userId, CancellationToken cancellationToken)
        {
            return await _repo.GetUserDetails(userId,cancellationToken);
        }

        public async Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken)
        {
            return await _repo.GetUserWalletBalance(userId, cancellationToken);
        }

        public async Task<UserLoginDto> Login(string username, string password, CancellationToken cancellationToken)
        {
            //password = password.ToMd5Hex();
            return await _repo.Login(username, password, cancellationToken);
        }
    }
}
