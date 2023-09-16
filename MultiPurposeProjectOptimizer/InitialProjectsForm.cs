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
    public partial class InitialProjectsForm : Form
    {
        SolverInputsForm PreviousForm;
        int SolverInputsSetId;

        public InitialProjectsForm(SolverInputsForm previousForm, int solverInputsSetId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            SolverInputsSetId = solverInputsSetId;
            RefreshProjectSolverLinkGrid();
            RefreshAllProjectsGrid();
        }

        public void RefreshProjectSolverLinkGrid()
        {
            ProjectSolverLinkGrid.Rows.Clear();
            List<Dictionary<string, string>> solverProjectLinksList = DBManager.SelectProjectSolverLink(SolverInputsSetId);
            for (int i = 0; i < solverProjectLinksList.Count; i++)
            {
                Dictionary<string, string> link = solverProjectLinksList[i];
                ProjectSolverLinkGrid.Rows.Add(
                    link["linkId"],
                    i + 1,
                    link["projectId"],
                    link["projectName"]);
            }
        }

        public void RefreshAllProjectsGrid()
        {
            AllProjectsGrid.Rows.Clear();
            List<Dictionary<string, string>> projectsList = DBManager.SelectProjects();
            for (int i = 0; i < projectsList.Count; i++)
            {
                Dictionary<string, string> link = projectsList[i];
                AllProjectsGrid.Rows.Add(
                    link["projectId"],
                    i + 1,
                    link["projectName"]);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitialProjectsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void AddProjectLinkButton_Click(object sender, EventArgs e)
        {
            if (AllProjectsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки добавляемых проектов",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow projectRow in AllProjectsGrid.SelectedRows)
            {
                if (projectRow.Cells["ProjectId"].Value == null) continue;
                bool alreadyHasProject = false;
                int projectId = int.Parse(projectRow.Cells["ProjectId"].Value.ToString());
                foreach (DataGridViewRow linkRow in ProjectSolverLinkGrid.Rows)
                {
                    if (linkRow.Cells["LinkProjectId"].Value == null) continue;
                    if (int.Parse(linkRow.Cells["LinkProjectId"].Value.ToString()) == projectId)
                    {
                        alreadyHasProject = true;
                        break;
                    }
                }
                if (alreadyHasProject)
                {
                    string projectName = projectRow.Cells["ProjectName"].Value.ToString();
                    MessageBox.Show(string.Format("Проект {0} уже учавствует в данной задаче", projectName),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                DBManager.InsertProjectSolverLink(SolverInputsSetId, projectId, false);
            }
            RefreshProjectSolverLinkGrid();
        }

        private void DeleteLinkButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите убрать выделенные проекты из задачи?",
                                "Убрать проекты", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = ProjectSolverLinkGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(ProjectSolverLinkGrid.SelectedRows[i].Cells["LinkId"].Value.ToString());
                DBManager.DeleteProjectSolverLink(removedId);
            }
            RefreshProjectSolverLinkGrid();
        }

        private void LinkPropertiesButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = ProjectSolverLinkGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка проекта в таблице участвующих проектов",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одного проекта в таблице участвующих проектов",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int projectId = int.Parse(ProjectSolverLinkGrid.SelectedRows[0].Cells["LinkProjectId"].Value.ToString());
            this.Enabled = false;
            new ProjectPropertiesEditForm(this, projectId).Show();
        }

        private void ProjectPropertiesButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = AllProjectsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка проекта в таблице всех проектов",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одного проекта в таблице всех проектов",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int projectId = int.Parse(AllProjectsGrid.SelectedRows[0].Cells["ProjectId"].Value.ToString());
            this.Enabled = false;
            new ProjectPropertiesEditForm(this, projectId).Show();
        }
    }
}
