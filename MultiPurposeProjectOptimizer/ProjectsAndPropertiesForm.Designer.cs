
namespace MultiPurposeProjectOptimizer
{
    partial class ProjectsAndPropertiesForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchProjectTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.ProjectAddButton = new System.Windows.Forms.Button();
            this.ProjectsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddPropertyButton = new System.Windows.Forms.Button();
            this.PropertiesGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectProperties = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsMultiPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MPPInfluenceButtonRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchProjectTextBox);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.deleteProjectButton);
            this.groupBox2.Controls.Add(this.ProjectAddButton);
            this.groupBox2.Controls.Add(this.ProjectsGrid);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 221);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проекты";
            // 
            // SearchProjectTextBox
            // 
            this.SearchProjectTextBox.Location = new System.Drawing.Point(6, 21);
            this.SearchProjectTextBox.Name = "SearchProjectTextBox";
            this.SearchProjectTextBox.Size = new System.Drawing.Size(543, 20);
            this.SearchProjectTextBox.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(555, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Искать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Location = new System.Drawing.Point(555, 78);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(97, 23);
            this.deleteProjectButton.TabIndex = 5;
            this.deleteProjectButton.Text = "Удалить";
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // ProjectAddButton
            // 
            this.ProjectAddButton.Location = new System.Drawing.Point(555, 49);
            this.ProjectAddButton.Name = "ProjectAddButton";
            this.ProjectAddButton.Size = new System.Drawing.Size(97, 23);
            this.ProjectAddButton.TabIndex = 3;
            this.ProjectAddButton.Text = "Добавить";
            this.ProjectAddButton.UseVisualStyleBackColor = true;
            this.ProjectAddButton.Click += new System.EventHandler(this.ProjectAddButton_Click);
            // 
            // ProjectsGrid
            // 
            this.ProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectRowNumber,
            this.ProjectName,
            this.ProjectProperties,
            this.IsMultiPurpose,
            this.MPPInfluenceButtonRow});
            this.ProjectsGrid.Location = new System.Drawing.Point(6, 48);
            this.ProjectsGrid.Name = "ProjectsGrid";
            this.ProjectsGrid.Size = new System.Drawing.Size(543, 150);
            this.ProjectsGrid.TabIndex = 1;
            this.ProjectsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AddPropertyButton);
            this.groupBox1.Controls.Add(this.PropertiesGrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 221);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddPropertyButton
            // 
            this.AddPropertyButton.Location = new System.Drawing.Point(255, 50);
            this.AddPropertyButton.Name = "AddPropertyButton";
            this.AddPropertyButton.Size = new System.Drawing.Size(97, 23);
            this.AddPropertyButton.TabIndex = 3;
            this.AddPropertyButton.Text = "Добавить";
            this.AddPropertyButton.UseVisualStyleBackColor = true;
            this.AddPropertyButton.Click += new System.EventHandler(this.AddPropertyButton_Click);
            // 
            // PropertiesGrid
            // 
            this.PropertiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.RowNumber,
            this.PropertyName});
            this.PropertiesGrid.Location = new System.Drawing.Point(6, 48);
            this.PropertiesGrid.Name = "PropertiesGrid";
            this.PropertiesGrid.Size = new System.Drawing.Size(243, 151);
            this.PropertiesGrid.TabIndex = 1;
            this.PropertiesGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertiesGrid_RowValidated);
            this.PropertiesGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PropertiesGrid_RowValidating);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(530, 420);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(147, 40);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ProjectId
            // 
            this.ProjectId.HeaderText = "ProjectId";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Visible = false;
            // 
            // ProjectRowNumber
            // 
            this.ProjectRowNumber.HeaderText = "№";
            this.ProjectRowNumber.Name = "ProjectRowNumber";
            this.ProjectRowNumber.ReadOnly = true;
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
            this.ProjectProperties.ReadOnly = true;
            this.ProjectProperties.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectProperties.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // IsMultiPurpose
            // 
            this.IsMultiPurpose.HeaderText = "Многоцелевой проект";
            this.IsMultiPurpose.Name = "IsMultiPurpose";
            this.IsMultiPurpose.ReadOnly = true;
            // 
            // MPPInfluenceButtonRow
            // 
            this.MPPInfluenceButtonRow.HeaderText = "Влияние на другие проекты";
            this.MPPInfluenceButtonRow.Name = "MPPInfluenceButtonRow";
            this.MPPInfluenceButtonRow.ReadOnly = true;
            this.MPPInfluenceButtonRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MPPInfluenceButtonRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "№";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Название свойства";
            this.PropertyName.Name = "PropertyName";
            // 
            // ProjectsAndPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 480);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProjectsAndPropertiesForm";
            this.Text = "Проекты и свойства";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectsAndPropertiesForm_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchProjectTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.Button ProjectAddButton;
        private System.Windows.Forms.DataGridView ProjectsGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddPropertyButton;
        private System.Windows.Forms.DataGridView PropertiesGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewButtonColumn ProjectProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMultiPurpose;
        private System.Windows.Forms.DataGridViewButtonColumn MPPInfluenceButtonRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
    }
}