using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001
{
    public class ProjectsView : IProjectsView
    {
        public event EventHandler ProjectUpdated;

        public int NONE_SELECTED
        {
            get => default;
            set
            {
            }
        }

        public int SelectedProjectId
        {
            get => default;
            set
            {
            }
        }

        public void EnableControls()
        {
            throw new System.NotImplementedException();
        }

        public void LoadProjects()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProject()
        {
            throw new System.NotImplementedException();
        }
    }
}