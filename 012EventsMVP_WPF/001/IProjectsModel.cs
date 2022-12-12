using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001
{
    public interface IProjectsModel
    {
        event EventHandler ProjectUpdated;

        void GetProject();
        void GetProjects();
        void UpdateProject();
    }
}