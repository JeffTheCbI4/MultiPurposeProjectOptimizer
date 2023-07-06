
namespace MultiPurposeProjectOptimizer
{
    partial class ReadProjectPropertiesForm
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
            this.ProjectPropertyGrid = new System.Windows.Forms.DataGridView();
            this.ProjectPropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPropertyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).BeginInit();
            this.SuspendLayout();
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
            this.ProjectPropertyGrid.Location = new System.Drawing.Point(12, 12);
            this.ProjectPropertyGrid.Name = "ProjectPropertyGrid";
            this.ProjectPropertyGrid.ReadOnly = true;
            this.ProjectPropertyGrid.Size = new System.Drawing.Size(341, 354);
            this.ProjectPropertyGrid.TabIndex = 20;
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
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKButton.Location = new System.Drawing.Point(78, 384);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(209, 54);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ReadProjectPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ProjectPropertyGrid);
            this.Name = "ReadProjectPropertiesForm";
            this.Text = "ReadProjectPropertiesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadProjectPropertiesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectPropertyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProjectPropertyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectPropertyValue;
        private System.Windows.Forms.Button OKButton;
    }
}