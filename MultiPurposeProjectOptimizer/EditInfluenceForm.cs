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
    public partial class EditInfluenceForm : Form
    {
        ProjectsAndPropertiesForm PreviousForm;
        int InfluencingProjectId;
        bool BackgroundUpdatingStatus = true;
        int SelectedProjectId;
        public EditInfluenceForm(ProjectsAndPropertiesForm previousForm, int projectId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            InfluencingProjectId = projectId;

            RefreshProjectsGrid();
            RefreshInfluencesGrid(InfluencingProjectId);
        }

        public void RefreshProjectsGrid()
        {
            BackgroundUpdatingStatus = true;
            ProjectsGrid.Rows.Clear();
            List<Dictionary<string, string>> projectsList = DBManager.SelectProjects();
            for (int i = 0; i < projectsList.Count; i++)
            {
                Dictionary<string, string> project = projectsList[i];
                ProjectsGrid.Rows.Add(project["projectId"], i + 1, project["projectName"]);
            }
            BackgroundUpdatingStatus = false;
        }

        public void RefreshProjectPropertiesGrid(int projectId)
        {
            BackgroundUpdatingStatus = true;
            ProjectPropertiesGrid.Rows.Clear();
            List<Dictionary<string, string>> projectPropertiesList = DBManager.SelectProjectProperties(projectId);
            for (int i = 0; i < projectPropertiesList.Count; i++)
            {
                Dictionary<string, string> property = projectPropertiesList[i];
                ProjectPropertiesGrid.Rows.Add(property["projectPropertyId"], i + 1, property["propertyName"]);
            }
            BackgroundUpdatingStatus = false;
        }

        public void RefreshInfluencesGrid(int projectId)
        {
            BackgroundUpdatingStatus = true;
            InfluencesGrid.Rows.Clear();
            List<Dictionary<string, string>> influencesList = DBManager.SelectInfluences(projectId);
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
            BackgroundUpdatingStatus = false;
        }

        private void ProjectsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow clickedRow = ProjectsGrid.Rows[e.RowIndex];
            SelectedProjectId = int.Parse(clickedRow.Cells["ProjectGridProjectId"].Value.ToString());
            RefreshProjectPropertiesGrid(SelectedProjectId);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditInfluenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void AddInfluenceButton_Click(object sender, EventArgs e)
        {
            if (ProjectPropertiesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки влияемых свойств",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (InfluencingProjectId == SelectedProjectId)
            {
                MessageBox.Show("Проект не может влиять сам на себя",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow propertyRow in ProjectPropertiesGrid.SelectedRows)
            {
                if (propertyRow.Cells["ProjectPropertyId"].Value == null) continue;
                bool alreadyHasInfluence = false;
                string propertyName = propertyRow.Cells["PropertyName"].Value.ToString();
                int projectPropertyId = int.Parse(propertyRow.Cells["ProjectPropertyId"].Value.ToString());
                foreach (DataGridViewRow influenceRow in InfluencesGrid.Rows)
                {
                    if (influenceRow.Cells["InfluenceId"].Value == null) continue;
                    if (int.Parse(influenceRow.Cells["InfluencedProjectId"].Value.ToString()) == SelectedProjectId &&
                        int.Parse(influenceRow.Cells["InfluencedProjectPropertyId"].Value.ToString()) == projectPropertyId)
                    {
                        alreadyHasInfluence = true;
                        break;
                    }
                }
                if (alreadyHasInfluence)
                {
                    MessageBox.Show(string.Format("На свойство {0} уже есть влияние", propertyName),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                DBManager.InsertInfluence(InfluencingProjectId, projectPropertyId, 0);
            }
            RefreshInfluencesGrid(InfluencingProjectId);
            DBManager.UpdateProjectIsMPP(InfluencingProjectId, true);
            PreviousForm.RefreshProjectGrid();
        }

        private void InfluencesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus ||
                InfluencesGrid.Rows[e.RowIndex].Cells["InfluenceId"].Value == null) return;
            DataGridViewRow currentRow = InfluencesGrid.Rows[e.RowIndex];
            if (!double.TryParse(InfluencesGrid.Rows[e.RowIndex].Cells["InfluenceValue"].Value.ToString(),
                out double influenceValue))
            {
                InfluencesGrid.Rows[e.RowIndex].Cells["InfluenceValue"].ErrorText = "Некорректное значение (должно быть число)";
            } else if (currentRow.Cells["InfluenceId"].Value != null &&
                int.TryParse(currentRow.Cells["InfluenceId"].Value.ToString(), out int influenceId))
            {
                DBManager.UpdateInfluenceValue(influenceValue, influenceId);
                currentRow.Cells["InfluenceValue"].ErrorText = "";
            }
            
        }

        private void DeleteInfluenceButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные влияния?",
                                "Удалить влияния", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = InfluencesGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(InfluencesGrid.SelectedRows[i].Cells["InfluenceId"].Value.ToString());
                DBManager.DeleteInfluence(removedId);
            }
            RefreshInfluencesGrid(InfluencingProjectId);
            if (InfluencesGrid.Rows.Count == 0)
            {
                DBManager.UpdateProjectIsMPP(InfluencingProjectId, false);
                PreviousForm.RefreshProjectGrid();
            }
        }
    }
}
