using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebMyPham.Application.System.Roles;
using WebMyPham.Data.Entities;

namespace WebMyPham.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly RoleManager<AppRole> _roleManager;
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        public RolesController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() // bắt buộc đăng nhập
        {
            //var roles = await _roleService.GetAll();
            var roles = await _roleService.GetAll();
            return Ok(roles);
        }
    }
}
