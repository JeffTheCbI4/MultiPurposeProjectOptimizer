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
        public MainMenuForm()
        {
            InitializeComponent();
            this.Enabled = false;
            new DatabaseLogInForm(this).Show();

            /*DBManager.User = "USER-PC\\User";
            DBManager.Password = "";
            //DBManager.DataSource = "USER-PC\\SQLEXPRESS";
            DBManager.DataSource = "localhost";
            DBManager.InitialCatalog = "MPPOptimizerDB";
            DBManager.IntegratedSecurity = true;
            DBManager.ConnectToDB();*/
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
