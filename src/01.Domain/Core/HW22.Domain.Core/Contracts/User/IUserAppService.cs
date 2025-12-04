using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.User;

namespace HW22.Domain.Core.Contracts.User
{
    public interface IUserAppService
    {
        Task<ResultDto<UserLoginDto>> Login(string username, string password, CancellationToken cancellationToken);
        Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken);
    }
}
