using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void AddProject(Project project)
        {
            _projectDal.Add(project);
        }

        public void DeleteProject(Project project)
        {
            _projectDal.Delete(project);
        }

        public Project GetProjectById(int id)
        {
            return _projectDal.Get(x => x.ProjectID == id);
        }

        public List<Project> GetProjectList()
        {
            return _projectDal.List();
        }

        public void UpdateProject(Project project)
        {
            _projectDal.Update(project);
        }

       
    }
}
