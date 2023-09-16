
namespace MultiPurposeProjectOptimizer
{
    partial class ProjectPropertiesEditForm
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.DeleteProjectPropertyButton = new System.Windows.Forms.Button();
            this.AddProjectPropertyButton = new System.Windows.Forms.Button();
            this.PropertiesGrid = new System.Windows.Forms.DataGridView();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyGrid = new System.Windows.Forms.DataGridView();
            this.ProjectPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(703, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Поиск";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(454, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 25;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(489, 439);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 23;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DeleteProjectPropertyButton
            // 
            this.DeleteProjectPropertyButton.Location = new System.Drawing.Point(361, 49);
            this.DeleteProjectPropertyButton.Name = "DeleteProjectPropertyButton";
            this.DeleteProjectPropertyButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteProjectPropertyButton.TabIndex = 22;
            this.DeleteProjectPropertyButton.Text = "Удалить";
            this.DeleteProjectPropertyButton.UseVisualStyleBackColor = true;
            this.DeleteProjectPropertyButton.Click += new System.EventHandler(this.DeleteProjectPropertyButton_Click);
            // 
            // AddProjectPropertyButton
            // 
            this.AddProjectPropertyButton.Location = new System.Drawing.Point(703, 49);
            this.AddProjectPropertyButton.Name = "AddProjectPropertyButton";
            this.AddProjectPropertyButton.Size = new System.Drawing.Size(75, 23);
            this.AddProjectPropertyButton.TabIndex = 21;
            this.AddProjectPropertyButton.Text = "Добавить";
            this.AddProjectPropertyButton.UseVisualStyleBackColor = true;
            this.AddProjectPropertyButton.Click += new System.EventHandler(this.AddProjectPropertyButton_Click);
            // 
            // PropertiesGrid
            // 
            this.PropertiesGrid.AllowUserToAddRows = false;
            this.PropertiesGrid.AllowUserToDeleteRows = false;
            this.PropertiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyId,
            this.PropertyRowNumber,
            this.PropertyName});
            this.PropertiesGrid.Location = new System.Drawing.Point(454, 49);
            this.PropertiesGrid.Name = "PropertiesGrid";
            this.PropertiesGrid.ReadOnly = true;
            this.PropertiesGrid.Size = new System.Drawing.Size(243, 365);
            this.PropertiesGrid.TabIndex = 20;
            // 
            // PropertyId
            // 
            this.PropertyId.HeaderText = "PropertyId";
            this.PropertyId.Name = "PropertyId";
            this.PropertyId.ReadOnly = true;
            this.PropertyId.Visible = false;
            // 
            // PropertyRowNumber
            // 
            this.PropertyRowNumber.HeaderText = "№";
            this.PropertyRowNumber.Name = "PropertyRowNumber";
            this.PropertyRowNumber.ReadOnly = true;
            // 
            // PropertyName
            // 
            this.PropertyName.HeaderText = "Название свойства";
            this.PropertyName.Name = "PropertyName";
            this.PropertyName.ReadOnly = true;
            // 
            // ProjectPropertyGrid
            // 
            this.ProjectPropertyGrid.AllowUserToAddRows = false;
            this.ProjectPropertyGrid.AllowUserToDeleteRows = false;
            this.ProjectPropertyGrid.CausesValidation = false;
            this.ProjectPropertyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectPropertyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectPropertyId,
            this.ProjectPropertyRowNumber,
            this.ProjectPropertyName,
            this.ProjectPropertyValue});
            this.ProjectPropertyGrid.Location = new System.Drawing.Point(14, 49);
            this.ProjectPropertyGrid.Name = "ProjectPropertyGrid";
            this.ProjectPropertyGrid.Size = new System.Drawing.Size(341, 365);
            this.ProjectPropertyGrid.TabIndex = 19;
            this.ProjectPropertyGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectPropertyGrid_CellValueChanged);
            // 
            // ProjectPropertyId
            // 
            this.ProjectPropertyId.HeaderText = "ProjectPropertyId";
            this.ProjectPropertyId.Name = "ProjectPropertyId";
            this.ProjectPropertyId.Visible = false;
            // 
            // ProjectPropertyRowNumber
            // 
            this.ProjectPropertyRowNumber.HeaderText = "№";
            this.ProjectPropertyRowNumber.Name = "ProjectPropertyRowNumber";
            this.ProjectPropertyRowNumber.ReadOnly = true;
            // 
            // ProjectPropertyName
            // 
            this.ProjectPropertyName.HeaderText = "Название свойства";
            this.ProjectPropertyName.Name = "ProjectPropertyName";
            this.ProjectPropertyName.ReadOnly = true;
            // 
            // ProjectPropertyValue
            // 
            this.ProjectPropertyValue.HeaderText = "Значение";
            this.ProjectPropertyValue.Name = "ProjectPropertyValue";
            // 
            // ProjectPropertiesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 484);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteProjectPropertyButton);
            this.Controls.Add(this.AddProjectPropertyButton);
            this.Controls.Add(this.PropertiesGrid);
            this.Controls.Add(this.ProjectPropertyGrid);
            this.Name = "ProjectPropertiesEditForm";
            this.Text = "Редактирование свойств проекта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProjectPropertiesEditForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button DeleteProjectPropertyButton;
        private System.Windows.Forms.Button AddProjectPropertyButton;
        private System.Windows.Forms.DataGridView PropertiesGrid;
        private System.Windows.Forms.DataGridView ProjectPropertyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyValue;
    }
}