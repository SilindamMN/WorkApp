namespace Domain.Enties
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
    using Domain.Enties.TimeSheets;
    using Domain.Entities;

    public class Department : BaseEntity<int>
    {
        public string DepartmentName { get; set; }
        public string Description { get; set; }

        public ICollection<JobTitle> JobTitles { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}