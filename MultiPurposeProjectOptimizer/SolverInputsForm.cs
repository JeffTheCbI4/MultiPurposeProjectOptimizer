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
    public partial class SolverInputsForm : Form
    {
        Form MainMenu;
        bool BackgroundUpdatingStatus = true;
        public SolverInputsForm(Form mainMenu)
        {
            InitializeComponent();
            MainMenu = mainMenu;

            RefreshSolverInputsGrid();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            
        }

        public void RefreshSolverInputsGrid()
        {
            BackgroundUpdatingStatus = true;
            SolverInputsGrid.Rows.Clear();
            List<Dictionary<string, string>> solverInputsSetsList = DBManager.SelectSolverInputsSet();
            for (int i = 0; i < solverInputsSetsList.Count; i++)
            {
                Dictionary<string, string> solverInputsSet = solverInputsSetsList[i];
                SolverInputsGrid.Rows.Add(
                    solverInputsSet["solverInputsSetId"],
                    i + 1,
                    solverInputsSet["setName"],
                    solverInputsSet["solutionQuantityCap"]);
            }
            BackgroundUpdatingStatus = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolverInputsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.Show();
        }

        private void SolverInputsGrid_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            int rowIndex = e.RowIndex;
            var validatedCells = SolverInputsGrid.Rows[rowIndex].Cells;
            if (validatedCells["SetName"].Value == null ||
                String.IsNullOrWhiteSpace(validatedCells["SetName"].Value.ToString()))
            {
                e.Cancel = true;
                validatedCells["SetName"].ErrorText = "Имя не должно быть пустым";
                return;
            } else
            {
                DataGridViewRowCollection rows = SolverInputsGrid.Rows;

                for (int i = 0; i < rows.Count - 1; i++)
                {
                    DataGridViewRow row = rows[i];
                    if (row.Cells["SetName"].Value.ToString() == validatedCells["SetName"].Value.ToString()
                        && i != rowIndex)
                    {
                        validatedCells["SetName"].ErrorText = "Имя должно быть уникальным";
                        e.Cancel = true;
                    }
                }
            }

            if (validatedCells["solutionQuantityCap"].Value == null ||
                !int.TryParse(validatedCells["solutionQuantityCap"].Value.ToString(), out int result) ||
                result < 0)
            {
                e.Cancel = true;
                validatedCells["solutionQuantityCap"].ErrorText = "Значение должно быть целым и положительным числом";
                return;
            }
        }

        private void SolverInputsGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = SolverInputsGrid.Rows[e.RowIndex];
            //Если у строки нет Id - то операция добавления
            try
            {
                if (currentRow.Cells["SolverInputsSetId"].Value == null)
                {
                    string setName = currentRow.Cells["SetName"].Value.ToString();
                    int solutionQuantityCap = int.Parse(currentRow.Cells["SolutionQuantityCap"].Value.ToString());
                    DBManager.InsertSolverInputsSet(1, setName, solutionQuantityCap);

                    currentRow.Cells["SetName"].ErrorText = "";
                    currentRow.Cells["SolutionQuantityCap"].ErrorText = "";

                    currentRow.Cells["RowNumber"].Value = currentRow.Index + 1;
                    int solverInputsSetId = int.Parse(DBManager.SelectSolverInputsSetByName(setName)[0]["solverInputsSetId"]);
                    currentRow.Cells["SolverInputsSetId"].Value = solverInputsSetId;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Непредвиденная ошибка при валидации таблицы проектов\n" +
                    exception.Message,
                                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выделенные задачи?",
                                "Удалить задачи", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            int rowsCount = SolverInputsGrid.SelectedRows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                int removedId = int.Parse(SolverInputsGrid.SelectedRows[i].Cells["SolverInputsSetId"].Value.ToString());
                DBManager.DeleteSolverInputsSet(removedId);
            }
            RefreshSolverInputsGrid();
        }

        private void SolverInputsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BackgroundUpdatingStatus ||
                SolverInputsGrid.Rows[e.RowIndex].Cells["SolverInputsSetId"].Value == null) return;
            DataGridViewRow currentRow = SolverInputsGrid.Rows[e.RowIndex];
            if (currentRow.Cells["SolverInputsSetId"].Value != null &&
                int.TryParse(currentRow.Cells["SolverInputsSetId"].Value.ToString(), out int solverInputsSetId))
            {
                string setName = currentRow.Cells["SetName"].Value.ToString();
                int solutionQuantityCap = int.Parse(currentRow.Cells["SolutionQuantityCap"].Value.ToString());
                DBManager.UpdateSolverInputsSet(setName, solutionQuantityCap, solverInputsSetId);
                currentRow.Cells["SetName"].ErrorText = "";
                currentRow.Cells["SolutionQuantityCap"].ErrorText = "";
            }
        }

        private void CapsButton_Click(object sender, EventArgs e)
        {
            int selectedRowsCount = SolverInputsGrid.SelectedRows.Count;
            if (selectedRowsCount == 0)
            {
                MessageBox.Show("Не выбрана строка задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedRowsCount > 1)
            {
                MessageBox.Show("Выбрано больше одной задачи",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int solverInputsSetId = int.Parse(SolverInputsGrid.SelectedRows[0].Cells["SolverInputsSetId"].Value.ToString());
            this.Enabled = false;
            new EditCapsForm(this, solverInputsSetId).Show();
        }
    }
}
