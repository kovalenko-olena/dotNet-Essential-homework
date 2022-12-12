using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001
{
    public interface IProjectsView
    {
        event EventHandler ProjectUpdated;

        int NONE_SELECTED { get; set; }
        int SelectedProjectId { get; set; }

        void EnableControls();
        void LoadProjects();
        void UpdateProject();
    }
}