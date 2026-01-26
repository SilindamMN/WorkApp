namespace API.Controllers.Maintanance
{
  using Application.Interfaces;
    using Application.Interfaces.Core;
  using Application.Services;
    using Domain.Constants;
  using Domain.Dtos.Account;
  using Domain.Dtos.LeaveAllocation;
  using Domain.Dtos.LeaveTypes;
  using Domain.Enties.Leaves;
    using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Identity;
  using Microsoft.AspNetCore.Mvc;

    [ApiController]
  [Route("api/[controller]")]
  public class LeaveAllocationController : ControllerBase
  {
    private readonly ILeaveAllocationService leaveAllocationService;

    public LeaveAllocationController(ILeaveAllocationService leaveAllocationService)
    {
      this.leaveAllocationService = leaveAllocationService;
    }

    [HttpGet]
    [Route("LeaveAllocationByUsereName")]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin + "," + StaticUserRoles.OwnerAdminManagerUser + "," + StaticUserRoles.ADMIN + "," +StaticUserRoles.OwnerAdminManager)]
        public async Task<ActionResult<IEnumerable<EmployeeLeaveAllocationDto>>> GetUserAllocationByUserNamesync(string userName)
    {
      var allocations = await leaveAllocationService.GetLeaveAllocationsByUsername(userName);

      if (allocations == null)
      {
        return NotFound(); // Return HTTP 404 Not Found if user not found
      }

      return Ok(allocations); // Return HTTP 200 OK with the allocations
    }

    [HttpGet]
    [Route("LeaveAllocationByLeaveName")]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin + "," + StaticUserRoles.USER + "," + StaticUserRoles.ADMIN + "," +StaticUserRoles.ADMIN)]
        public async Task<ActionResult<IEnumerable<LeaveAllocationDto>>> GetUserAllocationByLeaveNamesync(string Leavename)
    {
      var allocations = await leaveAllocationService.GetLeaveAllocationsByLeaveType(Leavename);

      if (allocations == null)
      {
        return NotFound(); // Return HTTP 404 Not Found if user not found
      }

      return Ok(allocations); // Return HTTP 200 OK with the allocations
    }

    [HttpGet]
    [Route("MyLeaveAllocations")]
        [Authorize(Roles = StaticUserRoles.OwnerAdmin + "," + StaticUserRoles.USER + "," + StaticUserRoles.ADMIN)]

        public async Task<ActionResult<IEnumerable<EmployeeLeaveAllocationDto>>> GetMyAllocationsync()
    {
      var allocations = await leaveAllocationService.GetMyLeavesAllocations(User);

      if (allocations == null)
      {
        return NotFound(); // Return HTTP 404 Not Found if user not found
      }
      return Ok(allocations); // Return HTTP 200 OK with the allocations
    }

    [HttpGet("LeaveAllocations")]

        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetLeaveAllocations()
    {
      var result = await leaveAllocationService.GetLeaveAllocations();
      return Ok(result);
    }
  }
}