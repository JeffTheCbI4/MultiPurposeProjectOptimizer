using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class Solution
    {
        public Dictionary<string, double> SolutionProperties { get; set; }
        public List<Solution> ContainedSolutions { get; set; }
        public Dictionary<int, bool?> ProjectStatus { get; set; }
        public bool IsMerged { get; set; }

        public Solution(Dictionary<string, double> solutionProperties, Dictionary<int, bool?> projectStatus, bool isMerged)
        {
            SolutionProperties = solutionProperties;
            ProjectStatus = projectStatus;
            IsMerged = isMerged;
        }

        public Solution(Dictionary<string, double> solutionProperties,
            Dictionary<int, bool?> projectStatus, bool isMerged,
            List<Solution> containedSolutions) : this(solutionProperties, projectStatus, isMerged)
        {
            ContainedSolutions = containedSolutions;
        }


    }
}
