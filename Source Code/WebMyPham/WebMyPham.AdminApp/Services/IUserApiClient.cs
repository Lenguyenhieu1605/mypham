using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.System.Users;

namespace WebMyPham.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
