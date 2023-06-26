using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        //public string directionName { }
        public Dictionary<string, double> Properties { get; set; }

        public Project(int projectId, string projectName, Dictionary<string, double> properties)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Properties = properties;
        }
    }
}
