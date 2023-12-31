﻿
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
            this.ProjectsGrid = new System.Windows.Forms.DataGridView();
            this.ProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMultiPurpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchProjectTextBox = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.ProjectPropertiesButton = new System.Windows.Forms.Button();
            this.InfluenceButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ProjectPropertyGrid = new System.Windows.Forms.DataGridView();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оптимальный набор проектов";
            // 
            // ProjectsGrid
            // 
            this.ProjectsGrid.AllowUserToAddRows = false;
            this.ProjectsGrid.AllowUserToDeleteRows = false;
            this.ProjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectId,
            this.RowNumber,
            this.ProjectName,
            this.IsMultiPurpose});
            this.ProjectsGrid.Location = new System.Drawing.Point(32, 92);
            this.ProjectsGrid.Name = "ProjectsGrid";
            this.ProjectsGrid.ReadOnly = true;
            this.ProjectsGrid.Size = new System.Drawing.Size(342, 333);
            this.ProjectsGrid.TabIndex = 2;
            // 
            // ProjectId
            // 
            this.ProjectId.HeaderText = "ProjectId";
            this.ProjectId.Name = "ProjectId";
            this.ProjectId.ReadOnly = true;
            this.ProjectId.Visible = false;
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
            // IsMultiPurpose
            // 
            this.IsMultiPurpose.HeaderText = "Многоцелевой проект";
            this.IsMultiPurpose.Name = "IsMultiPurpose";
            this.IsMultiPurpose.ReadOnly = true;
            // 
            // SearchProjectTextBox
            // 
            this.SearchProjectTextBox.Location = new System.Drawing.Point(32, 66);
            this.SearchProjectTextBox.Name = "SearchProjectTextBox";
            this.SearchProjectTextBox.Size = new System.Drawing.Size(342, 20);
            this.SearchProjectTextBox.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(394, 66);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Искать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ProjectPropertiesButton
            // 
            this.ProjectPropertiesButton.Location = new System.Drawing.Point(394, 95);
            this.ProjectPropertiesButton.Name = "ProjectPropertiesButton";
            this.ProjectPropertiesButton.Size = new System.Drawing.Size(97, 23);
            this.ProjectPropertiesButton.TabIndex = 10;
            this.ProjectPropertiesButton.Text = "Свойства";
            this.ProjectPropertiesButton.UseVisualStyleBackColor = true;
            this.ProjectPropertiesButton.Click += new System.EventHandler(this.ProjectPropertiesButton_Click);
            // 
            // InfluenceButton
            // 
            this.InfluenceButton.Location = new System.Drawing.Point(394, 124);
            this.InfluenceButton.Name = "InfluenceButton";
            this.InfluenceButton.Size = new System.Drawing.Size(97, 23);
            this.InfluenceButton.TabIndex = 12;
            this.InfluenceButton.Text = "Влияние";
            this.InfluenceButton.UseVisualStyleBackColor = true;
            this.InfluenceButton.Click += new System.EventHandler(this.InfluenceButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(394, 383);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 42);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ProjectPropertyGrid
            // 
            this.ProjectPropertyGrid.AllowUserToAddRows = false;
            this.ProjectPropertyGrid.AllowUserToDeleteRows = false;
            this.ProjectPropertyGrid.CausesValidation = false;
            this.ProjectPropertyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectPropertyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyId,
            this.ProjectPropertyRowNumber,
            this.PropertyName,
            this.PropertyValue,
            this.CapValue});
            this.ProjectPropertyGrid.Location = new System.Drawing.Point(511, 66);
            this.ProjectPropertyGrid.Name = "ProjectPropertyGrid";
            this.ProjectPropertyGrid.ReadOnly = true;
            this.ProjectPropertyGrid.Size = new System.Drawing.Size(443, 359);
            this.ProjectPropertyGrid.TabIndex = 20;
            // 
            // PropertyId
            // 
            this.PropertyId.HeaderText = "PropertyId";
            this.PropertyId.Name = "PropertyId";
            this.PropertyId.ReadOnly = true;
            this.PropertyId.Visible = false;
            // 
            // ProjectPropertyRowNumber
            // 
            this.ProjectPropertyRowNumber.HeaderText = "№";
            this.ProjectPropertyRowNumber.Name = "ProjectPropertyRowNumber";
            this.ProjectPropertyRowNumber.ReadOnly = true;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Название свойства";
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            // 
            // PropertyValue
            // 
            this.PropertyValue.HeaderText = "Значение";
            this.PropertyValue.Name = "PropertyValue";
            this.PropertyValue.ReadOnly = true;
            // 
            // CapValue
            // 
            this.CapValue.HeaderText = "Значение ограничения";
            this.CapValue.Name = "CapValue";
            this.CapValue.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(507, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Совокупные значения свойств проектов";
            // 
            // OptimalProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectPropertyGrid);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.InfluenceButton);
            this.Controls.Add(this.ProjectPropertiesButton);
            this.Controls.Add(this.SearchProjectTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.ProjectsGrid);
            this.Controls.Add(this.label1);
            this.Name = "OptimalProjectListForm";
            this.Text = "Оптимальный набор проектов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptimalProjectListForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProjectsGrid;
        private System.Windows.Forms.TextBox SearchProjectTextBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsMultiPurpose;
        private System.Windows.Forms.Button ProjectPropertiesButton;
        private System.Windows.Forms.Button InfluenceButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridView ProjectPropertyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapValue;
        private System.Windows.Forms.Label label2;
    }
}