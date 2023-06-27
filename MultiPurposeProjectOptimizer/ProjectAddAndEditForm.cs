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
    public partial class ProjectAddAndEditForm : Form
    {
        ProjectsAndPropertiesForm PreviousForm;
        List<Project> ProjectsList;
        Project EditedProject;
        public ProjectAddAndEditForm(ProjectsAndPropertiesForm previousForm, List<Project> projectsList)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            ProjectsList = projectsList;
        }
        public ProjectAddAndEditForm(ProjectsAndPropertiesForm previousForm, List<Project> projectsList, Project editedProject)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            ProjectsList = projectsList;
            EditedProject = editedProject;

            this.Text = "Редактирование проекта";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectAddAndEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            //Если редактируемого проекта нет (null) значит проект добавляется
            //Иначе - редактируется
            if (EditedProject == null)
            {
                string projectName = ProjectNameTextbox.Text;
                int projectId = ProjectsList.Count > 0 ? ProjectsList.Last().ProjectId + 1 : 0;
                Project addedProject = new Project(projectId, projectName, new Dictionary<string, double>());
                ProjectsList.Add(addedProject);
                PreviousForm.RefreshProjectGrid();
            }
            this.Close();
        }
    }
}
