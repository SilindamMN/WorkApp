namespace Application.Services.GenericServices
{
  using Application.Interfaces.GenericInterfaces;
  using System.Threading.Tasks;
  using System.Linq;
  using Domain.Dtos.GeneralAdmin;

  public class ClientService : IClientService
  {
    private readonly DataContext dataContext;

    public ClientService(DataContext dataContext)
    {
      this.dataContext = dataContext;
    }

    public async Task<IEnumerable<ClientDetailDto>> GetClientProjectAsync(int clientId)
    {
      var projectNames = (from p in dataContext.Projects
                          where p.ClientId == clientId
                          select new ClientDetailDto
                          {
                              ProjectId = p.Id,
                            ProjectName = p.ProjectName,
                            ProjectStartDate = p.StartDate
                            
                          }).ToList();
      return projectNames;
    }
  }
}