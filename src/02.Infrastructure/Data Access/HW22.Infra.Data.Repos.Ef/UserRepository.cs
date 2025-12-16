using HW22.Domain.Core.Contracts.Repository;
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
                .Where(u => u.UserName == username && u.PasswordHash == password)
                .Select(u => new UserLoginDto
                {
                    UserId = u.Id,
                    UserName = u.UserName,
                    //IsAdmin = u.IsAdmin
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

        public async Task<GetUserDto?> GetUserDetails(int userId,CancellationToken cancellationToken)
        {
            return await _context.Users
                .AsNoTracking()
                .Where(u => u.Id == userId)
                .Select(u => new GetUserDto
                {

                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Phone = u.PhoneNumber,
                    WalletCount = u.Wallet.Amount,
                    Address = u.Address,
                    Username = u.UserName,
                })
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<List<GetUserDto>> GetUsers(CancellationToken cancellationToken)
        {
            return await _context.Users
                .AsNoTracking()
                //.Where(u => u.IsAdmin == false)
                .Select(u => new GetUserDto
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Username = u.UserName,
                    orderCount = u.Orders.Count,
                })
                .ToListAsync(cancellationToken);
        }
    }
}
