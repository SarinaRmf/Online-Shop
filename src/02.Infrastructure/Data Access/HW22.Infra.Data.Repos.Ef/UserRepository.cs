using HW22.Domain.Core.Contracts.User;
using HW22.Domain.Core.Dtos.User;
using HW22.Infra.Db.SqlServer.Ef;
using Microsoft.EntityFrameworkCore;

namespace HW22.Infra.Data.Repos.Ef
{
    public class UserRepository(AppDbContext _context) : IUserRepository
    {
        public async Task<UserLoginDto?> Login(string username, string password, CancellationToken cancellationToken)
        {
            return _context.Users
                .AsNoTracking()
                .Where(u => u.Username == username && u.PasswordHash == password)
                .Select(u => new UserLoginDto
                {
                    UserId = u.Id,
                    UserName = u.Username,
                })
                .FirstOrDefault();
        }
        public async Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken)
        {
            return await _context.Users
                .Where(u => u.Id == userId)
                .Select(u => u.Wallet.Amount)
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}
