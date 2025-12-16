using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.User;

namespace HW22.Domain.Core.Contracts.AppService
{
    public interface IUserAppService
    {
        Task<ResultDto<bool>> Login(string username, string password, CancellationToken cancellationToken);
        Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken);
        Task<GetUserDto?> GetUserDetails(int userId, CancellationToken cancellationToken);
        Task<List<GetUserDto>> GetUsers(CancellationToken cancellationToken);
        Task<ResultDto<bool>> Register(RegisterUserDto userDto, CancellationToken cancellationToken);
    }
}
