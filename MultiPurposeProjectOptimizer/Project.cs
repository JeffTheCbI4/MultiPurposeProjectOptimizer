using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string directionName { }
        public Dictionary<string, double> Properties { get; set; }

        public Project(int projectId, string projectName)
        {
            this.Id = projectId;
            this.Name = projectName;
        }
        public Project(int projectId, string projectName, Dictionary<string, double> properties) : this(projectId, projectName)
        {
            this.Properties = properties;
        }

        public Project copyProject()
        {
            Dictionary<string, double> newProperties = new Dictionary<string, double>();
            foreach(string key in Properties.Keys)
            {
                newProperties.Add(key, Properties[key]);
            }
            return new Project(Id, Name, newProperties);
        }
    }
}
