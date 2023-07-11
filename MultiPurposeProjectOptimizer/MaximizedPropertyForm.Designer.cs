
namespace MultiPurposeProjectOptimizer
{
    partial class MaximizedPropertyForm
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
            this.PropertiesGrid = new System.Windows.Forms.DataGridView();
            this.PropertyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyRowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MaximizerPropertyLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.PropertyNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).BeginInit();
            this.SuspendLayout();
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
            this.PropertiesGrid.Location = new System.Drawing.Point(11, 124);
            this.PropertiesGrid.Name = "PropertiesGrid";
            this.PropertiesGrid.ReadOnly = true;
            this.PropertiesGrid.Size = new System.Drawing.Size(395, 290);
            this.PropertiesGrid.TabIndex = 22;
            this.PropertiesGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PropertiesGrid_CellDoubleClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Список свойств";
            // 
            // MaximizerPropertyLabel
            // 
            this.MaximizerPropertyLabel.AutoSize = true;
            this.MaximizerPropertyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizerPropertyLabel.Location = new System.Drawing.Point(12, 16);
            this.MaximizerPropertyLabel.Name = "MaximizerPropertyLabel";
            this.MaximizerPropertyLabel.Size = new System.Drawing.Size(272, 24);
            this.MaximizerPropertyLabel.TabIndex = 25;
            this.MaximizerPropertyLabel.Text = "Максимизируемое свойство:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(89, 432);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(208, 33);
            this.OKButton.TabIndex = 26;
            this.OKButton.Text = "ОК";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PropertyNameLabel
            // 
            this.PropertyNameLabel.AutoSize = true;
            this.PropertyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropertyNameLabel.Location = new System.Drawing.Point(13, 49);
            this.PropertyNameLabel.Name = "PropertyNameLabel";
            this.PropertyNameLabel.Size = new System.Drawing.Size(117, 24);
            this.PropertyNameLabel.TabIndex = 27;
            this.PropertyNameLabel.Text = "Не выбрано";
            // 
            // MaximizedPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 482);
            this.Controls.Add(this.PropertyNameLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MaximizerPropertyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PropertiesGrid);
            this.Name = "MaximizedPropertyForm";
            this.Text = "MaximizedPropertyForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaximizedPropertyForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView PropertiesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyRowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaximizerPropertyLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label PropertyNameLabel;
    }
}