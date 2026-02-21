namespace API.Controllers.GeneralAdmin
{
  using Application.Interfaces;
    using Application.Interfaces.Core;
    using Application.Interfaces.GenericInterfaces;
  using Application.Services.Auth;
  using Application.Services.GenericServices;
    using Domain.Constants;
    using Domain.Dtos.Account;
  using Domain.Dtos.GeneralAdmin;
  using Domain.Dtos.LeaveTypes.Teams;
  using Domain.Enties.TimeSheets;
  using Domain.Entities;
  using Microsoft.AspNetCore.Authorization;
  using Microsoft.AspNetCore.Mvc;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  [ApiController]
  [Route("api/[controller]")]
  public class TeamController : ControllerBase
  {
    private readonly IGenericService<Team, TeamDto> _teamService;
    private readonly ITeamInterface teamInterface;

    public TeamController(
        IGenericService<Team, TeamDto> teamService,ITeamInterface teamInterface)
    {
      _teamService = teamService;
      this.teamInterface = teamInterface;
    }

    [HttpGet]
        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetAllTeams()
    {
      var result = await _teamService.GetAllAsync();
      return Ok(result);
    }

    [HttpGet("{id}")]
        [Authorize(Roles = StaticUserRoles.USER)]

        public async Task<IActionResult> GetTeamById(int id)
    {
      var result = await _teamService.GetByIdAsync(id);
      if (result is null)
      {
        return NotFound("Team not found");
      }
      return Ok(result);
    }

    [HttpPost]
        [Authorize( StaticUserRoles.ADMIN)]
        public async Task<IActionResult> CreateTeam([FromBody] TeamDto teamDto)
    {
      var result = await teamInterface.CreateTeam(teamDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpPatch("{id}")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UpdateTeam(int id, [FromBody] TeamDto updateTeamDto)
    {
      var result = await _teamService.UpdateAsync(id, updateTeamDto);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpDelete("{id}")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> SoftDeleteTeam(int id)
    {
      var result = await _teamService.SoftDelete(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpDelete("{id}/undo")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UnSoftDeleteTeam(int id)
    {
      var result = await _teamService.UndoSoftDeleteAsync(id);
      if (result.IsSucceed)
      {
        return Ok(result.Message);
      }
      return StatusCode(result.StatusCode, result.Message);
    }

    [HttpPost("add-member")]
       [Authorize(Roles = StaticUserRoles.ADMIN)]
    public async Task<IActionResult> AddTeamMember(string username, int teamId)
    {
      var response = await teamInterface.UpdateTeamMembership(username, teamId);
      return StatusCode(response.StatusCode, response);
    }

    [HttpPost("remove-member")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]

        public async Task<IActionResult> RemoveTeamMember(string username)
    {
      var response = await teamInterface.UpdateTeamMembership(username);
      return StatusCode(response.StatusCode, response);
    }

    [HttpGet("withdetails")]

        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<ActionResult<IEnumerable<TeamMemberDetailsDto>>> GetAllTeamsWithMembers()
    {
      var teams = await teamInterface.GetAllTeamsWithMembersAsync();
      return Ok(teams);
    }
  }
}