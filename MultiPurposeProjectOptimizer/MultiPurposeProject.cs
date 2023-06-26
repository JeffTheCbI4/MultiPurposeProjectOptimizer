using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class MultiPurposeProject : Project
    {
        public List<Influence> Influence { get; set; }

        public MultiPurposeProject(int projectId,
            string projectName,
            Dictionary<string, double> properties,
            List<Influence> influence) : base(projectId, projectName, properties)
        {
            this.Influence = influence;
        }
    }
}
