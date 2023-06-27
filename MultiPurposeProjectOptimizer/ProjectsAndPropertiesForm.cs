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
            for (int i = rowsCount - 1; i >= 0; i--)
            {
                int removedIndex = int.Parse(ProjectsGrid.SelectedRows[i].Cells["ProjectRowNumber"].Value.ToString());
                MainMenu.Projects.RemoveAt(removedIndex - 1);
            }
            RefreshProjectGrid();
        }

        public void RefreshProjectGrid()
        {
            ProjectsGrid.Rows.Clear();
            for (int i = 0; i < MainMenu.Projects.Count; i++)
            {
                string projectName = MainMenu.Projects[i].ProjectName;
                ProjectsGrid.Rows.Add(i + 1, projectName);
            }
        }

        private void ProjectAddButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new ProjectAddAndEditForm(this, MainMenu.Projects).Show();
        }
    }
}
