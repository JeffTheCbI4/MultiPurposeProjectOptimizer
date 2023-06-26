using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class Influence
    {
        public int InfluenceId { get; set; }
        public int InfluencedProjectId {get; set;}
        public Dictionary<string, double> InfluencedProperties { get; set; }

        public Influence(int influenceId, int influencedProjectId, Dictionary<string, double> influencedProperties)
        {
            this.InfluenceId = influenceId;
            this.InfluencedProjectId = influencedProjectId;
            this.InfluencedProperties = influencedProperties;
        }
    }
}
