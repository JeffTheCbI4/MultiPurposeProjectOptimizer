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

        new public MultiPurposeProject copyProject()
        {
            Dictionary<string, double> newProperties = new Dictionary<string, double>();
            foreach (string key in Properties.Keys)
            {
                newProperties.Add(key, Properties[key]);
            }
            return new MultiPurposeProject(Id, Name, newProperties, Influence);
        }
    }
}
