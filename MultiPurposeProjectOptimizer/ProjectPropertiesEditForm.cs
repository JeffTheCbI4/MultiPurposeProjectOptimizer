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
    public partial class ProjectPropertiesEditForm : Form
    {
        ProjectsAndPropertiesForm PreviousForm;
        int ProjectId;
        bool backgroundUpdatingStatus = true;
        public ProjectPropertiesEditForm(ProjectsAndPropertiesForm previousForm, int projectId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            ProjectId = projectId;
            RefreshPropertyGrid();
            RefreshProjectPropertyGrid(ProjectId);
        }

        private void AddProjectPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertiesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки добавляемых свойств",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach(DataGridViewRow propertyRow in PropertiesGrid.SelectedRows)
            {
                if (propertyRow.Cells["PropertyId"].Value == null) continue;
                bool alreadyHasProperty = false;
                string propertyName = propertyRow.Cells["PropertyName"].Value.ToString();
                foreach (DataGridViewRow projectPropertyRow in ProjectPropertyGrid.Rows)
                {
                    if (projectPropertyRow.Cells["ProjectPropertyId"].Value == null) continue;
                    if (projectPropertyRow.Cells["ProjectPropertyName"].Value.ToString() == propertyName)
                    {
                        alreadyHasProperty = true;
                        break;
                    }
                }
                if(alreadyHasProperty)
                {
                    MessageBox.Show(string.Format("Свойство {0} уже есть у данного проекта", propertyName),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                int propertyId = int.Parse(propertyRow.Cells["PropertyId"].Value.ToString());
                DBManager.InsertProjectProperty(ProjectId, propertyId, 0);
            }
            RefreshProjectPropertyGrid(ProjectId);
        }
        public void RefreshPropertyGrid()
        {
            backgroundUpdatingStatus = true;
            PropertiesGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectProperty();
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                PropertiesGrid.Rows.Add(property["propertyId"], i + 1, property["propertyName"]);
            }
            backgroundUpdatingStatus = false;
        }

        public void RefreshProjectPropertyGrid(int projectId)
        {
            backgroundUpdatingStatus = true;
            ProjectPropertyGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectProjectProperties(projectId);
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                ProjectPropertyGrid.Rows.Add(property["projectPropertyId"], i + 1, property["propertyName"], 
                    property["propertyValue"]);
            }
            backgroundUpdatingStatus = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectPropertiesEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void DeleteProjectPropertyButton_Click(object sender, EventArgs e)
        {
            int rowsCount = ProjectPropertyGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(ProjectPropertyGrid.SelectedRows[i].Cells["ProjectPropertyId"].Value.ToString());
                DBManager.DeleteProjectProperty(removedId);
            }
            RefreshProjectPropertyGrid(ProjectId);
        }

        private void ProjectPropertyGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (backgroundUpdatingStatus 
                || ProjectPropertyGrid.Rows[e.RowIndex].Cells["ProjectPropertyId"].Value == null) return;
            object value = ProjectPropertyGrid.Rows[e.RowIndex].Cells["ProjectPropertyValue"].Value;
            double doubleValue;
            if (value == null || !double.TryParse(value.ToString(), out doubleValue) || doubleValue < 0)
            {
                ProjectPropertyGrid.Rows[e.RowIndex].Cells["ProjectPropertyValue"].ErrorText =
                    "Значение должно быть положительным числом";
                return;
            }
            ProjectPropertyGrid.Rows[e.RowIndex].Cells["ProjectPropertyValue"].ErrorText = "";
            int projectPropertyId = int.Parse(ProjectPropertyGrid.Rows[e.RowIndex].Cells["ProjectPropertyId"].Value.ToString());
            DBManager.UpdateProjectPropertyValue(projectPropertyId, doubleValue);
        }
    }
}
