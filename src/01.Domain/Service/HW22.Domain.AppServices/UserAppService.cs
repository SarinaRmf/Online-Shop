using HW22.Domain.Core.Contracts.AppService;
using HW22.Domain.Core.Contracts.Servcie;
using HW22.Domain.Core.Dtos._common;
using HW22.Domain.Core.Dtos.User;
using HW22.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW22.Domain.AppServices
{
    public class UserAppService(IUserService userService,SignInManager<ApplicationUser> signInManager,UserManager<ApplicationUser> userManager) : IUserAppService
    {
        public async Task<List<GetUserDto>> GetUsers(CancellationToken cancellationToken)
        {
            return await userService.GetUsers(cancellationToken);
        }

        public async Task<GetUserDto> GetUserDetails(int userId, CancellationToken cancellationToken)
        {
            return await userService.GetUserDetails(userId,cancellationToken);
        }

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

            //var UserLoginDto = await userService.Login(username, password, cancellationToken);
            var userLoginDto = await userManager.Users
                .Where(u => u.UserName == username) // ابتدا فیلتر را بزن
                .Select(u => new UserLoginDto
                {
        UserId = u.Id,
        UserName = u.UserName,
        IsAdmin = u.IsAdmin
    })
    .FirstOrDefaultAsync(cancellationToken);
            var result = await signInManager.PasswordSignInAsync(username, password, true, false);
            if (result.Succeeded) {
                return ResultDto<UserLoginDto>.Success("Login successful.", userLoginDto);
            }
            return ResultDto<UserLoginDto>.Failure("Invalid username or password!");
        }

        public async Task<ResultDto<bool>> Register(RegisterUserDto userDto, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser
            {
                UserName = userDto.Username,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Address = userDto.Address,
                PhoneNumber = userDto.Phone,
                IsAdmin = false,
                CreatedAt = DateTime.Now
            };

            var result = await userManager.CreateAsync(user, userDto.Password);
            if (result.Succeeded) { 
            
                return ResultDto<bool>.Success("User registered successfully.", true);  
            }
            var errors = string.Join(", ", result.Errors.Select(e => e.Description));
            return ResultDto<bool>.Failure($"User registration failed: {errors}", false);
        }


    }
}
