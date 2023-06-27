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
    public partial class MainMenuForm : Form
    {
        public List<Project> Projects { get; set; }
        public MainMenuForm()
        {
            InitializeComponent();
            Project project1 = new Project(0, "aaa", new Dictionary<string, double>());
            Project project2 = new Project(1, "bbb", new Dictionary<string, double>());
            Project project3 = new Project(2, "ccc", new Dictionary<string, double>());
            Projects = new List<Project>() { project1, project2, project3 };
        }

        private void ProjectAndPropertiesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProjectsAndPropertiesForm(this).Show();
        }

        private void SilverInputsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SolverInputsForm(this).Show();
        }
    }
}
