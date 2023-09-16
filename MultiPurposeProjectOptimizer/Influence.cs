using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPurposeProjectOptimizer
{
    class Influence
    {
        public int Id { get; set; }
        public int InfluencedProjectId {get; set;}
        public string InfluencedPropertyName { get; set; }
        public double Value { get; set; }

        public Influence(int influenceId, int influencedProjectId, string influencedPropertyName, double Value)
        {
            this.Id = influenceId;
            this.InfluencedProjectId = influencedProjectId;
            this.InfluencedPropertyName = influencedPropertyName;
            this.Value = Value;
        }
    }
}
