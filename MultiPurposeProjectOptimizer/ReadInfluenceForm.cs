using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPurposeProjectOptimizer
{
    public partial class ReadInfluenceForm : Form
    {
        Form PreviousForm;
        int ProjectId;
        int SolverInputsSetId;
        public ReadInfluenceForm(Form previousForm, int projectId, int solverInputsSetId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            ProjectId = projectId;
            SolverInputsSetId = solverInputsSetId;
            RefreshInfluencesGrid(ProjectId, SolverInputsSetId);
        }

        public void RefreshInfluencesGrid(int projectId, int solverInputsSetId)
        {
            InfluencesGrid.Rows.Clear();
            List<Dictionary<string, string>> influencesList = DBManager.SelectRelevantInfluences(projectId, solverInputsSetId);
            for (int i = 0; i < influencesList.Count; i++)
            {
                Dictionary<string, string> influence = influencesList[i];
                InfluencesGrid.Rows.Add(
                    influence["influenceId"],
                    i + 1,
                    influence["projectId"],
                    influence["projectName"],
                    influence["projectPropertyId"],
                    influence["propertyId"],
                    influence["propertyName"],
                    influence["influenceValue"]);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadInfluenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }
    }
}
