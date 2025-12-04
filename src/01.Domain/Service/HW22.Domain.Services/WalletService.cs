using HW22.Domain.Core.Contracts.Wallet;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Services
{
    public class WalletService(IWalletRepository _repo) : IWalletService
    {
        public async Task<bool> Update(int userId, decimal newAmount, CancellationToken cancellationToken)
        {
            return await _repo.Update(userId, newAmount, cancellationToken);
        }
    }
}
