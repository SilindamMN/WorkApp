namespace Application.Services.Core
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Security.Claims;
  using System.Text;
  using System.Threading.Tasks;
  using Application.Helpers;
  using Application.Interfaces;
  using Application.Interfaces.Auth;
    using Application.Interfaces.Core;
    using Application.Interfaces.GenericInterfaces;
  using Domain.Account;
  using Domain.Dtos.General;
  using Domain.Dtos.JobTitles;
  using Domain.Enties;
  using Domain.Enums;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

  public class UserJobTitleService : IUserJobTitleService
  {
    private readonly DataContext dataContext;
        private readonly UserManager<ApplicationUser> userManager;

        public UserJobTitleService(DataContext dataContext, UserManager<ApplicationUser> userManager)
    {
      this.dataContext = dataContext;
            this.userManager = userManager;
        }

    public async Task<GeneralServiceResponseDto> AssignJobTitleToUser(AssignJobTitleDto assignJobTitle)
    {
      var user = await dataContext.Users.FirstOrDefaultAsync(x => x.UserName == assignJobTitle.username);
      //assign the jobTitle id
      user.JobTitleId = assignJobTitle.jobTitleId;
      await dataContext.SaveChangesAsync();
      return ResponseHelper.CreateResponse(true, 200, "JobTitle Assigned Successfully");
    }

    public Task<IEnumerable<ApplicationUser>> GetUsersByJobTitle(string title)
    {
      throw new NotImplementedException();
    }

        public async Task<JobTitleDto?> GetJobTitleForUser(string userName)
        {
            // Use UserManager instead of direct DbContext query
            var user = await userManager.FindByNameAsync(userName);

            if (user == null || user.JobTitleId == null)
            {
                return null;
            }
            var val = await GetJobTitleInfo(user.JobTitleId.Value);
            return val;
        }


        //will get the jobTitle including department name
        private async Task<JobTitleDto> GetJobTitleInfo(int jobTitleId)
    {
      var departmenta = await (from jobTitle in dataContext.JobTitles
                    join department in dataContext.Departments on jobTitle.DepartmentId equals department.Id
                    where jobTitle.Id == jobTitleId
                    select new JobTitleDto
                    {
                        Id = jobTitle.Id,
                        Title = jobTitle.Title,
                      DepartmentName = department.DepartmentName,
                      Seniority = jobTitle.Seniority.ToString() // Assuming Seniority is an enum
                    }).FirstOrDefaultAsync();
            return departmenta;
    }

    public async Task<IEnumerable<JobTitleDto>> GetJobTitles()
    {

      var jobTitlesWithDepartments = await dataContext.JobTitles
      .Include(jt => jt.Department)
      .Select(jt => new JobTitleDto
      {
          Id = jt.Id,
        Title = jt.Title,
        DepartmentName = jt.Department.DepartmentName,
        Description = jt.Description,
        Seniority = jt.Seniority.ToString()
      })
      .ToListAsync();
      return jobTitlesWithDepartments;
    }
  }
}