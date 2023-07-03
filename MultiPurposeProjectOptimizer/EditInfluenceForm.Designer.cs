
namespace MultiPurposeProjectOptimizer
{
    partial class EditInfluenceForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.AddInfluenceButton = new System.Windows.Forms.Button();
            this.ProjectPropertiesGrid = new System.Windows.Forms.DataGridView();
            this.ProjectPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectsGrid = new System.Windows.Forms.DataGridView();
            this.ProjectGridProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DeleteInfluenceButton = new System.Windows.Forms.Button();
            this.InfluencesGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.InfluenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedProjectPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluencedPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfluenceValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertiesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfluencesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(493, 488);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AddInfluenceButton
            // 
            this.AddInfluenceButton.Location = new System.Drawing.Point(707, 74);
            this.AddInfluenceButton.Name = "AddInfluenceButton";
            this.AddInfluenceButton.Size = new System.Drawing.Size(75, 23);
            this.AddInfluenceButton.TabIndex = 11;
            this.AddInfluenceButton.Text = "Добавить";
            this.AddInfluenceButton.UseVisualStyleBackColor = true;
            this.AddInfluenceButton.Click += new System.EventHandler(this.AddInfluenceButton_Click);
            // 
            // ProjectPropertiesGrid
            // 
            this.ProjectPropertiesGrid.AllowUserToAddRows = false;
            this.ProjectPropertiesGrid.AllowUserToDeleteRows = false;
            this.ProjectPropertiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectPropertiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectPropertyId,
            this.dataGridViewTextBoxColumn1,
            this.PropertyName});
            this.ProjectPropertiesGrid.Location = new System.Drawing.Point(458, 74);
            this.ProjectPropertiesGrid.Name = "ProjectPropertiesGrid";
            this.ProjectPropertiesGrid.ReadOnly = true;
            this.ProjectPropertiesGrid.Size = new System.Drawing.Size(243, 126);
            this.ProjectPropertiesGrid.TabIndex = 10;
            // 
            // ProjectPropertyId
            // 
            this.ProjectPropertyId.HeaderText = "ProjectPropertyId";
            this.ProjectPropertyId.Name = "ProjectPropertyId";
            this.ProjectPropertyId.ReadOnly = true;
            this.ProjectPropertyId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "№";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Название свойства";
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            // 
            // ProjectsGrid
            // 
            this.ProjectsGrid.AllowUserToAddRows = false;
            this.ProjectsGrid.AllowUserToDeleteRows = false;
            this.ProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectGridProjectId,
            this.RowNumber,
            this.ProjectName});
            this.ProjectsGrid.Location = new System.Drawing.Point(18, 74);
            this.ProjectsGrid.Name = "ProjectsGrid";
            this.ProjectsGrid.ReadOnly = true;
            this.ProjectsGrid.Size = new System.Drawing.Size(341, 126);
            this.ProjectsGrid.TabIndex = 9;
            this.ProjectsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectsGrid_CellDoubleClick);
            // 
            // ProjectGridProjectId
            // 
            this.ProjectGridProjectId.HeaderText = "ProjectId";
            this.ProjectGridProjectId.Name = "ProjectGridProjectId";
            this.ProjectGridProjectId.ReadOnly = true;
            this.ProjectGridProjectId.Visible = false;
            // 
            // RowNumber
            // 
            this.RowNumber.HeaderText = "№";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.ReadOnly = true;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Название проекта";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(365, 44);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(707, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Свойства влиямего проекта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Список проектов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 248);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(683, 20);
            this.textBox3.TabIndex = 23;
            // 
            // DeleteInfluenceButton
            // 
            this.DeleteInfluenceButton.Location = new System.Drawing.Point(707, 281);
            this.DeleteInfluenceButton.Name = "DeleteInfluenceButton";
            this.DeleteInfluenceButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteInfluenceButton.TabIndex = 22;
            this.DeleteInfluenceButton.Text = "Удалить";
            this.DeleteInfluenceButton.UseVisualStyleBackColor = true;
            this.DeleteInfluenceButton.Click += new System.EventHandler(this.DeleteInfluenceButton_Click);
            // 
            // InfluencesGrid
            // 
            this.InfluencesGrid.AllowUserToAddRows = false;
            this.InfluencesGrid.AllowUserToDeleteRows = false;
            this.InfluencesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfluencesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfluenceId,
            this.dataGridViewTextBoxColumn3,
            this.InfluencedProjectId,
            this.dataGridViewTextBoxColumn5,
            this.InfluencedProjectPropertyId,
            this.InfluencedPropertyId,
            this.InfluencedPropertyName,
            this.InfluenceValue});
            this.InfluencesGrid.Location = new System.Drawing.Point(18, 274);
            this.InfluencesGrid.Name = "InfluencesGrid";
            this.InfluencesGrid.Size = new System.Drawing.Size(683, 143);
            this.InfluencesGrid.TabIndex = 21;
            this.InfluencesGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.InfluencesGrid_CellValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Влияния проекта";
            // 
            // InfluenceId
            // 
            this.InfluenceId.HeaderText = "InfluenceId";
            this.InfluenceId.Name = "InfluenceId";
            this.InfluenceId.ReadOnly = true;
            this.InfluenceId.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "№";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // InfluencedProjectId
            // 
            this.InfluencedProjectId.HeaderText = "InflluenceProjectId";
            this.InfluencedProjectId.Name = "InfluencedProjectId";
            this.InfluencedProjectId.ReadOnly = true;
            this.InfluencedProjectId.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Название влияемого проекта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // InfluencedProjectPropertyId
            // 
            this.InfluencedProjectPropertyId.HeaderText = "InfluencedProjectPropertyId";
            this.InfluencedProjectPropertyId.Name = "InfluencedProjectPropertyId";
            this.InfluencedProjectPropertyId.ReadOnly = true;
            this.InfluencedProjectPropertyId.Visible = false;
            // 
            // InfluencedPropertyId
            // 
            this.InfluencedPropertyId.HeaderText = "InfluencedPropertyId";
            this.InfluencedPropertyId.Name = "InfluencedPropertyId";
            this.InfluencedPropertyId.ReadOnly = true;
            this.InfluencedPropertyId.Visible = false;
            // 
            // InfluencedPropertyName
            // 
            this.InfluencedPropertyName.HeaderText = "Название влияемого свойства";
            this.InfluencedPropertyName.Name = "InfluencedPropertyName";
            this.InfluencedPropertyName.ReadOnly = true;
            // 
            // InfluenceValue
            // 
            this.InfluenceValue.HeaderText = "Значение влияния";
            this.InfluenceValue.Name = "InfluenceValue";
            // 
            // EditInfluenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DeleteInfluenceButton);
            this.Controls.Add(this.InfluencesGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AddInfluenceButton);
            this.Controls.Add(this.ProjectPropertiesGrid);
            this.Controls.Add(this.ProjectsGrid);
            this.Name = "EditInfluenceForm";
            this.Text = "Редактирование влияний проекта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditInfluenceForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertiesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfluencesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button AddInfluenceButton;
        private System.Windows.Forms.DataGridView ProjectPropertiesGrid;
        private System.Windows.Forms.DataGridView ProjectsGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button DeleteInfluenceButton;
        private System.Windows.Forms.DataGridView InfluencesGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectGridProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedProjectPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluencedPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfluenceValue;
    }
}