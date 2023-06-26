
namespace MultiPurposeProjectOptimizer
{
    partial class OptimalProjectListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DirectionsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectProperties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMultiPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPPInfluenceButtonRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchProjectTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DirectionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оптимальный набор проектов для набора ограничений:";
            // 
            // DirectionsGrid
            // 
            this.DirectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DirectionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProjectName,
            this.ProjectProperties,
            this.IsMultiPurpose,
            this.MPPInfluenceButtonRow});
            this.DirectionsGrid.Location = new System.Drawing.Point(32, 92);
            this.DirectionsGrid.Name = "DirectionsGrid";
            this.DirectionsGrid.Size = new System.Drawing.Size(543, 333);
            this.DirectionsGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Название проекта";
            this.ProjectName.Name = "ProjectName";
            // 
            // ProjectProperties
            // 
            this.ProjectProperties.HeaderText = "Свойства проекта";
            this.ProjectProperties.Name = "ProjectProperties";
            // 
            // IsMultiPurpose
            // 
            this.IsMultiPurpose.HeaderText = "Многоцелевой проект";
            this.IsMultiPurpose.Name = "IsMultiPurpose";
            // 
            // MPPInfluenceButtonRow
            // 
            this.MPPInfluenceButtonRow.HeaderText = "Влияние на другие проекты";
            this.MPPInfluenceButtonRow.Name = "MPPInfluenceButtonRow";
            // 
            // SearchProjectTextBox
            // 
            this.SearchProjectTextBox.Location = new System.Drawing.Point(32, 66);
            this.SearchProjectTextBox.Name = "SearchProjectTextBox";
            this.SearchProjectTextBox.Size = new System.Drawing.Size(543, 20);
            this.SearchProjectTextBox.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(581, 65);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Искать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // OptimalProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.SearchProjectTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.DirectionsGrid);
            this.Controls.Add(this.label1);
            this.Name = "OptimalProjectListForm";
            this.Text = "Оптимальный набор проектов";
            ((System.ComponentModel.ISupportInitialize)(this.DirectionsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DirectionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMultiPurpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn MPPInfluenceButtonRow;
        private System.Windows.Forms.TextBox SearchProjectTextBox;
        private System.Windows.Forms.Button button8;
    }
}