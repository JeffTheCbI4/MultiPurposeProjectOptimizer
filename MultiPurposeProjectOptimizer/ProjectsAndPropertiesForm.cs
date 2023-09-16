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
    public partial class ProjectsAndPropertiesForm : Form
    {
        MainMenuForm MainMenu;
        bool BackgroundUpdatingStatus = true;
        public ProjectsAndPropertiesForm(MainMenuForm mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;
            RefreshProjectGrid();
            RefreshPropertyGrid();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectsAndPropertiesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.Show();
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные проекты?",
                                "Удалить проекты", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = ProjectsGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(ProjectsGrid.SelectedRows[i].Cells["ProjectId"].Value.ToString());
                DBManager.DeleteProject(removedId);
            }
            RefreshProjectGrid();
        }

        public void RefreshProjectGrid()
        {
            BackgroundUpdatingStatus = true;
            ProjectsGrid.Rows.Clear();
            List<Dictionary<string,string>> projectsList = DBManager.SelectProjects();
            for (int i = 0; i < projectsList.Count; i++)
            {
                Dictionary<string, string> project = projectsList[i];
                bool isMPString = project["isMultiPurpose"] == "True" ? true : false;
                ProjectsGrid.Rows.Add(project["projectId"], i + 1, project["projectName"], isMPString);
            }
            BackgroundUpdatingStatus = false;
        }

        public void RefreshPropertyGrid()
        {
            BackgroundUpdatingStatus = true;
            PropertiesGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectProperty();
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                PropertiesGrid.Rows.Add(property["propertyId"], i + 1, property["propertyName"]);
            }
            BackgroundUpdatingStatus = false;
        }

        private void AddPropertyButton_Click(object sender, EventArgs e)
        {

            /*int lastRowNumber = PropertiesGrid.Rows[PropertiesGrid.Rows.Count].Cells["RowNumber"].Value;
            PropertiesGrid.Rows.Add();*/
        }

        private void PropertiesGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            int rowIndex = e.RowIndex;
            var validatedCells = PropertiesGrid.Rows[rowIndex].Cells;
            if (validatedCells["PropertyName"].Value == null ||
                String.IsNullOrWhiteSpace(validatedCells["PropertyName"].Value.ToString()))
            {
                e.Cancel = true;
                validatedCells["PropertyName"].ErrorText = "Имя не должно быть пустым";
                return;
            }

            DataGridViewRowCollection rows = PropertiesGrid.Rows;

            for (int i = 0; i < rows.Count - 1; i++)
            {
                DataGridViewRow row = rows[i];
                if (row.Cells["PropertyName"].Value.ToString() == validatedCells["PropertyName"].Value.ToString()
                    && i != rowIndex)
                {
                    validatedCells["PropertyName"].ErrorText = "Имя должно быть уникальным";
                    e.Cancel = true;
                }
            }
        }

        private void PropertiesGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = PropertiesGrid.Rows[e.RowIndex];
            //Если у строки нет Id - то операция добавления
            if (currentRow.Cells["Id"].Value == null)
            {
                string propertyName = currentRow.Cells["PropertyName"].Value.ToString();
                DBManager.InsertProperty(propertyName);
                currentRow.Cells["PropertyName"].ErrorText = "";
                currentRow.Cells["RowNumber"].Value = currentRow.Index + 1;
                int propertyId = int.Parse(DBManager.SelectPropertyByName(propertyName)[0]["propertyId"]);
                currentRow.Cells["Id"].Value = propertyId;
            }
        }

        private void DeletePropertyButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные свойства?",
                                "Удалить свойства", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = PropertiesGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(PropertiesGrid.SelectedRows[i].Cells["Id"].Value.ToString());
                DBManager.DeleteProperty(removedId);
            }
            RefreshPropertyGrid();
        }

        private void ProjectsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            int rowIndex = e.RowIndex;
            var validatedCells = ProjectsGrid.Rows[rowIndex].Cells;
            if (validatedCells["ProjectName"].Value == null ||
                String.IsNullOrWhiteSpace(validatedCells["ProjectName"].Value.ToString()))
            {
                e.Cancel = true;
                validatedCells["ProjectName"].ErrorText = "Имя не должно быть пустым";
                return;
            }

            DataGridViewRowCollection rows = ProjectsGrid.Rows;

            for (int i = 0; i < rows.Count - 1; i++)
            {
                DataGridViewRow row = rows[i];
                if (row.Cells["ProjectName"].Value.ToString() == validatedCells["ProjectName"].Value.ToString()
                    && i != rowIndex)
                {
                    validatedCells["ProjectName"].ErrorText = "Имя должно быть уникальным";
                    e.Cancel = true;
                }
            }
        }

        private void ProjectsGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = ProjectsGrid.Rows[e.RowIndex];
            //Если у строки нет Id - то операция добавления
            try
            {
                if (currentRow.Cells["ProjectId"].Value == null)
                {
                    string projectName = currentRow.Cells["ProjectName"].Value.ToString();
                    DBManager.InsertProject(projectName, 1, false);
                    currentRow.Cells["ProjectName"].ErrorText = "";
                    currentRow.Cells["ProjectRowNumber"].Value = currentRow.Index + 1;
                    int propertyId = int.Parse(DBManager.SelectProjectByName(projectName)[0]["projectId"]);
                    currentRow.Cells["ProjectId"].Value = propertyId;
                }
            } catch (Exception exception)
            {
                MessageBox.Show("Непредвиденная ошибка при валидации таблицы проектов\n" +
                    exception.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProjectPropertiesButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = ProjectsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одного проекта",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int projectId = int.Parse(ProjectsGrid.SelectedRows[0].Cells["ProjectId"].Value.ToString());
            this.Enabled = false;
            new ProjectPropertiesEditForm(this, projectId).Show();
        }

        private void ProjectsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus || 
                ProjectsGrid.Rows[e.RowIndex].Cells["ProjectId"].Value == null) return;
            DataGridViewRow currentRow = ProjectsGrid.Rows[e.RowIndex];
            if (currentRow.Cells["ProjectId"].Value != null &&
                int.TryParse(currentRow.Cells["ProjectId"].Value.ToString(), out int projectId))
            {
                string projectName = currentRow.Cells["ProjectName"].Value.ToString();
                DBManager.UpdateProjectName(projectName, projectId);
                currentRow.Cells["ProjectName"].ErrorText = "";
            }
        }

        private void InfluencesButton_Click(object sender, EventArgs e)
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
            new EditInfluenceForm(this, projectId).Show();
        }

        private void PropertiesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus ||
                PropertiesGrid.Rows[e.RowIndex].Cells["Id"].Value == null) return;
            DataGridViewRow currentRow = PropertiesGrid.Rows[e.RowIndex];
            if (currentRow.Cells["Id"].Value != null &&
                int.TryParse(currentRow.Cells["Id"].Value.ToString(), out int propertyId))
            {
                string propertyName = currentRow.Cells["PropertyName"].Value.ToString();
                DBManager.UpdateProperty(propertyName, propertyId);
                currentRow.Cells["PropertyName"].ErrorText = "";
            }
        }
    }
}
