using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebMyPham.ViewModels.Common;
using WebMyPham.ViewModels.System.Users;

namespace WebMyPham.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserViewModel>>> GetUsersPaging(GetUserPagingRequest request);
        //lấy ra dc ds user trả về model phân trang

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
    }
}
