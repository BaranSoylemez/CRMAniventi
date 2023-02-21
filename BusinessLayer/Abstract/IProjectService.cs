using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{  
    public interface IProjectService
    {
        List<Project> GetProjectList();
        void AddProject(Project project);
        void DeleteProject(Project project);
        void UpdateProject(Project project);
        Project GetProjectById(int id);
    }
}
