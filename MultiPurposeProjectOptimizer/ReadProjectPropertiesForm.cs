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
    public partial class ReadProjectPropertiesForm : Form
    {
        Form PreviousForm;
        int ProjectId;
        public ReadProjectPropertiesForm(Form previousForm, int projectId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            ProjectId = projectId;
            RefreshProjectPropertyGrid(ProjectId);
        }

        public void RefreshProjectPropertyGrid(int projectId)
        {
            ProjectPropertyGrid.Rows.Clear();
            List<Dictionary<string, string>> propertiesList = DBManager.SelectProjectProperties(projectId);
            for (int i = 0; i < propertiesList.Count; i++)
            {
                Dictionary<string, string> property = propertiesList[i];
                ProjectPropertyGrid.Rows.Add(property["projectPropertyId"], i + 1, property["propertyName"],
                    property["propertyValue"]);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadProjectPropertiesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }
    }
}
