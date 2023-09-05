﻿using Microsoft.AspNetCore.Mvc;
using Wheel.Core.Http;
using Wheel.Services.PermissionManage;
using Wheel.Services.PermissionManage.Dtos;

namespace Wheel.Controllers
{
    /// <summary>
    /// 权限管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionManageController : WheelControllerBase
    {
        private readonly IPermissionManageAppService _permissionManageAppService;
        public PermissionManageController(IPermissionManageAppService permissionManageAppService)
        {
            _permissionManageAppService = permissionManageAppService;
        }
        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        public async Task<R<List<GetAllPermissionDto>>> GetAllPermission()
        {
            var result = await _permissionManageAppService.GetAllPermission();
            return new R<List<GetAllPermissionDto>>(result);
        }
    }
}
