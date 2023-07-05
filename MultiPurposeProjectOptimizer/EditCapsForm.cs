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
    public partial class EditCapsForm : Form
    {
        SolverInputsForm PreviousForm;
        int SolverInputsSetId;
        bool BackgroundUpdatingStatus = true;

        public EditCapsForm(SolverInputsForm previousForm, int solverInputsSetId)
        {
            InitializeComponent();
            PreviousForm = previousForm;
            SolverInputsSetId = solverInputsSetId;
            RefreshPropertyGrid();
            RefreshPropertyCapsGrid();
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

        public void RefreshPropertyCapsGrid()
        {
            BackgroundUpdatingStatus = true;
            PropertyCapsGrid.Rows.Clear();
            List<Dictionary<string, string>> capsList = DBManager.SelectPropertyCap(SolverInputsSetId);
            for (int i = 0; i < capsList.Count; i++)
            {
                Dictionary<string, string> propertyCap = capsList[i];
                PropertyCapsGrid.Rows.Add(
                    propertyCap["propertyCapId"],
                    i + 1,
                    propertyCap["propertyId"],
                    propertyCap["propertyName"],
                    propertyCap["capValue"]);
            }
            BackgroundUpdatingStatus = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCapsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Enabled = true;
        }

        private void AddCapButton_Click(object sender, EventArgs e)
        {
            if (PropertiesGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбраны строки ограничиваемых свойств",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow propertyRow in PropertiesGrid.SelectedRows)
            {
                if (propertyRow.Cells["PropertyId"].Value == null) continue;
                bool alreadyHasPropertyCap = false;
                int propertyId = int.Parse(propertyRow.Cells["PropertyId"].Value.ToString());
                foreach (DataGridViewRow projectPropertyRow in PropertyCapsGrid.Rows)
                {
                    if (projectPropertyRow.Cells["PropertyCapId"].Value == null) continue;
                    if (int.Parse(projectPropertyRow.Cells["CapGridPropertyId"].Value.ToString()) == propertyId)
                    {
                        alreadyHasPropertyCap = true;
                        break;
                    }
                }
                if (alreadyHasPropertyCap)
                {
                    string propertyName = propertyRow.Cells["PropertyName"].Value.ToString();
                    MessageBox.Show(string.Format("Свойство {0} уже имеет ограничение в данной задаче", propertyName),
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                DBManager.InsertPropertyCap(SolverInputsSetId, propertyId, 0);
            }
            RefreshPropertyCapsGrid();
        }

        private void DeleteCapButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные ограничения?",
                                "Удалить ограничения", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = PropertyCapsGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(PropertyCapsGrid.SelectedRows[i].Cells["PropertyCapId"].Value.ToString());
                DBManager.DeletePropertyCap(removedId);
            }
            RefreshPropertyCapsGrid();
        }

        private void PropertyCapsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewCell changedCell = PropertyCapsGrid.Rows[rowIndex].Cells["PropertyCapValue"];
            if (changedCell.Value == null)
            {
                changedCell.ErrorText = "Ограничение не должно быть пустым";
                return;
            } else if (!double.TryParse(changedCell.Value.ToString(), out double capValue) || capValue < 0)
            {
                changedCell.ErrorText = "Ограничение должно быть положительным числом";
                return;
            } else
            {
                changedCell.ErrorText = "";
            }
        }

        private void PropertyCapsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus) return;
            int rowIndex = e.RowIndex;
            DataGridViewCell changedCell = PropertyCapsGrid.Rows[rowIndex].Cells["PropertyCapValue"];

            int propertyCapId = int.Parse(PropertyCapsGrid.Rows[rowIndex].Cells["PropertyCapId"].Value.ToString());
            double capValue = double.Parse(PropertyCapsGrid.Rows[rowIndex].Cells["PropertyCapValue"].Value.ToString());
            DBManager.UpdatePropertyCapValue(propertyCapId, capValue);
        }
    }
}
