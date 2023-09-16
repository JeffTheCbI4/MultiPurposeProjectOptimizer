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
    public partial class MaximizedPropertyForm : Form
    {
        Form PreviousForm;
        int SolverInputsSetId;
        int MaximizedPropertyId = -1;
        public MaximizedPropertyForm(Form previousForm, int solverInputsSetId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            SolverInputsSetId = solverInputsSetId;
            RefreshPropertyGrid();
            List<Dictionary<string, string>> dbData = DBManager.SelectMaximizedProperty(solverInputsSetId);
            if (dbData.Count == 1)
            {
                MaximizedPropertyId = int.Parse(dbData[0]["maximizedPropertyId"]);
                PropertyNameLabel.Text = dbData[0]["propertyName"];
            }
        }

        private void PropertiesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int propertyId = int.Parse(PropertiesGrid.Rows[e.RowIndex].Cells["PropertyId"].Value.ToString());
            string propertyName = PropertiesGrid.Rows[e.RowIndex].Cells["PropertyName"].Value.ToString();
            if (MaximizedPropertyId == -1)
            {
                DBManager.InsertMaximizedProperty(SolverInputsSetId, propertyId);
                List<Dictionary<string, string>> dbData = DBManager.SelectMaximizedProperty(SolverInputsSetId);
                MaximizedPropertyId = int.Parse(dbData[0]["maximizedPropertyId"]);
            } else
            {
                DBManager.UpdateMaximizedProperty(MaximizedPropertyId, propertyId);
            }
            PropertyNameLabel.Text = propertyName;
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizedPropertyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }
    }
}
