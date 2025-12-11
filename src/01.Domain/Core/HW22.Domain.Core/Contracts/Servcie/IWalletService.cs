using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.Core.Contracts.Servcie
{
    public interface IWalletService
    {
        Task<bool> Update(int userId, decimal newAmount, CancellationToken cancellationToken);
    }
}
