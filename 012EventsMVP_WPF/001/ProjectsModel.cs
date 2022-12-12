using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001
{
    public class ProjectsModel : IProjectsModel
    {
        private int projects;

        public event EventHandler ProjectUpdated;

        public void GetProject()
        {
            throw new System.NotImplementedException();
        }

        public void GetProjects()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProject()
        {
            throw new System.NotImplementedException();
        }
    }
}