namespace API.Controllers.GeneralAdmin
{
    using Application.Interfaces.Core;
    using Application.Interfaces.GenericInterfaces;
    using Domain.Constants;
    using Domain.Dtos.GeneralAdmin;
    using Domain.Enties;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProjectsController : ControllerBase
    {
        private readonly IGenericService<Project, ProjectDto> _projectService;
        private readonly IProjectService project;

        public ProjectsController(
            IGenericService<Project, ProjectDto> projectService,IProjectService project)
        {
            _projectService = projectService;
            this.project = project;
        }

        // ============================
        // GET: api/Projects
        // ============================
        [HttpGet]
        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetAllProjects()
        {
            var result = await _projectService.GetAllAsync();
            return Ok(result);
        }

        // ============================
        // GET: api/Projects/5
        // ============================
        [HttpGet("{id}")]
        [Authorize(Roles = StaticUserRoles.USER)]
        public async Task<IActionResult> GetProjectById(int id)
        {
            var result = await _projectService.GetByIdAsync(id);

            if (result is null)
                return NotFound("Project not found.");

            return Ok(result);
        }

        // ============================
        // POST: api/Projects
        // ============================
        [HttpPost]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> CreateProject([FromBody] CreateProjectDto createProject)
        {
            var result = await project.CreateProjectAsync(createProject);

            if (result.IsSucceed)
                return Ok(result.Message);

            return StatusCode(result.StatusCode, result.Message);
        }

        // ============================
        // PATCH: api/Projects/5
        // ============================
        [HttpPatch("{id}")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UpdateProject(int id, [FromBody] ProjectDto updateProjectDto)
        {
            var result = await _projectService.UpdateAsync(id, updateProjectDto);

            if (result.IsSucceed)
                return Ok(result.Message);

            return StatusCode(result.StatusCode, result.Message);
        }

        // ============================
        // DELETE: api/Projects/5
        // ============================
        [HttpDelete("{id}")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> SoftDeleteProject(int id)
        {
            var result = await _projectService.SoftDelete(id);

            if (result.IsSucceed)
                return Ok(result.Message);

            return StatusCode(result.StatusCode, result.Message);
        }

        // ============================
        // DELETE: api/Projects/5/undo
        // ============================
        [HttpDelete("{id}/undo")]
        [Authorize(Roles = StaticUserRoles.ADMIN)]
        public async Task<IActionResult> UndoSoftDeleteProject(int id)
        {
            var result = await _projectService.UndoSoftDeleteAsync(id);

            if (result.IsSucceed)
                return Ok(result.Message);

            return StatusCode(result.StatusCode, result.Message);
        }
    }
}