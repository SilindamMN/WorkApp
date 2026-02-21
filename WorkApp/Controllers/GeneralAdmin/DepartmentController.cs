namespace API.Controllers.GeneralAdmin
{
    using Application.Interfaces.GenericInterfaces;
    using Application.Services.Auth;
    using Application.Services.GenericServices;
    using AutoMapper;
    using Domain.Constants;
    using Domain.Dtos.Account;
    using Domain.Dtos.Departments;
    using Domain.Dtos.GeneralAdmin;
    using Domain.Enties;
    using Domain.Enties.Leaves;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IGenericService<Department, DepartmentDto> _DepartmentService;
        private readonly IGenericService<Department, UpdateDepartmentDto> updateDepartmentService;
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService,
            IGenericService<Department, DepartmentDto> DepartmentService, IGenericService<Department, UpdateDepartmentDto> updateDepartmentService)

        {
            _DepartmentService = DepartmentService;
            this.updateDepartmentService = updateDepartmentService;
            this.departmentService = departmentService;
        }

        [HttpGet]

        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetAllDepartments()
        {
            var result = await _DepartmentService.GetAllAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]

        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var result = await _DepartmentService.GetByIdAsync(id);
            if (result is null)
            {
                return NotFound("leaveRequestId not found");
            }
            else
            {
                return Ok(result);
            }
        }

        [HttpGet]
        [Route("DepartmentUserDetailJobTitle/{id}")]

        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<ActionResult<List<UserDetailJobTitle>>> GetDepartmentUserDetailJobTitle(int id)
        {
            var result = await departmentService.GetUserJobTitleTeamsListAsync(id);
            if (result == null || !result.Any())
            {
                return NotFound($"No details found for departmentId: {id}");
            }

            return Ok(result);
        }

        [HttpPost("CreateSingleDepartment")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> CreateDepartment([FromBody] DepartmentDto DepartmentDto)
        {
            var result = await _DepartmentService.CreateAsync(DepartmentDto);
            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }
            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpPatch("UpdateDepartment/{id}")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UpdateDepartment(int id, [FromBody] UpdateDepartmentDto updateDepartmentDto)
        {
            var result = await updateDepartmentService.UpdateAsync(id, updateDepartmentDto);
            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }
            else
            {
                return StatusCode(result.StatusCode, result.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteDepartment")]
        [Authorize(Roles = StaticUserRoles.ADMIN )]
        public async Task<IActionResult> SoftDeleteDepartment(int id)
        {
            var result = await _DepartmentService.SoftDelete(id);
            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }
            return StatusCode(result.StatusCode, result.Message);
        }

        [HttpDelete("{id}/undo")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UnSoftDeleteDepartment(int id)
        {
            var result = await _DepartmentService.UndoSoftDeleteAsync(id);
            if (result.IsSucceed)
            {
                return Ok(result.Message);
            }
            return StatusCode(result.StatusCode, result.Message);
        }
    }
}