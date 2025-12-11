using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Repository
{
    public interface IWalletRepository
    {
        Task<bool> Update(int userId, decimal newAmount,CancellationToken cancellationToken);
    }
}
