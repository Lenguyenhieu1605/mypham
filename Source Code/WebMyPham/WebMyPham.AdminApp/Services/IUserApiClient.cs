using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Common;
using WebMyPham.ViewModels.System.Users;

namespace WebMyPham.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest request); //nhập vào 1 userregisterrequest

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest registerRequest);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

    }
}
