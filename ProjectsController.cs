WorkApp/API/Controllers/ProjectsController.cs
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Interfaces.Core;
using Domain.Dtos.General;
using Domain.Dtos.GeneralAdmin;
using System.Collections.Generic;

namespace WorkApp.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProjectsController : ControllerBase
  {
    private readonly IProjectService projectService;
    private readonly ILogger<ProjectsController> logger;

    public ProjectsController(
      IProjectService projectService,
      ILogger<ProjectsController> logger)
    {
      this.projectService = projectService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var projects = await projectService.GetAllProjectsWithClientsAsync();
      return Ok(projects);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProjectDto projectDto)
    {
      if (projectDto == null) return BadRequest("Project data is required.");

      var result = await projectService.CreateProjectAsync(projectDto);
      return StatusCode(result.Code, result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] CreateProjectDto projectDto)
    {
      if (projectDto == null) return BadRequest("Project data is required.");

      var result = await projectService.UpdateProjectAsync(id, projectDto);
      return StatusCode(result.Code, result);
    }
  }
}