using HW22.Domain.Core.Contracts.User;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.AppServices
{
    public class UserAppService(IUserService userService) : IUserAppService
    {
        public async Task<decimal> GetUserWalletBalance(int userId, CancellationToken cancellationToken)
        {
            return await userService.GetUserWalletBalance(userId, cancellationToken);
        }

        public async Task<ResultDto<UserLoginDto>> Login(string username, string password, CancellationToken cancellationToken)
        {
            if(string.IsNullOrWhiteSpace(username)) { 
            
                return ResultDto<UserLoginDto>.Failure("Username cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(password)) { 
            
                return ResultDto<UserLoginDto>.Failure("Password cannot be empty.");
            }

            var result = await userService.Login(username, password, cancellationToken);
            if (result is not null)
            {
                return ResultDto<UserLoginDto>.Success("Login successful.", result);
            }
            return ResultDto<UserLoginDto>.Failure("Invalid username or password!", result);
        }
    }
}
