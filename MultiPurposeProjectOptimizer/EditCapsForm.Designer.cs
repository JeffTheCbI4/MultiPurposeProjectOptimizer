
namespace MultiPurposeProjectOptimizer
{
    partial class EditCapsForm
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
            this.PropertyCapsGrid = new System.Windows.Forms.DataGridView();
            this.PropertiesGrid = new System.Windows.Forms.DataGridView();
            this.AddCapButton = new System.Windows.Forms.Button();
            this.DeleteCapButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyCapId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapGridPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyCapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyCapValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PropertyCapsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PropertyCapsGrid
            // 
            this.PropertyCapsGrid.AllowUserToAddRows = false;
            this.PropertyCapsGrid.AllowUserToDeleteRows = false;
            this.PropertyCapsGrid.CausesValidation = false;
            this.PropertyCapsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PropertyCapsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyCapId,
            this.CapRowNumber,
            this.CapGridPropertyId,
            this.PropertyCapName,
            this.PropertyCapValue});
            this.PropertyCapsGrid.Location = new System.Drawing.Point(24, 38);
            this.PropertyCapsGrid.Name = "PropertyCapsGrid";
            this.PropertyCapsGrid.Size = new System.Drawing.Size(341, 365);
            this.PropertyCapsGrid.TabIndex = 3;
            this.PropertyCapsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertyCapsGrid_CellValueChanged);
            this.PropertyCapsGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PropertyCapsGrid_RowValidating);
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
            this.PropertiesGrid.Location = new System.Drawing.Point(464, 38);
            this.PropertiesGrid.Name = "PropertiesGrid";
            this.PropertiesGrid.ReadOnly = true;
            this.PropertiesGrid.Size = new System.Drawing.Size(243, 365);
            this.PropertiesGrid.TabIndex = 4;
            // 
            // AddCapButton
            // 
            this.AddCapButton.Location = new System.Drawing.Point(713, 38);
            this.AddCapButton.Name = "AddCapButton";
            this.AddCapButton.Size = new System.Drawing.Size(75, 23);
            this.AddCapButton.TabIndex = 5;
            this.AddCapButton.Text = "Добавить";
            this.AddCapButton.UseVisualStyleBackColor = true;
            this.AddCapButton.Click += new System.EventHandler(this.AddCapButton_Click);
            // 
            // DeleteCapButton
            // 
            this.DeleteCapButton.Location = new System.Drawing.Point(371, 38);
            this.DeleteCapButton.Name = "DeleteCapButton";
            this.DeleteCapButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCapButton.TabIndex = 6;
            this.DeleteCapButton.Text = "Удалить";
            this.DeleteCapButton.UseVisualStyleBackColor = true;
            this.DeleteCapButton.Click += new System.EventHandler(this.DeleteCapButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(499, 430);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
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
            // PropertyCapId
            // 
            this.PropertyCapId.HeaderText = "PropertyCapId";
            this.PropertyCapId.Name = "PropertyCapId";
            this.PropertyCapId.ReadOnly = true;
            this.PropertyCapId.Visible = false;
            // 
            // CapRowNumber
            // 
            this.CapRowNumber.HeaderText = "№";
            this.CapRowNumber.Name = "CapRowNumber";
            this.CapRowNumber.ReadOnly = true;
            // 
            // CapGridPropertyId
            // 
            this.CapGridPropertyId.HeaderText = "PropertyId";
            this.CapGridPropertyId.Name = "CapGridPropertyId";
            this.CapGridPropertyId.ReadOnly = true;
            this.CapGridPropertyId.Visible = false;
            // 
            // PropertyCapName
            // 
            this.PropertyCapName.HeaderText = "Название свойства";
            this.PropertyCapName.Name = "PropertyCapName";
            this.PropertyCapName.ReadOnly = true;
            // 
            // PropertyCapValue
            // 
            this.PropertyCapValue.HeaderText = "Значение ограничения";
            this.PropertyCapValue.Name = "PropertyCapValue";
            // 
            // EditCapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 475);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DeleteCapButton);
            this.Controls.Add(this.AddCapButton);
            this.Controls.Add(this.PropertiesGrid);
            this.Controls.Add(this.PropertyCapsGrid);
            this.Name = "EditCapsForm";
            this.Text = "Редактирование ограничений";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditCapsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PropertyCapsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PropertyCapsGrid;
        private System.Windows.Forms.DataGridView PropertiesGrid;
        private System.Windows.Forms.Button AddCapButton;
        private System.Windows.Forms.Button DeleteCapButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyCapId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapGridPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyCapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyCapValue;
    }
}