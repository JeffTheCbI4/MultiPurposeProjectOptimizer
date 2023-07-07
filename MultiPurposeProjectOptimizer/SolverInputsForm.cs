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
    public partial class SolverInputsForm : Form
    {
        Form MainMenu;
        bool BackgroundUpdatingStatus = true;
        public SolverInputsForm(Form mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;

            RefreshSolverInputsGrid();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            Dictionary<int, Project> Projects = PrepareNonMPProjectsDictionary(solverInputsSetId);
            //Dictionary<int, MultiPurposeProject> MPProjects = PrepareMPProjectsDictionary(solverInputsSetId);
            Dictionary<string, double> Caps = PrepareCaps(solverInputsSetId);
            List<string> MaximizedProperties = PrepareMaximizedProperties(solverInputsSetId);

            PackOptimizer optimizer = new PackOptimizer(Projects, Caps, MaximizedProperties);
            optimizer.Solve();
            /*try
            {
                PackOptimizer optimizer = new PackOptimizer(Projects, Caps, MaximizedProperties);
                optimizer.Solve();
            } catch (Exception exception)
            {
                MessageBox.Show("Произошла ошибка: " + exception.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private Dictionary<int, Project> PrepareNonMPProjectsDictionary(int solverInputsSetId)
        {
            Dictionary<int, Project> preparedProjectsList = new Dictionary<int, Project>();

            List<Dictionary<string, string>> linkedProjectsList = DBManager.SelectProjectSolverLinkByMP(solverInputsSetId, false);
            foreach(Dictionary<string, string> rawLinkData in linkedProjectsList)
            {
                int projectId = int.Parse(rawLinkData["projectId"]);
                string projectName = rawLinkData["projectName"];
                Dictionary<string, double> projectProperties = PrepareProjectProperties(projectId);
                
                Project project = new Project(projectId, projectName, projectProperties);
                preparedProjectsList.Add(projectId, project);
            }
            return preparedProjectsList;
        }

        private Dictionary<int, MultiPurposeProject> PrepareMPProjectsDictionary(int solverInputsSetId)
        {
            Dictionary<int, MultiPurposeProject> preparedProjectsList = new Dictionary<int, MultiPurposeProject>();

            List<Dictionary<string, string>> linkedProjectsList = DBManager.SelectProjectSolverLinkByMP(solverInputsSetId, true);
            foreach (Dictionary<string, string> rawLinkData in linkedProjectsList)
            {
                int projectId = int.Parse(rawLinkData["projectId"]);
                string projectName = rawLinkData["projectName"];
                Dictionary<string, double> projectProperties = PrepareProjectProperties(projectId);
                List<Influence> influences = PrepareProjectInfluences(projectId);

                MultiPurposeProject project = new MultiPurposeProject(projectId, projectName, projectProperties, influences);
                preparedProjectsList.Add(projectId, project);
            }
            return preparedProjectsList;
        }

        private Dictionary<string, double> PrepareProjectProperties(int projectId)
        {
            Dictionary<string, double> properties = new Dictionary<string, double>();
            List<Dictionary<string, string>> projectPropertiesList = DBManager.SelectProjectProperties(projectId);
            foreach(Dictionary<string, string> rawPropertyData in projectPropertiesList)
            {
                string propertyName = rawPropertyData["propertyName"];
                double propertyValue = double.Parse(rawPropertyData["propertyValue"]);
                properties.Add(propertyName, propertyValue);
            }
            return properties;
        }

        private List<Influence> PrepareProjectInfluences(int projectId)
        {
            List<Influence> influences = new List<Influence>();
            List<Dictionary<string, string>> projectInfluencesList = DBManager.SelectInfluences(projectId);
            foreach (Dictionary<string, string> rawInfluenceData in projectInfluencesList)
            {
                int influenceId = int.Parse(rawInfluenceData["influenceId"]);
                int influencedProjectId = int.Parse(rawInfluenceData["projectId"]);
                string propertyName = rawInfluenceData["propertyName"];
                double influenceValue = double.Parse(rawInfluenceData["influenceValue"]);

                Influence influence = new Influence(influenceId, influencedProjectId, propertyName, influenceValue);
                influences.Add(influence);
            }
            return influences;
        }

        private Dictionary<string, double> PrepareCaps(int solverInputsSetId)
        {
            Dictionary<string, double> capsList = new Dictionary<string, double>();
            List<Dictionary<string, string>> rawCapsList = DBManager.SelectPropertyCap(solverInputsSetId);
            foreach(Dictionary<string, string> rawCapData in rawCapsList)
            {
                string propertyName = rawCapData["propertyName"];
                double capValue = double.Parse(rawCapData["capValue"]);

                capsList.Add(propertyName, capValue);
            }
            return capsList;
        }

        private List<string> PrepareMaximizedProperties(int solverInputsSetId)
        {
            List<string> maximizedPropertiesList = new List<string>();

            List<Dictionary<string, string>> dbData = DBManager.SelectMaximizedProperty(solverInputsSetId);
            foreach(Dictionary<string, string> row in dbData)
            {
                string propertyName = row["propertyName"];
                maximizedPropertiesList.Add(propertyName);
            }
            return maximizedPropertiesList;
        }

        public void RefreshSolverInputsGrid()
        {
            BackgroundUpdatingStatus = true;
            SolverInputsGrid.Rows.Clear();
            List<Dictionary<string, string>> solverInputsSetsList = DBManager.SelectSolverInputsSet();
            for (int i = 0; i < solverInputsSetsList.Count; i++)
            {
                Dictionary<string, string> solverInputsSet = solverInputsSetsList[i];
                SolverInputsGrid.Rows.Add(
                    solverInputsSet["solverInputsSetId"],
                    i + 1,
                    solverInputsSet["setName"],
                    solverInputsSet["solutionQuantityCap"]);
            }
            BackgroundUpdatingStatus = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolverInputsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.Show();
        }

        private void SolverInputsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            int rowIndex = e.RowIndex;
            var validatedCells = SolverInputsGrid.Rows[rowIndex].Cells;
            if (validatedCells["SetName"].Value == null ||
                String.IsNullOrWhiteSpace(validatedCells["SetName"].Value.ToString()))
            {
                e.Cancel = true;
                validatedCells["SetName"].ErrorText = "Имя не должно быть пустым";
                return;
            } else
            {
                DataGridViewRowCollection rows = SolverInputsGrid.Rows;

                for (int i = 0; i < rows.Count - 1; i++)
                {
                    DataGridViewRow row = rows[i];
                    if (row.Cells["SetName"].Value.ToString() == validatedCells["SetName"].Value.ToString()
                        && i != rowIndex)
                    {
                        validatedCells["SetName"].ErrorText = "Имя должно быть уникальным";
                        e.Cancel = true;
                    }
                }
            }

            if (validatedCells["solutionQuantityCap"].Value == null ||
                !int.TryParse(validatedCells["solutionQuantityCap"].Value.ToString(), out int result) ||
                result < 0)
            {
                e.Cancel = true;
                validatedCells["solutionQuantityCap"].ErrorText = "Значение должно быть целым и положительным числом";
                return;
            }
        }

        private void SolverInputsGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = SolverInputsGrid.Rows[e.RowIndex];
            //Если у строки нет Id - то операция добавления
            try
            {
                if (currentRow.Cells["SolverInputsSetId"].Value == null)
                {
                    string setName = currentRow.Cells["SetName"].Value.ToString();
                    int solutionQuantityCap = int.Parse(currentRow.Cells["SolutionQuantityCap"].Value.ToString());
                    DBManager.InsertSolverInputsSet(1, setName, solutionQuantityCap);

                    currentRow.Cells["SetName"].ErrorText = "";
                    currentRow.Cells["SolutionQuantityCap"].ErrorText = "";

                    currentRow.Cells["RowNumber"].Value = currentRow.Index + 1;
                    int solverInputsSetId = int.Parse(DBManager.SelectSolverInputsSetByName(setName)[0]["solverInputsSetId"]);
                    currentRow.Cells["SolverInputsSetId"].Value = solverInputsSetId;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Непредвиденная ошибка при валидации таблицы проектов\n" +
                    exception.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные задачи?",
                                "Удалить задачи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = SolverInputsGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(SolverInputsGrid.SelectedRows[i].Cells["SolverInputsSetId"].Value.ToString());
                DBManager.DeleteSolverInputsSet(removedId);
            }
            RefreshSolverInputsGrid();
        }

        private void SolverInputsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus ||
                SolverInputsGrid.Rows[e.RowIndex].Cells["SolverInputsSetId"].Value == null) return;
            DataGridViewRow currentRow = SolverInputsGrid.Rows[e.RowIndex];
            if (currentRow.Cells["SolverInputsSetId"].Value != null &&
                int.TryParse(currentRow.Cells["SolverInputsSetId"].Value.ToString(), out int solverInputsSetId))
            {
                string setName = currentRow.Cells["SetName"].Value.ToString();
                int solutionQuantityCap = int.Parse(currentRow.Cells["SolutionQuantityCap"].Value.ToString());
                DBManager.UpdateSolverInputsSet(setName, solutionQuantityCap, solverInputsSetId);
                currentRow.Cells["SetName"].ErrorText = "";
                currentRow.Cells["SolutionQuantityCap"].ErrorText = "";
            }
        }

        private void CapsButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            this.Enabled = false;
            new EditCapsForm(this, solverInputsSetId).Show();
        }

        private void InitialProjectsButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            this.Enabled = false;
            new InitialProjectsForm(this, solverInputsSetId).Show();
        }

        private void OptimalProjectsButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            this.Enabled = false;
            new OptimalProjectListForm(this, solverInputsSetId).Show();
        }

        private void MaximizedPropertyButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            this.Enabled = false;
            new MaximizedPropertyForm(this, solverInputsSetId).Show();
        }
    }
}
