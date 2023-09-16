
namespace MultiPurposeProjectOptimizer
{
    partial class InitialProjectsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.DeleteLinkButton = new System.Windows.Forms.Button();
            this.AddProjectLinkButton = new System.Windows.Forms.Button();
            this.AllProjectsGrid = new System.Windows.Forms.DataGridView();
            this.ProjectSolverLinkGrid = new System.Windows.Forms.DataGridView();
            this.LinkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkPropertiesButton = new System.Windows.Forms.Button();
            this.ProjectPropertiesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSolverLinkGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Список всех проектов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Список участвующих проектов";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(494, 434);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 14;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DeleteLinkButton
            // 
            this.DeleteLinkButton.Location = new System.Drawing.Point(366, 42);
            this.DeleteLinkButton.Name = "DeleteLinkButton";
            this.DeleteLinkButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteLinkButton.TabIndex = 13;
            this.DeleteLinkButton.Text = "Удалить";
            this.DeleteLinkButton.UseVisualStyleBackColor = true;
            this.DeleteLinkButton.Click += new System.EventHandler(this.DeleteLinkButton_Click);
            // 
            // AddProjectLinkButton
            // 
            this.AddProjectLinkButton.Location = new System.Drawing.Point(708, 42);
            this.AddProjectLinkButton.Name = "AddProjectLinkButton";
            this.AddProjectLinkButton.Size = new System.Drawing.Size(75, 23);
            this.AddProjectLinkButton.TabIndex = 12;
            this.AddProjectLinkButton.Text = "Добавить";
            this.AddProjectLinkButton.UseVisualStyleBackColor = true;
            this.AddProjectLinkButton.Click += new System.EventHandler(this.AddProjectLinkButton_Click);
            // 
            // AllProjectsGrid
            // 
            this.AllProjectsGrid.AllowUserToAddRows = false;
            this.AllProjectsGrid.AllowUserToDeleteRows = false;
            this.AllProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.ProjectRowNumber,
            this.ProjectName});
            this.AllProjectsGrid.Location = new System.Drawing.Point(459, 42);
            this.AllProjectsGrid.Name = "AllProjectsGrid";
            this.AllProjectsGrid.ReadOnly = true;
            this.AllProjectsGrid.Size = new System.Drawing.Size(243, 365);
            this.AllProjectsGrid.TabIndex = 11;
            // 
            // ProjectSolverLinkGrid
            // 
            this.ProjectSolverLinkGrid.AllowUserToAddRows = false;
            this.ProjectSolverLinkGrid.AllowUserToDeleteRows = false;
            this.ProjectSolverLinkGrid.CausesValidation = false;
            this.ProjectSolverLinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectSolverLinkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinkId,
            this.LinkRowNumber,
            this.LinkProjectId,
            this.LinkProjectName});
            this.ProjectSolverLinkGrid.Location = new System.Drawing.Point(19, 42);
            this.ProjectSolverLinkGrid.Name = "ProjectSolverLinkGrid";
            this.ProjectSolverLinkGrid.Size = new System.Drawing.Size(341, 365);
            this.ProjectSolverLinkGrid.TabIndex = 10;
            // 
            // LinkId
            // 
            this.LinkId.HeaderText = "LinkId";
            this.LinkId.Name = "LinkId";
            this.LinkId.ReadOnly = true;
            this.LinkId.Visible = false;
            // 
            // LinkRowNumber
            // 
            this.LinkRowNumber.HeaderText = "№";
            this.LinkRowNumber.Name = "LinkRowNumber";
            this.LinkRowNumber.ReadOnly = true;
            // 
            // LinkProjectId
            // 
            this.LinkProjectId.HeaderText = "LinkProjectId";
            this.LinkProjectId.Name = "LinkProjectId";
            this.LinkProjectId.ReadOnly = true;
            this.LinkProjectId.Visible = false;
            // 
            // LinkProjectName
            // 
            this.LinkProjectName.HeaderText = "Название проекта";
            this.LinkProjectName.Name = "LinkProjectName";
            this.LinkProjectName.ReadOnly = true;
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
            this.ProjectName.ReadOnly = true;
            // 
            // LinkPropertiesButton
            // 
            this.LinkPropertiesButton.Location = new System.Drawing.Point(366, 71);
            this.LinkPropertiesButton.Name = "LinkPropertiesButton";
            this.LinkPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.LinkPropertiesButton.TabIndex = 17;
            this.LinkPropertiesButton.Text = "Свойства";
            this.LinkPropertiesButton.UseVisualStyleBackColor = true;
            this.LinkPropertiesButton.Click += new System.EventHandler(this.LinkPropertiesButton_Click);
            // 
            // ProjectPropertiesButton
            // 
            this.ProjectPropertiesButton.Location = new System.Drawing.Point(708, 71);
            this.ProjectPropertiesButton.Name = "ProjectPropertiesButton";
            this.ProjectPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.ProjectPropertiesButton.TabIndex = 18;
            this.ProjectPropertiesButton.Text = "Свойства";
            this.ProjectPropertiesButton.UseVisualStyleBackColor = true;
            this.ProjectPropertiesButton.Click += new System.EventHandler(this.ProjectPropertiesButton_Click);
            // 
            // InitialProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.ProjectPropertiesButton);
            this.Controls.Add(this.LinkPropertiesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteLinkButton);
            this.Controls.Add(this.AddProjectLinkButton);
            this.Controls.Add(this.AllProjectsGrid);
            this.Controls.Add(this.ProjectSolverLinkGrid);
            this.Name = "InitialProjectsForm";
            this.Text = "InitialProjectsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InitialProjectsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AllProjectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSolverLinkGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button DeleteLinkButton;
        private System.Windows.Forms.Button AddProjectLinkButton;
        private System.Windows.Forms.DataGridView AllProjectsGrid;
        private System.Windows.Forms.DataGridView ProjectSolverLinkGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.Button LinkPropertiesButton;
        private System.Windows.Forms.Button ProjectPropertiesButton;
    }
}