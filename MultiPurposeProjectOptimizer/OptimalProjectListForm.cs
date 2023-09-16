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
    public partial class OptimalProjectListForm : Form
    {
        Form PreviousForm;
        int SolverInputsSetId;
        public OptimalProjectListForm(Form previousForm, int solverInputsSetId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            SolverInputsSetId = solverInputsSetId;
            RefreshProjectsGrid();
            RefreshProjectPropertyGrid();
        }

        public void RefreshProjectsGrid()
        {
            ProjectsGrid.Rows.Clear();
            List<Dictionary<string, string>> projectsList = DBManager.SelectTakenProjectSolverLink(SolverInputsSetId);
            for (int i = 0; i < projectsList.Count; i++)
            {
                Dictionary<string, string> project = projectsList[i];
                string isMultiPurpose = project["isMultiPurpose"] == "True" ? "Да" : "Нет";
                ProjectsGrid.Rows.Add(
                    project["projectId"],
                    i + 1,
                    project["projectName"],
                    isMultiPurpose);
            }
        }

        public void RefreshProjectPropertyGrid()
        {
            ProjectPropertyGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectOptimalSolutionSumProperties(SolverInputsSetId);
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                ProjectPropertyGrid.Rows.Add(
                    property["propertyId"],
                    i + 1,
                    property["propertyName"],
                    property["propertyValueSum"],
                    property["avgCapValue"]);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptimalProjectListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void ProjectPropertiesButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = ProjectsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одного проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int projectId = int.Parse(ProjectsGrid.SelectedRows[0].Cells["ProjectId"].Value.ToString());
            this.Enabled = false;
            new ReadProjectPropertiesForm(this, projectId).Show();
        }

        private void InfluenceButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = ProjectsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одного проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int projectId = int.Parse(ProjectsGrid.SelectedRows[0].Cells["ProjectId"].Value.ToString());
            this.Enabled = false;
            new ReadInfluenceForm(this, projectId, SolverInputsSetId).Show();
        }
    }
}
