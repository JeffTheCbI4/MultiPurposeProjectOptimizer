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

        private void ProjectsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProjectsGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                this.Enabled = false;
                new ProjectAddAndEditForm(this, MainMenu.Projects).Show();
            }
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
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
            ProjectsGrid.Rows.Clear();
            List<Dictionary<string,string>> projectsList = DBManager.SelectProjects();
            for (int i = 0; i < projectsList.Count; i++)
            {
                Dictionary<string, string> project = projectsList[i];
                string isMPString = project["isMultiPurpose"] == "True" ? "Да" : "Нет";
                ProjectsGrid.Rows.Add(project["projectId"], i + 1, project["projectName"], "Свойства", isMPString, "Влияние");
            }
        }

        private void ProjectAddButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ProjectAddAndEditForm(this, MainMenu.Projects).Show();
        }

        public void RefreshPropertyGrid()
        {
            PropertiesGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectProperty();
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                PropertiesGrid.Rows.Add(property["propertyId"], i + 1, property["propertyName"]);
            }
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
            DataGridViewRowCollection rows = PropertiesGrid.Rows;

            for (int i = 0; i < rows.Count - 1; i++)
            {
                DataGridViewRow row = rows[i];
                if (row.Cells["PropertyName"].Value.ToString() == validatedCells["PropertyName"].Value.ToString() && i != rowIndex)
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
            //Иначе - операция обновления
            if (currentRow.Cells["Id"].Value == null)
            {
                string propertyName = currentRow.Cells["PropertyName"].Value.ToString();
                DBManager.InsertProperty(propertyName);
                RefreshProjectGrid();
            }
        }
    }
}
